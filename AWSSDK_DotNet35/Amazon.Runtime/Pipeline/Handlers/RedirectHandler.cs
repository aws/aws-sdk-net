/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Net;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler processes HTTP redirects and reissues the call to the
    /// redirected location.
    /// </summary>
    public class RedirectHandler : PipelineHandler
    {
        /// <summary>
        /// Processes HTTP redirects and reissues the call to the
        /// redirected location.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            var isRedirect = false;
            do
            {
                try
                {
                    base.InvokeSync(executionContext);
                    return;
                }
                catch (WebException exception)
                {
                    isRedirect = HandleRedirect(executionContext, exception);
                    if (!isRedirect)
                        throw;
                }
                catch (HttpErrorResponseException httpException)
                {
                    var webException = httpException.InnerException as WebException;
                    if (webException != null)
                    {
                        isRedirect = HandleRedirect(executionContext, webException);
                        if (!isRedirect)
                            throw;    
                    }
                    else
                    {
                        throw;
                    }                    
                }
                RetryHandler.PrepareForRetry(executionContext.RequestContext);
            } while (isRedirect);            
        }

#if BCL45 || WIN_RT || WINDOWS_PHONE 

        /// <summary>
        /// Processes HTTP redirects and reissues the call to the
        /// redirected location.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var isRedirect = false;
            do
            {
                try
                {
                    return await base.InvokeAsync<T>(executionContext);
                }
                catch (WebException exception)
                {
                    isRedirect = HandleRedirect(executionContext, exception);
                    if (!isRedirect)
                        throw;
                }
                catch (HttpErrorResponseException httpException)
                {
                    var webException = httpException.InnerException as WebException;
                    if (webException != null)
                    {
                        isRedirect = HandleRedirect(executionContext, webException);
                        if (!isRedirect)
                            throw;    
                    }
                    else
                    {
                        throw;
                    }                    
                }
                RetryHandler.PrepareForRetry(executionContext.RequestContext);
            } while (isRedirect);
            throw new AmazonClientException("Neither a response was returned nor an exception was thrown in the Runtime RedirectHandler.");
        }

#elif BCL && !BCL45

        /// <summary>
        /// Processes HTTP redirects and reissues the call to the
        /// redirected location.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            var exception = executionContext.ResponseContext.AsyncResult.Exception;
            if (exception != null)
            {
                var webException = exception as WebException;
                var httpException = exception as HttpErrorResponseException;

                if (webException== null && httpException!= null)
                {
                    webException = httpException.InnerException as WebException;   
                }

                if (webException != null)
                {
                    // Call InvokeAsync to redirect to new location.
                    if (HandleRedirect(ExecutionContext.CreateFromAsyncContext(executionContext), webException))
                    {
                        executionContext.ResponseContext.AsyncResult.Exception = null;
                        RetryHandler.PrepareForRetry(executionContext.RequestContext);
                        base.InvokeAsync(executionContext);
                        return;
                    }
                }
            }

            // Not a redirect, call outer callbacks to continue processing response.
            base.InvokeAsyncCallback(executionContext);
        }
#endif

        /// <summary>
        /// Checks if a HTTP 307 (temporary redirect) has occured and changes the 
        /// request endpoint to the redirected location.
        /// </summary>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        /// <param name="exception">The WebException from from the HTTP handler.</param>
        /// <returns>
        /// A boolean value that indicates if a redirect has occured.
        /// </returns>
        private bool HandleRedirect(IExecutionContext executionContext, WebException exception)
        {
            var requestContext = executionContext.RequestContext;
            var httpErrorResponse = exception.Response as HttpWebResponse;
            if (httpErrorResponse != null && 
                httpErrorResponse.StatusCode == HttpStatusCode.TemporaryRedirect)
            {
                string redirectedLocation = httpErrorResponse.Headers[HeaderKeys.LocationHeader];
                requestContext.Metrics.AddProperty(Metric.RedirectLocation, redirectedLocation);

                var isRewindableStream = executionContext.RequestContext.Request.IsRequestStreamRewindable();

                if (isRewindableStream &&
                    !string.IsNullOrEmpty(redirectedLocation))
                {
                    this.Logger.InfoFormat("Request {0} is being redirected to {1}.",
                        requestContext.RequestName, redirectedLocation);
                    requestContext.Request.Endpoint = new Uri(redirectedLocation);
                    return true;
                }
            }
            return false;
        }
    }
}
