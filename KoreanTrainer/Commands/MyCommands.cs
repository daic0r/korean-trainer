using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KoreanTrainer.Commands
{
    public static class MyCommands
    {
        public static readonly RoutedUICommand AddWord;

        static MyCommands()
        {
            AddWord = new RoutedUICommand("Add word...", "AddWord", typeof(MyCommands));
        }
    }
}
