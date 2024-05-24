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

new Edge("AB", nodeA, nodeB, "--");
new Edge("AD", nodeA, nodeD, "--");
new Edge("DE", nodeD, nodeE, "--");
new Edge("DG", nodeD, nodeG, "--");
new Edge("EC", nodeE, nodeC, "--");
new Edge("GF", nodeG, nodeF, "--");

Graph graph = new Graph("Test", new List<Node> {nodeA, nodeA, nodeC, nodeD, nodeE, nodeF, nodeG});

Console.WriteLine("Calling DFS:");
graph.DFS(nodeA);

Console.WriteLine("Calling BFS:");
graph.BFS(nodeA);