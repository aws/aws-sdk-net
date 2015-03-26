using Amazon.Runtime;
using System;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public class DisposableSwitch : IDisposable
    {
        private bool CallbacksSet { get; set; }
        private Action EndAction { get; set; }

        public DisposableSwitch(Action onEnd)
            : this(null, onEnd) { }
        public DisposableSwitch(Action onStart, Action onEnd)
        {
            SetCallbacks(onStart, onEnd);
        }

        protected DisposableSwitch()
        { }
        protected void SetCallbacks(Action onStart, Action onEnd)
        {
            if (CallbacksSet)
                throw new InvalidOperationException();

            if (onStart != null)
                onStart();
            EndAction = onEnd;

            CallbacksSet = true;
        }

        public void Dispose()
        {
            if (EndAction != null)
                EndAction();
        }
    }

    public class ServiceResponseCounter : DisposableSwitch
    {
        public int ResponseCount { get; private set; }
        private Predicate<AmazonWebServiceRequest> RequestsToCount { get; set; }
        private AmazonServiceClient Client { get; set; }

        public ServiceResponseCounter(AmazonServiceClient client, Predicate<AmazonWebServiceRequest> requestsToCount = null)
        {
            ResponseCount = 0;
            Client = client;
            RequestsToCount = requestsToCount;

            SetCallbacks(Attach, Detach);
        }

        public void Reset()
        {
            ResponseCount = 0;
        }

        private void Attach()
        {
            Client.AfterResponseEvent += Count;
        }
        private void Detach()
        {
            Client.AfterResponseEvent -= Count;
        }
        private void Count(object sender, ResponseEventArgs e)
        {
            var wsrea = e as WebServiceResponseEventArgs;
            var request = wsrea.Request;

            if (RequestsToCount == null || RequestsToCount(request))
            {
                ResponseCount++;
            }
        }
    }
}
