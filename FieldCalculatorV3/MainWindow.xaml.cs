using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FieldCalculatorV3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Builder builder;
        //vr 17-20
        //za 10-13
        public DispatcherTimer timer;

        private int activeGrid = 0;

        public Styling styles;

        public MainWindow()
        {
            InitializeComponent();
            this.styles = new Styling();
            this.builder = new Builder(this);
            SetActiveGrid(0);
        }

        public void SwitchGrid()
        {
            Grid newGrid = new Grid();
            switch (this.activeGrid)
            {
                case 0:
                    newGrid = builder.MakeMainMenu();
                    break;
                case 1:
                    newGrid = builder.MakeCircleMenu();
                    break;
                case 2:
                    newGrid = builder.MakeSquareMenu();
                    break;
                case 3:
                    newGrid = builder.MakeTriangleMenu();
                    break;
            }
            if (this.activeGrid != 0)
            {
                newGrid.Children.Add(builder.MakeBackButton());
            }
            master.Children.Clear();
            master.Children.Add(newGrid);
        }

        public int GetActiveGrid()
        {
            return this.activeGrid;
        }

        public void SetActiveGrid(int grid)
        {
            this.activeGrid = grid;
            SwitchGrid();
        }
    }
}
