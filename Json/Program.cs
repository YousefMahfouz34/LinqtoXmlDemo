
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Utf8JsonReader and Utf8JsonWriter


            //byte[] data = File.ReadAllBytes("people.json");
            //Utf8JsonReader reader = new Utf8JsonReader(data);
            //switch (reader.TokenType) 
            //{
            //        case JsonTokenType.StartObject:
            //        Console.WriteLine($"Start of object");
            //        break;
            //        case JsonTokenType.EndObject:
            //        Console.WriteLine($"End of object");
            //        break;
            //        case JsonTokenType.StartArray:
            //        Console.WriteLine($"Start of Array");
            //        break;
            //        case JsonTokenType.EndArray:
            //        Console.WriteLine($"End of Array");
            //        break;
            //        case JsonTokenType.PropertyName:
            //        Console.Write($"Property: {reader.GetString()}");
            //        break;
            //        case JsonTokenType.String:
            //        Console.WriteLine($"Value: {reader.GetString()}");
            //        break;
            //        case JsonTokenType.Number:
            //        Console.WriteLine($" Value: {reader.GetInt32()}");
            //        break;
            //        default:
            //        Console.WriteLine($"No support for {reader.TokenType}");
            //        break;

            //}
            //var option = new JsonWriterOptions { Indented = true };
            //using (var stream = File.Create("myfile.json"))
            //using (var writer = new Utf8JsonWriter(stream, option))
            //{
            //    writer.WriteStartObject();
            //    writer.WriteString("FirstName", "Yousef");
            //    writer.WriteString("LastName", "Mahfouz");
            //    writer.WritePropertyName("Age");
            //    writer.WriteNumberValue(46);
            //    writer.WriteEndObject();
            //}
            #endregion
            #region JsonDocument
            // reading simple values
            //using JsonDocument document = JsonDocument.Parse("123");
            //int number = document.RootElement.GetInt32();
            //Console.WriteLine(number);
            ////Reading JSON arrays
            //using JsonDocument document1= JsonDocument.Parse(@"[1,2,3,4,4,5]");
            //int len= document1.RootElement.GetArrayLength();
            //Console.WriteLine(len);
            //foreach (var item in document1.RootElement.EnumerateArray())
            //{
            //    Console.WriteLine(item.GetInt32());
            //}
            //// JSON with linq
            //using var stream = File.OpenRead("D:\\Projects\\LinqToXml\\Json\\bin\\Debug\\net8.0");
            //using JsonDocument document2 = JsonDocument.Parse("myfile.json");            //var query =
            //            from person in document2.RootElement.EnumerateArray()
            //            select new
            //            {
            //                FirstName = person.GetProperty("FirstName").GetString(),
            //                Age = person.GetProperty("Age").GetInt32(),
            //                Friends =
            //            from friend in person.GetProperty("Friends").EnumerateArray()
            //            select friend.GetString()
            //            };            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.FirstName);
            //    Console.WriteLine(item.Age);
            //    foreach (var item1 in item.Friends)
            //    {
            //        Console.WriteLine(item1);
            //    }


            //}




            #endregion
            #region Json Node
            //read simple value
             JsonNode node = JsonNode.Parse("1234");
            int num = (int) node;
            Console.WriteLine(num);


            #endregion






        }
    }
}
