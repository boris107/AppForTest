using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //public const string path = "Text.txt";        

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();               
                openFile.FileName = Directory.GetCurrentDirectory() + @"\" + LibraryTest.ViewModel.MainViewModel.path ;
                openFile.OpenFile();
                System.Diagnostics.Process.Start("notepad.exe", openFile.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(LibraryTest.ViewModel.MainViewModel.path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("1 5 6 \n2 8 6 5 \n3 6 7 8 7 8 9 123 \n1 5 5 \n1 6 5 \n2 7 7 7 \n3 6 7 8 7 5 5 \n4 6 7 8 7 5 5 ");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    if (fs.Length > 0)
                    {
                        MessageBox.Show("Файл успешно создан.");
                        fs.Close();
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            //LibraryTest.ViewModel.DataFromFile file = new LibraryTest.ViewModel.DataFromFile();
            //var test = file.GetDataFromFile(LibraryTest.ViewModel.MainViewModel.path);

            LibraryTest.Model.ProcessingData processing = new LibraryTest.Model.ProcessingData();
            int[] r = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            processing.MedianaFilter(r, 9);
        }

        private void btnProcessing_Click(object sender, RoutedEventArgs e)
        {
            //LibraryTest.ViewModel.MainViewModel processingWindow = new LibraryTest.ViewModel.MainViewModel();
            View.ProcessingWindow processingWindow = new View.ProcessingWindow();
            processingWindow.DataContext = new LibraryTest.ViewModel.MainViewModel();
            processingWindow.Show();
        }
    }
}
