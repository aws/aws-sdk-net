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
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGatewayCapabilityConfiguration Request Marshaller
    /// </summary>       
    public class UpdateGatewayCapabilityConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateGatewayCapabilityConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGatewayCapabilityConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGatewayCapabilityConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGatewayId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field GatewayId set");
            request.AddPathResource("{gatewayId}", StringUtils.FromString(publicRequest.GatewayId));
            request.ResourcePath = "/20200301/gateways/{gatewayId}/capability";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapabilityConfiguration())
                {
                    context.Writer.WritePropertyName("capabilityConfiguration");
                    context.Writer.Write(publicRequest.CapabilityConfiguration);
                }

                if(publicRequest.IsSetCapabilityNamespace())
                {
                    context.Writer.WritePropertyName("capabilityNamespace");
                    context.Writer.Write(publicRequest.CapabilityNamespace);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"edge.";

            return request;
        }
        private static UpdateGatewayCapabilityConfigurationRequestMarshaller _instance = new UpdateGatewayCapabilityConfigurationRequestMarshaller();        

        internal static UpdateGatewayCapabilityConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGatewayCapabilityConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}