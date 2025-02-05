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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RejectInboundConnection Request Marshaller
    /// </summary>       
    public class RejectInboundConnectionRequestMarshaller : IMarshaller<IRequest, RejectInboundConnectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RejectInboundConnectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RejectInboundConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetConnectionId())
                throw new AmazonOpenSearchServiceException("Request object does not have required field ConnectionId set");
            request.AddPathResource("{ConnectionId}", StringUtils.FromString(publicRequest.ConnectionId));
            request.ResourcePath = "/2021-01-01/opensearch/cc/inboundConnection/{ConnectionId}/reject";

            return request;
        }
        private static RejectInboundConnectionRequestMarshaller _instance = new RejectInboundConnectionRequestMarshaller();        

        internal static RejectInboundConnectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RejectInboundConnectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}