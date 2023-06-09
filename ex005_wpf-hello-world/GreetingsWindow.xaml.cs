using System.Windows;

namespace ex005_wpf_hello_world
{
    public partial class GreetingsWindow : Window
    {
        public GreetingsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (HelloRadioButton.IsChecked == true)
            {
                MessageBox.Show("Hello!");
            }
            else if (GoodbyeRadioButton.IsChecked == true)
            {
                MessageBox.Show("Goodbye!");
            }
            else
            {
                MessageBox.Show("Select one of the options first!");
            }
        }
    }
}
