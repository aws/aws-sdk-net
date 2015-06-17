using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo
    {
        public string Platform
        {
            get
            {
                return "";
            }
        }

        public string Model
        {
            get
            {
                return "";
            }
        }

        public string Make
        {
            get
            {
                return "";
            }
        }

        public string PlatformVersion
        {
            get
            {
                return "";
            }
        }

        public string Locale
        {
            get
            {
                return CultureInfo.CurrentCulture.DisplayName;
            }
        }
    }
}
