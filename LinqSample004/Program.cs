using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list1 = new List<int> { 1, 2, 3, 4, 5, 6};
            //var list2 = new List<int> { 1, 3, 4, 7, 8, 9};

            //var union = list1.Union(list2);
            //Console.WriteLine($"聯集結果");
            //foreach (var item in union) Console.Write(item);

            //var intersect = list1.Intersect(list2);
            //Console.WriteLine($"\n交集結果");
            //foreach (var item in intersect) Console.Write(item);

            //var aEXb = list1.Except(list2);
            //Console.WriteLine($"\nA 差集 B 結果");
            //foreach (var item in aEXb) Console.Write(item);

            //var bEXa = list2.Except(list1);
            //Console.WriteLine($"\nB 差集 A 結果");
            //foreach (var item in bEXa) Console.Write(item);

            //var list = new List<string> { "台北", "台北", "洛杉磯", "紐約", "紐約", "台北" };
            //var result = list.Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            var list = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            
            var resultOFSkip = list.Skip(3);
            Console.WriteLine("Skip(3) 的結果");
            Display(resultOFSkip);

            var resultOFTake = list.Take(3);
            Console.WriteLine("\nTake(3) 的結果");
            Display(resultOFTake);

            var resultOFSkipTake = list.Except( list.Skip(list.Count()-3));
            Console.WriteLine("\nSkip(2).Take(2) 的結果");
            Display(resultOFSkipTake);

            Console.ReadLine();
        }

        static void Display(IEnumerable<string> source)
        {
            foreach(var item in source) { Console.Write($"{item}, "); }
        }
    }
}
