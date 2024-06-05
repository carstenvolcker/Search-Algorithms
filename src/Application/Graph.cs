namespace Application
{
    public class Graph
    {
        // Public variables
        public Guid Guid { get; }
        public string Name { get; private set; }
        public List<Edge> Edges { get; set; } = [];
        public List<Node> Nodes { get; set; } = [];

        // Constructors
        public Graph(string name, List<Node> nodes)
        {
            Guid = Guid.NewGuid();
            Name = name;
            Nodes = nodes;
        }

        public Graph(string name)
        {
            Guid = Guid.NewGuid();
            Name = name;
        }

        // Public functions
        public void AddEdge(string name, string leftNodeName, string rightNodeName, string direction)
        {
            Edge edge = new Edge(name, leftNodeName, rightNodeName, direction);
            if (!Edges.Contains(edge))
            {
                Edges.Add(edge);
            }
            foreach (Node node in edge.Nodes)
            {
                if (!Nodes.Contains(node))
                {
                    Nodes.Add(node);
                }
            }
        }

        public void ModifyName(string name)
        {
            Name = name;
        }

        public void DFS(Node start) // Depth First Search (DFS).
        {
            Stack<Node> stack = [];
            HashSet<Node> visited = [];

            stack.Push(start);
            while (stack.Count > 0 && visited.Count < Nodes.Count)
            {
                Node node = stack.Pop();
                visited.Add(node);
                foreach (Edge edge in node.Edges)
                {
                    if (!visited.Contains(edge.Nodes[1]))
                    {
                        stack.Push(edge.Nodes[1]);
                    }
                }
                Console.WriteLine("Visited node: " + node.Name + ", count = " + visited.Count.ToString());
            }
        }

        public void BFS(Node start) // Breadth First Search (BFS).
        {
            Queue<Node> stack = [];
            HashSet<Node> visited = [];

            stack.Enqueue(start);
            while (stack.Count > 0 && visited.Count < Nodes.Count)
            {
                Node node = stack.Dequeue();
                visited.Add(node);
                foreach (Edge edge in node.Edges)
                {
                    if (!visited.Contains(edge.Nodes[1]))
                    {
                        stack.Enqueue(edge.Nodes[1]);
                    }
                }
                Console.WriteLine("Visited node: " + node.Name + ", count = " + visited.Count.ToString());
            }
        }
    }

    public class Edge
    {
        // Public variables
        public Guid Guid { get; }
        public string Name { get; private set; }
        public Node[] Nodes { get; } = new Node[2];
        public string Direction { get; private set; }

        // Private variables
        private readonly string[] directions = ["->", "<-", "--"]; // 0: Left to right, 1: right to left, 2: undirected.

        // Constructors
        public Edge(string name, Node node0, Node node1, string direction)
        {
            Guid = Guid.NewGuid();
            Name = name;
            Nodes = [node0, node1];
            DirectionSetup(direction);
        }

        public Edge(string name, string leftNodeName, string rightNodeName, string direction)
        {
            Guid = Guid.NewGuid();
            Name = name;
            Nodes = [new Node(leftNodeName), new Node(rightNodeName)];
            DirectionSetup(direction);
        }

        // Public functions
        public void ModifyName(string name)
        {
            Name = name;
        }

        public void ModifyDirection(string direction)
        {
            Direction = direction;
        }

        // Private functions
        private void DirectionSetup(string direction)
        {
            int index = Array.IndexOf(directions, direction);
            switch (index)
            {
                case 0:
                    Nodes[0].Edges.Add(this);
                    break;
                case 1:
                    Nodes[1].Edges.Add(this);
                    break;
                case 2:
                    Nodes[0].Edges.Add(this);
                    Nodes[1].Edges.Add(this);
                    break;
                default:
                    throw new Exception(DirectionError(direction));
            }
            Direction = Nodes[0].Name + " " + direction + " " + Nodes[1].Name;
        }

        private string DirectionError(string direction)
        {
            string message = "Illegal direction " + direction + ". Valid directions: ";
            for (int i = 0; i < directions.Count() - 1; i++)
            {
                message += "\"" + directions[i] + "\", ";
            }
            return message += "\"" + directions[directions.Count() - 1] + "\".";
        }
}

    public class Node
    {
        // Public variables
        public Guid Guid { get; }
        public string Name { get; private set; }
        public List<Edge> Edges { get; set; } = [];

        // Constructors
        public Node(string name)
        {
            //Guid = Guid.NewGuid();
            Name = name;
        }

        // Public functions
        public void ModifyName(string name)
        {
            Name = name;
        }
    }
}

//private enum Direction
//{
//    Left2Right,
//    Right2Left,
//    Undirected
//}

//private Direction? String2Enum(string direction)
//{
//    for (int i = 0; i < directions.Count(); i++)
//    {
//        if (directions[i].CompareTo(direction) == 0)
//        {
//            return (Direction)i;
//        }
//    }
//    return null;

//    String.Compare(directions[0], direction) == 0 ? Direction.Left2Right :
//        String.Compare(directions[0], direction) == 0 ? Direction.Left2Right :
//        String.Compare(directions[0], direction) == 0 ? Direction.Left2Right : null;
//    directions[1] => Direction.Right2Left,
//            directions[2] => Direction.Undirected,
//            _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}"),
//        };