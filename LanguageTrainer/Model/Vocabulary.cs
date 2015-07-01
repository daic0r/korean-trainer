using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTrainer.Model
{
    [Serializable]
    public class Vocabulary : ISerializable, IEnumerable
    {
        public ObservableCollection<LanguageWord> Words { get; set; }
        public Languages ForeignLanguage { get; set; }
        public Languages LocalLanguage { get; set; }

        public Vocabulary()
        {
            ForeignLanguage = Languages.KOREAN;
            LocalLanguage = Languages.ENGLISH;
            Words = new ObservableCollection<LanguageWord>();
        }

        public Vocabulary(SerializationInfo info, StreamingContext ctxt)
        {
            ForeignLanguage = (Languages)info.GetValue("ForeignLanguage", typeof(Languages));
            LocalLanguage = (Languages)info.GetValue("LocalLanguage", typeof(Languages));
            Int32 numWords = (Int32)info.GetValue("NumWords", typeof(Int32));
            Words = new ObservableCollection<LanguageWord>();
            for (int i = 0; i < numWords; i++)
            {
                Words.Add(new LanguageWord( 
                    (string)info.GetValue(string.Format("Foreign{0}", i), typeof(string)),
                    (string)info.GetValue(string.Format("Local{0}", i), typeof(string))
                ));
            }
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ForeignLanguage", ForeignLanguage);
            info.AddValue("LocalLanguage", LocalLanguage);
            info.AddValue("NumWords", Words.Count);
            int currentWordIdx = 0;
            foreach (LanguageWord w in Words)
            {
                info.AddValue(string.Format("Foreign{0}", currentWordIdx), w.Foreign);
                info.AddValue(string.Format("Local{0}", currentWordIdx), w.Local);
                currentWordIdx++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Words.GetEnumerator();
        }
    }
}
