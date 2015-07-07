using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.Model
{
    public static class VocableFactory
    {
        public static Vocable CreateVocable(string Foreign, string Local, VocableKind Kind)
        {
            switch (Kind)
            {
                case VocableKind.Verb:
                    return new Verb(Foreign, Local, Kind);
                case VocableKind.Adjective:
                    return new Adjective(Foreign, Local, Kind);
                default:
                    return new Vocable(Foreign, Local, Kind);
            }
        }
    }
}
