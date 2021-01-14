using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Philosoph
    {
        public string name;
        public int leftfork;
        public int rightfork;
        public Forks forks;
        public int eattime;
        public int thinktime;
        Random rnd = new Random();

        public Philosoph(string name, int leftfork, int rightfork, Forks forks)
        {
            this.eattime = rnd.Next(0, 500);
            this.thinktime = rnd.Next(0, 500);
            this.forks = forks;
            this.leftfork = leftfork;
            this.rightfork = rightfork;
            this.name = name;
            new Thread(this.Run).Start();
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(thinktime);
                forks.GetForks(leftfork, rightfork);
                Console.WriteLine($"{name} is eating");
                Thread.Sleep(eattime);
                forks.PutForks(leftfork, rightfork);
            }
        }
    }
}
