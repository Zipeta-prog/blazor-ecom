using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFronted.models
{
    public class Products
    {
       public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string dateAdded { get; set; }
		public int price { get; set; }
        
    }
}