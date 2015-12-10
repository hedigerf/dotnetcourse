using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum13
{
    class LambdaTest
    {
        public delegate int Function(int x);

        public delegate int Function4(int k1, int k2, int k3,int x);

        public int[] ProcessData(Function f,int[] array)
        {
            int[] res = new int[array.Length];
            int i = 0;
            foreach(int value in array)
            {
                res[i++] = f(value);
            }
            return res;
        }

        public int[] ProcessData2(Function4 f, int x, int[] array)
        {
            int[] res = new int[array.Length / 3];
            int i = 0;
            var list = new List<int>();
            foreach (int value in array)
            {
                list.Add(value);
                if(list.Count == 3)
                {
                    int first = list[0];
                    res[i++] = f(list[0],list[1],list[2], x);
                    list.Clear();
                }
            }
            return res;
        }
    }
}
