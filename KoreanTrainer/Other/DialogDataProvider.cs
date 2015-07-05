using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoreanTrainer.Interfaces;
using KoreanTrainer.Model;
using KoreanTrainer.Views;
using System.Windows;

namespace KoreanTrainer.Other
{
    public enum DialogStyle
    {
        Standard
    };

    public class DialogDataProvider : IDataProviderService
    {
        public DialogStyle DialogStyleInUse { get; set; }
        public Window MainWindow { get; private set; }

        public DialogDataProvider(Window mainWindow, DialogStyle style = DialogStyle.Standard)
        {
            DialogStyleInUse = style;
            MainWindow = mainWindow;
        }

        // Will be called through a IDataProviderService reference anyway,
        // so no need to expose it through this type
        Vocable IDataProviderService.RetrieveNewVocable()
        {
            switch (DialogStyleInUse)
            {
                case DialogStyle.Standard:
                    AddWordDialog dialog = new AddWordDialog();
                    dialog.Owner = MainWindow;
                    dialog.ShowDialog();
                    if (dialog.DialogResult ?? false)
                    {
                        string result;
                        result = string.Format("Foreign word: {0}\nLocal word: {1}\nKind: {2}", dialog.MyViewModel.ForeignWord, dialog.MyViewModel.LocalWord, dialog.MyViewModel.Kind);
                        MessageBox.Show(result);
                        //dialog.CurrentVocabulary.Vocables.Add();
                        return new Vocable(dialog.MyViewModel.ForeignWord, dialog.MyViewModel.LocalWord, dialog.MyViewModel.Kind);
                    }
                    break;
            }
            return null;
        }
    }
}
