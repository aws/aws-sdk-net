using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity.Marshalers
{
    public class NSDateMarshaler : ICustomMarshaler
    {
        private static readonly NSDateMarshaler _instance = new NSDateMarshaler();

        public static ICustomMarshaler GetInstance(string cookie)
        {
            return _instance;
        }

        public void CleanUpManagedData(object ManagedObj)
        {
            //Doesn't need to do anything
        }

        public virtual void CleanUpNativeData(IntPtr pNativeData)
        {
            //Doesn't need to do anything
        }

        public int GetNativeDataSize()
        {
            return IntPtr.Size;
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            DateTime date = (DateTime)managedObj;
            return ObjC.ToNSDate(date);
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return default(DateTime);
            return ObjC.FromNSDate(pNativeData);
        }
    }

    public class NSDateReleaseMarshaler : NSDateMarshaler
    {
        private static readonly NSDateReleaseMarshaler _instance = new NSDateReleaseMarshaler();

        public static new ICustomMarshaler GetInstance(string cookie)
        {
            return _instance;
        }

        public override void CleanUpNativeData(IntPtr pNativeData)
        {
            if (pNativeData != IntPtr.Zero)
                ObjC.MessageSend(pNativeData, Selector.ReleaseHandle);
        }
    }
}