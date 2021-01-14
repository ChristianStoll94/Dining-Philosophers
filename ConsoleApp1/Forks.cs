using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Forks
    {
        private readonly bool[] Fork = new bool[5];

        public void GetForks(int left, int right)
        {
            lock (this)
            {
                while (Fork[left] || Fork[right])
                {
                    Monitor.Wait(this);
                }
                Fork[left] = true;
                Fork[right] = true;
            }
        }

        public void PutForks(int left, int right)
        {
            lock (this)
            {
                Fork[left] = false;
                Fork[right] = false;
                Monitor.PulseAll(this);
            }
        }
    }
}
