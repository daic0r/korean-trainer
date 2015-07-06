using KoreanTrainer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.ViewModel
{
    public class AddWordViewModel : BaseViewModel
    {
        public string ForeignWord { get; set; }
        public string LocalWord { get; set; }

        private VocableKind _kind;
        public VocableKind Kind
        {
            get
            {
                return _kind;
            }
            set
            {
                _kind = value;
                OnPropertyChanged();
            }
        }
        public string Conjugation { get; set; }
    }
}
