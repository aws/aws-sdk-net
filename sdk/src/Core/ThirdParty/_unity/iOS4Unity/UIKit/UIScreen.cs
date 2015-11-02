using System;

namespace ThirdParty.iOS4Unity
{
    public class UIScreen : NSObject
    {
        private static readonly IntPtr _classHandle;

        static UIScreen()
        {
            _classHandle = ObjC.GetClass("UIScreen");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal UIScreen(IntPtr handle)
            : base(handle)
        {
        }

        public CGRect ApplicationFrame
        {
            get { return ObjC.MessageSendCGRect(Handle, Selector.GetHandle("applicationFrame")); }
        }

        public UIScreenMode[] AvailableModes
        {
            get { return ObjC.FromNSArray<UIScreenMode>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("availableModes"))); }
        }

        public CGRect Bounds
        {
            get { return ObjC.MessageSendCGRect(Handle, Selector.GetHandle("bounds")); }
        }

        public float Brightness
        {
            get { return ObjC.MessageSendFloat(Handle, Selector.GetHandle("brightness")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setBrightness"), value); }
        }

        public static string BrightnessDidChangeNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIScreenBrightnessDidChangeNotification"); }
        }

        public UIScreenMode CurrentMode
        {
            get { return Runtime.GetNSObject<UIScreenMode>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("currentMode"))); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setCurrentMode"), value.Handle); }
        }

        public static string DidConnectNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIScreenDidConnectNotification"); }
        }

        public static string DidDisconnectNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIScreenDidDisconnectNotification"); }
        }

        public static UIScreen MainScreen
        {
            get { return Runtime.GetNSObject<UIScreen>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("mainScreen"))); }
        }

        public UIScreen MirroredScreen
        {
            get { return Runtime.GetNSObject<UIScreen>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("mirroredScreen"))); }
        }

        public static string ModeDidChangeNotification
        {
            get { return ObjC.GetStringConstant(ObjC.Libraries.UIKit, "UIScreenModeDidChangeNotification"); }
        }

        /// <summary>
        /// iOS 8 only
        /// </summary>
        public CGRect NativeBounds
        {
            get { return ObjC.MessageSendCGRect(Handle, Selector.GetHandle("nativeBounds")); }
        }

        /// <summary>
        /// iOS 8 only
        /// </summary>
        public float NativeScale
        {
            get { return ObjC.MessageSendFloat(Handle, Selector.GetHandle("nativeScale")); }
        }

        public UIScreenMode PreferredMode
        {
            get { return Runtime.GetNSObject<UIScreenMode>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("preferredMode"))); }
        }

        public float Scale
        {
            get { return ObjC.MessageSendFloat(Handle, Selector.GetHandle("scale")); }
        }

        public static UIScreen[] Screens
        {
            get { return ObjC.FromNSArray<UIScreen>(ObjC.MessageSendIntPtr(_classHandle,Selector.GetHandle( "screens"))); }
        }

        public bool WantsSoftwareDimming
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("wantsSoftwareDimming")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setWantsSoftwareDimming"), value); }
        }
    }
}