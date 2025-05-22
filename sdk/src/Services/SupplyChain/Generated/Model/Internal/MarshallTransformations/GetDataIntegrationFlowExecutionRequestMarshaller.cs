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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SupplyChain.Model;
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
namespace Amazon.SupplyChain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDataIntegrationFlowExecution Request Marshaller
    /// </summary>       
    public class GetDataIntegrationFlowExecutionRequestMarshaller : IMarshaller<IRequest, GetDataIntegrationFlowExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDataIntegrationFlowExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDataIntegrationFlowExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SupplyChain");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-01-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetExecutionId())
                throw new AmazonSupplyChainException("Request object does not have required field ExecutionId set");
            request.AddPathResource("{executionId}", StringUtils.FromString(publicRequest.ExecutionId));
            if (!publicRequest.IsSetFlowName())
                throw new AmazonSupplyChainException("Request object does not have required field FlowName set");
            request.AddPathResource("{flowName}", StringUtils.FromString(publicRequest.FlowName));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonSupplyChainException("Request object does not have required field InstanceId set");
            request.AddPathResource("{instanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/api-data/data-integration/instance/{instanceId}/data-integration-flows/{flowName}/executions/{executionId}";

            return request;
        }
        private static GetDataIntegrationFlowExecutionRequestMarshaller _instance = new GetDataIntegrationFlowExecutionRequestMarshaller();        

        internal static GetDataIntegrationFlowExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDataIntegrationFlowExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}