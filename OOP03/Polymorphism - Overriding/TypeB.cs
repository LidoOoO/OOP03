using OOP03.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Polymorphism___Overriding
{
    internal class TypeB : TypeA
    {
        #region Part 03 Polymorphism - Overriding
        public int B { get; set; }


        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        // Overriding 
        // 1. Using New Keyword 
        // 2. Using Override Keyword

        // Apply Function Overriding Using New Keyword
        // Static Binding [Early Binding]
        // MyFunc01() => Static Bonded Method
        // Static Binding Works During Compiler Time
        // Compiler Wiil Bind Function Call Based On Reference Type Not Object Type 
        public new void MyFunc01() // New => New Version From MyFunc01() 
        {
            Console.WriteLine("I am Derived [Child]");
        }

        // Appling Function Overriding Using Overriding Keyword
        // Function Must be Inherited From Parent [Public - Virtual Function]
        // Dynamic Binding [Late Binding]
        // MyFunc02() => Dynamic Bonded Method 
        // Dynamic Bining Work During Run Time
        // CLR Will Bind Function Call Based On Obgject Type Not Reference Type   

        public override void MyFunc02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        } 
        #endregion
    }
}
