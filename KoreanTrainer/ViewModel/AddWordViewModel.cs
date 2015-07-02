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
        public VocableKind Kind { get; set; }
    }
}
