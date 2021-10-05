using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAndSave
{
    class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Reading data from MongoDB database");
            ProductList.GetData();

        }
        public void SaveData()
        {
            Console.WriteLine("Saving to the  MongoDB database");

        }

    }
}
