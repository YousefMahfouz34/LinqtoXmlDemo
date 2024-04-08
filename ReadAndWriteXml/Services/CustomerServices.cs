using CacheManager.Core;
using Microsoft.Ajax.Utilities;
using ReadAndWriteXml.Models;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WebGrease;

namespace ReadAndWriteXml.Services
{
    public class CustomerServices : ICustomerServices
    {
        XmlSerializer serializer;
        XElement CustomerData;
        List<Customer> CustomerList;

        public CustomerServices()
        {
            serializer = new XmlSerializer(typeof(Customer));
             CustomerList = new List<Customer>();


        }



       public async Task<List<Customer>> Read()
            { 
        //{
        //    bool isEmpty = reader.IsEmptyElement;
        //    reader.ReadStartElement();
        //    while (reader.NodeType == XmlNodeType.Element)
        //    {
        //        reader.ReadStartElement();
        //        Customer.Id = reader.ReadContentAsInt();
        //        Customer.Name = reader.ReadElementString("Name");
        //        Customer.PhoneNumber = reader.ReadElementString("PhoneNumber");
        //        CustomerList.Add(Customer);
        //    }
            return CustomerList;


        }


        FileStream str = File.OpenWrite("Data.xml");
        public async Task<bool> Write(Customer obj)
        {
            serializer.Serialize(str, obj);
            str.Dispose();
            return true;

            //Customer customer = new Customer();
            //customer.Id = obj.Id;
            //try
            //{
            //    writer.WriteElementString("id", obj.Id.ToString());
            //    writer.WriteElementString("Name", $"{obj.Name}".ToString());
            //    writer.WriteElementString("PhoneNumber", $"{obj.PhoneNumber}".ToString());
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

    }
}

