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
using System.Windows.Media.Animation;
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
        private DoubleAnimation _opacityIn;
        private DoubleAnimation _opacityOut;
        private Storyboard _sbOpacityIn;
        private Storyboard _sbOpacityOut;

        public RevealControl()
        {
            InitializeComponent();

            _opacityIn = new DoubleAnimation(1, new Duration(TimeSpan.FromMilliseconds(100)));
            _opacityOut = new DoubleAnimation(0, new Duration(TimeSpan.FromMilliseconds(100)));
            _sbOpacityIn = new Storyboard();
            _sbOpacityOut = new Storyboard();


            Storyboard.SetTarget(_opacityIn, border);
            Storyboard.SetTargetProperty(_opacityIn, new PropertyPath(Border.OpacityProperty));

            Storyboard.SetTarget(_opacityOut, border);
            Storyboard.SetTargetProperty(_opacityOut, new PropertyPath(Border.OpacityProperty));

            _sbOpacityIn.Children.Add(_opacityIn);
            _sbOpacityOut.Children.Add(_opacityOut);

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
            _sbOpacityIn.Begin();
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            _sbOpacityOut.Begin();

        }

        private void Move(MouseEventArgs e)
        {
            var pos = e.GetPosition(this);

            maskTransform.X = (pos.X - Width / 2) / Width;
            maskTransform.Y = (pos.Y - Height / 2) / Height;

        }
    }
}
