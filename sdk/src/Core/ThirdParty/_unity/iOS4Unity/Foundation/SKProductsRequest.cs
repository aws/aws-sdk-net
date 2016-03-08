using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
    public class SKProductsRequest : NSObject
    {
        private static readonly IntPtr _classHandle;

        static SKProductsRequest()
        {
            _classHandle = ObjC.GetClass("SKProductsRequest");
        }

        public override IntPtr ClassHandle
        {
            get { return _classHandle; }
        }

        private Dictionary<object, IntPtrHandler2> _receivedResponse, _failed;

        public SKProductsRequest(params string[] productIds)
        {
            ObjC.MessageSendIntPtr(Handle, Selector.GetHandle("initWithProductIdentifiers:"), ObjC.ToNSSet(productIds));
            ObjC.MessageSend(Handle, Selector.GetHandle("setDelegate:"), Handle);
        }

        internal SKProductsRequest(IntPtr handle)
            : base(handle)
        {
        }

        public void Cancel()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("cancel"));
        }

        public void Start()
        {
            ObjC.MessageSend(Handle, Selector.GetHandle("start"));
        }

        public event EventHandler<SKProductsResponseEventArgs> ReceivedResponse
        {
            add
            {
                if (_receivedResponse == null)
                    _receivedResponse = new Dictionary<object, IntPtrHandler2>();
                IntPtrHandler2 callback = (_, i) => value(this, new SKProductsResponseEventArgs { Response = Runtime.GetNSObject<SKProductsResponse>(i) });
                _receivedResponse[value] = callback;
                Callbacks.Subscribe(this, "productsRequest:didReceiveResponse:", callback);
            }
            remove
            {
                IntPtrHandler2 callback;
                if (_receivedResponse != null && _receivedResponse.TryGetValue(value, out callback))
                {
                    _receivedResponse.Remove(value);
                    Callbacks.Unsubscribe(this, "productsRequest:didReceiveResponse:", callback);
                }
            }
        }

        public event EventHandler<NSErrorEventArgs> Failed
        {
            add
            {
                if (_failed == null)
                    _failed = new Dictionary<object, IntPtrHandler2>();
                IntPtrHandler2 callback = (_, i) => value(this, new NSErrorEventArgs { Error = Runtime.GetNSObject<NSError>(i) });
                _failed[value] = callback;
                Callbacks.Subscribe(this, "request:didFailWithError:", callback);
            }
            remove
            {
                IntPtrHandler2 callback;
                if (_failed != null && _failed.TryGetValue(value, out callback))
                {
                    _failed.Remove(value);
                    Callbacks.Unsubscribe(this, "request:didFailWithError:", callback);
                }
            }
        }

        public event EventHandler Finished
        {
            add { Callbacks.Subscribe(this, "requestDidFinish:", value); }
            remove { Callbacks.Unsubscribe(this, "requestDidFinish:", value); }
        }
    }

    public class SKProductsResponseEventArgs : EventArgs
    {
        public SKProductsResponse Response;
    }
}