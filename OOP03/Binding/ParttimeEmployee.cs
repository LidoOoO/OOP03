using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
    internal class ParttimeEmployee : Employee
    {
        public int CountOfHours { get; set; }

        public decimal HourRate { get; set; }




        public new void GetEmployeeType()
        {
            Console.WriteLine("I am ParttimeEmployee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"ParttimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , Count Of Hours = {CountOfHours} , Hour Rate = {HourRate:c}");
        }
    }
}
