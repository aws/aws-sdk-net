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

using Amazon.LambdaWeb.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LambdaWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetWebFunctionEndpoint Request Marshaller
    /// </summary>
    public partial class GetWebFunctionEndpointRequestMarshaller : IMarshaller<IRequest, GetWebFunctionEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetWebFunctionEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetWebFunctionEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LambdaWeb");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-07";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetEndpointName())
            {
                throw new AmazonLambdaWebException("Request object does not have required field EndpointName set");
            }
            request.AddPathResource("{endpointName}", StringUtils.FromString(publicRequest.EndpointName));

            if (!publicRequest.IsSetFunctionName())
            {
                throw new AmazonLambdaWebException("Request object does not have required field FunctionName set");
            }
            request.AddPathResource("{functionName}", StringUtils.FromString(publicRequest.FunctionName));

            request.ResourcePath = "/2025-03-07/web-functions/{functionName}/endpoints/{endpointName}";

            return request;
        }

        private static readonly GetWebFunctionEndpointRequestMarshaller _instance = new();

        internal static GetWebFunctionEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetWebFunctionEndpointRequestMarshaller Instance => _instance;
    }
}
