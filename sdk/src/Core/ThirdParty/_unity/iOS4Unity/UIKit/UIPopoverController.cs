using System;

namespace ThirdParty.iOS4Unity
{
    public class UIPopoverController : NSObject
    {
        private static readonly IntPtr _classHandle;

        static UIPopoverController()
        {
            _classHandle = ObjC.GetClass("UIPopoverController");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        public UIPopoverController(UIViewController controller)
        {
            Handle = ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("initWithContentViewController:"), controller.Handle);
            ObjC.MessageSend(Handle, Selector.GetHandle("setDelegate:"), Handle);
        }

        internal UIPopoverController(IntPtr handle)
            : base(handle)
        {
        }

        public void PresentFromRect(CGRect rect, UIView view, UIPopoverArrowDirection arrowDirections, bool animated)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("presentPopoverFromRect:inView:permittedArrowDirections:animated:"), rect, view.Handle, (uint)arrowDirections, animated);
        }

        public void SetContentViewController(UIViewController viewController, bool animated)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("setContentViewController:animated:"), viewController.Handle, animated);
        }

        public void SetPopoverContentSize(CGSize size, bool animated)
        {
            ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("setPopoverContentSize:animated:"), size, animated);
        }

        public void Dismiss(bool animated)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("dismissPopoverAnimated:"), animated);
        }

        public UIViewController ContentViewController
        {
            get { return Runtime.GetNSObject<UIViewController>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("contentViewController"))); }
            set { ObjC.MessageSend(Handle,Selector.GetHandle( "setContentViewController:"), value.Handle); }
        }

        public UIPopoverArrowDirection PopoverArrowDirection
        {
            get { return (UIPopoverArrowDirection)ObjC.MessageSendUInt(Handle, Selector.GetHandle("popoverArrowDirection")); }
        }

        public CGSize PopoverContentSize
        {
            get { return ObjC.MessageSendCGSize(Handle, "popoverContentSize"); }
            set { ObjC.MessageSend(Handle, Selector.GetHandle("setPopoverContentSize:"), value); }
        }

        public bool PopoverVisible
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isPopoverVisible")); }
        }

        public event EventHandler Dismissed
        {
            add { Callbacks.Subscribe(this, "popoverControllerDidDismissPopover:", value); }
            remove { Callbacks.Unsubscribe(this, "popoverControllerDidDismissPopover:", value); }
        }
    }

    [CLSCompliant(false)]
    public enum UIPopoverArrowDirection : uint
    {
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8,
        Any = 15,
        Unknown = 4294967295
    }
}