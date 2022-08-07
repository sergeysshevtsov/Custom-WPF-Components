using System;
using System.Windows;
using System.Windows.Controls;

namespace CustomDropdownMenuControl
{
    public class CustomDropdownMenu : ContentControl
    {


        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(CustomDropdownMenu), new PropertyMetadata(false));

        static CustomDropdownMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomDropdownMenu), new FrameworkPropertyMetadata(typeof(CustomDropdownMenu)));
        }
    }
}
