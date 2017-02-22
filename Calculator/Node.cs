enum NodeType
{
    Operator, Value
}

class Node 
{
    public NodeType Type = NodeType.Value;
    public Node Left;
    public Node Right;
    public decimal? Value = null;
    
}