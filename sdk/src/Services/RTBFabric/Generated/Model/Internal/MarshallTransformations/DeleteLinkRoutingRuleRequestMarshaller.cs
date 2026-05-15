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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RTBFabric.Model;
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
namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteLinkRoutingRule Request Marshaller
    /// </summary>       
    public class DeleteLinkRoutingRuleRequestMarshaller : IMarshaller<IRequest, DeleteLinkRoutingRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteLinkRoutingRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteLinkRoutingRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RTBFabric");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-15";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetGatewayId())
                throw new AmazonRTBFabricException("Request object does not have required field GatewayId set");
            request.AddPathResource("{gatewayId}", StringUtils.FromString(publicRequest.GatewayId));
            if (!publicRequest.IsSetLinkId())
                throw new AmazonRTBFabricException("Request object does not have required field LinkId set");
            request.AddPathResource("{linkId}", StringUtils.FromString(publicRequest.LinkId));
            if (!publicRequest.IsSetRuleId())
                throw new AmazonRTBFabricException("Request object does not have required field RuleId set");
            request.AddPathResource("{ruleId}", StringUtils.FromString(publicRequest.RuleId));
            request.ResourcePath = "/responder-gateway/{gatewayId}/link/{linkId}/routing-rule/{ruleId}";

            return request;
        }
        private static DeleteLinkRoutingRuleRequestMarshaller _instance = new DeleteLinkRoutingRuleRequestMarshaller();        

        internal static DeleteLinkRoutingRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteLinkRoutingRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}