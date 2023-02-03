using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using GLGMLab4;
using System.Xml.Linq;

namespace ProductMaintenance
{
    public static class OrderDB
    {
        public static List<Order> GetOrders(string path)
        {
            // create the list
            List<Order> orders = new List<Order>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(path, settings);

            // read past all nodes to the first Product node
            if (xmlIn.ReadToDescendant("Product"))
            {
                //NEED TO FIX THIS, THIS IS STEP 10F AND I HAVE NO IDEA WHAT'S ASKED
                // create one Product object for each Product node
                do
                {
                    xmlIn.ReadStartElement("Product");
                    string name = xmlIn.ReadElementContentAsString();
                    bool delivery = xmlIn.ReadElementContentAsBoolean();
                    decimal amount = xmlIn.ReadElementContentAsDecimal();
                    
                    Order readOrder = new Order(name,delivery,amount);
                    orders.Add(readOrder);
                }
                while (xmlIn.ReadToNextSibling("Product"));
            }
            
            // close the XmlReader object
            xmlIn.Close();

            return orders;
        }

        public static void SaveOrders(List<Order> orders, string path)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Products");

            // write each product object to the xml file
           /* foreach (Order order in orders)
            {
                Order product = new Order(name, delivery, amount);
                xmlOut.WriteStartElement("Product");
                xmlOut.WriteElementString("Code",
                    OrderID);
                xmlOut.WriteElementString("Description",
                    product.Description);
                xmlOut.WriteElementString("Price",
                    Convert.ToString(product.Price));
                xmlOut.WriteEndElement();

            }*/

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}
