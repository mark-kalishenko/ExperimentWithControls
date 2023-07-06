using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ExperimentWithControls
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


        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = numberTextBox.Text;
        }

        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
