using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Polymorphism
{
    internal class TypeA
    {

        #region Part 03 Polymorphism - Overriding
        public int A { get; set; }
        // Automatic Property
        //Compiler Will Generate Hidden Private Att [Backing Field]

        public TypeA(int a)
        {
            A = a;
        }


        // Object Member Functions [Non Static Functions]

        public void MyFunc01()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyFunc02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        } 
        #endregion
    }
}
