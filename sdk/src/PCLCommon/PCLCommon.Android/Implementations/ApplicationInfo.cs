using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Common
{
    public class ApplicationInfo
    {
        public static string AppTitle
        {
            get
            {
                return Application.Context.ApplicationInfo.LoadLabel(Application.Context.PackageManager).ToString();
            }
        }

        public static string AppVersionName
        {
            get
            {
                return Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0).VersionName;

            }
        }

        public static string AppVersionCode
        {
            get
            {
                return Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0).VersionCode.ToString();
            }
        }

        public static string PackageName
        {
            get
            {
                return Application.Context.PackageName;
            }
        }

    }
}
