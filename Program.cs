using System;

namespace DataAccessAndSave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the type of database you would like to access data from " +
                "(ex mongo, list, sql");
            var userResponse = Console.ReadLine().ToLower();
            var dataAcctype = DataAccessFactory.GetDataAccessType(userResponse);
            dataAcctype.LoadData();
            dataAcctype.SaveData();
        }
    }
}
