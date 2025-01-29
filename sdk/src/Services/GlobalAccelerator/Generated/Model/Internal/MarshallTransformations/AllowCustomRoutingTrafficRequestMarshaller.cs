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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlobalAccelerator.Model;
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
namespace Amazon.GlobalAccelerator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AllowCustomRoutingTraffic Request Marshaller
    /// </summary>       
    public class AllowCustomRoutingTrafficRequestMarshaller : IMarshaller<IRequest, AllowCustomRoutingTrafficRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AllowCustomRoutingTrafficRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AllowCustomRoutingTrafficRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GlobalAccelerator");
            string target = "GlobalAccelerator_V20180706.AllowCustomRoutingTraffic";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowAllTrafficToEndpoint())
            {
                context.Writer.WritePropertyName("AllowAllTrafficToEndpoint");
                context.Writer.WriteBooleanValue(publicRequest.AllowAllTrafficToEndpoint.Value);
            }

            if(publicRequest.IsSetDestinationAddresses())
            {
                context.Writer.WritePropertyName("DestinationAddresses");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDestinationAddressesListValue in publicRequest.DestinationAddresses)
                {
                        context.Writer.WriteStringValue(publicRequestDestinationAddressesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDestinationPorts())
            {
                context.Writer.WritePropertyName("DestinationPorts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDestinationPortsListValue in publicRequest.DestinationPorts)
                {
                        context.Writer.WriteNumberValue(publicRequestDestinationPortsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEndpointGroupArn())
            {
                context.Writer.WritePropertyName("EndpointGroupArn");
                context.Writer.WriteStringValue(publicRequest.EndpointGroupArn);
            }

            if(publicRequest.IsSetEndpointId())
            {
                context.Writer.WritePropertyName("EndpointId");
                context.Writer.WriteStringValue(publicRequest.EndpointId);
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
        private static AllowCustomRoutingTrafficRequestMarshaller _instance = new AllowCustomRoutingTrafficRequestMarshaller();        

        internal static AllowCustomRoutingTrafficRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AllowCustomRoutingTrafficRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}