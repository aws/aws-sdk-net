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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
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
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCoreNetworkPolicy Request Marshaller
    /// </summary>       
    public class GetCoreNetworkPolicyRequestMarshaller : IMarshaller<IRequest, GetCoreNetworkPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCoreNetworkPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCoreNetworkPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCoreNetworkId())
                throw new AmazonNetworkManagerException("Request object does not have required field CoreNetworkId set");
            request.AddPathResource("{coreNetworkId}", StringUtils.FromString(publicRequest.CoreNetworkId));
            
            if (publicRequest.IsSetAlias())
                request.Parameters.Add("alias", StringUtils.FromString(publicRequest.Alias));
            
            if (publicRequest.IsSetPolicyVersionId())
                request.Parameters.Add("policyVersionId", StringUtils.FromInt(publicRequest.PolicyVersionId));
            request.ResourcePath = "/core-networks/{coreNetworkId}/core-network-policy";
            request.UseQueryString = true;

            return request;
        }
        private static GetCoreNetworkPolicyRequestMarshaller _instance = new GetCoreNetworkPolicyRequestMarshaller();        

        internal static GetCoreNetworkPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCoreNetworkPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}