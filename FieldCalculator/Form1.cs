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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TriBtn_Click(object sender, EventArgs e)
        {
            triangle triangleForm = new triangle();
            triangleForm.Show();
        }

        private void SqrBtn_Click(object sender, EventArgs e)
        {
            Square squareForm = new Square();
            squareForm.Show();
        }

        private void CirBtn_Click(object sender, EventArgs e)
        {
            Circle circleForm = new Circle();
            circleForm.Show();
        }
    }
}
