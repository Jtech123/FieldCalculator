﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius
        {
            get;
            set;
        }

        public virtual double diameter
        {
            get;
            set;
        }

        public double CalculateDiameter(double radius)
        {
            if (radius > 0)
                return radius * 2;

            return -1;
        }

        public double CalculateRadius(double diameter)
        {
            if (diameter > 0)
                return diameter / 2;

            return -1;
        }

        public override double CalculateArea(object[] args)
        {
            radius = (double)args[0];

            if (radius > 0)
                return Math.PI * Math.Pow(radius, 2);
            return -1;
        }

        public override double CalculateCircumference(object[] args)
        {
            diameter = (double)args[0];

            if (diameter > 0)
                return Math.PI * diameter;
            return -1;
        }

        public virtual string Foo()
        {
            throw new System.NotImplementedException();
        }

    }

}