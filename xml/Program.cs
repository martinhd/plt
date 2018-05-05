using System;
using System.Xml;
using System.Xml.XPath;

//see https://msdn.microsoft.com/en-us/library/ms256086(v=vs.110).aspx

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XPathDocument doc = new XPathDocument("https://www.w3schools.com/xml/books.xml");
            var nav = doc.CreateNavigator();
            
            var authors = nav.Select("/bookstore/book/author[1]");

            foreach(var author in authors)
               Console.WriteLine(author.ToString());
        }
    }
}
