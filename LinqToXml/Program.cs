using System.Diagnostics;
using System.Xml.Linq;

namespace LinqToXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create Dom 
            //Instantiating an X-DOM
            //XElement lname = new XElement("Lname", "mohamed");
            //XElement customer = new XElement("customer");
            //customer.Add(new XAttribute("Id", 1));
            //customer.Add(new XElement("Fname", "Yousef"));
            //customer.Add(lname);
            //Console.WriteLine(customer);
            /*
             * output
            <customer Id="1">
            <fname>Yousef</fname>
            <Lname>ohamed</Lname>
            </customer>
            */
            //create Xml Element

            //XElement Employees = new XElement(
            //    "Employees",
            //        new XElement(
            //            "Employee",
            //            new XElement("Id", "1"),
            //            new XElement("Name", "Yousef"),
            //            new XElement("Age", "28"),
            //            new XElement("Adress",
            //                    new XElement("country", "Egypt"),
            //                    new XElement("city", "Assuit"),
            //                    new XElement("postcode", "Ast-1234")
            //                ),
            //            new XElement("Phone", "01002306887")
            //            )

            //           );
            //Console.WriteLine(Employees.ToString());
            #endregion
            #region Loading and Parsing
            //load from file 
            XElement loadingfromfile = XElement.Load(@"D:\spatiumempolyee.txt");
            Console.WriteLine(loadingfromfile);
            // Parse builds an X-DOM from a string.
            string xmlfromstring = @"<Empolyee Id=""1"">
                                    <Fname>Yousef</Fname>
                                    <Lname>mohamed</Lname>
                                    </Empolyee>";
            Console.WriteLine(XElement.Parse(xmlfromstring));
            #endregion
            #region Functional Construction
            XElement functionelement = new XElement("functionelement", new XAttribute("Id", "1"),
                                                   new XElement("name", "Functionelement"),
                                                   new XComment("nice job")
                                                   );
            Console.WriteLine(functionelement.ToString());

            #endregion
            #region Navigating and Querying
            //firstnode(),lastnode(),nodes()
            var Elment = new XElement("Elment1",
                                    new XElement("elmentchild1", "childelment1"),
                                    new XElement("elmentchild2", "elmentchild2"),
                                    new XElement("elment2",
                                     new XElement("elment2child1", "elment2child1"),
                                    new XElement("elment2child2", "elment2child1")
                                    )
                                    );
            Console.WriteLine(Elment.ToString());
            Console.WriteLine("----------------------------------------------");
            foreach ( XNode node in Elment.Nodes() ) 
            {
                Console.WriteLine(node.ToString(SaveOptions.DisableFormatting) + ".");
            }
            Console.WriteLine("-----------------------------------------------------");
            foreach (XElement e in Elment.Elements())
                Console.WriteLine(e.Name + "=" + e.Value);
            Console.WriteLine("--------------------------------------------------------");
            var first=Elment.FirstNode;
            Console.WriteLine(first);
            var last = Elment.LastNode;
            Console.WriteLine(last);
            var countelment = Elment.Elements("elmentchild1").Count();
            Console.WriteLine(countelment);
            #endregion
            //////////////////////////Day two in chapter10///////////////////////////////
            #region Updating X-Dom
            // Console.WriteLine("-------------------------------------------");
            // XElement setting = new XElement("setting", new XElement("timeout", "30"));
            // Console.WriteLine(setting);
            // setting.SetValue("updatevalue");
            // Console.WriteLine(setting);
            // setting.SetElementValue("timeupdate","updatevalue");
            // Console.WriteLine(setting);
            // XElement seq=new XElement("seq",new XElement("one"),new XElement("three"));
            // Console.WriteLine(seq);
            // //seq.FirstNode.AddAfterSelf(new XElement("two"));
            //// Console.WriteLine(seq);
            // seq.LastNode.AddBeforeSelf(new XElement("two"));
            // Console.WriteLine(seq);
            // //removing node
            // XElement contacts = XElement.Parse(
            //                             @"<contacts>
            //                             <customer name='Mary'/>
            //                             <customer name='Chris' archived='true'/>
            //                             <supplier name='Susan'>
            //                             <phone archived='true'>012345678<!--confidential--></phone>
            //                             </supplier>
            //                             </contacts>");
            // Console.WriteLine(contacts);
            // contacts.Element("customer").Remove();
            // Console.WriteLine(contacts);


            #endregion
            #region Working with values
            #region setting values
            ////setting values
            //XElement date = new XElement("time", DateTime.Now);
            //Console.WriteLine(date.ToString());
            //Console.WriteLine("after setting value");
            //date.SetValue(DateTime.Now.AddDays(3));
            //Console.WriteLine(date.ToString());
            //#endregion
            //#region Getting values
            //XElement datenow = new XElement("datenow",DateTime.Now);
            //DateTime dateTime=(DateTime)datenow;
            //Console.WriteLine(dateTime.ToString());
            //#endregion
            //#endregion
            //#region Documents and Declarations
            //var doc1 = new XDocument(
            //          new XElement("test", "data"));
            //var doc = new XDocument(
            //          new XDeclaration("1.0", "utf-16", "yes"));
            //doc.Save("test.xml");
            #endregion
          
        }
    }
}
