using System.Windows;
using System.Windows.Input;

namespace FlatUi.Controls
{
    public partial class WindowStripe
    {
        public WindowStripe()
        {
            InitializeComponent();
        }

        private void Rectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Window.GetWindow(this)?.DragMove();
        }

        private void BtnCloseClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this)?.Close();
        }

        private void BtnMaxClick(object sender, RoutedEventArgs e)
        {
            var wnd = Window.GetWindow(this);
            if (wnd == null) return;

            if (wnd.WindowState != WindowState.Maximized)
            {
                wnd.WindowState = WindowState.Maximized;
                return;
            }
            if (wnd.WindowState != WindowState.Normal)
            {
                wnd.WindowState = WindowState.Normal;
                return;
            }
        }

        private void BtnMinClick(object sender, RoutedEventArgs e)
        {
            var wnd = Window.GetWindow(this);
            if (wnd == null) return;

            if (wnd.WindowState != WindowState.Minimized)
            {
                wnd.WindowState = WindowState.Minimized;
                return;
            }
            if (wnd.WindowState != WindowState.Normal)
            {
                wnd.WindowState = WindowState.Normal;
                return;
            }
        }
    }
}
