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

using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.IO;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler signs the request.
    /// </summary>
    public class Signer : GenericHandler
    {
        /// <summary>
        /// Signs the request before invoking the next handler.
        /// </summary>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            if (ShouldSign(executionContext.RequestContext))
            {
                SignRequest(executionContext.RequestContext);
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
        internal static void SignRequest(IRequestContext requestContext)
        {
            ImmutableCredentials immutableCredentials = requestContext.ImmutableCredentials;

            // credentials would be null in the case of anonymous users getting public resources from S3
            if (immutableCredentials == null)
                return;

            using (requestContext.Metrics.StartEvent(Metric.RequestSigningTime))
            {
                if (immutableCredentials.UseToken)
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
                requestContext.Signer.Sign(requestContext.Request, requestContext.ClientConfig, requestContext.Metrics,
                    immutableCredentials.AccessKey, immutableCredentials.SecretKey);
            }
        }
    }
}
