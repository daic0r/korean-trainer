using KoreanTrainer.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace KoreanTrainer.Other
{
    public struct EnumListEntry
    {
        public Type EnumType { get; set; }
        public object Value { get; set; }
        public string Description { get; set; }
    }
    
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
                    Selector control = sender as Selector;
                    if (control != null)
                    {
                        if (args.NewValue != null)
                        {
                            Type enumType = (Type)args.NewValue;
                            //control.ItemsSource = Enum.GetValues((Type)args.NewValue);
                            Array vals = Enum.GetValues(enumType);
                            List<EnumListEntry> l = new List<EnumListEntry>();
                            foreach (object val in vals)
                            {
                                FieldInfo info = enumType.GetField(val.ToString());
                                EnumReadableNameAttribute attrib = info.GetCustomAttribute<EnumReadableNameAttribute>();
                                
                                string displayName;
                                if (attrib != null)
                                    displayName = attrib.ReadableName;
                                else
                                    displayName = val.ToString();

                                l.Add(new EnumListEntry()
                                    {
                                        Value = val,
                                        Description = displayName
                                    });
                            }
                            control.ItemsSource = l;
                            control.SelectedValuePath = "Value";
                            control.DisplayMemberPath = "Description";
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
    }
}
