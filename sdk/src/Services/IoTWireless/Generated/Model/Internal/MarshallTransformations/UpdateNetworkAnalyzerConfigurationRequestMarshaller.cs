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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNetworkAnalyzerConfiguration Request Marshaller
    /// </summary>       
    public class UpdateNetworkAnalyzerConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateNetworkAnalyzerConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNetworkAnalyzerConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNetworkAnalyzerConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetConfigurationName())
                throw new AmazonIoTWirelessException("Request object does not have required field ConfigurationName set");
            request.AddPathResource("{ConfigurationName}", StringUtils.FromString(publicRequest.ConfigurationName));
            request.ResourcePath = "/network-analyzer-configurations/{ConfigurationName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetMulticastGroupsToAdd())
                {
                    context.Writer.WritePropertyName("MulticastGroupsToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMulticastGroupsToAddListValue in publicRequest.MulticastGroupsToAdd)
                    {
                            context.Writer.Write(publicRequestMulticastGroupsToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMulticastGroupsToRemove())
                {
                    context.Writer.WritePropertyName("MulticastGroupsToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMulticastGroupsToRemoveListValue in publicRequest.MulticastGroupsToRemove)
                    {
                            context.Writer.Write(publicRequestMulticastGroupsToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTraceContent())
                {
                    context.Writer.WritePropertyName("TraceContent");
                    context.Writer.WriteObjectStart();

                    var marshaller = TraceContentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TraceContent, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWirelessDevicesToAdd())
                {
                    context.Writer.WritePropertyName("WirelessDevicesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWirelessDevicesToAddListValue in publicRequest.WirelessDevicesToAdd)
                    {
                            context.Writer.Write(publicRequestWirelessDevicesToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWirelessDevicesToRemove())
                {
                    context.Writer.WritePropertyName("WirelessDevicesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWirelessDevicesToRemoveListValue in publicRequest.WirelessDevicesToRemove)
                    {
                            context.Writer.Write(publicRequestWirelessDevicesToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWirelessGatewaysToAdd())
                {
                    context.Writer.WritePropertyName("WirelessGatewaysToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWirelessGatewaysToAddListValue in publicRequest.WirelessGatewaysToAdd)
                    {
                            context.Writer.Write(publicRequestWirelessGatewaysToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWirelessGatewaysToRemove())
                {
                    context.Writer.WritePropertyName("WirelessGatewaysToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWirelessGatewaysToRemoveListValue in publicRequest.WirelessGatewaysToRemove)
                    {
                            context.Writer.Write(publicRequestWirelessGatewaysToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateNetworkAnalyzerConfigurationRequestMarshaller _instance = new UpdateNetworkAnalyzerConfigurationRequestMarshaller();        

        internal static UpdateNetworkAnalyzerConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNetworkAnalyzerConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}