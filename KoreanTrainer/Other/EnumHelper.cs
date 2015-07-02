using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KoreanTrainer.Other
{
    public static class EnumHelper
    {
        public static readonly DependencyProperty EnumProperty = DependencyProperty.RegisterAttached("Enum",
            typeof(Type),
            typeof(EnumHelper),
            new FrameworkPropertyMetadata(
                null,
                (sender, args) =>
                {
                    ItemsControl control = sender as ItemsControl;
                    if (control != null)
                    {
                        if (args.NewValue != null)
                        {
                            control.ItemsSource = Enum.GetValues((Type)args.NewValue);
                        }
                    }
                }));

        public static void SetEnum(ItemsControl control, Type t)
        {
            if (control != null)
            {
                control.SetValue(EnumProperty, t);
            }
        }

        public static Type GetEnum(ItemsControl control)
        {
            if (control != null)
            {
                return (Type)control.GetValue(EnumProperty);
            }
            return null;
        }
    }
}
