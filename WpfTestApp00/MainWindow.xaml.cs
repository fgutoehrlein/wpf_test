using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfTestApp00
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ProcessFormCommit_0(object sender, RoutedEventArgs rea)
        {
            var checkBoxResult = Checkbox_0.IsChecked;
            var formString = FormString_0.Text;
        }
        public void ProcessRescalePicture(object sender, RoutedEventArgs rea)
        {
            if(Picture_test.Height == 200)
            {
                Picture_test.Height = 100;
                Picture_test.Width = 100;
            }
            else
            {
                Picture_test.Height = 200;
                Picture_test.Width = 200;
            }
        }


        private void BrowseButton_Click(object sender, RoutedEventArgs rea)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog().Value)
            {
                string selectedFileName = dlg.FileName;
                FileNameLabel.Content = selectedFileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                Picture_test.Source = bitmap;
            }
        }

    }
}
