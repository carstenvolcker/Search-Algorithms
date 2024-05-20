using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Application
{
    public class Graph
    {
        

        public Graph()
        {
            var node1 = new Node();
            var node2 = new Node();
            var node3 = new Node();
            var node4 = new Node();
            var node5 = new Node();

            var edge1 = new Edge();
            var edge2 = new Edge();
            var edge3 = new Edge();
            var edge4 = new Edge();

            edge1.Node1 = node1;
            edge1.Node2 = node2;
            edge2.Node1 = node2;
            edge2.Node2 = node3;
            edge3.Node1 = node2;
            edge3.Node2 = node4;
            edge4.Node1 = node4;
            edge4.Node2 = node5;

            node1.Edges.Add(edge1);
            node2.Edges.Add(edge1);
            node2.Edges.Add(edge2);
            node2.Edges.Add(edge3);
            node3.Edges.Add(edge2);
            node4.Edges.Add(edge3);
            node4.Edges.Add(edge4);
            node5.Edges.Add(edge4);
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
        public Node Node1 { get; set; } = null!;
        public Node Node2 { get; set; } = null!;
    }

    public class Node
    {
        public List<Edge> Edges { get; set;} = [];
    }
}
