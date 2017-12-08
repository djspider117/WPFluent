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

namespace WPFluent.Components.Controls
{
    /// <summary>
    /// Interaction logic for RevealControl.xaml
    /// </summary>
    public partial class RevealControl : UserControl
    {

        private bool _hasEntered;

        public RevealControl()
        {
            InitializeComponent();
        }

        private void Rectangle_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            Move(e);
        }


        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            _hasEntered = true;
            //rt.Opacity = 1;
            //rb.Opacity = 1;
            //mainLight.Opacity = 1;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            _hasEntered = false;
            //rt.Opacity = 0;
            //rb.Opacity = 0;
            //mainLight.Opacity = 0;

        }

        private void Move(MouseEventArgs e)
        {
            //if (!_hasEntered)
                //return;

            var pos = e.GetPosition(this);

            maskTransform.X = (pos.X - Width / 2) / Width;
            maskTransform.Y = (pos.Y - Height / 2) / Height;

        }
    }
}
