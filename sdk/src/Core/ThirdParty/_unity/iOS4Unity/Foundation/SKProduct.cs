using System;

namespace ThirdParty.iOS4Unity
{
    public class SKProduct : NSObject
    {
        private static readonly IntPtr _classHandle;

        static SKProduct()
        {
            _classHandle = ObjC.GetClass("SKProduct");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        internal SKProduct(IntPtr handle)
            : base(handle)
        {
        }

        public bool Downloadable
        {
            get { return ObjC.MessageSendBool(Handle, Selector.GetHandle("isDownloadable")); }
        }

        public string LocalizedDescription
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("localizedDescription")); }
        }

        public string LocalizedTitle
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("localizedTitle")); }
        }

        public double Price
        {
            get { return ObjC.FromNSNumber(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("price"))); }
        }

        public NSLocale PriceLocale
        {
            get { return Runtime.GetNSObject<NSLocale>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("priceLocale"))); }
        }

        public string ProductIdentifier
        {
            get { return ObjC.MessageSendString(Handle, Selector.GetHandle("productIdentifier")); }
        }

        public SKPaymentTransactionState TransactionState
        {
            get { return (SKPaymentTransactionState)ObjC.MessageSendInt(Handle, Selector.GetHandle("transactionState")); }
        }
    }

    public enum SKPaymentTransactionState
    {
        Purchasing,
        Purchased,
        Failed,
        Restored,
        Deferred
    }
}