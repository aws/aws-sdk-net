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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
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
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteFlowVersion Request Marshaller
    /// </summary>       
    public class DeleteFlowVersionRequestMarshaller : IMarshaller<IRequest, DeleteFlowVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteFlowVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteFlowVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetFlowIdentifier())
                throw new AmazonBedrockAgentException("Request object does not have required field FlowIdentifier set");
            request.AddPathResource("{flowIdentifier}", StringUtils.FromString(publicRequest.FlowIdentifier));
            if (!publicRequest.IsSetFlowVersion())
                throw new AmazonBedrockAgentException("Request object does not have required field FlowVersion set");
            request.AddPathResource("{flowVersion}", StringUtils.FromString(publicRequest.FlowVersion));
            
            if (publicRequest.IsSetSkipResourceInUseCheck())
                request.Parameters.Add("skipResourceInUseCheck", StringUtils.FromBool(publicRequest.SkipResourceInUseCheck));
            request.ResourcePath = "/flows/{flowIdentifier}/versions/{flowVersion}/";
            request.UseQueryString = true;

            return request;
        }
        private static DeleteFlowVersionRequestMarshaller _instance = new DeleteFlowVersionRequestMarshaller();        

        internal static DeleteFlowVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteFlowVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}