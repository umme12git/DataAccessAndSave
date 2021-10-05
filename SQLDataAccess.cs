using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAndSave
{
    class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Reading data from Sql database");
            ProductList.GetData();
        }
        public void SaveData()
        {
            Console.WriteLine("Saving to the Sql database");

        }

    }
}
