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
using System.Windows.Navigation;
using System.Windows.Shapes;

using FolderBrowserDialog = System.Windows.Forms.FolderBrowserDialog;

namespace SVGFontTool
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Browse_Font(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fontDialog = new OpenFileDialog();
            if (fontDialog.ShowDialog() == true)
                txtFont.Text = fontDialog.InitialDirectory + fontDialog.FileName;
        }

        private void Browse_Destination(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog destinationDialog = new FolderBrowserDialog();
            if (destinationDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtDestination.Text = destinationDialog.SelectedPath;
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            if(txtFont.Text != null && txtDestination.Text != null && txtEnum.Text != null)
            {
                //Perform Reading and Writing logic
            }
        }
    }
}
