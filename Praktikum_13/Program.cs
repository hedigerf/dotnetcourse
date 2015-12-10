using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum13
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 1, 2, 3, 4, 5, 6, 2, 1, 8 };            var lambdaTest = new LambdaTest();

            //a)
            Console.WriteLine("a)");            var res =lambdaTest.ProcessData(i => (int)Math.Pow(i, 2), values);            Array.ForEach(res, elem => Console.WriteLine(elem));

            //b)
            Console.WriteLine("b)");
            var res2 = lambdaTest.ProcessData2((k1,k2,k3,x) => k1* (int)Math.Pow(x, 2)+k2* (int)Math.Pow(x, 1) + k3,2,values);
            Array.ForEach(res2, elem => Console.WriteLine(elem));

            //c)
            Console.WriteLine("c)");
            var res3 =values.Select(elem => elem % 3 == 0 ? elem : 0);
            foreach(int elem in res3)
            {
                Console.WriteLine(elem);
            }

            //d)
            Console.WriteLine("d)");
            IEnumerable<int> scoreQuery =
                from score in values
                    where score > 3
                        where score < 6
                            select score;
            foreach(int elem in scoreQuery)
            {
                Console.WriteLine(elem);
            }


            System.Threading.Thread.Sleep(4000);

        }


    }
}
