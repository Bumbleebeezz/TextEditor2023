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
using Path = System.IO.Path;

namespace TextEditor2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Create filePath as field
        string _filePath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();

            // Create folder
            var directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TextEditorPath2023");
            Directory.CreateDirectory(directoryPath);

            // Edit file, will overwrite existing 
            _filePath = Path.Combine(directoryPath, "test.txt");
        }

        private void SaveFileBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Save input text 
            var mainMenuText = MainTextBox.Text;

            // Save to file
            // using, no need to close StreamWriter 
            using var sw = new StreamWriter(_filePath);
            sw.Write(mainMenuText);
        }

        private void OpenFileBtn_OnClick(object sender, RoutedEventArgs e)
        {
            // Read file 
            using var sr = new StreamReader(_filePath);
            // Read the entire file at once
            var text = sr.ReadToEnd();

            // Display text in MainTextBox
            // text = property {get; set;}
            MainTextBox.Text = text;

        }
    }
}
