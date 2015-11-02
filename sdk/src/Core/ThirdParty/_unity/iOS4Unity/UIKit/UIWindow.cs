using System;

namespace ThirdParty.iOS4Unity
{
    public sealed class UIWindow : UIView
    {
        private static readonly IntPtr _classHandle;

        static UIWindow()
        {
            _classHandle = ObjC.GetClass("UIWindow");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public UIWindow()
        {
        }

        public UIWindow(CGRect frame)
            : base(frame)
        {
        }

        internal UIWindow(IntPtr handle)
            : base(handle)
        {
        }

        public bool IsKeyWindow
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isKeyWindow")); }
        }

        public void BecomeKeyWindow()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("becomeKeyWindow"));
        }

        public void MakeKeyAndVisible()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("makeKeyAndVisible"));
        }

        public void MakeKeyWindow()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("makeKeyWindow"));
        }

        public void ResignKeyWindow()
        {
            ObjC.MessageSend(Handle,Selector.GetHandle( "resignKeyWindow"));
        }

        public UIScreen Screen
        {
            get { return Runtime.GetNSObject<UIScreen>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("screen"))); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setScreen:"), value.Handle); }
        }

        public float WindowLevel
        {
            get { return ObjC.MessageSendFloat(Handle,Selector.GetHandle( "windowLevel")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setWindowLevel:"), value); }
        }

        public UIViewController RootViewController
        {
            get { return Runtime.GetNSObject<UIViewController>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("rootViewController"))); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setRootViewController:"), value.Handle); }
        }
    }

    public static class UIWindowLevel
    {
        public static float Alert
        {
            get { return ObjC.GetFloatConstant(ObjC.Libraries.UIKit, "UIWindowLevelAlert"); }
        }

        public static float Normal
        {
            get { return ObjC.GetFloatConstant(ObjC.Libraries.UIKit, "UIWindowLevelNormal"); }
        }

        public static float StatusBar
        {
            get { return ObjC.GetFloatConstant(ObjC.Libraries.UIKit, "UIWindowLevelStatusBar"); }
        }
    }
}