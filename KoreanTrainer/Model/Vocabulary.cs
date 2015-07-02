using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.Model
{
    [Serializable]
    public class Vocabulary : IEnumerable
    {
        public ObservableCollection<Vocable> Vocables { get; set; }

        public Vocabulary()
        {
            Vocables = new ObservableCollection<Vocable>();
        }

//         public Vocabulary(SerializationInfo info, StreamingContext ctxt)
//         {
//             ForeignLanguage = (Languages)info.GetValue("ForeignLanguage", typeof(Languages));
//             LocalLanguage = (Languages)info.GetValue("LocalLanguage", typeof(Languages));
//             Int32 numWords = (Int32)info.GetValue("NumWords", typeof(Int32));
//             Words = new ObservableCollection<Vocable>();
//             for (int i = 0; i < numWords; i++)
//             {
//                 Words.Add(new Vocable( 
//                     (string)info.GetValue(string.Format("Foreign{0}", i), typeof(string)),
//                     (string)info.GetValue(string.Format("Local{0}", i), typeof(string)),
//                     (WordKind)info.GetValue(string.Format("WordKind{0}", i), typeof(WordKind))
//                 ));
//             }
//         }
// 
//         void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
//         {
//             info.AddValue("ForeignLanguage", ForeignLanguage);
//             info.AddValue("LocalLanguage", LocalLanguage);
//             info.AddValue("NumWords", Words.Count);
//             int currentWordIdx = 0;
//             foreach (Vocable w in Words)
//             {
//                 info.AddValue(string.Format("Foreign{0}", currentWordIdx), w.Foreign);
//                 info.AddValue(string.Format("Local{0}", currentWordIdx), w.Local);
//                 info.AddValue(string.Format("WordKind{0}", currentWordIdx), w.WordKind);
//                 currentWordIdx++;
//             }
//         }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Vocables.GetEnumerator();
        }
    }
}
