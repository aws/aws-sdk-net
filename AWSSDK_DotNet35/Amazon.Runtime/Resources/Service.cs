using Amazon.Runtime.Internal;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Resources
{
    public abstract class Service<T> : IDisposable where T : IDisposable
    {
        bool _disposed = false;
        bool _shouldDisposeClient = true;
        T _client;

        public Service(T client)
        {
            _client = client;
        }

        protected T Client
        {
            get
            {
                return _client;
            }
        }

        protected bool ShouldDisposeClient
        {
            get { return _shouldDisposeClient; }
            set { _shouldDisposeClient = value; }
        }

        #region Dispose methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing && this.ShouldDisposeClient)
            {
                if (this.Client != null)
                    this.Client.Dispose();

                _disposed = true;
            }
        }

        protected ObjectDisposedException HandleObjectDisposedException(string methodName, ObjectDisposedException exception)
        {
            var message = string.Format(CultureInfo.InvariantCulture, "Execution of the {0} method failed as the service client associated with it has been disposed. " +
                "The service client which was used to construct the resource root should not be disposed for the lifetime of the resource root.",
                   methodName);
            return new ObjectDisposedException(message, exception);
        }

        #endregion
    }

    internal class ResourcesUtilities
    {
        internal static TResponse Invoke<TRequest,TResponse>(TRequest request, Func<TRequest,TResponse> func, string methodName)
            where TRequest : AmazonWebServiceRequest
            where TResponse : AmazonWebServiceResponse
        {
            try
            {
                request.BeforeRequestEvent += ResourcesUtilities.AppendUserAgent;
                return func(request);
            }
            catch (ObjectDisposedException exception)
            {
                throw HandleObjectDisposedException(methodName, exception);
            }
            finally
            {
                request.BeforeRequestEvent -= ResourcesUtilities.AppendUserAgent;
            }
        }

        internal static IEnumerable<TResponse> InvokePaginator<TRequest, TResponse>(TRequest request, 
            Func<TRequest,IEnumerable<TResponse>> func, string methodName)
            where TRequest : AmazonWebServiceRequest
        {
            try
            {
                request.BeforeRequestEvent += ResourcesUtilities.AppendUserAgent;
                return func(request);
            }
            catch (ObjectDisposedException exception)
            {
                throw HandleObjectDisposedException(methodName, exception);
            }
            finally
            {
                request.BeforeRequestEvent -= ResourcesUtilities.AppendUserAgent;
            }
        }

        internal static void AppendUserAgent(object sender, RequestEventArgs args)
        {
            var wsArgs = args as WebServiceRequestEventArgs;
            if (wsArgs != null)
            {
                var currentUserAgent = wsArgs.Headers[AWSSDKUtils.UserAgentHeader];
                wsArgs.Headers[AWSSDKUtils.UserAgentHeader] = currentUserAgent + " ResourceAPI";
            }
        }

        internal static ObjectDisposedException HandleObjectDisposedException(string methodName, ObjectDisposedException exception)
        {
            var message = string.Format(CultureInfo.InvariantCulture, "Execution of the {0} method failed as the service client associated with it has been disposed. " +
                "The service client which was used to construct the resource root should not be disposed for the lifetime of the resource root.",
                   methodName);
            return new ObjectDisposedException(message, exception);
        }
    }
}
