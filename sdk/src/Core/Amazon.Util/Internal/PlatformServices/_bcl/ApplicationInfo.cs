using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo
    {
        public static string AppTitle
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public static string AppVersionName
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public static string AppVersionCode
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public static string PackageName
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }


    }
}