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

using Amazon.Runtime.Internal.Util;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Pipeline.HttpHandler
{
    /// <summary>
    /// A DelegatingHandler that automatically retries requests when they fail due to 
    /// stale connections from the HTTP connection pool. This prevents dead pooled 
    /// connections from counting against the SDK's retry limit.
    /// </summary>
    /// <remarks>
    /// When HttpClient reuses a connection from its pool, it may not immediately know
    /// if the server has closed that connection. The first write attempt will fail with
    /// errors like "Broken pipe" or "Connection reset". This handler catches these
    /// specific errors and retries the request once, allowing HttpClient to establish
    /// a fresh connection without consuming a retry from the SDK's retry policy.
    /// </remarks>
    public class PooledConnectionRetryHandler : DelegatingHandler
    {
        // Key used to mark requests that have already been retried by this handler
        private const string RetryAttemptedKey = "AmazonSDK_PooledConnectionRetryAttempted";
        
        private readonly Logger _logger = Logger.GetLogger(typeof(PooledConnectionRetryHandler));

        /// <summary>
        /// Initializes a new instance of the PooledConnectionRetryHandler class.
        /// </summary>
        /// <param name="innerHandler">The inner handler to delegate requests to.</param>
        public PooledConnectionRetryHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        /// <summary>
        /// Sends an HTTP request, automatically retrying once if the failure is due to
        /// a stale pooled connection.
        /// </summary>
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, 
            CancellationToken cancellationToken)
        {
            try
            {
                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Only retry if this is a stale connection error and we haven't already retried
                if (IsStaleConnectionError(ex) && !HasRetryBeenAttempted(request))
                {
                    _logger.DebugFormat(
                        "Detected stale pooled connection error: {0}. Automatically retrying request to {1}",
                        GetErrorMessage(ex),
                        request.RequestUri);

                    // Mark that we've attempted a retry to prevent infinite loops
                    MarkRetryAttempted(request);

                    try
                    {
                        // Retry the request - HttpClient will use a fresh connection
                        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                        
                        _logger.DebugFormat(
                            "Automatic retry succeeded for request to {0}",
                            request.RequestUri);
                        
                        return response;
                    }
                    catch (Exception retryEx)
                    {
                        _logger.DebugFormat(
                            "Automatic retry failed for request to {0}: {1}",
                            request.RequestUri,
                            GetErrorMessage(retryEx));
                        
                        // Retry failed - throw the new exception
                        throw;
                    }
                }

                // Not a stale connection error, or already retried - rethrow original exception
                throw;
            }
        }

        /// <summary>
        /// Determines if an exception indicates a stale pooled connection.
        /// </summary>
        /// <remarks>
        /// This method relies on SocketException error codes rather than error messages,
        /// as error codes are stable across platforms and .NET versions, while error
        /// messages can vary and are subject to localization.
        /// </remarks>
        private static bool IsStaleConnectionError(Exception ex)
        {
            // Walk the exception chain looking for SocketException with known stale connection error codes
            var currentException = ex;
            while (currentException != null)
            {
                if (currentException is SocketException socketException)
                {
                    // SocketError.Shutdown (32) = Broken pipe on Unix/Linux
                    // SocketError.ConnectionReset (10054) = Connection reset by peer
                    // SocketError.ConnectionAborted (10053) = Connection aborted
                    if (socketException.SocketErrorCode == SocketError.Shutdown ||
                        socketException.SocketErrorCode == SocketError.ConnectionReset ||
                        socketException.SocketErrorCode == SocketError.ConnectionAborted)
                    {
                        return true;
                    }
                }

                currentException = currentException.InnerException;
            }

            return false;
        }

        /// <summary>
        /// Checks if a retry has already been attempted for this request.
        /// </summary>
        private static bool HasRetryBeenAttempted(HttpRequestMessage request)
        {
#if NET8_0_OR_GREATER
            return request.Options.TryGetValue(new HttpRequestOptionsKey<bool>(RetryAttemptedKey), out var attempted) && attempted;
#else
            return request.Properties.TryGetValue(RetryAttemptedKey, out var value) && 
                   value is bool attempted && 
                   attempted;
#endif
        }

        /// <summary>
        /// Marks that a retry has been attempted for this request.
        /// </summary>
        private static void MarkRetryAttempted(HttpRequestMessage request)
        {
#if NET8_0_OR_GREATER
            request.Options.Set(new HttpRequestOptionsKey<bool>(RetryAttemptedKey), true);
#else
            request.Properties[RetryAttemptedKey] = true;
#endif
        }

        /// <summary>
        /// Extracts a readable error message from an exception.
        /// </summary>
        private static string GetErrorMessage(Exception ex)
        {
            var currentException = ex;
            while (currentException != null)
            {
                if (currentException is IOException || currentException is SocketException)
                {
                    return $"{currentException.GetType().Name}: {currentException.Message}";
                }
                currentException = currentException.InnerException;
            }
            return ex.Message;
        }
    }
}
