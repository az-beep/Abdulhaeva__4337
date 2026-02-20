using System.Windows;

namespace Group4337
{
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Abdulhaeva_4337 win = new Abdulhaeva_4337();
            win.Show();
            Close();
        }
    }
}