using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            //開始用 var 了
            var list = CreateList();
            //這裡的 person1 是單個物件， 也就是 MyData person1
            
            var person = list.FirstOrDefault((x) => x.Name == "貓咪");
            // 判斷回傳結果是否為 null
            if(person == null)
            {
                //如果是 null 則另行處理
                    Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到 : {person.Name} - {person.Age}");
            }

            var person1 = list.SingleOrDefault((x) => x.Name == "Tom");
            Console.WriteLine($"找到唯一的 : {person1.Name} - {person1.Age}");
            //因為找不到， 就會跳出例外
            //建議第一道手段不要用try-catch
            try
            {
                var person2 = list.Single((x) => x.Name == "Bill");
                Console.WriteLine($"找到唯一的 : {person2.Name} - {person2.Age}");

            }
            catch (Exception ex) { Console.WriteLine("沒有Bill或重複?"); }
            //person3 ElementAtOrDefault
            var person3 = list.ElementAtOrDefault(index);
            if (person3 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為 : {index} 的人是 {person3.Name} - { person3.Age}");
            }

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
