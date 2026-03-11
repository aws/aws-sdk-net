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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
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
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDurableExecutionHistory Request Marshaller
    /// </summary>       
    public class GetDurableExecutionHistoryRequestMarshaller : IMarshaller<IRequest, GetDurableExecutionHistoryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDurableExecutionHistoryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDurableExecutionHistoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDurableExecutionArn())
                throw new AmazonLambdaException("Request object does not have required field DurableExecutionArn set");
            request.AddPathResource("{DurableExecutionArn}", StringUtils.FromString(publicRequest.DurableExecutionArn));
            
            if (publicRequest.IsSetIncludeExecutionData())
                request.Parameters.Add("IncludeExecutionData", StringUtils.FromBool(publicRequest.IncludeExecutionData));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems));
            
            if (publicRequest.IsSetReverseOrder())
                request.Parameters.Add("ReverseOrder", StringUtils.FromBool(publicRequest.ReverseOrder));
            request.ResourcePath = "/2025-12-01/durable-executions/{DurableExecutionArn}/history";
            request.UseQueryString = true;

            return request;
        }
        private static GetDurableExecutionHistoryRequestMarshaller _instance = new GetDurableExecutionHistoryRequestMarshaller();        

        internal static GetDurableExecutionHistoryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDurableExecutionHistoryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}