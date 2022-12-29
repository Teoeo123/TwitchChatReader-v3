using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

namespace TwitchChatReader_v3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void ClickRed(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Close();
        }

        private void ClickGreen(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && WindowState==WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
               
            }
            else
            {
                WindowState = WindowState.Maximized;
            }

        }
        private void ClickYellow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                WindowState = WindowState.Minimized;
        }
        
        private void ClickBlack(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && searchbar.Visibility == Visibility.Visible)
            {
                searchbar.Visibility = Visibility.Hidden;
            }
            else
                searchbar.Visibility = Visibility.Visible;
        }

        private void Search(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Trace.WriteLine("enter");
                searchbar.Visibility = Visibility.Hidden;
                StackChat.Visibility = Visibility.Visible;
                WSlabel.Visibility = Visibility.Hidden;
            }
        }
    }
}
