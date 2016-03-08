using System;

namespace ThirdParty.iOS4Unity
{
    public class SKPaymentTransaction : NSObject
    {
        private static readonly IntPtr _classHandle;

        static SKPaymentTransaction()
        {
            _classHandle = ObjC.GetClass("SKPaymentTransaction");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal SKPaymentTransaction(IntPtr handle)
            : base(handle)
        {
        }

        public NSError Error
        {
            get
            {
                IntPtr handle = ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("error"));
                return handle == IntPtr.Zero ? null : Runtime.GetNSObject<NSError>(handle);
            }
        }

        public SKPaymentTransaction OriginalTransaction
        {
            get
            {
                IntPtr handle = ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("originalTransaction"));
                return handle == IntPtr.Zero ? null : Runtime.GetNSObject<SKPaymentTransaction>(handle);
            }
        }

        public DateTime TransactionDate
        {
            get { return (DateTime)ObjC.MessageSendDate(Handle, Selector.GetHandle("transactionDate")); }
        }

        public string TransactionIdentifier
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("transactionIdentifier")); }
        }
    }
}