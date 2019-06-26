using System.Windows;
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
using Magic8Ball_Logic;
using System;

namespace Magic8Ball_WPF
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


        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            Magic8Ball magic = new Magic8Ball();
            magic.Shake();
            String _question = txtQuestion.Text;
            if (_question == "") 
            {
                MessageBox.Show("You must enter a question");
            }
            else { 
            string search = "Searching the mystic realms (RAM) for an answer.";
            MessageBox.Show(search);

            String answer = magic.GetAnswer();
            txtAnswerres.Background = Brushes.CadetBlue;
            txtAnswerres.Text = "The answer to your question '" + _question + "' is '" + answer + "'.";

            }


        }


    }
}
