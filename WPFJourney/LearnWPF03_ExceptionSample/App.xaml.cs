using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LearnWPF03_ExceptionSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " 
                + e.Exception.Message, 
                "Exception Sample", 
                MessageBoxButton.OK, 
                MessageBoxImage.Warning);

            e.Handled = true;   // 告知 WPF 我们已处理完成此异常且没有其他相关事项需要完成
        }
    }
}
