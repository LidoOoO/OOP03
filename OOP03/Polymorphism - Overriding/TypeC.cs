using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Polymorphism___Overriding
{
    // TypeC -> Direct Parent {TypeB}
    // TypeC -> Indirect Parent {TypeA} 
    internal class TypeC : TypeB
    {
        public int C { get; set; }


        public TypeC(int a , int b , int c) : base (a , b)
        {
            C = c;
        }

        public new void MyFunc01()
        {
            Console.WriteLine("I am Derived [Grand Child]");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C}");
        }
    }
}
