//using System.ComponentModel.Design.Serialization;
//using System.Security.Cryptography.X509Certificates;

namespace Application
{
    public class Graph
    {
        // Fields
        public Guid Guid { get; }
        public List<Node> Nodes { get; set; }

        // Constructors
        public Graph(List<Node> nodes)
        {
            Guid = Guid.NewGuid();
            Nodes = nodes;
        }

        // Functions
        /*
        public void DFS(Node start)
        {
            Stack<Node> stack = [];
            stack.Push(start);
            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                Console.WriteLine("Visited node: " + node.Id.ToString());
                foreach (Edge edge in node.Edges)
                {
                    stack.Push(edge.Node2);
                }
            }
        }
        */

        /*
        public void Traverse()
        {
            var edge1 = Root.Edges.First();
            var node2 = edge1.Node2;
            var edge2 = node2.Edges.First();
        }
        */
    }

    public class Edge
    {
        // Fields
        public Guid Guid { get; }
        public Node Node1 { get; set; } = null!;
        public Node Node2 { get; set; } = null!;

        // Constructors
        public Edge(Node node1, Node node2)
        {
            Guid = Guid.NewGuid();

            Node1 = node1;
            Node2 = node2;

            Node1.Edges.Add(this);
            Node2.Edges.Add(this);
        }

        // Functions
    }

    public class Node
    {
        // Fields
        public Guid Guid { get; }
        public int Id { get; set; }
        public List<Edge> Edges { get; set; } = [];

        // Constructors
        public Node(int id)
        {
            Guid = Guid.NewGuid();
            Id = id;
        }

        // Functions
    }
}
