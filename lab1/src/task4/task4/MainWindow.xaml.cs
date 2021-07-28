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

namespace task4
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

        private void EraseByPoint(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void EraseByStroke(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void GestureOnly(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.GestureOnly;
        }

        private void Ink(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void InkAndGesture(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.InkAndGesture;
        }

        private void None(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.None;
        }

        private void Select(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.Select;
        }

        private void BrushWidthChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ink.DefaultDrawingAttributes.Width = ChooseWidth.Value;
            ink.DefaultDrawingAttributes.Height = ChooseWidth.Value;
        }

        private void ColorsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)(ColorsList.SelectedValue);
            string value = (string)(selectedItem.Content);
            ink.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(value);
        }
    }
}
