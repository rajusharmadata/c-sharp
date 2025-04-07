using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Setmethod obj = new Setmethod();
            // obj.Car = "BMW";
            // Console.WriteLine(obj.Car);
            // obj.Car = "Mercedes";
            // Console.WriteLine(obj.Car);
            // Circle obj = new Circle(5);
            // Console.WriteLine("Area of Circle: " + obj.CircleArea());

            // interface Example
            TrangleArea obj = new TrangleArea(5, 10);
            Console.WriteLine("Area of Rectangle: " + obj.trangleArea());
        }
    }