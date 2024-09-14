using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Polymorphism___Overriding
{

    //TypeA => Indirect Parent
    //TypeB => Indirect parent
    //TypeC => Direct Parent 
    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int a , int b , int c , int d) : base(a , b , c)
        {
            D = d;
        }

        public new void MyFunc01()
        {
            Console.WriteLine("i am Derived [Child Grand Child]");
        }

        // MyFunc02 - Public Virtual
        // New => End Sequences
        // Virtual => Start New Sequences
        public new virtual void MyFunc02()
        {
            Console.WriteLine($"TypeD : A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }
}
