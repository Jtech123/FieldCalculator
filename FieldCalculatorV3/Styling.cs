using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace FieldCalculatorV3
{
    public class Styling
    {
        public GridLayout normalGrid;
        public TextLayout textLayout;
        public ImageLayout imageLayout;
        public ButtonLayout normalButton, menuButton, backButton;
        public TextBoxLayout textBoxLayout;
        public LabelLayout normalLabel, titleLabel;
        public StackLayout mainMenuStackPanel, calculateStackPanel, inputFieldLayout;

        public struct GridLayout
        {
            public int width;
            public int height;
            public Thickness margin;
        }

        public struct TextLayout
        {
            public FontFamily fontFamily;
        }

        public struct ImageLayout
        {
            public int width;
            public int height;
            public Thickness margin;
        }

        public struct ButtonLayout
        {
            public int width;
            public int height;
            public Thickness margin;
        }

        public struct TextBoxLayout
        {
            public int width;
            public int height;
            public Thickness margin;
        }

        public struct LabelLayout
        {
            public int width;
            public int height;
            public double fontSize;
            public Thickness margin;
        }

        public struct StackLayout
        {
            public int width;
            public int height;
            public Thickness margin;
        }

        public Styling()
        {
            normalGrid = new GridLayout();
            normalGrid.width = 950;
            normalGrid.height = 450;
            normalGrid.margin = new Thickness(0);

            textLayout = new TextLayout();
            textLayout.fontFamily = new FontFamily("Cambria");

            imageLayout = new ImageLayout();
            imageLayout.width = 500;
            imageLayout.height = 250;
            imageLayout.margin = new Thickness(100,50,100,50); //<----

            normalButton = new ButtonLayout();
            normalButton.width = 200;
            normalButton.height = 50;
            normalButton.margin = new Thickness(5); //<----

            menuButton = new ButtonLayout();
            menuButton.width = 250;
            menuButton.height = 50;
            menuButton.margin = new Thickness(0); //<----

            backButton = new ButtonLayout();
            backButton.width = 200;
            backButton.height = 50;
            backButton.margin = new Thickness(0); //<----

            textBoxLayout = new TextBoxLayout();
            textBoxLayout.width = 200;
            textBoxLayout.height = 25;
            textBoxLayout.margin = new Thickness(0); //<----

            normalLabel = new LabelLayout();
            normalLabel.width = 200;
            normalLabel.height = 25;
            normalLabel.margin = new Thickness(0); //<----
            normalLabel.fontSize = 12;

            titleLabel = new LabelLayout();
            titleLabel.width = 500;
            titleLabel.height = 50;
            titleLabel.margin = new Thickness(10);
            titleLabel.fontSize = 24;

            mainMenuStackPanel = new StackLayout();
            mainMenuStackPanel.width = 750;
            mainMenuStackPanel.height = 50;
            mainMenuStackPanel.margin = new Thickness(0,37.5,0,37.5); //<----

            calculateStackPanel = new StackLayout();
            calculateStackPanel.width = 500;
            calculateStackPanel.height = 50;
            calculateStackPanel.margin = new Thickness(0, 0, 0, 0);

            inputFieldLayout = new StackLayout();
            inputFieldLayout.width = 50;
            inputFieldLayout.height = 200;
            inputFieldLayout.margin = new Thickness(0, 0, 0, 0);
        }
    }
}
