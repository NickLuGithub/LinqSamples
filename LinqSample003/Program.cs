﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list = CreateList();

            //// 這裡的 person1 是單個物件, 也就是 MyData person1
            //var person1 = list.SingleOrDefault((x) => x.Name == "Tom");
            //Console.WriteLine($"找到唯一的 : {person1.Name} - {person1.Age}");

            //// 因為找不到唯一 (裡面有兩個 Bill) 就會跳出例外
            //var person2 = list.Single((x) => x.Name == "Bill");
            //Console.WriteLine($"找到唯一的 : {person2.Name} - {person2.Age}");

            //var list = CreateList();
            //var person = list.FirstOrDefault((x) => x.Name == "李小龍");
            //// 判斷回傳結果是否為 null
            //if (person == null)
            //{
            //    //如果是 null 則另行處理
            //    Console.WriteLine("查無此人");
            //}
            //else
            //{
            //    Console.WriteLine($"找到 : {person.Name} - {person.Age}");
            //}

            //int index = 1;
            //var list = CreateList();
            //// 這裡的 person 是單個物件, 也就是 MyData person

            //var person = list.ElementAtOrDefault(index);
            //if (person == null)
            //{
            //    Console.WriteLine("查無此人");
            //}
            //else
            //{
            //    Console.WriteLine($"找到索引為 : {index} 的人為 {person.Name} - {person.Age}");
            //}

            var list = CreateList();
            string name = "David";
            bool result = list.Any(x => x.Name == name);
            
            if(result)
            {
                Console.WriteLine($"找到了 : {name}");
            }
            else
            {
                Console.WriteLine($"找不到 : {name}");
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