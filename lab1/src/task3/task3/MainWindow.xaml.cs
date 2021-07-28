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

namespace task3
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
        public void ClearStatusBar(object sender, RoutedEventArgs e)
        {
            ApplicationStatusBar.Text = "...";
        }
        // = = = = = Change background color
        private void ChangeBackgroundColor_MouseEnter(object sender, RoutedEventArgs e)
        {
            ApplicationStatusBar.Text = "Click, if you want to change background color";
        }

        private void Button_GetBackgroundColor_setGridBackground(object sender, RoutedEventArgs e)
        {
            ApplicationGrid.Background = (sender as Button).Background;
        }
        private void MenuItem_GetBackgroundColor_setGridBackground(object sender, RoutedEventArgs e)
        {
            ApplicationGrid.Background = (sender as MenuItem).Background;
        }

        // = = = = = About the developer
        private void AboutTheDev_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Developer: Pavel Galanin\n");
        }
        private void AboutTheDev_MouseEnter(object sender, RoutedEventArgs e)
        {
            ApplicationStatusBar.Text = "Click, if you want to understand who is author";
        }
        // = = = = = Close application
        private void CloseApplication_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void CloseApplication_MouseEnter(object sender, RoutedEventArgs e)
        {
            ApplicationStatusBar.Text = "Click, if you want to close application";
        }
    }
}
