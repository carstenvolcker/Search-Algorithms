// See https://aka.ms/new-console-template for more information
using Application;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

var nodeA = new Node("A");
var nodeB = new Node("B");
var nodeC = new Node("C");
var nodeD = new Node("D");
var nodeE = new Node("E");
var nodeF = new Node("F");
var nodeG = new Node("G");

new Edge(nodeA, nodeB);
new Edge(nodeA, nodeD);
new Edge(nodeD, nodeE);
new Edge(nodeD, nodeG);
new Edge(nodeE, nodeC);
new Edge(nodeG, nodeF);

Graph graph = new Graph(new List<Node> { nodeA, nodeA, nodeC, nodeD, nodeE, nodeF, nodeG });

graph.DFS(nodeA);