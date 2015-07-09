using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public string Platform
        {
            get
            {
                return string.Empty;
            }
        }

        public string Model
        {
            get
            {
                return string.Empty;
            }
        }

        public string Make
        {
            get
            {
                return string.Empty;
            }
        }

        public string PlatformVersion
        {
            get
            {
                return string.Empty;
            }
        }

        public string Locale
        {
            get
            {
                return string.Empty;
            }
        }
    }
}
