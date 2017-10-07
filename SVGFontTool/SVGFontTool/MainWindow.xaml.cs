using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml;
using System.Xml.Linq;
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
            fontDialog.Filter = "SVG File (*.svg) | *.svg";
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
            if(!string.IsNullOrEmpty(txtFont.Text)&& !string.IsNullOrEmpty(txtDestination.Text) && !string.IsNullOrEmpty(txtEnum.Text))
            {
               
                if (File.Exists(txtFont.Text) && Directory.Exists(txtDestination.Text))
                {
                    List<string> GlyphNames = new List<string>();
                    List<string> PathDatas = new List<string>();
                    XmlTextReader reader = new XmlTextReader(txtFont.Text);
                    XmlNodeType type;
                    while(reader.Read())
                    {
                        type = reader.NodeType;
                        if (reader.Name == "glyph")
                        {
                            GlyphNames.Add(reader.GetAttribute("glyph-name"));
                            PathDatas.Add(reader.GetAttribute("d"));
                        }
                    }
                }
            }
        }
    }
}
