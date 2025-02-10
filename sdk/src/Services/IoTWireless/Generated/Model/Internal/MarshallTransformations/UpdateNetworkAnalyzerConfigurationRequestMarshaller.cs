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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetMulticastGroupsToAdd())
            {
                context.Writer.WritePropertyName("MulticastGroupsToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMulticastGroupsToAddListValue in publicRequest.MulticastGroupsToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestMulticastGroupsToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMulticastGroupsToRemove())
            {
                context.Writer.WritePropertyName("MulticastGroupsToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMulticastGroupsToRemoveListValue in publicRequest.MulticastGroupsToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestMulticastGroupsToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTraceContent())
            {
                context.Writer.WritePropertyName("TraceContent");
                context.Writer.WriteStartObject();

                var marshaller = TraceContentMarshaller.Instance;
                marshaller.Marshall(publicRequest.TraceContent, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWirelessDevicesToAdd())
            {
                context.Writer.WritePropertyName("WirelessDevicesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWirelessDevicesToAddListValue in publicRequest.WirelessDevicesToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestWirelessDevicesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWirelessDevicesToRemove())
            {
                context.Writer.WritePropertyName("WirelessDevicesToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWirelessDevicesToRemoveListValue in publicRequest.WirelessDevicesToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestWirelessDevicesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWirelessGatewaysToAdd())
            {
                context.Writer.WritePropertyName("WirelessGatewaysToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWirelessGatewaysToAddListValue in publicRequest.WirelessGatewaysToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestWirelessGatewaysToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWirelessGatewaysToRemove())
            {
                context.Writer.WritePropertyName("WirelessGatewaysToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWirelessGatewaysToRemoveListValue in publicRequest.WirelessGatewaysToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestWirelessGatewaysToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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