using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Sample.Defines
{
    /// <summary>
    /// </summary>
    public class LabelAttribute : Attribute
    {
        public string Label { get; protected set; }

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        public LabelAttribute(string value)
        {
            this.Label = value;
        }
    }

    public static class EnumAttribute
    {

        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetLabel(this Enum value)
        {
            Type type = value.GetType();

            FieldInfo fieldInfo = type.GetField(value.ToString());

            if (fieldInfo == null)
            {
                return null;
            }

            LabelAttribute label = fieldInfo.GetCustomAttribute(typeof(LabelAttribute)) as LabelAttribute;
            return label != null ? label.Label : null;
        }
    }
}