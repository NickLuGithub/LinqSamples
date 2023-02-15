using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            var person1 = list.FirstOrDefault((x) => x.Age < 37);
            Console.WriteLine($"小於 37 歲的第一個人 : {person1.Name}");

            var person2 = list.FirstOrDefault((x) => x.Age < 30);
            try
            {
                Console.WriteLine($"小於 30 歲的第一個人 : {person2.Name}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"沒有小於 30 歲的人");
            }
            
            Console.ReadLine();
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Name = "Bill", Age = 47},
                new MyData { Name = "John", Age = 37},
                new MyData { Name = "Tom", Age = 48},
                new MyData { Name = "David", Age = 36},
                new MyData { Name = "Bill", Age = 35},
            };
        }
    }
}
