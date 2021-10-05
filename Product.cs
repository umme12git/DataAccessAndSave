using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAndSave
{
    public class Product : IProduct
    {
        public Product()
        {

        }
        public string productName { get; set; }
        public double productPrice { get; set; }

    }
}
