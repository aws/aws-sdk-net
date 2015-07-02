using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Windows.ApplicationModel;
using Windows.Storage;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo : IApplicationInfo
    {
        public string AppTitle
        {
            get
            {
                Package package = Package.Current;
                PackageId packageId = package.Id;
                return packageId.FullName;
            }
        }

        public string AppVersionName
        {
            get
            {
                Package package = Package.Current;
                PackageId packageId = package.Id;
                PackageVersion version = packageId.Version;

                return string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            }
        }

        public string AppVersionCode
        {
            get
            {
                Package package = Package.Current;
                PackageId packageId = package.Id;
                PackageVersion version = packageId.Version;

                return string.Format("{0}",version.Build);
            }
        }

        public string PackageName
        {
            get
            {
                Package package = Package.Current;
                PackageId packageId = package.Id;
                return packageId.Name;
            }
        }
    }
}