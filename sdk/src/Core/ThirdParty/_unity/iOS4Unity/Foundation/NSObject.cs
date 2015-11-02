using System;

namespace ThirdParty.iOS4Unity
{
    public class NSObject : IDisposable
    {
        private static readonly IntPtr _classHandle;

        static NSObject()
        {
            _classHandle = ObjC.GetClass("NSObject");
        }

        public virtual IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        ~NSObject()
        {
            Dispose();
        }

        public IntPtr Handle;
        private readonly bool _shouldRelease;

        public NSObject(IntPtr handle)
        {
            Handle = handle;
            Runtime.RegisterNSObject(this);
        }

        public NSObject()
        {
            Handle = ObjC.MessageSendIntPtr(ClassHandle, Selector.AllocHandle);
            Runtime.RegisterNSObject(this);
            _shouldRelease = true;
        }

        public string Description
        {
            get { return ObjC.FromNSString(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("description"))); }
        }

        public override string ToString()
        {
            return Description;
        }

        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);

            if (Handle != IntPtr.Zero)
            {
                Runtime.UnregisterNSObject(Handle);
                Callbacks.UnsubscribeAll(this);
                if (_shouldRelease)
                {
                    ObjC.MessageSend(Handle, Selector.ReleaseHandle);
                }
            }
        }
    }
}