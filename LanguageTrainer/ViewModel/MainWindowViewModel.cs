using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageTrainer.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LanguageTrainer.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Vocabulary _currentVocabulary;
        public Vocabulary CurrentVocabulary
        {
            get
            {
                return _currentVocabulary;
            }
            set
            {
                _currentVocabulary = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
//             CurrentVocabulary = new Vocabulary();
//             CurrentVocabulary.Words.Add(new LanguageWord("먹다", "to eat"));
//             CurrentVocabulary.Words.Add(new LanguageWord("살다", "to live, reside"));
//             CurrentVocabulary.Words.Add(new LanguageWord("싸다", "cheap"));
//             CurrentVocabulary.Words.Add(new LanguageWord("가족", "family"));
//             CurrentVocabulary.Words.Add(new LanguageWord("사랑하다", "to love"));
//             CurrentVocabulary.Words.Add(new LanguageWord("이름", "name"));
        }

        public void SaveVocabulary()
        {
            Stream stream = File.Open("Vocabulary.voc", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, CurrentVocabulary);
            stream.Close();
        }

        public void LoadVocabulary()
        {
            Stream stream = File.Open("Vocabulary.voc", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            CurrentVocabulary = (Vocabulary)bf.Deserialize(stream);
            stream.Close();
        }
    }
}
