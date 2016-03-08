using System;
using System.Globalization;

namespace ThirdParty.iOS4Unity
{
    public sealed class UIDevice : NSObject
    {
        private static readonly IntPtr _classHandle;
        private static int _majorVersion = -1;
        private static int _minorVersion = -1;

        static UIDevice()
        {
            _classHandle = ObjC.GetClass("UIDevice");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public static string BatteryLevelDidChangeNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIDeviceBatteryLevelDidChangeNotification"); }
        }

        public static string BatteryStateDidChangeNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIDeviceBatteryStateDidChangeNotification"); }
        }

        public static string OrientationDidChangeNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIDeviceOrientationDidChangeNotification"); }
        }

        public static string ProximityStateDidChangeNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIDeviceProximityStateDidChangeNotification"); }
        }

        internal UIDevice(IntPtr handle)
            : base(handle)
        {
        }

        public static UIDevice CurrentDevice
        {
            get { return Runtime.GetNSObject<UIDevice>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("currentDevice"))); }
        }

        public float BatteryLevel
        {
            get { return ObjC.MessageSendFloat(Handle, Selector.GetHandle("batteryLevel")); }
        }

        public bool BatteryMonitoringEnabled
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isBatteryMonitoringEnabled")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setBatteryMonitoringEnabled:"), value); }
        }

        public UIDeviceBatteryState BatteryState
        {
            get { return (UIDeviceBatteryState)ObjC.MessageSendInt(Handle, Selector.GetHandle("batteryState")); }
        }

        public bool CheckSystemVersion(int major, int minor)
        {
            if (_majorVersion == -1)
            {
                string[] array = this.SystemVersion.Split(new char[] {
                    '.'
                });
                if (array.Length < 1 || !int.TryParse(array[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out _majorVersion))
                {
                    _majorVersion = 2;
                }
                if (array.Length < 2 || !int.TryParse(array[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out _minorVersion))
                {
                    _minorVersion = 0;
                }
            }
            return _majorVersion > major || (_majorVersion == major && _minorVersion >= minor);
        }

        public bool GeneratesDeviceOrientationNotifications
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isGeneratingDeviceOrientationNotifications")); }
        }

        public string LocalizedModel
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("localizedModel")); }
        }

        public string Model
        {
            get { return ObjC.FromNSString(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("model"))); }
        }

        public string Name
        {
            get { return ObjC.FromNSString(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("name"))); }
        }

        public UIDeviceOrientation Orientation
        {
            get { return (UIDeviceOrientation)ObjC.MessageSendInt(Handle,Selector.GetHandle( "orientation")); }
        }

        public void PlayInputClick()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("playInputClick"));
        }

        public bool ProximityMonitoringEnabled
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isProximityMonitoringEnabled")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setProximityMonitoringEnabled:"), value); }
        }

        public bool ProximityState
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("proximityState")); }
        }

        public string SystemName
        {
            get { return ObjC.FromNSString(ObjC.MessageSendIntPtr(Handle,Selector.GetHandle( "systemName"))); }
        }

        public string SystemVersion
        {
            get { return ObjC.FromNSString(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("systemVersion"))); }
        }

        public UIUserInterfaceIdiom UserInterfaceIdiom
        {
            get { return (UIUserInterfaceIdiom)ObjC.MessageSendInt(Handle, Selector.GetHandle("userInterfaceIdiom")); }
        }
    }

    public enum UIDeviceBatteryState
    {
        Unknown,
        Unplugged,
        Charging,
        Full
    }

    public enum UIDeviceOrientation
    {
        Unknown,
        Portrait,
        PortraitUpsideDown,
        LandscapeLeft,
        LandscapeRight,
        FaceUp,
        FaceDown
    }

    public enum UIUserInterfaceIdiom
    {
        Unspecified = -1,
        Phone,
        Pad
    }
}