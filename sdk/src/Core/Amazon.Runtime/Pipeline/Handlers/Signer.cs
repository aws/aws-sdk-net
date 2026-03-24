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

using Amazon.Runtime.EventStreams.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Runtime.Internal.Util;
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
            else if (executionContext.RequestContext.Request.EventStreamPublisher != null
                     && executionContext.RequestContext.Retries > 0)
            {
                RecreateEventSignerForRetry(executionContext.RequestContext);
            }
        }

        protected static async System.Threading.Tasks.Task PreInvokeAsync(IExecutionContext executionContext)
        {
            if (ShouldSign(executionContext.RequestContext))
            {
                await SignRequestAsync(executionContext.RequestContext).ConfigureAwait(false);
                executionContext.RequestContext.IsSigned = true;
            }
            else if (executionContext.RequestContext.Request.EventStreamPublisher != null
                     && executionContext.RequestContext.Retries > 0)
            {
                // On retry, the Signer is skipped (IsSigned=true, ResignRetries=false).
                // But event streaming requests need a fresh AWS4EventSigner because
                // the old signer's _previousSignature chain has advanced past event N
                // from the failed attempt. The server on the new connection expects
                // the chain to start from the initial request signature.
                // We recreate just the event signer (not the full request signature).
                RecreateEventSignerForRetry(executionContext.RequestContext);
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
                if (requestContext.Identity is AWSCredentials awsCredentials)
                {
                    using (TracingUtilities.CreateSpan(requestContext, TelemetryConstants.CredentialsRetrievalSpanName))
                    using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.ResolveIdentityDurationMetricName))
                    using (requestContext.Metrics.StartEvent(Metric.CredentialsRequestTime))
                    {
                        immutableCredentials = awsCredentials.GetCredentials();
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
                if (!string.IsNullOrEmpty(immutableCredentials?.AccountId))
                {
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.RESOLVED_ACCOUNT_ID);
                }

                requestContext.Signer.Sign(
                    requestContext.Request,
                    requestContext.ClientConfig,
                    requestContext.Metrics,
                    requestContext.Identity
                );

                if (requestContext.Request.EventStreamPublisher != null)
                {
                    var signingRegion = requestContext.Request.DeterminedSigningRegion;
                    var authServiceName = requestContext.ClientConfig.AuthenticationServiceName;
                    var requestSignature = requestContext.Request.AWS4SignerResult?.Signature;

                    var requestHashCode = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(requestContext.Request);
                    var signerLog = Util.Logger.GetLogger(typeof(Signer));
                    signerLog.DebugFormat(
                        "Signer.SignRequestAsync creating EventSigner: requestHashCode={0}, requestName={1}, isSigned={2}, resignRetries={3}, " +
                        "identityType={4}, accessKeyId={5}, signingRegion={6}, authServiceName={7}, " +
                        "requestSignature={8}, retries={9}",
                        requestHashCode,
                        requestContext.RequestName,
                        requestContext.IsSigned,
                        requestContext.ClientConfig.ResignRetries,
                        requestContext.Identity?.GetType().Name ?? "null",
                        immutableCredentials?.AccessKey ?? "null",
                        signingRegion,
                        authServiceName,
                        requestSignature?.Substring(0, System.Math.Min(16, requestSignature?.Length ?? 0)) + "...",
                        requestContext.Retries);

                    var eventSigner = requestContext.Signer.CreateEventSigner(
                                            requestContext.Identity,
                                            region: signingRegion,
                                            service: authServiceName,
                                            requestSignature: requestSignature);
                    
                    requestContext.Request.HttpRequestStreamPublisher = new EventSignerHttpRequestStreamPublisher(
                        requestContext.Request.EventStreamPublisher,
                        eventSigner,
                        requestHashCode);
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
                ImmutableCredentials immutableCredentials = null;
                if (requestContext.Identity is AWSCredentials awsCredentials)
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
                if (!string.IsNullOrEmpty(immutableCredentials?.AccountId))
                {
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.RESOLVED_ACCOUNT_ID);
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
                    var signingRegion = requestContext.Request.DeterminedSigningRegion;
                    var authServiceName = requestContext.ClientConfig.AuthenticationServiceName;
                    var requestSignature = requestContext.Request.AWS4SignerResult?.Signature;

                    var requestHashCode = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(requestContext.Request);
                    var signerLog = Util.Logger.GetLogger(typeof(Signer));
                    signerLog.DebugFormat(
                        "Signer.SignRequestAsync creating EventSigner: requestHashCode={0}, requestName={1}, isSigned={2}, resignRetries={3}, " +
                        "identityType={4}, accessKeyId={5}, signingRegion={6}, authServiceName={7}, " +
                        "requestSignature={8}, retries={9}",
                        requestHashCode,
                        requestContext.RequestName,
                        requestContext.IsSigned,
                        requestContext.ClientConfig.ResignRetries,
                        requestContext.Identity?.GetType().Name ?? "null",
                        immutableCredentials?.AccessKey ?? "null",
                        signingRegion,
                        authServiceName,
                        requestSignature?.Substring(0, System.Math.Min(16, requestSignature?.Length ?? 0)) + "...",
                        requestContext.Retries);

                    var eventSigner = requestContext.Signer.CreateEventSigner(
                                            requestContext.Identity,
                                            region: signingRegion,
                                            service: authServiceName,
                                            requestSignature: requestSignature);
                    
                    requestContext.Request.HttpRequestStreamPublisher = new EventSignerHttpRequestStreamPublisher(
                        requestContext.Request.EventStreamPublisher,
                        eventSigner,
                        requestHashCode);
                }
            }
        }

        /// <summary>
        /// Recreates only the event signer and publisher for event streaming requests on retry.
        /// The initial request signature (from AWS4SignerResult) is reused since the request
        /// headers haven't changed. Only the event signer needs to be reset because its
        /// _previousSignature chain has advanced past event N from the failed attempt.
        /// </summary>
        private static void RecreateEventSignerForRetry(IRequestContext requestContext)
        {
            var requestSignature = requestContext.Request.AWS4SignerResult?.Signature;
            if (requestSignature == null)
            {
                return;
            }

            var signingRegion = requestContext.Request.DeterminedSigningRegion;
            var authServiceName = requestContext.ClientConfig.AuthenticationServiceName;

            var requestHashCode = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(requestContext.Request);
            var signerLog = Util.Logger.GetLogger(typeof(Signer));
            signerLog.DebugFormat(
                "Signer.RecreateEventSignerForRetry: requestHashCode={0}, requestName={1}, " +
                "signingRegion={2}, authServiceName={3}, requestSignature={4}, retries={5}",
                requestHashCode,
                requestContext.RequestName,
                signingRegion,
                authServiceName,
                requestSignature?.Substring(0, System.Math.Min(16, requestSignature?.Length ?? 0)) + "...",
                requestContext.Retries);

            var eventSigner = requestContext.Signer.CreateEventSigner(
                                    requestContext.Identity,
                                    region: signingRegion,
                                    service: authServiceName,
                                    requestSignature: requestSignature);

            requestContext.Request.HttpRequestStreamPublisher = new EventSignerHttpRequestStreamPublisher(
                requestContext.Request.EventStreamPublisher,
                eventSigner,
                requestHashCode);
        }
    }
}
