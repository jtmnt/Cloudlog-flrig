using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudlog_flrig
{
    public static class Extensions
    {
        public static string MaxLength(this string value, int maxLength)
        {
            if (value == null) value = string.Empty;
            if (value.Length > maxLength)
            {
                value = value.Substring(0, maxLength);
            }

            return value;
        }
    }
}
