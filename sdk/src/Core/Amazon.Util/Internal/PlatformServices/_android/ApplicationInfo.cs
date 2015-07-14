using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo:IApplicationInfo
    {
        public string AppTitle
        {
            get
            {
                return Application.Context.ApplicationInfo.LoadLabel(Application.Context.PackageManager).ToString();
            }
        }

        public string AppVersionName
        {
            get
            {
                return Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0).VersionName;

            }
        }

        public string AppVersionCode
        {
            get
            {
                return Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0).VersionCode.ToString();
            }
        }

        public string PackageName
        {
            get
            {
                return Application.Context.PackageName;
            }
        }


        public string SpecialFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            }
        }

    }
}
