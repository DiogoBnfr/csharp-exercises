using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ex006_wpf_moving_square
{
    public partial class MovingSquare : Window
    {
        public MovingSquare()
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
            const int squareHeight = 140;
            const double squareWidth = 119.9;
            
            if (e.Key == Key.Up)
            {
                if (Canvas.GetTop(Square) != 0) 
                {
                    Canvas.SetTop(Square, Canvas.GetTop(Square) - squareStep);
                }
            }

            if (e.Key == Key.Down)
            {
                if (Canvas.GetTop(Square) < Window.ActualHeight - squareHeight)
                {
                    Canvas.SetTop(Square, Canvas.GetTop(Square) + squareStep);
                }
            }

            if (e.Key == Key.Left)
            {
                if (Canvas.GetLeft(Square) != 0)
                {
                    Canvas.SetLeft(Square, Canvas.GetLeft(Square) - squareStep);
                }
            }
            
            if (e.Key == Key.Right)
            {
                if (Canvas.GetLeft(Square) < Window.ActualWidth - squareWidth)
                {
                    Canvas.SetLeft(Square, Canvas.GetLeft(Square) + squareStep);
                }
            }
        }
    }
}
