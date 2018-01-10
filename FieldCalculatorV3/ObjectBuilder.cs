using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.IO;

namespace FieldCalculatorV3
{
    class ObjectBuilder
    {
        private MainWindow window;

        public ObjectBuilder(MainWindow window)
        {
            this.window = window;
        }

        private Grid MakeGrid(int width, int height, string gridName, Thickness margin)
        {
            Grid g = new Grid();
            g.Width = width;
            g.Height = height;
            g.Margin = margin;
            g.Name = gridName;

            return g;
        }

        public Button MakeButton(int width, int height, string content, string buttonName, RoutedEventHandler handler, Thickness margin)
        {
            Button b = new Button();
            b.Content = content;
            b.Width = width;
            b.Height = height;
            b.Margin = margin;
            b.Name = buttonName;
            b.FontFamily = window.styles.textLayout.fontFamily;

            b.Click += handler;

            return b;
        }

        private Image MakeImage(string location)
        {
            Image image = new Image();
            BitmapImage bitmapImage = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + @"\images\" + location));
            //image.Width = 300;
            //image.Height = 300;
            image.Source = bitmapImage;
            image.Stretch = System.Windows.Media.Stretch.Uniform;
            image.Name = "imgShape";
            image.HorizontalAlignment = HorizontalAlignment.Stretch;
            image.VerticalAlignment = VerticalAlignment.Stretch;

            return image;
        }

        public Label MakeLabel(int width, int height, string content, string labelName, Thickness margin)
        {
            Label l = new Label();
            l.Content = content;
            l.Width = width;
            l.Height = height;
            l.Name = labelName;
            l.Margin = margin;
            l.FontFamily = window.styles.textLayout.fontFamily;

            return l;
        }

        private TextBox MakeTextBox(int width, int height, string textBoxName, Thickness margin)
        {
            TextBox t = new TextBox();
            t.Width = width;
            t.Height = height;
            t.Name = textBoxName;
            t.Margin = margin;
            t.MaxLength = 20;
            t.FontFamily = window.styles.textLayout.fontFamily;


            return t;
        }

        private StackPanel MakeStackPanel(int width, int height, string stackPanelName, Thickness margin, int orientation)
        {
            StackPanel s = new StackPanel();
            s.Width = width;
            s.Height = height;
            s.Name = stackPanelName;
            s.Margin = margin;
            switch (orientation)
            {
                case 0:
                    s.Orientation = Orientation.Horizontal;
                    break;
                case 1:
                    s.Orientation = Orientation.Vertical;
                    break;
            }

            return s;
        }

        public DispatcherTimer MakeTimer(int miliseconds, int seconds, int minutes, bool enabled, EventHandler handler)
        {
            TimeSpan t = new TimeSpan(0, 0, minutes, seconds, miliseconds);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = t;
            timer.Tick += handler;
            timer.IsEnabled = enabled;

            return timer;
        }

        public Grid MakeMainGrid(string gridName)
        {
            Grid g = MakeGrid(window.styles.normalGrid.width, window.styles.normalGrid.height, gridName, window.styles.normalGrid.margin);

            return g;
        }

        public StackPanel MakeMenuButtonGroup()
        {
            StackPanel s = MakeStackPanel(window.styles.mainMenuStackPanel.width, window.styles.mainMenuStackPanel.height, "grdMenuButtonGroup", window.styles.mainMenuStackPanel.margin, 0);
            Button circle = MakeMenuButton("Cirkel", "btnCircle", BtnCircle_Click);
            Button square = MakeMenuButton("Rechthoek", "btnSquare", BtnSquare_Click);
            Button triangle = MakeMenuButton("Driehoek", "btnTriangle", BtnTriangle_Click);
            s.VerticalAlignment = VerticalAlignment.Bottom;
            UIElement[] elements = { circle, square, triangle };

            FillStackPanel(s, elements, out s);

            return s;
        }

        public StackPanel MakeCalculationButtonGroup(string[] buttonTexts, string[] buttonNames, RoutedEventHandler[] buttonHandlers)
        {
            StackPanel s = MakeStackPanel(window.styles.calculateStackPanel.width, window.styles.calculateStackPanel.height, "grdCalculateButtonGroup", window.styles.calculateStackPanel.margin, 0);
            s.VerticalAlignment = VerticalAlignment.Top;
            UIElement[] elements = new UIElement[0];
            if (buttonNames.Length == buttonTexts.Length && buttonNames.Length == buttonHandlers.Length)
            {
                elements = new UIElement[buttonNames.Length];
                for (int i = 0; i < buttonNames.Length; i++)
                {
                    Button b = MakeMenuButton(buttonTexts[i], buttonNames[i], buttonHandlers[i]);

                    elements[i] = b;
                }
            }

            if (elements.Length > 0)
            {
                FillStackPanel(s, elements, out s);
            }

            return s;
        }

        private Button MakeMenuButton(string content, string buttonName, RoutedEventHandler handler)
        {
            Button b = MakeButton(window.styles.menuButton.width, window.styles.menuButton.height, content, buttonName, handler, window.styles.menuButton.margin);

            return b;
        }

        public Label MakeTitleLabel(string content, string labelName)
        {
            Label l = MakeLabel(window.styles.titleLabel.width, window.styles.titleLabel.height, content, labelName, window.styles.titleLabel.margin);
            l.FontSize = window.styles.titleLabel.fontSize;
            l.VerticalAlignment = VerticalAlignment.Top;
            l.HorizontalAlignment = HorizontalAlignment.Center;
            l.HorizontalContentAlignment = HorizontalAlignment.Center;

            return l;
        }

        public Grid MakeImageGrid(string image)
        {
            Grid g = MakeGrid(window.styles.imageLayout.width, window.styles.imageLayout.height, "grdImage", window.styles.imageLayout.margin);
            if (image.Contains("triangle"))
                g.Margin = new Thickness(125, 50, 100, 50);
            Image img = MakeImage(image);


            g.Children.Add(img);

            return g;
        }

        public StackPanel MakeInputField(string stackPanelName, string textBoxName, string labelName, string labelContent, Thickness margin, bool readOnly = false)
        {
            StackPanel s = MakeStackPanel(window.styles.inputFieldLayout.height, window.styles.inputFieldLayout.width, stackPanelName, window.styles.inputFieldLayout.margin, 1);

            TextBox textBox = MakeTextBox(window.styles.textBoxLayout.width, window.styles.textBoxLayout.height, textBoxName, window.styles.textBoxLayout.margin);
            textBox.VerticalAlignment = VerticalAlignment.Bottom;
            textBox.HorizontalAlignment = HorizontalAlignment.Center;
            textBox.IsReadOnly = readOnly;
            if (readOnly)
                textBox.MaxLength = 50;
            Label label = MakeLabel(window.styles.normalLabel.width, window.styles.normalLabel.height, labelContent, labelName, window.styles.normalLabel.margin);
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Center;
            label.HorizontalContentAlignment = HorizontalAlignment.Center;

            UIElement[] elements = { textBox, label };

            FillStackPanel(s, elements, out s);

            return s;
        }

        public Button MakeBackButton()
        {
            Button b = MakeButton(window.styles.backButton.width, window.styles.backButton.height, "Back", "btnBack", BtnBack_Click, window.styles.backButton.margin);
            b.VerticalAlignment = VerticalAlignment.Bottom;
            b.HorizontalAlignment = HorizontalAlignment.Left;
            
            return b;
        }

        public bool FillGrid(Grid parent, UIElement[] children, out Grid result)
        {
            result = parent;
            if (children.Length <= 0)
                return false;
            foreach (UIElement child in children)
            {
                result.Children.Add(child);
            }
            if (children.Length == result.Children.Count)
                return true;
            return false;
        }

        public bool FillStackPanel(StackPanel parent, UIElement[] children, out StackPanel result)
        {
            result = parent;
            if (children.Length <= 0)
                return false;
            foreach (UIElement child in children)
            {
                result.Children.Add(child);
            }
            if (children.Length == result.Children.Count)
                return true;
            return false;
        }

        public void BtnCircle_Click(object sender, RoutedEventArgs e)
        {
            window.SetActiveGrid(1);
        }

        public void BtnSquare_Click(object sender, RoutedEventArgs e)
        {
            window.SetActiveGrid(2);
        }

        public void BtnTriangle_Click(object sender, RoutedEventArgs e)
        {
            window.SetActiveGrid(3);
        }

        public void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            window.SetActiveGrid(0);
        }
    }
}
