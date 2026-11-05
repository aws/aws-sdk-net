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

using Amazon.APIGateway.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteGatewayResponse Request Marshaller
    /// </summary>
    public partial class DeleteGatewayResponseRequestMarshaller : IMarshaller<IRequest, DeleteGatewayResponseRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteGatewayResponseRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteGatewayResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetResponseType())
            {
                throw new AmazonAPIGatewayException("Request object does not have required field ResponseType set");
            }
            request.AddPathResource("{responseType}", StringUtils.FromString(publicRequest.ResponseType));

            if (!publicRequest.IsSetRestApiId())
            {
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            }
            request.AddPathResource("{restApiId}", StringUtils.FromString(publicRequest.RestApiId));

            request.ResourcePath = "/restapis/{restApiId}/gatewayresponses/{responseType}";

            return request;
        }

        private static readonly DeleteGatewayResponseRequestMarshaller _instance = new();

        internal static DeleteGatewayResponseRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteGatewayResponseRequestMarshaller Instance => _instance;
    }
}
