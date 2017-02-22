using System.IO;
using System;

class Program
{
    static void Main()
    {
        //Node root = new Node();
        //Node node = Parser.Parse("3     + 4 * 2");
        Node node = Parser.Parse(".34566");
        if (node.Value != null) 
          Console.WriteLine(">" + node.Value);
        else
          Console.WriteLine(">" + "null");
    }
}
