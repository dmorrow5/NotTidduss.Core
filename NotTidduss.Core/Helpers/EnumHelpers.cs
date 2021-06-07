using System;
using System.Collections.Generic;
using System.Linq;

namespace NotTidduss.Core.Helpers
{
    public static class EnumHelpers
    {
        public static List<T> EnumValuesToList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }
    }
}
