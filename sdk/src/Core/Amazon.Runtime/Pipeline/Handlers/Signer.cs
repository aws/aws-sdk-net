/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime.EventStreams;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Util;
using System.IO;
using System.Threading.Tasks;


namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler signs the request.
    /// </summary>
    public class Signer : PipelineHandler
    {
        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            await PreInvokeAsync(executionContext).ConfigureAwait(false);
            return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        }

        /// <summary>
        /// Signs the request before invoking the next handler.
        /// </summary>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        protected static void PreInvoke(IExecutionContext executionContext)
        {
            if (ShouldSign(executionContext.RequestContext))
            {
                SignRequest(executionContext.RequestContext);
                executionContext.RequestContext.IsSigned = true;
            } 
        }

        protected static async System.Threading.Tasks.Task PreInvokeAsync(IExecutionContext executionContext)
        {
            if (ShouldSign(executionContext.RequestContext))
            {
                await SignRequestAsync(executionContext.RequestContext).ConfigureAwait(false);
                executionContext.RequestContext.IsSigned = true;
            }
        }

        /// <summary>
        /// Determines if the request should be signed.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <returns>A boolean value that indicated if the request should be signed.</returns>
        private static bool ShouldSign(IRequestContext requestContext)
        {
            return !requestContext.IsSigned ||
                requestContext.ClientConfig.ResignRetries;
        }

        /// <summary>
        /// Signs the request.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        public static void SignRequest(IRequestContext requestContext)
        {
            if (requestContext.Identity == null && requestContext.Signer.RequiresCredentials)
            {
                return;
            }

            using (requestContext.Metrics.StartEvent(Metric.RequestSigningTime))
            using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.AuthSigningDurationMetricName))
            {
                ImmutableCredentials immutableCredentials = null;

                using (TracingUtilities.CreateSpan(requestContext, TelemetryConstants.CredentialsRetrievalSpanName))
                using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.ResolveIdentityDurationMetricName))
                using (requestContext.Metrics.StartEvent(Metric.CredentialsRequestTime))
                {
                    immutableCredentials = (requestContext.Identity as AWSCredentials)?.GetCredentials();
                }

                if (immutableCredentials?.UseToken == true && 
                    !(requestContext.Signer is NullSigner) && 
                    !(requestContext.Signer is BearerTokenSigner))
                {
                    ClientProtocol protocol = requestContext.Signer.Protocol;
                    switch (protocol)
                    {
                        case ClientProtocol.QueryStringProtocol:
                            requestContext.Request.Parameters["SecurityToken"] = immutableCredentials.Token;
                            break;
                        case ClientProtocol.RestProtocol:
                            requestContext.Request.Headers[HeaderKeys.XAmzSecurityTokenHeader] = immutableCredentials.Token;
                            break;
                        default:
                            throw new InvalidDataException("Cannot determine protocol");
                    }
                }

                requestContext.Signer.Sign(
                    requestContext.Request,
                    requestContext.ClientConfig,
                    requestContext.Metrics,
                    requestContext.Identity
                );

                if (requestContext.Request.EventStreamPublisher != null)
                {
                    var eventSigner = requestContext.Signer.CreateEventSigner(
                                            requestContext.Identity, 
                                            region: requestContext.Request.DeterminedSigningRegion, 
                                            service: requestContext.ClientConfig.AuthenticationServiceName, 
                                            requestSignature: requestContext.Request.AWS4SignerResult.Signature);

                    requestContext.Request.HttpRequestStreamPublisher = new EventSignerHttpRequestStreamPublisher(
                        requestContext.Request.EventStreamPublisher,
                        eventSigner);
                }
            }
        }

        /// <summary>
        /// Signs the request.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        private static async Task SignRequestAsync(IRequestContext requestContext)
        {
            if (requestContext.Identity == null && requestContext.Signer.RequiresCredentials)
            {
                return;
            }

            using (requestContext.Metrics.StartEvent(Metric.RequestSigningTime))
            using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.AuthSigningDurationMetricName))
            {
                var awsCredentials = requestContext.Identity as AWSCredentials;
                ImmutableCredentials immutableCredentials = null;

                if (awsCredentials != null)
                {
                    using (TracingUtilities.CreateSpan(requestContext, TelemetryConstants.CredentialsRetrievalSpanName))
                    using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.ResolveIdentityDurationMetricName))
                    using (requestContext.Metrics.StartEvent(Metric.CredentialsRequestTime))
                    {
                        immutableCredentials = await awsCredentials.GetCredentialsAsync().ConfigureAwait(false);
                    }
                }

                if (immutableCredentials?.UseToken == true &&
                    !(requestContext.Signer is NullSigner) &&
                    !(requestContext.Signer is BearerTokenSigner))
                {
                    ClientProtocol protocol = requestContext.Signer.Protocol;
                    switch (protocol)
                    {
                        case ClientProtocol.QueryStringProtocol:
                            requestContext.Request.Parameters["SecurityToken"] = immutableCredentials.Token;
                            break;
                        case ClientProtocol.RestProtocol:
                            requestContext.Request.Headers[HeaderKeys.XAmzSecurityTokenHeader] = immutableCredentials.Token;
                            break;
                        default:
                            throw new InvalidDataException("Cannot determine protocol");
                    }
                }

                await requestContext.Signer
                    .SignAsync(
                        requestContext.Request,
                        requestContext.ClientConfig,
                        requestContext.Metrics,
                        requestContext.Identity)
                    .ConfigureAwait(false);

                if (requestContext.Request.EventStreamPublisher != null)
                {
                    var eventSigner = requestContext.Signer.CreateEventSigner(
                                            requestContext.Identity,
                                            region: requestContext.Request.DeterminedSigningRegion,
                                            service: requestContext.ClientConfig.AuthenticationServiceName,
                                            requestSignature: requestContext.Request.AWS4SignerResult.Signature);
                    
                    requestContext.Request.HttpRequestStreamPublisher = new EventSignerHttpRequestStreamPublisher(
                        requestContext.Request.EventStreamPublisher,
                        eventSigner);
                }
            }
        }
    }

    /// <summary>
    /// This class is used when a request is streaming events to a service. The IRequest will have EventStreamPublisher
    /// assigned to it. The class will read the events from the EventStreamPublisher and format the message
    /// for sending to the service. Formatting includes signing the event and converting the event message
    /// to a byte array.
    /// </summary>
    internal class EventSignerHttpRequestStreamPublisher : IHttpRequestStreamPublisher
    {
        private readonly IEventStreamPublisher _eventPublisher;
        private readonly IEventSigner _eventSigner;

        /// <summary>
        /// Create an instance of EventSignerHttpRequestStreamPublisher
        /// </summary>
        /// <param name="eventPublisher">The event publisher to pull events from.</param>
        /// <param name="eventSigner">The event signer used to sign the events.</param>
        public EventSignerHttpRequestStreamPublisher(IEventStreamPublisher eventPublisher, IEventSigner eventSigner)
        {
            _eventPublisher = eventPublisher;
            _eventSigner = eventSigner;
        }

        /// <inheritdoc/>
        public async Task<byte[]> NextBytesAsync()
        {
            var evnt = await _eventPublisher.NextEventAsync().ConfigureAwait(false);
            if ( evnt == null)
            {
                return null;
            }

            var signedBytes = await _eventSigner.SignEventAsync(evnt.ToByteArray()).ConfigureAwait(false);
            return signedBytes;
        }
    }
}
