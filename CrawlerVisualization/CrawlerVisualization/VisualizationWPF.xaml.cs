using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuickGraph;
using System.IO;
using GraphX;
using GraphX.Controls;
using GraphX.PCL.Common.Models;
using GraphX.PCL.Logic.Models;
using GraphX.PCL.Logic.Algorithms.LayoutAlgorithms;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;

namespace CrawlerVisualization
{

    //Layout visual class
    public class GraphAreaExample : GraphArea<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>> { }

    //Graph data class
    public class GraphExample : BidirectionalGraph<DataVertex, DataEdge> { }

    //Logic core class
    public class GXLogicCoreExample : GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>> { }

    //Vertex data object
    public class DataVertex : VertexBase
    {
        /// <summary>
        /// Some string property for example purposes
        /// </summary>
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    //Edge data object
    public class DataEdge : EdgeBase<DataVertex>
    {
        public DataEdge(DataVertex source, DataVertex target, double weight = 1)
            : base(source, target, weight)
        {
        }

        public DataEdge()
            : base(null, null, 1)
        {
        }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }


    /// <summary>
    /// Interaction logic for VisualizationWPF.xaml
    /// </summary>
    public partial class VisualizationWPF : UserControl
    {

        private IBidirectionalGraph<object, IEdge<object>> _graphToVisualize;

        public IBidirectionalGraph<object, IEdge<object>> GraphToVisualize
        {
            get
            {
                return _graphToVisualize;
            }
        }

        public Dictionary<string, DataVertex> NodesInGraph;
        public string startPath;
        public GraphExample graph;

        public VisualizationWPF(string startupPath)
        {
            
            startPath = startupPath;
            InitializeComponent();

        }

        private void SetupVertices()
        {
            //Random Rand = new Random();


            ////Create and add vertices using some DataSource for ID's
            //for (int i = 1; i <= 100; i++)
            //{
            //    graph.AddVertex(new DataVertex() { ID = i, Text = i.ToString() });
            //}

            //var vlist = graph.Vertices.ToList();
            ////Generate random edges for the vertices
            //foreach (var item in vlist)
            //{
            //    if (Rand.Next(0, 50) > 25) continue;
            //    var vertex2 = vlist[Rand.Next(0, graph.VertexCount - 1)];
            //    graph.AddEdge(new DataEdge(item, vertex2, Rand.Next(1, 50))
            //    { Text = string.Format("{0} -> {1}", item, vertex2) });
            //}

            
        }

        private void SetupLayouts()
        {
            var LogicCore = new GXLogicCoreExample();
            //This property sets layout algorithm that will be used to calculate vertices positions
            //Different algorithms uses different values and some of them uses edge Weight property.
            LogicCore.DefaultLayoutAlgorithm = GraphX.PCL.Common.Enums.LayoutAlgorithmTypeEnum.KK;
            //Now we can set optional parameters using AlgorithmFactory
            //NOTE: default parameters can be automatically created each time you change Default algorithms
            LogicCore.DefaultLayoutAlgorithmParams =
                               LogicCore.AlgorithmFactory.CreateLayoutParameters(GraphX.PCL.Common.Enums.LayoutAlgorithmTypeEnum.FR);
            //Unfortunately to change algo parameters you need to specify params type which is different for every algorithm.
            //((KKLayoutParameters)LogicCore.DefaultLayoutAlgorithmParams).MaxIterations = 100;


            //((SimpleTreeLayoutParameters)LogicCore.DefaultLayoutAlgorithmParams).Direction = LayoutDirection.BottomToTop;
            //((SimpleTreeLayoutParameters)LogicCore.DefaultLayoutAlgorithmParams).Seed = 0;
            //((SimpleTreeLayoutParameters)LogicCore.DefaultLayoutAlgorithmParams).LayerGap = 50;
            //((SimpleTreeLayoutParameters)LogicCore.DefaultLayoutAlgorithmParams).OptimizeWidthAndHeight = true;
            //((SimpleTreeLayoutParameters)LogicCore.DefaultLayoutAlgorithmParams).VertexGap = 50;
            //((SimpleTreeLayoutParameters)LogicCore.DefaultLayoutAlgorithmParams).SpanningTreeGeneration = SpanningTreeGeneration.DFS;

            //This property sets vertex overlap removal algorithm.
            //Such algorithms help to arrange vertices in the layout so no one overlaps each other.
            LogicCore.DefaultOverlapRemovalAlgorithm = GraphX.PCL.Common.Enums.OverlapRemovalAlgorithmTypeEnum.FSA;
            //Setup optional params
            LogicCore.DefaultOverlapRemovalAlgorithmParams =
                              LogicCore.AlgorithmFactory.CreateOverlapRemovalParameters(GraphX.PCL.Common.Enums.OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)LogicCore.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
            ((OverlapRemovalParameters)LogicCore.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;

            //This property sets edge routing algorithm that is used to build route paths according to algorithm logic.
            //For ex., SimpleER algorithm will try to set edge paths around vertices so no edge will intersect any vertex.
            LogicCore.DefaultEdgeRoutingAlgorithm = GraphX.PCL.Common.Enums.EdgeRoutingAlgorithmTypeEnum.SimpleER;

            //This property sets async algorithms computation so methods like: Area.RelayoutGraph() and Area.GenerateGraph()
            //will run async with the UI thread. Completion of the specified methods can be catched by corresponding events:
            //Area.RelayoutFinished and Area.GenerateGraphFinished.
            LogicCore.AsyncAlgorithmCompute = false;

            //Finally assign logic core to GraphArea object
            gg_Area.LogicCore = LogicCore;
            gg_Area.LogicCore.Graph = graph;
            gg_Area.EnableWinFormsHostingMode = true;
            gg_Area.GenerateGraph(true);
        }

        private void root_Loaded_1(object sender, RoutedEventArgs e)
        {
            graph = new GraphExample();
            NodesInGraph = new Dictionary<string, DataVertex>();
            TraverseFolderStrucutre(startPath + "\\cached");
            SetupLayouts();
        }

        private void TraverseFolderStrucutre(string root)
        {
            int idCount = 0;
            // Data structure to hold names of subfolders to be
            // examined for files.
            Stack<string> dirs = new Stack<string>(1000);

            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dirs.Push(root);
            string currentDir = root;
            
            DataVertex rootVertex = new DataVertex();
            rootVertex.ID = idCount;
            rootVertex.Text = currentDir;
            graph.AddVertex(rootVertex);
            idCount++;
            NodesInGraph.Add(currentDir, rootVertex);

            while (dirs.Count > 0)
            {
                string newDir = dirs.Pop();
                string[] subDirs;

                DataVertex currRoot;
                DataVertex dv = new DataVertex();
                bool success = NodesInGraph.TryGetValue(currentDir, out currRoot);

                if (NodesInGraph.ContainsKey(newDir))
                {
                    bool succ = NodesInGraph.TryGetValue(newDir, out dv);
                }
                else
                {
                    dv.ID = idCount;
                    dv.Text = newDir.Remove(0, root.Length + 1);
                    graph.AddVertex(dv);
                    NodesInGraph.Add(newDir, dv);
                    idCount++;
                }

                graph.AddEdge(new DataEdge(currRoot, dv));
                currentDir = newDir;


                try
                {
                    try
                    {
                        subDirs = Directory.GetDirectories(currentDir);
                        foreach (string subDir in subDirs)
                        {
                            int length = root.Length;
                            string col = subDir.Remove(0, length + 1);

                            DataVertex connectionVertex = new DataVertex();
                            if (NodesInGraph.ContainsKey(col))
                            {
                                bool succ = NodesInGraph.TryGetValue(col, out connectionVertex);
                            }
                            else
                            {
                                connectionVertex.ID = idCount;
                                connectionVertex.Text = col;
                                idCount++;
                                graph.AddVertex(connectionVertex);
                                NodesInGraph.Add(col, connectionVertex);
                            }
                            graph.AddEdge(new DataEdge(dv, connectionVertex));
                        }
                    }
                    // An UnauthorizedAccessException exception will be thrown if we do not have
                    // discovery permission on a folder or file. It may or may not be acceptable 
                    // to ignore the exception and continue enumerating the remaining files and 
                    // folders. It is also possible (but unlikely) that a DirectoryNotFound exception 
                    // will be raised. This will happen if currentDir has been deleted by
                    // another application or thread after our call to Directory.Exists. The 
                    // choice of which exceptions to catch depends entirely on the specific task 
                    // you are intending to perform and also on how much you know with certainty 
                    // about the systems on which this code will run.
                    catch (UnauthorizedAccessException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                    catch (System.IO.DirectoryNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    string[] files = null;
                    try
                    {
                        files = System.IO.Directory.GetFiles(currentDir);
                    }

                    catch (UnauthorizedAccessException e)
                    {

                        Console.WriteLine(e.Message);
                        continue;
                    }

                    catch (System.IO.DirectoryNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                    // Perform the required action on each file here.
                    // Modify this block to perform your required task.
                    foreach (string file in files)
                    {
                        try
                        {
                            // Perform whatever action is required in your scenario.
                            FileInfo fi = new FileInfo(file);
                            Console.WriteLine("{0}: {1}, {2}", fi.Name, fi.Length, fi.CreationTime);

                        }
                        catch (System.IO.FileNotFoundException e)
                        {
                            // If file was deleted by a separate application
                            //  or thread since the call to TraverseTree()
                            // then just continue.
                            Console.WriteLine(e.Message);
                            continue;
                        }
                    }

                    // Push the subdirectories onto the stack for traversal.
                    // This could also be done before handing the files.
                    foreach (string str in subDirs)
                        dirs.Push(str);
                }
                catch (Exception)
                { }
            }

        }
    }
}
