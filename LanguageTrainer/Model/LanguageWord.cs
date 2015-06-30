using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTrainer.Model
{
    public enum Languages
    {
        GERMAN,
        ENGLISH,
        KOREAN
    }

    public class LanguageWord
    {
        public string Foreign { get; set; }
        public string Local { get; set; }

        public LanguageWord(string Foreign, string Local)
        {
            this.Foreign = Foreign;
            this.Local = Local;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Foreign, Local);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
