using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3TimBM
{
    public class Circle
    {

        //Skapa även metoderna GetDiameter och SetDiameter, 
        //som används för att hämta och sätta värdet på fältet enligt samma mönster som i uppgift 1. 
        //Tänk på att typen som hanteras i detta fall är en double, och inte en string!

       
        private double diameter;
        private Point center;
        public void SetDiameter(double diameter)
        {
            this.diameter = diameter;
        }
        public double GetDiameter()
        {
            return diameter;
        }


        public double GetCircumference()
        {
            return this.diameter * 3.1416;
        }

        public void SetCenter(Point p)
        {
            this.center = p;
        }
        public Point GetCenter()
        {
            return center;
        }

    }
}
