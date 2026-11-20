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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.NetworkSecurityManager.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkSecurityManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListProtectedResourceCoverages Request Marshaller
    /// </summary>
    public partial class ListProtectedResourceCoveragesRequestMarshaller : IMarshaller<IRequest, ListProtectedResourceCoveragesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListProtectedResourceCoveragesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListProtectedResourceCoveragesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkSecurityManager");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-10-30";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetEntityType())
            {
                request.Parameters.Add("entityType", StringUtils.FromString(publicRequest.EntityType));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (string.IsNullOrEmpty(publicRequest.ResourceArn))
            {
                throw new AmazonNetworkSecurityManagerException("Request object does not have required field ResourceArn set");
            }

            if (publicRequest.IsSetResourceArn())
            {
                request.Parameters.Add("resourceArn", StringUtils.FromString(publicRequest.ResourceArn));
            }

            request.ResourcePath = "/resource-coverage/protected-resources";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListProtectedResourceCoveragesRequestMarshaller _instance = new();

        internal static ListProtectedResourceCoveragesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListProtectedResourceCoveragesRequestMarshaller Instance => _instance;
    }
}
