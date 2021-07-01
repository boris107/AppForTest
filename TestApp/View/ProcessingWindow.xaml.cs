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

namespace TestApp.View
{
    /// <summary>
    /// Логика взаимодействия для ProcessingWindow.xaml
    /// </summary>
    public partial class ProcessingWindow : Window
    {
        public ProcessingWindow()
        {
            InitializeComponent();
        }        
        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LibraryTest.ViewModel.MainViewModel mainViewModel)
            {
                mainViewModel.GetDataList();                
            }
        }

        private void btnGetFlow_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LibraryTest.ViewModel.MainViewModel mainViewModel)
            {
                mainViewModel.GetFlowData();
            }
        }

        private void btnMediana_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LibraryTest.ViewModel.MainViewModel mainViewModel)
            {
                mainViewModel.GetMedianaFilter();
            }
        }

        private void slValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (DataContext is LibraryTest.ViewModel.MainViewModel mainViewModel)
            {
                mainViewModel.GetMedianaFilter();
            }
        }

        private void btnMSort_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LibraryTest.ViewModel.MainViewModel mainViewModel)
            {
                mainViewModel.SortDataType();
            }
        }
    }
}
