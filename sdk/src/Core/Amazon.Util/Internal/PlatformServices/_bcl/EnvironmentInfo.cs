using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics.CodeAnalysis;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public string Platform
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public string Model
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public string Make
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public string PlatformVersion
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public string Locale
        {
            get
            {
                throw new NotImplementedException(ServiceFactory.NotImplementedErrorMessage);
            }
        }
    }
}
