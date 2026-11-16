using System.Globalization;
using System.Net.Http.Headers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex1_sort
{
    enum SortBy { Id,Name,Date, Price};

    internal class Program
    {

        public static List<Product> SortProducts(List<Product> products, SortBy parameter)
        {
            return parameter switch
            {
                SortBy.Id => products.OrderBy(p => p.Id).ToList(),
                SortBy.Name => products.OrderBy(p => p.Name).ToList(),
                SortBy.Price => products.OrderBy(p => p.Price).ToList(),
                SortBy.Date => products.OrderBy(p => p.Date).ToList(),

            };
        }
        static void Main(string[] args)
            {
                Product p1 = new Product(1,"pp", DateTime.Now, 50);
                Product p2 = new Product(2,"bb", DateTime.Now, 50);
                Product p3 = new Product(3,"ert", DateTime.Now, 50);
                Product p4 = new Product(4,"dd", DateTime.Now, 50);

                List<Product> products = [p1,p2,p3,p4];
                var sorted = SortProducts(products, SortBy.Name);

                foreach (var item in sorted) {
                    Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.Date}");
                }

            }
    }
}
