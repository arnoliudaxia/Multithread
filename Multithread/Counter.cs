using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread
{
    class MultithreadSample
    {
        public void printOneToTen()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void printOneToX(int x)
        {
            for (int i = 1; i < x+1; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void printOneToX(object x)
        {
            for (int i = 1; i < (int)x + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
