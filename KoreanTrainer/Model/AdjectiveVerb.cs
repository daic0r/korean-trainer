using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.Model
{
    public class AdjectiveVerb : Vocable
    {
        public Conjugation Conjugation { get; set; }

        public AdjectiveVerb(string Foreign, string Local) : base(Foreign, Local) { }
        public AdjectiveVerb(string Foreign, string Local, VocableKind Kind) : base(Foreign, Local, Kind) { }
    }
}
