using System;

namespace ThirdParty.iOS4Unity
{
    public class UIActivityViewController : UIViewController
    {
        private static readonly IntPtr _classHandle;

        static UIActivityViewController()
        {
            _classHandle = ObjC.GetClass("UIActivityViewController");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public UIActivityViewController(string text)
        {
            IntPtr textHandle = ObjC.ToNSString(text);
            IntPtr array = ObjC.ToNSArray(new[] { textHandle });
            ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("initWithActivityItems:applicationActivities:"), array, IntPtr.Zero);
            ObjC.MessageSend(textHandle,Selector.ReleaseHandle);
        }

        public UIActivityViewController(UIImage image)
        {
            IntPtr array = ObjC.ToNSArray(new[] { image.Handle });
            ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("initWithActivityItems:applicationActivities:"), array, IntPtr.Zero);
        }

        public UIActivityViewController(string text, UIImage image)
        {
            IntPtr textHandle = ObjC.ToNSString(text);
            IntPtr array = ObjC.ToNSArray(new[] { textHandle, image.Handle });
            ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("initWithActivityItems:applicationActivities:"), array, IntPtr.Zero);
            ObjC.MessageSend(textHandle, Selector.ReleaseHandle);
        }

        internal UIActivityViewController(IntPtr handle)
            : base(handle)
        {
        }
    }
}