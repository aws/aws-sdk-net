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

using Amazon.AppSync.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetType Request Marshaller
    /// </summary>
    public partial class GetTypeRequestMarshaller : IMarshaller<IRequest, GetTypeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTypeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.Format))
            {
                throw new AmazonAppSyncException("Request object does not have required field Format set");
            }

            if (publicRequest.IsSetFormat())
            {
                request.Parameters.Add("format", StringUtils.FromString(publicRequest.Format));
            }

            if (!publicRequest.IsSetApiId())
            {
                throw new AmazonAppSyncException("Request object does not have required field ApiId set");
            }
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));

            if (!publicRequest.IsSetTypeName())
            {
                throw new AmazonAppSyncException("Request object does not have required field TypeName set");
            }
            request.AddPathResource("{typeName}", StringUtils.FromString(publicRequest.TypeName));

            request.ResourcePath = "/v1/apis/{apiId}/types/{typeName}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetTypeRequestMarshaller _instance = new();

        internal static GetTypeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTypeRequestMarshaller Instance => _instance;
    }
}
