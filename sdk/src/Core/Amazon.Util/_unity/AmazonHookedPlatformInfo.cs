/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
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
using Logger = Amazon.Runtime.Internal.Util.Logger;

namespace Amazon.Util.Internal
{

    /// <summary>
    /// A Singleton class which hooks onto platform information.
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
        /// <summary>
        /// Platform e.g. "iPhone OS" or "Android"
        /// </summary>
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

        /// <summary>
        /// The device model.
        /// On iOS the device model is value returned by UIDevice.CurrentDevice.Model
        /// On Android the device mode is value returned by android.os.Build.MODEL
        /// </summary>
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

        /// <summary>
        /// The Device Make
        /// On iOS the device make is always "apple"
        /// On Android the device make is value returned by android.os.Build.MANUFACTURER
        /// </summary>
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

        /// <summary>
        /// Path returned by Application.persistentDataPath
        /// </summary>
        public string PersistentDataPath { get; set; }

        /// <summary>
        /// Version returned by Application.unityVersion
        /// </summary>
        public string UnityVersion { get; private set; }

        /// <summary>
        /// Current Locale for the device.
        /// 
        /// On iOS this is the the value returned by NSLocale.AutoUpdatingCurrentLocale
        /// On Android its the value returned by java.utils.Locale.getDefault();
        /// </summary>
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


        /// <summary>
        /// gets an instance of this class
        /// </summary>
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

        /// <summary>
        /// The package name for Anroid or the Bundle Identifier in case of iOS
        /// </summary>
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

        /// <summary>
        /// The version Name string for Android and CFBundleShortVersionString for iOS
        /// </summary>
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


        /// <summary>
        /// The Version Code or numeric representation for Android and CFBundleVersion for iOS 
        /// </summary>
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


        /// <summary>
        /// The title for the application
        /// </summary>
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
        /// Init this instance. This methods needs to be called from the main thread, Otherwise the values may not be initialized correctly
        /// </summary>
        public void Init()
        {

            PersistentDataPath = Application.persistentDataPath;

            UnityVersion = Application.unityVersion;

            if (InternalSDKUtils.IsAndroid)
            {
                //device related information
                PlatformVersion = AndroidInterop.GetStaticJavaField<string>("android.os.Build$VERSION", "RELEASE");
                Platform = ANDROID_OS;
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
