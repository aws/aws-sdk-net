using System;
using System.Collections.Generic;
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
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public string Model
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public string Make
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public string PlatformVersion
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        public string Locale
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }
    }
}
