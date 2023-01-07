using System;
using System.Windows;

namespace LearnWPF03_ExceptionSample
{
    /// <summary>
    /// Example1.xaml 的交互逻辑
    /// </summary>
    public partial class Example1 : Window
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            try
            {
                s.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: "
                    + ex.Message, "Exception Sample",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            s.Trim();
        }
    }
}
