using System;
using System.ComponentModel;

namespace NotTidduss.Core.Extensions
{
    public static class EnumExtensions
    {
        // Source: https://stackoverflow.com/questions/630803/associating-enums-with-strings-in-c-sharp
        // Note: Could have performance issues
        public static string ToDescriptionString<T>(this T val) where T : Enum
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
