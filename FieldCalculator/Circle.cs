using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldCalculator
{
    public partial class Circle : Form
    {
        private double radius, diameter;

        public Circle()
        {
            InitializeComponent();
        }

        private double CalculateDiameter(double radius)
        {
            if (radius > 0)
                return radius * 2;

            return -1;
        }

        

        private double CalculateRadius(double diameter)
        {
            if (diameter > 0)
                return diameter / 2;

            return -1;
        }

        private double CalculateCircumferential(double diameter = -1)
        {
            if (diameter > 0)
                return Math.PI * diameter;
            return -1;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double CalculateArea(double radius = -1)
        {
            if (radius > 0)
                return Math.PI * Math.Pow(radius, 2);
            return -1;
        }

        private void CalculateSidesBtn_Click(object sender, EventArgs e)
        {
            if (diameterBox.Text.Length > 0)
                double.TryParse(diameterBox.Text, out diameter);
            else
                diameter = -1;

            if (radiusBox.Text.Length > 0)
                double.TryParse(radiusBox.Text, out radius);
            else
                radius = -1;

            if (diameter == -1 && radius > 0)
            {
                diameter = CalculateDiameter(radius);
                diameterBox.Text = diameter.ToString();
            }
            if (diameter > 0 && radius == -1)
            {
                radius = CalculateRadius(diameter);
                radiusBox.Text = radius.ToString();
            }

            if (diameter > 0)
            {
                double result = CalculateCircumferential(diameter);

                if (result != -1)
                    cirqBox.Text = result.ToString();
            }

        }

        private void CalculateInnerBtn_Click(object sender, EventArgs e)
        {
            if (diameterBox.Text.Length > 0)
                double.TryParse(diameterBox.Text, out diameter);
            else
                diameter = -1;

            if (radiusBox.Text.Length > 0)
                double.TryParse(radiusBox.Text, out radius);
            else
                radius = -1;

            if (diameter == -1 && radius > 0)
            {
                diameter = CalculateDiameter(radius);
                diameterBox.Text = diameter.ToString();
            }

            if (diameter > 0 && radius == -1)
            {
                radius = CalculateRadius(diameter);
                radiusBox.Text = radius.ToString();
            }

            if (radius > 0)
            {
                double result = CalculateArea(radius);

                if (result != -1)
                    areaBox.Text = result.ToString();
            }
        }
    }
}
