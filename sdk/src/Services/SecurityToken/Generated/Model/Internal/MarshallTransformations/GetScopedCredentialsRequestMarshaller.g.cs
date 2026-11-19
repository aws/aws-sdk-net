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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.SecurityToken.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetScopedCredentials Request Marshaller
    /// </summary>
    public partial class GetScopedCredentialsRequestMarshaller : IMarshaller<IRequest, GetScopedCredentialsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetScopedCredentialsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetScopedCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityToken");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GetScopedCredentials");
            request.Parameters.Add("Version", "2011-06-15");

            if (publicRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds.Value));
            }
            if (publicRequest.IsSetMinimumSessionTokenSize())
            {
                request.Parameters.Add("MinimumSessionTokenSize", StringUtils.FromInt(publicRequest.MinimumSessionTokenSize.Value));
            }
            if (publicRequest.IsSetPolicy())
            {
                request.Parameters.Add("Policy", StringUtils.FromString(publicRequest.Policy));
            }
            if (publicRequest.IsSetScopedSessionDescription())
            {
                request.Parameters.Add("ScopedSessionDescription", StringUtils.FromString(publicRequest.ScopedSessionDescription));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly GetScopedCredentialsRequestMarshaller _instance = new();

        internal static GetScopedCredentialsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetScopedCredentialsRequestMarshaller Instance => _instance;
    }
}
