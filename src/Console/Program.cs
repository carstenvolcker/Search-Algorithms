// See https://aka.ms/new-console-template for more information
using Application;

Console.WriteLine("Hello, World!");

//var nodeA = new Node("A");
//var nodeB = new Node("B");
//var nodeC = new Node("C");
//var nodeD = new Node("D");
//var nodeE = new Node("E");
//var nodeF = new Node("F");
//var nodeG = new Node("G");

//new Edge("AB", nodeA, nodeB, "--");
//new Edge("AD", nodeA, nodeD, "--");
//new Edge("DE", nodeD, nodeE, "--");
//new Edge("DG", nodeD, nodeG, "--");
//new Edge("EC", nodeE, nodeC, "--");
//new Edge("GF", nodeG, nodeF, "--");

Graph graph = new Graph("G4G");

graph.AddEdge("AB", "A", "B", "--");
graph.AddEdge("AD", "A", "D", "--");
graph.AddEdge("DE", "D", "E", "--");
graph.AddEdge("DG", "D", "G", "--");
graph.AddEdge("EC", "E", "C", "--");
graph.AddEdge("GF", "G", "F", "--");

//Graph graph = new Graph("Test", new List<Node> {nodeA, nodeA, nodeC, nodeD, nodeE, nodeF, nodeG});

Console.WriteLine("Calling DFS:");
graph.DFS(graph.Nodes.Find(node => node.Name == "A"));

Console.WriteLine("Calling BFS:");
graph.BFS(graph.Nodes.Find(node => node.Name == "A"));