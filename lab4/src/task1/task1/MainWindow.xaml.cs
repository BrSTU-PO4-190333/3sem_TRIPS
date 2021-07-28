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

namespace task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int ButtonWidth = (int)button.Width;
            int ButtonHeight = (int)button.Height;
            int MaxWidth = 800;
            int MaxHeight = 450;
            int xButtonCord = (int)Canvas.GetLeft(button);
            int yButtonCord = (int)Canvas.GetTop(button);

            int xNewCord = (int)xButtonCord;
            int yNewCord = (int)yButtonCord;

            int Nx = 0;
            do
            {
                xNewCord = xButtonCord + rnd.Next(-ButtonWidth, ButtonWidth * 2);
                Nx += 1;
                if (Nx >= 100)
                {
                    MessageBox.Show("Зациклен цикл");
                    break;
                }
            }
            while (xNewCord <= 0 || (xNewCord + ButtonWidth) >= MaxWidth);

            int Ny = 0;
            do
            {
                yNewCord = yButtonCord + rnd.Next(-ButtonHeight, ButtonHeight * 2);
                Ny += 1;
                if (Ny >= 100)
                {
                    MessageBox.Show("Зациклен цикл");
                    break;
                }
            }
            while (yNewCord <= 0 || (yNewCord + ButtonHeight) >= MaxHeight);

            Canvas.SetLeft(button, xNewCord);
            Canvas.SetTop(button, yNewCord);

            MyTextBox.Text = ""
                + "MaxWidth = " + MaxWidth.ToString() + "\n"
                + "MaxHeight = " + MaxHeight.ToString() + "\n"
                + "xButtonCord = " + xButtonCord.ToString() + "\n"
                + "yButtonCord = " + yButtonCord.ToString() + "\n"
                + "xNewCord = " + xNewCord.ToString() + "\n"
                + "yNewCord = " + yNewCord.ToString() + "\n";
        }
    }
}
