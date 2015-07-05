using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoreanTrainer.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using KoreanTrainer.Other;

namespace KoreanTrainer.ViewModel
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
             CurrentVocabulary = new Vocabulary();
//             CurrentVocabulary.Vocables.Add(new Vocable("먹다", "to eat"));
//             CurrentVocabulary.Vocables.Add(new Vocable("살다", "to live, reside"));
//             CurrentVocabulary.Vocables.Add(new Vocable("싸다", "cheap"));
//             CurrentVocabulary.Vocables.Add(new Vocable("가족", "family"));
//             CurrentVocabulary.Vocables.Add(new Vocable("사랑하다", "to love"));
//             CurrentVocabulary.Vocables.Add(new Vocable("이름", "name"));
        }

        public void SaveVocabulary()
        {
//             Stream stream = File.Open("Vocabulary.voc", FileMode.Create);
//             BinaryFormatter bf = new BinaryFormatter();
//             bf.Serialize(stream, CurrentVocabulary);
//             stream.Close();
            using (var stream = new FileStream("Vocabulary.voc", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, CurrentVocabulary);
            }
        }

        public void LoadVocabulary()
        {
//             Stream stream = File.Open("Vocabulary.voc", FileMode.Open);
//             BinaryFormatter bf = new BinaryFormatter();
//             CurrentVocabulary = (Vocabulary)bf.Deserialize(stream);
//             stream.Close();
            using (var stream = new FileStream("Vocabulary.voc", FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                CurrentVocabulary = (Vocabulary) bf.Deserialize(stream);
            }
        }

        public void AddWord()
        {
            if (Globals.DataProviderService != null)
            {
                Vocable v = Globals.DataProviderService.RetrieveNewVocable();
                if (v != null)
                {
                    CurrentVocabulary.Vocables.Add(v);
                }
            }
        }
    }
}
