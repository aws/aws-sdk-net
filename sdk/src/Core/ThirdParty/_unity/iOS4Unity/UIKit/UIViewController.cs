using System;

namespace ThirdParty.iOS4Unity
{
    public class UIViewController : NSObject
    {
        private static readonly IntPtr _classHandle;

        static UIViewController()
        {
            _classHandle = ObjC.GetClass("UIViewController");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public UIViewController()
        {
        }

        internal UIViewController(IntPtr handle)
            : base(handle)
        {
        }

        public string Title
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("title")); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setTitle:"), value); }
        }

        public UIView View
        {
            get { return Runtime.GetNSObject<UIView>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("view"))); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setView:"), value.Handle); }
        }

        public bool IsViewLoaded
        {
            get { return ObjC.MessageSendBool(Handle,Selector.GetHandle( "isViewLoaded")); }
        }

        public void LoadView()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("loadView"));
        }

        public UIViewController ParentViewController
        {
            get { return Runtime.GetNSObject<UIViewController>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("parentViewController"))); }
        }

        public UIViewController PresentedViewController
        {
            get { return Runtime.GetNSObject<UIViewController>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("presentedViewController"))); }
        }

        public UIViewController PresentingViewController
        {
            get { return Runtime.GetNSObject<UIViewController>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("presentingViewController"))); }
        }

        //TODO: need to add the callback instead of using IntPtr.Zero
        public void PresentViewController(UIViewController controller, bool animated = true)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("presentViewController:animated:completion:"), controller.Handle, animated, IntPtr.Zero);
        }

        //TODO: need to add the callback instead of using IntPtr.Zero
        public void DismissViewController(bool animated = true)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("dismissViewControllerAnimated:completion:"), animated, IntPtr.Zero);
        }
    }
}