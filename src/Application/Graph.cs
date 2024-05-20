using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Application
{
    public class Graph
    {
        

        public Graph()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);

            new Edge(node1, node2);
            new Edge(node2, node3);
            new Edge(node2, node4);
            new Edge(node4, node5);

            Root = node1;
        }

        public Node Root { get; set; } = null!;

        public void Traverse()
        {
            var edge1 = Root.Edges.First();
            var node2 = edge1.Node2;
            var edge2 = node2.Edges.First();
        }
    }

    public class Edge
    {
        public Edge(Node node1, Node node2)
        {
            Node1 = node1;
            Node2 = node2;

            Node1.Edges.Add(this);
            Node2.Edges.Add(this);
        }

        public Node Node1 { get; set; } = null!;
        public Node Node2 { get; set; } = null!;
    }

    public class Node
    {
        public Node(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public List<Edge> Edges { get; set;} = [];
    }
}
