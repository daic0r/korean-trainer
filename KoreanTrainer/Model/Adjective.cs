using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.Model
{
    [Serializable]
    public class Adjective : AdjectiveVerb
    {
        public Adjective(string Foreign, string Local) : base(Foreign, Local) { }
        public Adjective(string Foreign, string Local, VocableKind Kind) : base(Foreign, Local, Kind) { }
    }
}
