using KoreanTrainer.ViewModel;
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

namespace KoreanTrainer.Views
{
    /// <summary>
    /// Interaction logic for AddWordDialog.xaml
    /// </summary>
    public partial class AddWordDialog : Window
    {
        public AddWordViewModel MyViewModel { get; private set; }

        public AddWordDialog()
        {
            MyViewModel = new AddWordViewModel();
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
