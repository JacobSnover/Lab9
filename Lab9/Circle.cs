using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9;

namespace Lab9
{
    class CircleApp
    {
        private double diameter = 0.0;
        public double radius;
        public double circumference = 0.0;
        private double area = 0.0;
        
        public CircleApp(double radius)
        {
            diameter = radius * 2;
            this.radius = radius;
        }

        public double GetCircumference()
        {
            circumference = Math.PI * diameter;
            return circumference;
        }

        public String GetFormattedCircumference()
        {
            string formatCirc = FormatNumber(circumference).ToString();
            return formatCirc;
        }

        public double GetArea()
        {
            area = Math.PI * radius * radius;
            return area;
        }

        public String GetFormattedArea()
        {
            string formatArea = FormatNumber(area).ToString();
            return formatArea;
        }

        private String FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }

        private double getRadius()
        {
            return radius;
        }

        public void setRadius(double newradius)
        {
            radius = newradius;
        }
    }
}
