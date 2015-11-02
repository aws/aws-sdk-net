using System;

namespace ThirdParty.iOS4Unity
{
    public class NSBundle : NSObject
    {
        private static readonly IntPtr _classHandle;

        static NSBundle()
        {
            _classHandle = ObjC.GetClass("NSBundle");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal NSBundle(IntPtr handle)
            : base(handle)
        {
        }

        public string BundleIdentifier
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("bundleIdentifier")); }
        }

        public string BundlePath
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("bundlePath")); }
        }

        public static NSBundle FromIdentifier(string str)
        {
            return Runtime.GetNSObject<NSBundle>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("bundleWithIdentifier:"), str));
        }

        public static NSBundle FromPath(string path)
        {
            return Runtime.GetNSObject<NSBundle>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("bundleWithPath:"), path));
        }

        public static NSBundle MainBundle
        {
            get { return Runtime.GetNSObject<NSBundle>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("mainBundle"))); }
        }

        public string LocalizedString(string key, string value = "", string table = "")
        {
            return ObjC.MessageSendString(Handle, Selector.GetHandle("localizedStringForKey:value:table:"), key, value, table);
        }

        public string ResourcePath
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("resourcePath")); }
        }

        public NSDictionary InfoDictionary
        {
            get
            {
                return Runtime.GetNSObject<NSDictionary>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("infoDictionary")));
            }
        }
    }
}