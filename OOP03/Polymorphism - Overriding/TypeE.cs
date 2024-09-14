using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Polymorphism___Overriding
{
    //TypeA => Indirect Parent
    //TypeB => Indirect parent
    //TypeC => Indirect Parent 
    //TypeD => Direct Parent
    internal class TypeE : TypeD
    {
        public int E { get; set; }


        public TypeE(int a , int b , int c , int d , int e) : base(a , b , c , d)
        {
            E = e;
        }

        //In TypeD MyFunc02() public new -> You Can not Overriding Using Keyword Override
        //In TypeD MyFunc02() public new Virtual -> You Can Overriding Using Keyword Override [New Sequence]
        

        public override void MyFunc02()
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");
        }




    }
}
