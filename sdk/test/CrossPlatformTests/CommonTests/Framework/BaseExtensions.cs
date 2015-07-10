using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.Framework
{
    public static class EncodingExtensions
    {
        public static string GetString(this Encoding self, byte[] bytes)
        {
            return self.GetString(bytes, 0, bytes.Length);
        }
    }
}
