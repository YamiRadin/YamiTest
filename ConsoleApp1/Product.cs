using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public decimal Price { get; set; }

            public Product(int id, string name, DateTime date, decimal price)
            {
                Id = id;
                Name = name;
                Date = date;
                Price = price;
            }
        }
    }