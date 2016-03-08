using System;

namespace ThirdParty.iOS4Unity
{
    public class UIView : NSObject
    {
        private static readonly IntPtr _classHandle;

        static UIView()
        {
            _classHandle = ObjC.GetClass("UIView");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public UIView()
        {
            ObjC.MessageSendIntPtr(Handle, Selector.Init);
        }

        public UIView(CGRect frame)
        {
            Handle = ObjC.MessageSendIntPtr(Handle, Selector.InitWithFrame, frame);
        }

        internal UIView(IntPtr handle)
            : base(handle)
        {
        }

        public CGRect Frame
        {
            get { return ObjC.MessageSendCGRect(Handle, Selector.GetHandle("frame")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setFrame:"), value); }
        }

        public CGRect Bounds
        {
            get { return ObjC.MessageSendCGRect(Handle, Selector.GetHandle("bounds")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setBounds:"), value); }
        }

        public CGPoint Center
        {
            get { return ObjC.MessageSendCGPoint(Handle, "center"); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setCenter:"), value); }
        }

        public void AddSubview(UIView view)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("addSubview:"), view.Handle);
        }

        public UIView[] Subviews
        {
            get { return ObjC.FromNSArray<UIView>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("subviews"))); }
        }

        public UIView Superview
        {
            get { return Runtime.GetNSObject<UIView>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("superview"))); }
        }

        public void BringSubviewToFront(UIView view)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("bringSubviewToFront:"), view.Handle);
        }

        public void SendSubviewToBack(UIView view)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("sendSubviewToBack:"), view.Handle);
        }

        public bool Hidden
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isHidden")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setHidden:"), value); }
        }

        public float Alpha
        {
            get { return ObjC.MessageSendFloat(Handle, Selector.GetHandle("alpha")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setAlpha:"), value); }
        }

        public UIWindow Window
        {
            get { return Runtime.GetNSObject<UIWindow>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("window"))); }
        }

        public void RemoveFromSuperview()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("removeFromSuperview"));
        }
    }
}