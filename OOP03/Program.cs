﻿using OOP03.Binding;
using OOP03.Polymorphism;
using OOP03.Polymorphism___Overriding;

namespace OOP03
{
    internal class Program
    {
        #region Part 02 Polymorphism - Overloading

        // Method Overloading Using Just For Readability

        //public static int Sum(int X , int Y)
        //{
        //    return X + Y;
        //}

        //public static double Sum(double X, double Y) 
        //{
        //    return X + Y;
        //}

        //public static int Sum(int X , int Y , int Z)
        //{
        //    return X + Y + Z;
        //}

        //public static double Sum(int X , double Y)
        //{
        //    return X + Y;
        //}
        
        //public static double Sum(double X , int Y)
        //{
        //    return X + Y;
        //}

        #endregion

        // Employee employee
        // Can refer => object employee
        // Can refer => object From Class Inheirt From employee [FullTimeEmployee - ParttimeEmployee]
        public static void ProcessEmployee(Employee employee)
        {
            if(employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            } 
        }
        
        // Not Overloading
        //public static void ProcessEmployee(ParttimeEmployee employee)
        //{
        //    if(employee is not null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    } 
        //}
        static void Main(string[] args)
        {
            #region Part 02 Polymorphism - Overloading


            //int Result = Sum(1, 2);

            //Console.WriteLine($"Result = {Result}"); // 3

            //Result = Sum(1, 2, 3);

            //Console.WriteLine($"Result = {Result}"); // 6

            //double Result02 = Sum(1.2, 2.2);
            //Console.WriteLine($"Result = {Result02}"); // 3.40

            //Result02 = Sum(2, 2.2);

            #endregion

            #region Part 03 Polymorphism - Overriding
            // Supported With Class ONLY
            // Function Overriding Must Be With Relationship [Inheritance]


            //TypeA typeA = new TypeA(1);
            //typeA.A = 10;
            //typeA.MyFunc01(); // I am Base [Parent]
            //typeA.MyFunc02(); // TypeA : A = 10

            //Console.WriteLine("===============");
            //TypeB typeB = new TypeB(1, 3);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.MyFunc01();
            //typeB.MyFunc02();

            #endregion

            #region Binding

            // Ref From Parent => Object From Child

            //TypeA RefBase;
            /// Declare For Reference From Type "TypeA"
            /// RefBase Refer To An Object From Type "TypeA"
            /// OR Refer To An Object From Any Class [Inherit From TypeA]

            //RefBase = new TypeB(1, 2);
            ////Binding 
            //RefBase.A = 10;
            ////RefBase.B = 20; //Invalid
            //RefBase.MyFunc01();// Override Using New [Static Binding]
            //RefBase.MyFunc02();// Override Using Override [Dynamic Binding]

            #endregion

            #region Not Binding
            //Ref From Child => Object From Parent


            //TypeB ChildRef = new TypeA(); // Invalid
            //RefBase = (TypeB) new TypeA(4); // Not Binding
            // Explicit Casting 
            // Unsafe Casting

            //TypeA typeA = new TypeA(4);
            //TypeB typeB = (TypeB) typeA;// Explicit Casting
            //// (TypeB) => Casting Operator - Function 

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //// System.InvalidCastException  

            //TypeA typeA = new TypeB(1, 4);
            //TypeB typeB = (TypeB) typeA;

            //Console.WriteLine(typeB.A); // 1
            //Console.WriteLine(typeB.B); // 4


            //object O = 13;

            //int X = (int) O;

            //Console.WriteLine(X);


            #endregion

            #region Part 06 Binding Ex 01

            //FulltimeEmployee fulltimeEmployee = new FulltimeEmployee(99, "Waleed", 22, 8000);
            //ProcessEmployee(fulltimeEmployee);


            //ParttimeEmployee parttimeEmployee = new ParttimeEmployee()
            //{
            //    Id = 97,
            //    Name = "Waleed",
            //    Age = 22,
            //    HourRate = 2.5m,
            //    CountOfHours = 87
            //};

            //ProcessEmployee(parttimeEmployee); // Invalid

            #endregion

            #region Part 07 Binding Ex 02

            //TypeA typeA = new TypeC(1 , 2 , 3);
            ////Binding 
            //typeA.A = 10;
            ////typeA.B = 20; //Invalid
            ////typeA.C = 30; //Invalid

            //typeA.MyFunc01(); // Override Using New Keyword [Static Binding]

            //// I am Base [Parent]

            //typeA.MyFunc02(); // Override Using Override Keyword [Dynamic Binding]

            ////TypeC : A = 10 , B = 2 , C = 3





            //Console.WriteLine("=====================");




            //TypeB typeB = new TypeC(1 , 2 , 3);
            //// TypeB Parent For TypeC
            //typeB.A = 10;
            //typeB.B = 20;
            ////typeB.C = 30; //Invalid

            //typeB.MyFunc01(); // Static Bonded Method

            ////I am Derived [Child]

            //typeB.MyFunc02(); // Dynamic Bonded Method

            ////TypeC: A = 10 , B = 20 , C = 3



            //TypeA typeA = new TypeE(1, 2, 3, 4, 5); // Indirect Parent
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5); // Indirect Parent
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5); // Indirect Parent



            //typeA.MyFunc02(); //Dynamic Bonded Method
            //typeB.MyFunc02(); //Dynamic Bonded Method
            //typeC.MyFunc02(); //Dynamic Bonded Method
            //// TypeC : A = 1 , B = 2 , C = 3

            //// Last Override Of MyFunc02 => Was In Type C
            //// TypeD => New Virtual


            //TypeD typeD = new TypeE(1 , 2 , 3 , 4 , 5); // Direct Parent

            //typeD.MyFunc02(); // Dynamic Binding
            //// Last Override Of MyFunc02()  In Class MyType E

            ////TypeE : A = 1 , B = 2 , C = 3 , D = 4 , E = 5



            #endregion

        }
    }
}
