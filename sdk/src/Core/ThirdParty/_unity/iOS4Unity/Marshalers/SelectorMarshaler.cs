using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity.Marshalers
{
    public class SelectorMarshaler : ICustomMarshaler
    {
        private static readonly SelectorMarshaler _instance = new SelectorMarshaler();

        public static ICustomMarshaler GetInstance(string cookie)
        {
            return _instance;
        }

        public void CleanUpManagedData(object managedObj)
        {
            //Doesn't need to do anything
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            //Doesn't need to do anything
        }

        public int GetNativeDataSize()
        {
            return IntPtr.Size;
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            string selectorName = managedObj as string;
            if (string.IsNullOrEmpty(selectorName))
                return IntPtr.Zero;

            var selector = ObjC.GetSelector(selectorName);

            return selector;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            return ObjC.GetSelectorName(pNativeData);
        }
    }
}