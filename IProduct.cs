using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAndSave
{
    public interface IProduct
    {
        public String productName { get; set; }
        public Double productPrice { get; set; }
    }
}
