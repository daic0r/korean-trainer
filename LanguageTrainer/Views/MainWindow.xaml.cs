using LanguageTrainer.Model;
using LanguageTrainer.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace LanguageTrainer.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private MainWindowViewModel _myViewModel;
        public MainWindowViewModel MyViewModel
        { 
            get
            {
                return _myViewModel;
            }
            set
            {
                _myViewModel = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            MyViewModel = new MainWindowViewModel(); 
            InitializeComponent();
        }

        private void CommandBinding_Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void CommandBinding_Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyViewModel.SaveVocabulary();
        }

        private void CommandBinding_Load_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyViewModel.LoadVocabulary();
        }

        private void CommandBinding_AddWord_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Views.AddWordDialog diag = new AddWordDialog();
            diag.ShowDialog();
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
