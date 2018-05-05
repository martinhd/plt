using System;
using System.Xml;
using System.Xml.XPath;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            XPathDocument doc = new XPathDocument("books.xml");
            var nav = doc.CreateNavigator();
        }
    }
}
