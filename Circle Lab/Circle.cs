using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Lab
{
    class Circle
    {
        private double radius;
        public double circumference;
        public double area;

        public Circle()
        {
            // nothing needed here
        }

        public Circle(double inRadius)
        {
            radius = inRadius;
        }
        
        public double CalculateCircumference(double inRadius)
        {
            circumference  = 2 * Math.PI * inRadius;
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            double roundedCirc = FormatNumber(circumference);
            return $"The circumference of your circle is: {roundedCirc}";
        }
        public double CalculateArea(double myRadius)
        {
            area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public string CalculateFormattedArea()
        {
            double roundedArea = FormatNumber(area);
            return $"The area of your circle is: {roundedArea}";
        }
        private double FormatNumber(double inNumber)
        {
            return Math.Round(inNumber, 2);
        }     
    }
}
