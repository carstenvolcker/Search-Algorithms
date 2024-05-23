// See https://aka.ms/new-console-template for more information
using Application;

Console.WriteLine("Hello, World!");

var node1 = new Node(1);
var node2 = new Node(2);
var node3 = new Node(3);
var node4 = new Node(4);
var node5 = new Node(5);

new Edge(node1, node2);
new Edge(node2, node3);
new Edge(node2, node4);
new Edge(node4, node5);

Graph graph = new Graph(new List<Node> { node1, node2, node3, node4, node5 });

//graph.DFS(node1);