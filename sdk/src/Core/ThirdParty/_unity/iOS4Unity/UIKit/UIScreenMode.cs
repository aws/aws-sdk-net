using System;

namespace ThirdParty.iOS4Unity
{
    public class UIScreenMode : NSObject
    {
        private static readonly IntPtr _classHandle;

        static UIScreenMode()
        {
            _classHandle = ObjC.GetClass("UIScreenMode");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal UIScreenMode(IntPtr handle)
            : base(handle)
        {
        }

        public float PixelAspectRatio
        {
            get { return ObjC.MessageSendFloat(Handle, Selector.GetHandle("pixelAspectRatio")); }
        }

        public CGSize Size
        {
            get { return ObjC.MessageSendCGSize(Handle, "size"); }
        }
    }
}