using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
    public class SKPaymentQueue : NSObject
    {
        private static readonly IntPtr _classHandle;

        static SKPaymentQueue()
        {
            _classHandle = ObjC.GetClass("SKPaymentQueue");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        private Dictionary<object, IntPtrHandler2> _restoreFailed, _updatedTransactions;

        internal SKPaymentQueue(IntPtr handle)
            : base(handle)
        {
            ObjC.MessageSend(Handle,Selector.GetHandle( "addTransactionObserver:"), Handle);
        }

        public static bool CanMakePayments
        {
            get { return ObjC.MessageSendBool(_classHandle, Selector.GetHandle("canMakePayments")); }
        }

        public SKPaymentTransaction[] Transactions
        {
            get { return ObjC.FromNSArray<SKPaymentTransaction>(ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("transactions"))); }
        }

        public static SKPaymentQueue DefaultQueue
        {
            get { return Runtime.GetNSObject<SKPaymentQueue>(ObjC.MessageSendIntPtr(_classHandle, Selector.GetHandle("defaultQueue"))); }
        }

        public event EventHandler RestoreCompleted
        {
            add { Callbacks.Subscribe(this, "paymentQueueRestoreCompletedTransactionsFinished:", value); }
            remove { Callbacks.Unsubscribe(this, "paymentQueueRestoreCompletedTransactionsFinished:", value); }
        }

        public event EventHandler<NSErrorEventArgs> RestoreFailed
        {
            add
            {
                if (_restoreFailed == null)
                    _restoreFailed = new Dictionary<object, IntPtrHandler2>();
                IntPtrHandler2 callback = (_, i) => value(this, new NSErrorEventArgs { Error = Runtime.GetNSObject<NSError>(i) });
                _restoreFailed[value] = callback;
                Callbacks.Subscribe(this, "paymentQueue:restoreCompletedTransactionsFailedWithError:", callback);
            }
            remove
            {
                IntPtrHandler2 callback;
                if (_restoreFailed != null && _restoreFailed.TryGetValue(value, out callback))
                {
                    _restoreFailed.Remove(value);
                    Callbacks.Unsubscribe(this, "paymentQueue:restoreCompletedTransactionsFailedWithError:", callback);
                }
            }
        }

        public event EventHandler<SKPaymentTransactionEventArgs> UpdatedTransactions
        {
            add
            {
                if (_updatedTransactions == null)
                    _updatedTransactions = new Dictionary<object, IntPtrHandler2>();
                IntPtrHandler2 callback = (_, i) => value(this, new SKPaymentTransactionEventArgs { Transactions = ObjC.FromNSArray<SKPaymentTransaction>(i) });
                _updatedTransactions[value] = callback;
                Callbacks.Subscribe(this, "paymentQueue:updatedTransactions:", callback);
            }
            remove
            {
                IntPtrHandler2 callback;
                if (_updatedTransactions != null && _updatedTransactions.TryGetValue(value, out callback))
                {
                    _updatedTransactions.Remove(value);
                    Callbacks.Unsubscribe(this, "paymentQueue:updatedTransactions:", callback);
                }
            }
        }

        public void AddPayment(SKPayment payment)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("addPayment:"), payment.Handle);
        }

        public void RestoreCompletedTransactions()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("restoreCompletedTransactions"));
        }

        public void FinishTransaction(SKPaymentTransaction transaction)
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("finishTransaction:"), transaction.Handle);
        }

        public override void Dispose()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("removeTransactionObserver:"), Handle);

            base.Dispose();
        }
    }

    public class SKPaymentTransactionEventArgs : EventArgs
    {
        public SKPaymentTransaction[] Transactions;
    }
}