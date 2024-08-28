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

        }
    }
}
