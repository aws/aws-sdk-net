/*
 * Copyright 2014-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 *
 * Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located in the "license" file accompanying this file.
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */
using UnityEngine;
using System.Collections;
using System.Threading;
using System.Globalization;
using System.Runtime.InteropServices;
using Amazon.Runtime.Internal.Util;
using System;
using System.Linq;
using ThirdParty.iOS4Unity;


namespace Amazon.Util.Internal
{

    /// <summary>
    /// This class can access hooked platform (iOS, Android etc.) information.
    /// For example, locale, make, application version and title.
    /// </summary>
    public class AmazonHookedPlatformInfo
    {
        private static Logger _logger = Logger.GetLogger(typeof(AmazonHookedPlatformInfo));
        private const string IPHONE_OS = "iPhone OS";
        private const string ANDROID_OS = "Android";

        private static AmazonHookedPlatformInfo instance = null;

        #region device related information
        private string device_platform;
        private string device_model;
        private string device_make;
        private string device_platformVersion;
        private string device_locale;
        #endregion

        #region application related information
        private string app_version_name;
        private string app_version_code;
        private string app_package_name;
        private string app_title;
        #endregion




        /// <summary>
        /// Initializes a new instance of the <see cref="Amazon.Util.Internal.AmazonHookedPlatformInfo"/> class.
        /// Provides a way of spoofing thevalues purely for internal testing purposes.
        /// </summary>
        private AmazonHookedPlatformInfo() { }


        #region device information
        public string Platform
        {
            get
            {
                return device_platform;
            }
            internal set
            {
                //Mobile Analytics Service accepts only values iPhoneOS,Android
                string platform = value;
                if (platform.Equals(RuntimePlatform.IPhonePlayer.ToString(), System.StringComparison.OrdinalIgnoreCase)
                    || platform.Contains("iPhoneOS") || platform.Contains("iPhone"))
                {
                    this.device_platform = IPHONE_OS;
                }
                else if (platform.Equals(RuntimePlatform.Android.ToString(), System.StringComparison.OrdinalIgnoreCase)
                    || platform.Contains("Android") || platform.Contains("android"))
                {
                    this.device_platform = ANDROID_OS;
                }
                else
                {
                    this.device_platform = platform;
                }
            }
        }

        public string Model
        {
            get
            {
                return device_model;
            }
            internal set
            {
                this.device_model = value;
            }
        }

        public string Make
        {
            get
            {
                return device_make;
            }
            internal set
            {
                this.device_make = value;
            }
        }

        /// <summary>
        /// Gets the platform version.
        /// </summary>
        /// <value>The platform version. Returns values like iPhone OS 6.1, API-17 etc.</value>
        public string PlatformVersion
        {
            get
            {
                return this.device_platformVersion;
            }
            internal set
            {
                this.device_platformVersion = value;
            }
        }


        public string PersistentDataPath { get; set; }

        public string Locale
        {
            get
            {
                return device_locale;
            }
            set
            {

                this.device_locale = value;
            }
        }

        public static AmazonHookedPlatformInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AmazonHookedPlatformInfo();
                    instance.Init();
                }
                return instance;
            }
        }

        #endregion

        #region application region
        public string PackageName
        {
            get
            {
                return app_package_name;
            }
            internal set
            {
                this.app_package_name = value;
            }
        }

        public string VersionName
        {
            get
            {
                return app_version_name;
            }
            internal set
            {
                this.app_version_name = value;
            }
        }

        public string VersionCode
        {
            get
            {
                return app_version_code;
            }
            internal set
            {
                this.app_version_code = value;
            }
        }

        public string Title
        {
            get
            {
                return app_title;
            }
            internal set
            {
                this.app_title = value;
            }
        }

        #endregion


        /// <summary>
        /// Init this instance. This methods needs to be called from the main thread, Otherwise the values may not initialize correctly
        /// </summary>
        public void Init()
        {

            PersistentDataPath = Application.persistentDataPath;

            if (InternalSDKUtils.IsAndroid)
            {
                //device related information
                PlatformVersion = AndroidInterop.GetStaticJavaField<string>("android.os.Build$VERSION", "RELEASE");
                Model = AndroidInterop.GetStaticJavaField<string>("android.os.Build", "MODEL");

                Make = AndroidInterop.GetStaticJavaField<string>("android.os.Build", "MANUFACTURER");

                var locale = AndroidInterop.GetJavaObjectStatically("java.util.Locale", "getDefault");
                Locale = AndroidInterop.CallMethod<string>(locale, @"toString");

                //application related information
                var context = AndroidInterop.GetAndroidContext();
                PackageName = AndroidInterop.CallMethod<string>(context, "getPackageName");

                var packageManager = AndroidInterop.CallMethod(context, "getPackageManager");
                var packageInfo = AndroidInterop.CallMethod(packageManager, "getPackageInfo", PackageName, 0);
                var applicationInfo = AndroidInterop.CallMethod(packageManager, "getApplicationInfo", PackageName, 0);
                VersionCode = System.Convert.ToString(AndroidInterop.GetJavaField<int>(packageInfo, "versionCode"));
                VersionName = AndroidInterop.GetJavaField<string>(packageInfo, "versionName");
                Title = AndroidInterop.CallMethod<string>(packageManager, "getApplicationLabel", applicationInfo);
            }
            else if (InternalSDKUtils.IsiOS)
            {
                //platform related information
                if (!string.IsNullOrEmpty(NSLocale.AutoUpdatingCurrentLocale.Identifier))
                {
                    Locale = NSLocale.AutoUpdatingCurrentLocale.Identifier;
                }
                else
                {
                    Locale = NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
                }

                using (var device = UIDevice.CurrentDevice)
                {
                    Platform = device.SystemName;
                    PlatformVersion = device.SystemVersion;
                    Model = device.Model;
                }

                Make = "apple";

                //Application related information
                using (var bundle = NSBundle.MainBundle)
                {
                    var infoPtr = ObjC.MessageSendIntPtr(bundle.Handle, Selector.GetHandle("infoDictionary"));
                    using (var info = ThirdParty.iOS4Unity.Runtime.GetNSObject<NSDictionary>(infoPtr))
                    {
                        Title = info.ObjectForKey("CFBundleDisplayName").ToString();
                        VersionCode = info.ObjectForKey("CFBundleVersion").ToString();
                        VersionName = info.ObjectForKey("CFBundleShortVersionString").ToString();
                        PackageName = info.ObjectForKey("CFBundleIdentifier").ToString();
                    }
                }
            }
        }

    }
}