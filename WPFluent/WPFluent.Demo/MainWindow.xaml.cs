using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Composition;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFluent.Demo
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
    }



    [MarkupExtensionReturnType(typeof(Brush))]
    public class CustomBrush : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {

            SolidColorBrush q = new SolidColorBrush();
            q.Color = Color.FromArgb(55, 66, 77, 88);

            return q;
        }

    }

    [MarkupExtensionReturnType(typeof(Brush))]
    public class AcrylicBrush : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {

            SolidColorBrush q = new SolidColorBrush();
            q.Color = Color.FromArgb(55, 66, 77, 88);

            return q;
        }

    }


}