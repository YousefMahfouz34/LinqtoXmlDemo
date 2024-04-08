using System.Xml;

namespace Chapter11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string myString = "<?xml version=\"1.0\" encoding=\"utf-8\" " +
                             "standalone=\"yes\"?>\r\n<customer id=\"123\" " +
                             "status=\"archived\">\r\n<firstname>Jim</firstname>\r" +
                             "\n<lastname>Bo</lastname>\r\n</customer>\r\n";
            XmlReader reader = XmlReader.Create(
            new System.IO.StringReader(myString));
            while (reader.Read())
            {

                Console.Write(new string(' ', reader.Depth * 2)); // Write indentation
                Console.Write(reader.NodeType.ToString());
                if (reader.NodeType == XmlNodeType.Element ||
                reader.NodeType == XmlNodeType.EndElement)
                {
                    Console.Write("Name=" + reader.Name);
                }
                else if (reader.NodeType == XmlNodeType.Text)
                {
                    Console.Write(" Value=" + reader.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
