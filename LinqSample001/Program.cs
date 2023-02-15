using LinqSample001;
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
            /*
             *Query Expression //具有IEnumerable 都可被foreach
            IEnumerable<MyData> people =
                from data in list
                where data.Name == "Bill"
                select data;  //結果值選則
            */
            //var people = list.Where(list, (x) => x.Name == "Bill");
            var people = Enumerable.Where(list, (x) => x.Name == "Bill");

            //顯示結果
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
            new MyData { Name = "Bill", Age = 47 },
            new MyData { Name = "John", Age = 37 },
            new MyData { Name = "Tom", Age = 48 },
            new MyData { Name = "David", Age = 36 },
            new MyData { Name = "Bill", Age = 45 },
            };
        }
    }
}

