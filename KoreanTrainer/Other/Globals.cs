using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoreanTrainer.Interfaces;

namespace KoreanTrainer.Other
{
    public static class Globals
    {
        public static IDataProviderService DataProviderService { get; set; }

        static Globals()
        {
            DataProviderService = null;
        }
    }
}
