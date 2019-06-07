using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CarsDB())
            {
                if (!db.Database.Exists())
                {
                    InitData();
                }
                
            }
            QueryData();
            Console.ReadKey();
        }

        static void QueryData()
        {
            CarsDB dbContext = new CarsDB();
            var cars = dbContext.Cars;
            dbContext.Database.Log = Console.WriteLine;
            var query = cars.Select(x => x.name);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
         
        static void InitData()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car() {name = "BMW", year = 2000 });
            cars.Add(new Car() {name = "Mersedes", year = 2010 });
            cars.Add(new Car() {name = "Hondai", year = 2012 });
            cars.Add(new Car() {name = "Nissan", year = 2006 });

            CarsDB db = new CarsDB();
                foreach (var item in cars)
                {
                    db.Cars.Add(item);
                }

            db.SaveChanges();
        } 

    }
}

