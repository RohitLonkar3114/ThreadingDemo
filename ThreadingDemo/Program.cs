using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo
{
    class Resource
    {
        public void Data(string s)
        {
            //lock(this)
            //{
            Monitor.Enter(this);
                for(int i=1;i<=5;i++)
                {
                    Console.WriteLine(s);
                    Thread.Sleep(1000);
                }
            Monitor.Exit(this);
            //}
        }
    }
    internal class Program
    {
        static Resource r=new Resource();

        public static void Thread1()
        {
            r.Data("Thread 1");
        }
        public static void Thread2()
        {
            r.Data("Thread 2");
        }
        public static void Thread3()
        {
            r.Data("Thread 3");
        }
        public static void Thread4()
        {
            r.Data("Thread 4");
        }
        public static void Thread5()
        {
            r.Data("Thread 5");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);
            Thread t3 = new Thread(Thread3);
            Thread t4 = new Thread(Thread4);
            Thread t5 = new Thread(Thread5);

            t1.Priority = ThreadPriority.Normal;
            t2.Priority=ThreadPriority.Highest;
            t3.Priority=ThreadPriority.BelowNormal;
            t4.Priority=ThreadPriority.AboveNormal;
            t5.Priority=ThreadPriority.Lowest;
            
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5
                
                .Start();
            Console.ReadLine();
        }
    }
}
