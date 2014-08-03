using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTracker.Extensions
{
    public static class ValueObjectRules
    {
        public static void AssertValueNotZero(this Int32 val, string  message)
        {
            if (val == 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
