using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.IntegrationTests.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class RetryUtilities
    {
        // Flag to force failing of a first request, but passing of retry requests
        public static bool FailOriginalRequests = false;
        public static bool TestClockSkewCorrection = false;
        public static bool SetIncorrectClockOffsetFuture = false;

        public static void ConfigureClient(AmazonServiceClient client)
        {
            if (FailOriginalRequests)
                ForceConfigureClient(client);

            // Attach events to client

            client.BeforeRequestEvent += (s, e) =>
            {
                if (TestClockSkewCorrection)
                {
                    // set clockskew correction to wrong value
                    SetIncorrectOffset();
                }
            };
            client.AfterResponseEvent += (s, e) =>
            {
            };
            client.ExceptionEvent += (s, e) =>
            {
            };
        }

        #region Clock Skew testing

        /// <summary>
        /// Disables clock skew correction until result is disposed
        /// </summary>
        /// <returns></returns>
        public static IDisposable DisableClockSkewCorrection()
        {
            return ClockSkewTemporarySwitch.Disable();
        }

        /// <summary>
        /// Enables clock skew correction until result is disposed
        /// </summary>
        /// <returns></returns>
        public static IDisposable EnableClockSkewCorrection()
        {
            return ClockSkewTemporarySwitch.Enable();
        }

        /// <summary>
        /// Class that switches clock skew correction on or off at creation,
        /// then returns to the previous setting when disposed
        /// </summary>
        private class ClockSkewTemporarySwitch : IDisposable
        {
            public bool OldValue { get; private set; }

            public ClockSkewTemporarySwitch(bool temporarilyCorrectClockSkew)
            {
                OldValue = AWSConfigs.CorrectForClockSkew;

                AWSConfigs.CorrectForClockSkew = temporarilyCorrectClockSkew;
            }

            public static ClockSkewTemporarySwitch Enable()
            {
                return new ClockSkewTemporarySwitch(temporarilyCorrectClockSkew: true);
            }
            public static ClockSkewTemporarySwitch Disable()
            {
                return new ClockSkewTemporarySwitch(temporarilyCorrectClockSkew: false);
            }

            public void Dispose()
            {
                AWSConfigs.CorrectForClockSkew = OldValue;
            }
        }

        private static void SetIncorrectOffset()
        {
            TimeSpan offset;
            if (SetIncorrectClockOffsetFuture)
                offset = General.IncorrectPositiveClockSkewOffset;
            else
                offset = General.IncorrectNegativeClockSkewOffset;
            General.SetClockSkewCorrection(offset);
        }

        #endregion

        #region Retry testing

        public static void ForceConfigureClient(AmazonServiceClient client)
        {
            RetryHttpRequestFactory.AddToClient(client);
        }

        private class RetryHttpRequestFactory : IHttpRequestFactory<Stream>
        {
            public IHttpRequest<Stream> CreateHttpRequest(Uri requestUri)
            {
                var request = new RetryHttpRequest(requestUri);
                return request;
            }
            public void Dispose()
            {
            }

            public static void AddToClient(AmazonServiceClient client)
            {
                var pipeline = client
                    .GetType()
                    .GetProperty("RuntimePipeline", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                    .GetValue(client, null)
                    as RuntimePipeline;

                var requestFactory = new RetryHttpRequestFactory();
                var httpHandler = new HttpHandler<Stream>(requestFactory, client);
                pipeline.ReplaceHandler<HttpHandler<Stream>>(httpHandler);
            }
        }

        private class RetryHttpRequest : HttpRequest
        {
            public RetryHttpRequest(Uri requestUri)
                : base(requestUri)
            {
                IsRetry = false;
            }

            public bool IsRetry { get; private set; }
            public bool IsRewindable { get; private set; }

            public override Amazon.Runtime.Internal.Transform.IWebResponseData GetResponse()
            {
                if (IsRetry || !IsRewindable)
                    return base.GetResponse();
                else
                    throw new WebException("Newp!", null, WebExceptionStatus.ConnectionClosed, null);
            }

#if BCL45
            public override System.Threading.Tasks.Task<IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
            {
                if (IsRetry || !IsRewindable)
                    return base.GetResponseAsync(cancellationToken);
                else
                    throw new WebException("Newp!", null, WebExceptionStatus.ConnectionClosed, null);
            }

#elif BCL && !BCL45
            public override IWebResponseData EndGetResponse(IAsyncResult asyncResult)
            {
                if (IsRetry || !IsRewindable)
                    return base.EndGetResponse(asyncResult);
                else
                    throw new WebException("Newp!", null, WebExceptionStatus.ConnectionClosed, null);
            }
#endif

            public override void ConfigureRequest(IRequestContext requestContext)
            {
                base.ConfigureRequest(requestContext);

                IsRetry = requestContext.Retries > 0;
                IsRewindable = requestContext.Request.IsRequestStreamRewindable();
            }
        }

        #endregion
    }
}
