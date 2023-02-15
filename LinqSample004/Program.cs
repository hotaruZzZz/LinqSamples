using LinqSample001;
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
            //開始用 var 了
            var list = CreateList();
            //這裡的 person1 是單個物件， 也就是 MyData person1
            var person1 = list.FirstOrDefault((x) => x.Age < 37);
            Console.WriteLine($"小於 37 歲的人生第一個被找到的是 : {person1.Name}");

            //因為找不到， 就會跳出例外
            try
            {
                var person2 = list.First((x) => x.Age < 30);
                Console.WriteLine($"小於 30 歲的人第一個被找到的是 : {person2.Name}");
            }
            catch(Exception ex) { Console.WriteLine("沒有小於30歲的"); }

            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
            new MyData { Name = "Bill", Age = 47 },
            new MyData { Name = "John", Age = 37 },
            new MyData { Name = "Tom", Age = 48 },
            new MyData { Name = "David", Age = 36 },
            new MyData { Name = "Bill", Age = 45 },
            };
        }
    }
}
