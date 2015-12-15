using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3TimBM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Console.WriteLine("Skriv Ditt namn.");
            //person.SetName(Console.ReadLine());
            //Console.WriteLine("Du heter " + person.GetName());

            Point point = new Point();
            Console.WriteLine("Skriv in ett X värde");
            point.SetX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Skriv in ett Y värde");
            point.SetY(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ditt X värde är: " + point.GetX() + " och ditt Y värde är: " + point.GetY());


            Circle circle = new Circle();
            Console.WriteLine("Skriv in diameter på en circel");
            circle.SetDiameter(double.Parse(Console.ReadLine()));
            circle.SetCenter(point);
            Console.WriteLine("Din diameter är " + circle.GetDiameter() + " och din omkrets är " + circle.GetCircumference());
            Console.WriteLine("Din X position är: " + circle.GetCenter().GetX());




        }
    }
}
