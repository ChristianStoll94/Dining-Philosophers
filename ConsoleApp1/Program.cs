using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var forks = new Forks();
            new Philosoph("Ben", 0, 1, forks);
            new Philosoph("Adi", 1, 2, forks);
            new Philosoph("Rob", 2, 3, forks);
            new Philosoph("Max", 3, 4, forks);
            new Philosoph("Kurt", 4, 0, forks);
        }
    }
}
