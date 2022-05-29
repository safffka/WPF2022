﻿namespace Petzold.StackTenButtons
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;

    class StackTenButtons : Window
    {

        public StackTenButtons()
        {
            Title = "Stack Ten Buttons";

            StackPanel stack = new StackPanel();
            stack.Background = Brushes.Aquamarine;
            Content = stack;
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Name = ((char)('A' + i)).ToString();
                btn.FontSize += rand.Next(10);
                btn.Content = "Button " + btn.Name + " says 'Click me'";
                btn.Click += ButtonOnClick;
                stack.Children.Add(btn);
            }
        }


        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new StackTenButtons());
        }

        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Button btn = args.Source as Button;
            MessageBox.Show("Button " + btn.Name + " has been clicked", "Button Click");
        }
    }
}