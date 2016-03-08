using System;

namespace ThirdParty.iOS4Unity
{
    public class NSMutableDictionary : NSDictionary
    {
        private static readonly IntPtr _classHandle;

        static NSMutableDictionary()
        {
            _classHandle = ObjC.GetClass("NSMutableDictionary");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal NSMutableDictionary(IntPtr handle)
            : base(handle)
        {
        }

        public NSMutableDictionary()
        {
            Handle = ObjC.MessageSendIntPtr(Handle, Selector.Init);
        }

        public new static NSMutableDictionary FromDictionary(NSDictionary dictionary)
        {
            return NSMutableDictionary.FromObjectsAndKeys(dictionary.Values, dictionary.Keys);
        }

        public new static NSMutableDictionary FromObjectAndKey(NSObject obj, string key)
        {
            IntPtr handle = ObjC.ToNSString(key);
            var dictionary = Runtime.GetNSObject<NSMutableDictionary>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dictionaryWithObject:forKey:"), obj.Handle, handle));
            ObjC.MessageSend(handle, Selector.ReleaseHandle);
            return dictionary;
        }

        public new static NSMutableDictionary FromObjectsAndKeys(NSObject[] objects, string[] keys)
        {
            var objectsHandle = ObjC.ToNSArray(objects);
            var keysHandle = ObjC.ToNSArray(keys);
            var dictionary = Runtime.GetNSObject<NSMutableDictionary>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dictionaryWithObjects:forKeys:"), objectsHandle, keysHandle));
            ObjC.ReleaseNSArrayItems(keysHandle);
            return dictionary;
        }

        public void SetObjectForKey(NSObject obj, string key)
        {
            IntPtr handle = ObjC.ToNSString(key);
            ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("setObject:forKey:"), obj.Handle, handle);
            ObjC.MessageSend(handle, Selector.ReleaseHandle);
        }

        public void RemoveObjectForKey(string key)
        {
            IntPtr handle = ObjC.ToNSString(key);
            ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("removeObjectForKey:"), handle);
            ObjC.MessageSend(handle, Selector.ReleaseHandle);
        }

        public new static NSMutableDictionary FromFile(string path)
        {
            return Runtime.GetNSObject<NSMutableDictionary>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("dictionaryWithContentsOfFile:"), path));
        }

        public void Clear()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("removeAllObjects"));
        }

        public override NSObject this[string key]
        {
            get { return ObjectForKey(key); }
            set { SetObjectForKey(value, key); }
        }
    }
}