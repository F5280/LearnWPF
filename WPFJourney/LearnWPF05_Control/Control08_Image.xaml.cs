using Microsoft.Win32;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LearnWPF05_Control
{
    /// <summary>
    /// Control08_Image.xaml 的交互逻辑
    /// </summary>
    public partial class Control08_Image : Window
    {
        public Control08_Image()
        {
            InitializeComponent();
        }

        //private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    if (openFileDialog.ShowDialog() == true)
        //    {
        //        Uri fileUri = new Uri(openFileDialog.FileName);
        //        imgDynamic.Source = new BitmapImage(fileUri);
        //    }
        //}

        //private void BtnLoadFromResource_Click(object sender, RoutedEventArgs e)
        //{
        //    Uri resourceUri = new Uri("./Images/LuKaMoDeLiQi.jpg", UriKind.Relative);
        //    imgDynamic.Source = new BitmapImage(resourceUri);
        //}
    }
}
