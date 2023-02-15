using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = CreateList();

            // 凡是有 IEnumerable 都可以 foreach
            // Query Expression

            /*
            var 宣告
             -- 強型別
             -- 隱含型別(所以這是個語法糖)
             -- 或稱右(後)決議型別
             -- 只能做為宣告區域變數使用
            */

            IEnumerable<MyData> people =
                from data in list
                where data.Name == "Bill"
                select data;

            foreach (MyData person in people) 
            {
                Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
            }

            Console.ReadLine();
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData {Name = "Bill", Age = 47},
                new MyData {Name = "John", Age = 37},
                new MyData {Name = "Tom", Age = 48},
                new MyData {Name = "David", Age = 36},
                new MyData {Name = "Bill", Age = 35},
            };
        }
    }
}
