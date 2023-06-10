using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ex006_wpf_moving_square
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            MyCanvas.Focus();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            const int squareStep = 10;
            
            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (e.Key == Key.Up)
            {
                Canvas.SetTop(Square, Canvas.GetTop(Square) - squareStep);
            }

            if (e.Key == Key.Down)
            {
                Canvas.SetTop(Square, Canvas.GetTop(Square) + squareStep);
            }

            if (e.Key == Key.Left)
            {
                Canvas.SetLeft(Square, Canvas.GetLeft(Square) - squareStep);
            }
            
            if (e.Key == Key.Right)
            {
                Canvas.SetLeft(Square, Canvas.GetLeft(Square) + squareStep);
            }
        }
    }
}
