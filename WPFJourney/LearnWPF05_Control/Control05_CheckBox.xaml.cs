﻿using System;
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
    /// Control05_CheckBox.xaml 的交互逻辑
    /// </summary>
    public partial class Control05_CheckBox : Window
    {
        public Control05_CheckBox()
        {
            InitializeComponent();
        }

        private void cbAllFeatures_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures.IsChecked == true);
            cbFeatureAbc.IsChecked = newVal;
            cbFeatureXyz.IsChecked = newVal;
            cbFeatureWww.IsChecked = newVal;
        }

        private void cbFeature_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures.IsChecked = null;
            if ((cbFeatureAbc.IsChecked == true) 
                && (cbFeatureXyz.IsChecked == true) 
                && (cbFeatureWww.IsChecked == true))
                cbAllFeatures.IsChecked = true;

            if ((cbFeatureAbc.IsChecked == false) 
                && (cbFeatureXyz.IsChecked == false) 
                && (cbFeatureWww.IsChecked == false))
                cbAllFeatures.IsChecked = false;
        }
    }
}
