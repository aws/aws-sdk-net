/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Net;
using System.Threading;
using Amazon.Util;

namespace Amazon.StorageGateway.Util
{
    /// <summary>
    /// Utilities for working with the AWS Storage Gateway service, such as
    /// requesting a running AWS Storage Gateway instances's activation key for
    /// registering a Storage Gateway server.
    /// </summary>
    public static class AmazonStorageGatewayUtil
    {
        private const string activationKeyName = "activationKey";
        private const string locationHeaderName = "Location";
        private const int defaultMaxRetries = 5;
        private const int defaultMaxBackoff = 30 * 1000;

        /// <summary>
        /// Sends a request to the AWS Storage Gateway server running at the
        /// specified address, and returns the activation key for that server.
        /// The default max retry count and max exponential backoff time will be
        /// used.
        /// </summary>
        /// <param name="gatewayAddress">The DNS name or IP address of a running AWS Storage Gateway</param>
        /// <returns>The activation key required for some API calls to AWS Storage Gateway.</returns>
        /// <remarks>Maximum default retry count is 5 attempts, with exponential backoff up to a max of 30 seconds.</remarks>
        public static string GetActivationKey(string gatewayAddress)
        {
            return GetActivationKey(gatewayAddress, defaultMaxRetries, defaultMaxBackoff);
        }

        /// <summary>
        /// Sends a request to the AWS Storage Gateway server running at the
        /// specified address, and returns the activation key for that server.
        /// The default max retry count and max exponential backoff time will be
        /// used.
        /// </summary>
        /// <param name="gatewayAddress">The DNS name or IP address of a running AWS Storage Gateway</param>
        /// <param name="activationRegion">The region in which the gateway will be activated.</param>
        /// <returns>The activation key required for some API calls to AWS Storage Gateway.</returns>
        /// <remarks>Maximum default retry count is 5 attempts, with exponential backoff up to a max of 30 seconds.</remarks>
        public static string GetActivationKey(string gatewayAddress, RegionEndpoint activationRegion)
        {
            return GetActivationKey(gatewayAddress, activationRegion, defaultMaxRetries, defaultMaxBackoff);
        }

        /// <summary>
        /// Sends a request to the AWS Storage Gateway server running at the
        /// specified address, and returns the activation key for that server.
        /// </summary>
        /// <param name="gatewayAddress">The DNS name or IP address of a running AWS Storage Gateway</param>
        /// <param name="maxRetries">The maximum number of retries to attempt on failure</param>
        /// <param name="maxBackoff">The maximum backoff time, in milliseconds, for retry attempts. Backoff times between retries rise exponentially until they hit this ceiling.</param>
        /// <returns>The activation key required for some API calls to AWS Storage Gateway.</returns>
        public static string GetActivationKey(string gatewayAddress, int maxRetries, int maxBackoff)
        {
            return GetActivationKey(gatewayAddress, null, maxRetries, maxBackoff);
        }

        /// <summary>
        /// Sends a request to the AWS Storage Gateway server running at the
        /// specified address, and returns the activation key for that server.
        /// </summary>
        /// <param name="gatewayAddress">The DNS name or IP address of a running AWS Storage Gateway</param>
        /// <param name="activationRegion">The region in which the gateway will be activated.</param>
        /// <param name="maxRetries">The maximum number of retries to attempt on failure</param>
        /// <param name="maxBackoff">The maximum backoff time, in milliseconds, for retry attempts. Backoff times between retries rise exponentially until they hit this ceiling.</param>
        /// <returns>The activation key required for some API calls to AWS Storage Gateway.</returns>
        public static string GetActivationKey(string gatewayAddress, RegionEndpoint activationRegion, int maxRetries, int maxBackoff)
        {
            if (maxRetries <= 1)
                maxRetries = defaultMaxRetries;
            if (maxBackoff <= 0)
                maxBackoff = defaultMaxBackoff;

            int retries = 0;
            while (retries < maxRetries)
            {
                try
                {
                    string uri = "http://" + gatewayAddress;
                    if (activationRegion != null)
                        uri = uri + "/?activationRegion=" + activationRegion.SystemName;
                    string locationHeader = GetHeader(uri);
                    var parameters = AWSSDKUtils.ParseQueryParameters(locationHeader);
                    string activationKey;
                    if (parameters.TryGetValue(activationKeyName, out activationKey) && !string.IsNullOrEmpty(activationKey))
                        return activationKey;

                    throw new AmazonStorageGatewayException("Unable to get activation key from : " + uri);
                }
                catch (WebException)
                {
                    retries++;
                    if (retries == maxRetries)
                        break;
                }

                int delay = (int)(Math.Pow(4, retries) * 100);
                delay = Math.Min(delay, maxBackoff);
                AWSSDKUtils.Sleep(delay);
            }

            throw new AmazonStorageGatewayException("Unable to get activation key; retries exhausted");
        }

        private static string GetHeader(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.AllowAutoRedirect = false;

            var asyncResponse = request.BeginGetResponse(null, null);
            using (HttpWebResponse response = request.EndGetResponse(asyncResponse) as HttpWebResponse)
            {
                if (response == null)
                {
                    throw new WebException("The Web Response for a successful request is null!", WebExceptionStatus.ProtocolError);
                }

                if (response.StatusCode != HttpStatusCode.Found)
                    throw new AmazonStorageGatewayException(
                        "Could not fetch activation key, received HTTP status code '" + response.StatusCode + "' expected '302'");

                return response.Headers[locationHeaderName];
            }
        }
    }
}
