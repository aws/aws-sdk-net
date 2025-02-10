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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
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
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetQuery Request Marshaller
    /// </summary>       
    public class GetQueryRequestMarshaller : IMarshaller<IRequest, GetQueryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetQueryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetQueryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetQueryId())
                throw new AmazonNeptuneGraphException("Request object does not have required field QueryId set");
            request.AddPathResource("{queryId}", StringUtils.FromString(publicRequest.QueryId));
            request.ResourcePath = "/queries/{queryId}";
        
            if (publicRequest.IsSetGraphIdentifier()) 
            {
                request.Headers["graphIdentifier"] = publicRequest.GraphIdentifier;
            }

            var hostPrefixLabels = new
            {
                graphIdentifier = StringUtils.FromString(publicRequest.GraphIdentifier),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.graphIdentifier))
                throw new AmazonNeptuneGraphException("graphIdentifier can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"{hostPrefixLabels.graphIdentifier}.";

            return request;
        }
        private static GetQueryRequestMarshaller _instance = new GetQueryRequestMarshaller();        

        internal static GetQueryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetQueryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}