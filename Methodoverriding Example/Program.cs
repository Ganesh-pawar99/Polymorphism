using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverriding_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.print(); 

            Console.ReadLine();
        }
    }
    public class A
    {
        public void print()
        {
            Console.WriteLine("A");
        }
    }
    public class B :A
    {
        public new void print()
        {
            Console.WriteLine("B");
        }
    }
}
