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

using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using System.Globalization;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler marshalls the request before calling invoking the next handler.
    /// </summary>
    public class Marshaller : GenericHandler
    {
        /// <summary>
        /// Marshalls the request before calling invoking the next handler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            requestContext.Request = requestContext.Marshaller.Marshall(
                executionContext.RequestContext.OriginalRequest);

            requestContext.Request.Headers[HeaderKeys.UserAgentHeader] = requestContext.ClientConfig.UserAgent; 
            // +" " + (asyncResult.CompletedSynchronously ? "ClientSync" : "ClientAsync");

            var method = requestContext.Request.HttpMethod.ToUpper(CultureInfo.InvariantCulture);
            if (method != "GET" && method != "DELETE" && method != "HEAD")
            {
                if (!requestContext.Request.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                {
                    if (requestContext.Request.UseQueryString)
                        requestContext.Request.Headers[HeaderKeys.ContentTypeHeader] = "application/x-amz-json-1.0";
                    else
                        requestContext.Request.Headers[HeaderKeys.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
                }
            }
        }
    }
}
