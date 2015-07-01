﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.Model
{

    [Serializable]
    public enum Languages
    {
        German,
        English,
        Korean
    }

    [Serializable]
    public enum VocableKind
    {
        None,
        Noun,
        Verb,
        Adjective,
        Adverb
    }

    [Serializable]
    public class Vocable
    {
        public string Foreign { get; set; }
        public string Local { get; set; }
        public VocableKind Kind { get; set; }

        public Vocable(string Foreign, string Local)
        {
            this.Foreign = Foreign;
            this.Local = Local;
        }

        public Vocable(string Foreign, string Local, VocableKind Kind) : this(Foreign, Local)
        {
            this.Kind = Kind;
        }

        public override string ToString()
        {
            string strRet = string.Format("{0} : {1}", Foreign, Local);
            if (Kind != VocableKind.None)
            {
                strRet += " (" + Kind + ")";
            }
            return strRet;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}