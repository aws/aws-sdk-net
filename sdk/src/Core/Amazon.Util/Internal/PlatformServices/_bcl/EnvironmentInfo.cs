using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo
    {
        public static string Platform
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public static string Model
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public static string Make
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public static string PlatformVersion
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public static string Locale
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }
    }
}
