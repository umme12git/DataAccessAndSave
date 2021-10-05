using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAndSave
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Reading data from sql database");
            ProductList.GetData();
            

        }
        public void SaveData()
        {
            Console.WriteLine("Saving data to sql database");
        }
    }


}
