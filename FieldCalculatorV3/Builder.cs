using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Shapes;

namespace FieldCalculatorV3
{
    class Builder
    {
        public MainWindow window;
        private ObjectBuilder myObject;
        //V Must be implemented V
        private int maxTries = 3;       // <
        private int currentTries = 0;   // <
        //^ Must be implemented ^
        
        public Builder(MainWindow window)
        {
            this.window = window;
            this.myObject = new ObjectBuilder(window);
            this.window.timer = this.myObject.MakeTimer(500, 0, 0, true, Timer_Tick);
        }

        public Grid MakeMainMenu()
        {
            Grid g = myObject.MakeMainGrid("grdMainGrid");
            Label lblTitle = myObject.MakeTitleLabel("Kies uw vorm", "lblTitle");
            StackPanel menuGroup = myObject.MakeMenuButtonGroup();

            UIElement[] elements = { lblTitle, menuGroup };

            myObject.FillGrid(g, elements, out g);

            return g;
        }

        public Grid MakeCircleMenu()
        {
            Grid g = myObject.MakeMainGrid("grdCircle");

            Label lblTitle = myObject.MakeTitleLabel("Cirkel", "lblTitle");

            string[] buttonTexts = { "Bereken omtrek", "Bereken oppervlakte" };
            string[] buttonNames = { "btnCircleCircumference", "btnCircleArea" };
            RoutedEventHandler[] buttonHandlers = { BtnCircleCircumference_Click, BtnCircleArea_Click };

            StackPanel calculateGroup = myObject.MakeCalculationButtonGroup(buttonTexts, buttonNames, buttonHandlers);

            Grid imgPanel = myObject.MakeImageGrid(@"circleIMG.png");

            StackPanel dPanel = myObject.MakeInputField("dPanel", "txtDiameter", "lblDiameter", "Diameter", new Thickness(0));
            dPanel.VerticalAlignment = VerticalAlignment.Center;
            dPanel.HorizontalAlignment = HorizontalAlignment.Left;

            StackPanel rPanel = myObject.MakeInputField("rPanel", "txtRadius", "lblRadius", "Straal", new Thickness(0));
            rPanel.VerticalAlignment = VerticalAlignment.Bottom;
            rPanel.HorizontalAlignment = HorizontalAlignment.Center;

            StackPanel aPanel = myObject.MakeInputField("aPanel", "txtArea", "lblArea", "Oppervlakte", new Thickness(0), true);
            aPanel.VerticalAlignment = VerticalAlignment.Center;
            aPanel.HorizontalAlignment = HorizontalAlignment.Center;

            StackPanel cPanel = myObject.MakeInputField("cPanel", "txtCircumference", "lblCircumference", "Omtrek", new Thickness(0), true);
            cPanel.VerticalAlignment = VerticalAlignment.Center;
            cPanel.HorizontalAlignment = HorizontalAlignment.Right;

            UIElement[] elements = { lblTitle, calculateGroup, imgPanel, dPanel, rPanel, aPanel, cPanel };

            if (elements.Length > 0)
            {
                myObject.FillGrid(g, elements, out g);
            }

            return g;
        }

        public Grid MakeSquareMenu()
        {
            Grid g = myObject.MakeMainGrid("grdSquare");

            Label lblTitle = myObject.MakeTitleLabel("Rechthoek", "lblTitle");

            string[] buttonTexts = { "Bereken omtrek", "Bereken oppervlakte" };
            string[] buttonNames = { "btnSquareCircumference", "btnSquareArea" };
            RoutedEventHandler[] buttonHandlers = { BtnSquareCircumference_Click, BtnSquareArea_Click };

            StackPanel calculateGroup = myObject.MakeCalculationButtonGroup(buttonTexts, buttonNames, buttonHandlers);

            Grid imgPanel = myObject.MakeImageGrid(@"squareIMG.png");

            StackPanel wPanel = myObject.MakeInputField("wPanel", "txtWidth", "lblWidth", "Breedte", new Thickness(0,0,0,100));
            wPanel.HorizontalAlignment = HorizontalAlignment.Center;
            wPanel.VerticalAlignment = VerticalAlignment.Bottom;

            StackPanel hPanel = myObject.MakeInputField("hPanel", "txtHeight", "lblHeight", "Hoogte", new Thickness(100, 0, 0, 0));
            hPanel.HorizontalAlignment = HorizontalAlignment.Left;
            hPanel.VerticalAlignment = VerticalAlignment.Center;

            StackPanel aPanel = myObject.MakeInputField("aPanel", "txtArea", "lblArea", "Oppervlakte", new Thickness(0, 10, 50, 90), true);
            aPanel.HorizontalAlignment = HorizontalAlignment.Center;
            aPanel.VerticalAlignment = VerticalAlignment.Center;

            StackPanel cPanel = myObject.MakeInputField("cPanel", "txtCircumference", "lblCircumference", "Omtrek", new Thickness(0, 90, 50, 10), true);
            cPanel.HorizontalAlignment = HorizontalAlignment.Right;
            cPanel.VerticalAlignment = VerticalAlignment.Center;

            UIElement[] elements = { lblTitle, calculateGroup, imgPanel, wPanel, hPanel, aPanel, cPanel };

            if (elements.Length > 0)
            {
                myObject.FillGrid(g, elements, out g);
            }

            return g;
        }

        public Grid MakeTriangleMenu()
        {
            Grid g = myObject.MakeMainGrid("grdTriangle");

            Label lblTitle = myObject.MakeTitleLabel("Rechthoekige driehoek", "lblTitle");

            string[] buttonTexts = { "Bereken omtrek", "Bereken inhoud" };
            string[] buttonNames = { "btnTriangleCircumference", "btnTriangleArea" };
            RoutedEventHandler[] buttonHandlers = { BtnTriangleCircumference_Click, BtnTriangleArea_Click };

            StackPanel calculateGroup = myObject.MakeCalculationButtonGroup(buttonTexts, buttonNames, buttonHandlers);

            Grid imgPanel = myObject.MakeImageGrid(@"triangleIMG.png");

            StackPanel straight1Panel = myObject.MakeInputField("straight1Panel", "txtStraight1", "lblStraight1", "Rechthoekige zijde", new Thickness(0));
            straight1Panel.HorizontalAlignment = HorizontalAlignment.Left;
            straight1Panel.VerticalAlignment = VerticalAlignment.Center;

            StackPanel straight2Panel = myObject.MakeInputField("straight2Panel", "txtStraight2", "lblStraight2", "Rechthoekige zijde", new Thickness(0));
            straight2Panel.HorizontalAlignment = HorizontalAlignment.Right;
            straight2Panel.VerticalAlignment = VerticalAlignment.Center;

            StackPanel lPanel = myObject.MakeInputField("longPanel", "txtLong", "lblLong", "Lange zijde", new Thickness(0));
            lPanel.HorizontalAlignment = HorizontalAlignment.Center;
            lPanel.VerticalAlignment = VerticalAlignment.Bottom;

            StackPanel aPanel = myObject.MakeInputField("aPanel", "txtArea", "lblArea", "Oppervlakte", new Thickness(0), true);
            aPanel.HorizontalAlignment = HorizontalAlignment.Center;
            aPanel.VerticalAlignment = VerticalAlignment.Center;

            UIElement[] elements = { lblTitle, calculateGroup, imgPanel, straight1Panel, straight2Panel, lPanel, aPanel };

            if (elements.Length > 0)
            {
                myObject.FillGrid(g, elements, out g);
            }

            return g;
        }

        public Button MakeBackButton()
        {
            Button b = myObject.MakeBackButton();

            return b;
        }

        public string FieldTrimmer(string input)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(input);
            byte[] allowedBytes = { 44, 46, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
            string result = "";

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                for (int j = 0; j < allowedBytes.Length; j++)
                {
                    if (asciiBytes[i] == allowedBytes[j])
                    {
                        byte[] newByte = { asciiBytes[i] };
                        char[] ascii = Encoding.ASCII.GetChars(newByte);
                        result += ascii[0];
                    }
                }
            }

            return result;
        }

        public void BtnCircleCircumference_Click(object sender, EventArgs e)
        {
            double radius = -1;
            double diameter = -1;
            double area = -1;
            double circumference = -1;

            Grid circleGrid = Helper.FindChild<Grid>(window.master, "grdCircle");

            StackPanel dPanel = Helper.FindChild<StackPanel>(circleGrid, "dPanel");
            StackPanel rPanel = Helper.FindChild<StackPanel>(circleGrid, "rPanel");
            StackPanel aPanel = Helper.FindChild<StackPanel>(circleGrid, "aPanel");
            StackPanel cPanel = Helper.FindChild<StackPanel>(circleGrid, "cPanel");

            TextBox txtDiameter = Helper.FindChild<TextBox>(dPanel, "txtDiameter");
            TextBox txtRadius = Helper.FindChild<TextBox>(rPanel, "txtRadius");
            TextBox txtArea = Helper.FindChild<TextBox>(aPanel, "txtArea");
            TextBox txtCircumference = Helper.FindChild<TextBox>(cPanel, "txtCircumference");

            txtDiameter.Text = FieldTrimmer(txtDiameter.Text);
            txtRadius.Text = FieldTrimmer(txtRadius.Text);
            txtArea.Text = FieldTrimmer(txtArea.Text);
            txtCircumference.Text = FieldTrimmer(txtCircumference.Text);

            if (txtDiameter.Text == "" || txtDiameter.Text == null)
                diameter = -1;
            else
                double.TryParse(txtDiameter.Text, out diameter);
            if (txtArea.Text == "" || txtArea.Text == null)
                area = -1;
            else
                double.TryParse(txtArea.Text, out area);
            if (txtRadius.Text == "" || txtRadius.Text == null)
                radius = -1;
            else
                double.TryParse(txtRadius.Text, out radius);
            if (txtCircumference.Text == "" || txtCircumference.Text == null)
                circumference = -1;
            else
                double.TryParse(txtCircumference.Text, out circumference);

            if (diameter > 0)
            {
                Circle circle = new Circle();
                txtCircumference.Text = circle.CalculateCircumference(new object[] { diameter }).ToString("#,###.000");
            }
            else if (radius > 0)
            {
                Circle circle = new Circle();
                txtCircumference.Text = circle.CalculateCircumference(new object[] { circle.CalculateDiameter(radius) }).ToString("#,###.000");
            }
            else
            {
                MessageBox.Show("Not all fields were filled in.");
            }
        }

        public void BtnCircleArea_Click(object sender, EventArgs e)
        {
            double radius = -1;
            double diameter = -1;
            double area = -1;

            Grid circleGrid = Helper.FindChild<Grid>(window.master, "grdCircle");

            StackPanel dPanel = Helper.FindChild<StackPanel>(circleGrid, "dPanel");
            StackPanel rPanel = Helper.FindChild<StackPanel>(circleGrid, "rPanel");
            StackPanel aPanel = Helper.FindChild<StackPanel>(circleGrid, "aPanel");
            StackPanel cPanel = Helper.FindChild<StackPanel>(circleGrid, "cPanel");

            TextBox txtDiameter = Helper.FindChild<TextBox>(dPanel, "txtDiameter");
            TextBox txtRadius = Helper.FindChild<TextBox>(rPanel, "txtRadius");
            TextBox txtArea = Helper.FindChild<TextBox>(aPanel, "txtArea");
            TextBox txtCircumference = Helper.FindChild<TextBox>(cPanel, "txtCircumference");

            txtDiameter.Text = FieldTrimmer(txtDiameter.Text);
            txtRadius.Text = FieldTrimmer(txtRadius.Text);
            txtArea.Text = FieldTrimmer(txtArea.Text);
            txtCircumference.Text = FieldTrimmer(txtCircumference.Text);

            if (txtDiameter.Text == "" || txtDiameter.Text == null)
                diameter = -1;
            else
                double.TryParse(txtDiameter.Text, out diameter);
            if (txtRadius.Text == "" || txtRadius.Text == null)
                radius = -1;
            else
                double.TryParse(txtRadius.Text, out radius);
            if (txtArea.Text == "" || txtArea.Text == null)
                area = -1;
            else
                double.TryParse(txtArea.Text, out area);

            if (diameter > 0)
            {
                Circle circle = new Circle();
                txtArea.Text = circle.CalculateArea(new object[] { circle.CalculateRadius(diameter) }).ToString("#,###.000");
            }
            else if (radius > 0)
            {
                Circle circle = new Circle();
                txtArea.Text = circle.CalculateArea(new object[] { radius }).ToString("#,###.000");
            }

            else
            {
                MessageBox.Show("Not all fields were filled in.");
            }
        }

        public void BtnSquareCircumference_Click(object sender, EventArgs e)
        {

            double width = -1;
            double height = -1;

            Grid squareGrid = Helper.FindChild<Grid>(window.master, "grdSquare");

            StackPanel wPanel = Helper.FindChild<StackPanel>(squareGrid, "wPanel");
            StackPanel hPanel = Helper.FindChild<StackPanel>(squareGrid, "hPanel");
            StackPanel aPanel = Helper.FindChild<StackPanel>(squareGrid, "aPanel");
            StackPanel cPanel = Helper.FindChild<StackPanel>(squareGrid, "cPanel");

            TextBox txtWidth = Helper.FindChild<TextBox>(wPanel, "txtWidth");
            TextBox txtHeight = Helper.FindChild<TextBox>(hPanel, "txtHeight");
            TextBox txtArea = Helper.FindChild<TextBox>(aPanel, "txtArea");
            TextBox txtCircumference = Helper.FindChild<TextBox>(cPanel, "txtCircumference");

            txtWidth.Text = FieldTrimmer(txtWidth.Text);
            txtHeight.Text = FieldTrimmer(txtHeight.Text);
            txtArea.Text = FieldTrimmer(txtArea.Text);
            txtCircumference.Text = FieldTrimmer(txtCircumference.Text);

            if (txtHeight.Text == "" || txtHeight.Text == null)
                height = -1;
            else
                double.TryParse(txtHeight.Text, out height);
            if (txtWidth.Text == "" || txtWidth.Text == null)
                width = -1;
            else
                double.TryParse(txtWidth.Text, out width);

            if (height > 0 && width > 0)
                txtCircumference.Text = ((height * 2) + (width * 2)).ToString();

            else
            {
                MessageBox.Show("Not all fields were filled in.");
            }
        }

        public void BtnSquareArea_Click(object sender, EventArgs e)
        {
            double height = -1;
            double width = -1;

            Grid squareGrid = Helper.FindChild<Grid>(window.master, "grdSquare");

            StackPanel wPanel = Helper.FindChild<StackPanel>(squareGrid, "wPanel");
            StackPanel hPanel = Helper.FindChild<StackPanel>(squareGrid, "hPanel");
            StackPanel aPanel = Helper.FindChild<StackPanel>(squareGrid, "aPanel");
            StackPanel cPanel = Helper.FindChild<StackPanel>(squareGrid, "cPanel");

            TextBox txtWidth = Helper.FindChild<TextBox>(wPanel, "txtWidth");
            TextBox txtHeight = Helper.FindChild<TextBox>(hPanel, "txtHeight");
            TextBox txtArea = Helper.FindChild<TextBox>(aPanel, "txtArea");
            TextBox txtCircumference = Helper.FindChild<TextBox>(cPanel, "txtCircumference");

            txtWidth.Text = FieldTrimmer(txtWidth.Text);
            txtHeight.Text = FieldTrimmer(txtHeight.Text);
            txtArea.Text = FieldTrimmer(txtArea.Text);
            txtCircumference.Text = FieldTrimmer(txtCircumference.Text);

            if (txtHeight.Text == "" || txtHeight.Text == null)
                height = -1;
            else
                double.TryParse(txtHeight.Text, out height);
            if (txtWidth.Text == "" || txtWidth.Text == null)
                width = -1;
            else
                double.TryParse(txtWidth.Text, out width);

            if (height > 0 && width > 0)
            {
                Square square = new Square();
                txtArea.Text = square.CalculateArea(new object[] { height, width }).ToString();
            }
            else
            {
                MessageBox.Show("Not all fields were filled in.");
            }
        }

        public void BtnTriangleCircumference_Click(object sender, EventArgs e)
        {
            double legA = -1;
            double legB = -1;
            double hypo = -1;
            double area = -1;

            Grid triangleGrid = Helper.FindChild<Grid>(window.master, "grdTriangle");

            StackPanel straight1Panel = Helper.FindChild<StackPanel>(triangleGrid, "straight1Panel");
            StackPanel straight2Panel = Helper.FindChild<StackPanel>(triangleGrid, "straight2Panel");
            StackPanel longPanel = Helper.FindChild<StackPanel>(triangleGrid, "longPanel");
            StackPanel aPanel = Helper.FindChild<StackPanel>(triangleGrid, "aPanel");
            StackPanel cPanel = Helper.FindChild<StackPanel>(triangleGrid, "cPanel");

            TextBox txtLegA = Helper.FindChild<TextBox>(straight1Panel, "txtStraight1");
            TextBox txtLegB = Helper.FindChild<TextBox>(straight2Panel, "txtStraight2");
            TextBox txtHypo = Helper.FindChild<TextBox>(longPanel, "txtLong");
            TextBox txtCircumference = Helper.FindChild<TextBox>(cPanel, "txtCircumference");
            TextBox txtArea = Helper.FindChild<TextBox>(aPanel, "txtArea");

            txtLegA.Text = FieldTrimmer(txtLegA.Text);
            txtLegB.Text = FieldTrimmer(txtLegB.Text);
            txtHypo.Text = FieldTrimmer(txtHypo.Text);
            txtArea.Text = FieldTrimmer(txtArea.Text);
            //txtCircumference.Text = FieldTrimmer(txtCircumference.Text);

            if (txtLegA.Text != "" && txtLegA.Text != null && !double.TryParse(txtLegA.Text, out legA))
                legA = -1;
            if (txtLegB.Text != "" && txtLegB.Text != null && !double.TryParse(txtLegB.Text, out legB))
                legB = -1;
            if (txtHypo.Text != "" && txtHypo.Text != null && !double.TryParse(txtHypo.Text, out hypo))
                hypo = -1;
            if (txtArea.Text != "" && txtArea.Text != null && !double.TryParse(txtArea.Text, out area))
                area = -1;

            if (legA > 0 && legB > 0 && hypo == -1)
            {
                Triangle triangle = new Triangle();
                txtHypo.Text = triangle.CalculateCircumference(new object[] { legA, legB, hypo }).ToString();
            }
            else if (legA == -1 && legB > 0 && hypo > 0)
            {
                Triangle triangle = new Triangle();
                txtLegA.Text = triangle.CalculateCircumference(new object[] { legA, legB, hypo }).ToString();
            }
            else if (legA > 0 && legB == -1 && hypo > 0)
            {
                Triangle triangle = new Triangle();
                txtLegB.Text = triangle.CalculateCircumference(new object[] { legA, legB, hypo }).ToString();
            }
            else
            {
                MessageBox.Show("Not all fields were filled in.");
            }
        }

        public void BtnTriangleArea_Click(object sender, EventArgs e)
        {
            double legA = -1;
            double legB = -1;
            double hypo = -1;
            double area = -1;

            Grid triangleGrid = Helper.FindChild<Grid>(window.master, "grdTriangle");

            StackPanel straight1Panel = Helper.FindChild<StackPanel>(triangleGrid, "straight1Panel");
            StackPanel straight2Panel = Helper.FindChild<StackPanel>(triangleGrid, "straight2Panel");
            StackPanel longPanel = Helper.FindChild<StackPanel>(triangleGrid, "longPanel");
            StackPanel aPanel = Helper.FindChild<StackPanel>(triangleGrid, "aPanel");
            StackPanel cPanel = Helper.FindChild<StackPanel>(triangleGrid, "cPanel");

            TextBox txtLegA = Helper.FindChild<TextBox>(straight1Panel, "txtStraight1");
            TextBox txtLegB = Helper.FindChild<TextBox>(straight2Panel, "txtStraight2");
            TextBox txtHypo = Helper.FindChild<TextBox>(longPanel, "txtLong");
            TextBox txtCircumference = Helper.FindChild<TextBox>(cPanel, "txtCircumference");
            TextBox txtArea = Helper.FindChild<TextBox>(aPanel, "txtArea");



            if (txtLegA.Text != "" && txtLegA.Text != null && !double.TryParse(txtLegA.Text, out legA))
                legA = -1;
            if (txtLegB.Text != "" && txtLegB.Text != null && !double.TryParse(txtLegB.Text, out legB))
                legB = -1;
            if (txtHypo.Text != "" && txtHypo.Text != null && !double.TryParse(txtHypo.Text, out hypo))
                hypo = -1;
            if (txtArea.Text != "" && txtArea.Text != null && !double.TryParse(txtArea.Text, out area))
                area = -1;

            if (legA > 0 && legB > 0 && hypo > 0)
            {
                Triangle triangle = new Triangle();
                txtArea.Text = triangle.CalculateArea(new object[] { legA, legB, hypo }).ToString();
            }
            else
            {
                MessageBox.Show("Not all fields were filled in.");
            }
        }

        public void Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
