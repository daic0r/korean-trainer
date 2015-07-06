using KoreanTrainer.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KoreanTrainer.Other
{
    public static class EnumHelper
    {
        //
        // Enum Property
        //
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
        //////////////////////////////////////////////////////////////

        //
        // ExtendedInfo
        //
        public static readonly DependencyProperty ExtendedInfo = DependencyProperty.RegisterAttached("ExtendedInfo",
            typeof(bool),
            typeof(EnumHelper),
            new FrameworkPropertyMetadata(
                false,
                (sender, args) =>
                {
                    if (sender != null && (bool)(args.NewValue) == true)
                    {
                        // Contains the currently selected enum value
                        var enumObject = (sender as FrameworkElement).DataContext;
                        Type enumType = enumObject.GetType();
                        FieldInfo info = enumType.GetField(enumObject.ToString());
                        EnumReadableNameAttribute attrib = info.GetCustomAttribute<EnumReadableNameAttribute>(false);
                        if (attrib != null)
                        {
                            if (sender is TextBlock)
                            {
                                (sender as TextBlock).Text = attrib.ReadableName;
                            }
                        }
                    }
                }
                ));
        public static void SetExtendedInfo(DependencyObject sender, bool active)
        {
            if (sender != null)
            {
                sender.SetValue(ExtendedInfo, active);
            }
        }

        public static bool GetExtendedInfo(DependencyObject sender)
        {
            if (sender != null)
            {
                return (bool) sender.GetValue(ExtendedInfo);
            }
            return false;
        }

        
    }
}
