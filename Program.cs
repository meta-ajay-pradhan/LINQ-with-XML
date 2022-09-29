using System.Xml.Linq;

namespace LinqWithXml
{
    public class Item
    {
        public string? Id { get; set; }

        public string? Author { get; set; }

        public string? Title { get; set; }

        public string? Genre { get; set; }

        public string? Price { get; set; }

        public string? Publish_date { get; set; }

        public string? Description { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //loading the xml documnet into the memory 
            XElement doc =
                XElement.Load("C:\\.NET\\LinqWithXml\\Data.xml");

            var result =
                from ed in doc.Descendants("book")
                select
                new Item(){
                    Author = ed.Element("author").Value,
                    Title = ed.Element("title").Value,
                    Genre = ed.Element("genre").Value,
                    Price = ed.Element("price").Value,
                    Publish_date = ed.Element("publish_date").Value,
                    Description = ed.Element("description").Value
                };

            foreach (var item in result)
            {
                Console.WriteLine("Author - " + item.Author);
                Console.WriteLine("Title - " + item.Title);
                Console.WriteLine("Genre - " + item.Genre);
                Console.WriteLine("Price - " + item.Price);
                Console.WriteLine("Publish_Date - " + item.Publish_date);
                Console.WriteLine("Description - " + item.Description);
                Console.WriteLine();
                Console.WriteLine();
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);            }
        }
    }
}
