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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeGatewayCapabilityConfiguration Request Marshaller
    /// </summary>       
    public class DescribeGatewayCapabilityConfigurationRequestMarshaller : IMarshaller<IRequest, DescribeGatewayCapabilityConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeGatewayCapabilityConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeGatewayCapabilityConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCapabilityNamespace())
                throw new AmazonIoTSiteWiseException("Request object does not have required field CapabilityNamespace set");
            request.AddPathResource("{capabilityNamespace}", StringUtils.FromString(publicRequest.CapabilityNamespace));
            if (!publicRequest.IsSetGatewayId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field GatewayId set");
            request.AddPathResource("{gatewayId}", StringUtils.FromString(publicRequest.GatewayId));
            request.ResourcePath = "/20200301/gateways/{gatewayId}/capability/{capabilityNamespace}";
            
            request.HostPrefix = $"api.";

            return request;
        }
        private static DescribeGatewayCapabilityConfigurationRequestMarshaller _instance = new DescribeGatewayCapabilityConfigurationRequestMarshaller();        

        internal static DescribeGatewayCapabilityConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeGatewayCapabilityConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}