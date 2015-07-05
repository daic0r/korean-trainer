using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoreanTrainer.Interfaces;
using System.Windows;

namespace KoreanTrainer.Other
{
    public static class Globals
    {
        public static Window MainWindow { get; set; }
        public static DialogStyle DialogStyleInUse { get; set; }
        public static IDataProviderService DataProviderService { get; set; }

        static Globals()
        {
            MainWindow = null;
            DialogStyleInUse = DialogStyle.Standard;
            DataProviderService = null;
        }

        public static void Initialize(Window mainWindow)
        {
            MainWindow = mainWindow;
            DataProviderService = new DialogDataProvider(MainWindow, DialogStyleInUse);
        }
    }
}
