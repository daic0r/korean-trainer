using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.Attributes
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    sealed class EnumReadableNameAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        public string ReadableName { get; set; }

        // This is a positional argument
        public EnumReadableNameAttribute(string ReadableName)
        {
            this.ReadableName = ReadableName;
        }
    }
}
