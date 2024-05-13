using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_kuchi
{
    internal class Dog
    {
        static int dogCount;

        private string name;
        private int age;
        public Dog(string name,int age)
        {
            this.name = name;
            this.age = age;
            dogCount += 1;
        }
        public void Bark()
        {
            Console.WriteLine("wow-wow");
        }

        internal void PrintInfo()
        {
            Console.Write("Dog's name: " + this.name + "; age:" + this.age + "; Obajda se sas: ");
            this.Bark();
        }
    }
}
