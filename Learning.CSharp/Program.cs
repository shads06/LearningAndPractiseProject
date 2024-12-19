using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            Console.WriteLine("Loading Data...");
            dt = LoadData();
            Console.WriteLine("\nData Loaded.\nPress any key to present time LINQ took to read");
            Console.ReadKey();
            Console.WriteLine("\nPlease wait...");
            UseLINQToRead(dt);
            Console.WriteLine("\nPress any key to present time it took to read data using loop");
            Console.ReadKey();
            Console.WriteLine("\nPlease wait...");
            UseLoopToRead(dt);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }

        public static DataTable LoadData()
        {
            DataTable dt = new DataTable();
            DataColumn column1 = new DataColumn("Name");
            dt.Columns.Add(column1);
            for (int i = 0; i <= 20000; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Name"] = i.ToString();
                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        public static void UseLINQToRead(DataTable dt)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var groupedData = dt.AsEnumerable().GroupBy(r => r.Field<string>("Name"));
            foreach (var item in groupedData) {}
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"\nTotal time LINQ took to read data from datatable: {elapsedMs} Miliseconds");
        }

        public static void UseLoopToRead(DataTable dt)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var item in dt.Rows) {}
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"\nTotal time loop took to read data from datatable: {elapsedMs} Miliseconds");
        }
    }
}
