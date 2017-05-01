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
using Wordcounter._2_Services;

namespace Wordcounter
{
    public partial class MainWindow : Window
    {

        private static CounterService counterService;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtText_TextChanged(object sender, TextChangedEventArgs e)
        {
            counterService = new CounterService();
            counterService.Text = txtText.Text;
            counterService.Lines = txtText.LineCount;

            lblCharacters.Content = counterService.countCharacters();
            lblWords.Content = counterService.countWords();
            lblLines.Content = counterService.countLines();
        }

        private void muRefresh_Click(object sender, RoutedEventArgs e)
        {
            counterService = new CounterService();

            txtText.Clear();
            lblCharacters.Content = "";
            lblWords.Content = "";
            lblLines.Content = "";
        }
    }
}
