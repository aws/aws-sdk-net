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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
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
namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNetworkProfile Request Marshaller
    /// </summary>       
    public class UpdateNetworkProfileRequestMarshaller : IMarshaller<IRequest, UpdateNetworkProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNetworkProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNetworkProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DeviceFarm");
            string target = "DeviceFarm_20150623.UpdateNetworkProfile";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-06-23";
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
            if(publicRequest.IsSetArn())
            {
                context.Writer.WritePropertyName("arn");
                context.Writer.WriteStringValue(publicRequest.Arn);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDownlinkBandwidthBits())
            {
                context.Writer.WritePropertyName("downlinkBandwidthBits");
                context.Writer.WriteNumberValue(publicRequest.DownlinkBandwidthBits.Value);
            }

            if(publicRequest.IsSetDownlinkDelayMs())
            {
                context.Writer.WritePropertyName("downlinkDelayMs");
                context.Writer.WriteNumberValue(publicRequest.DownlinkDelayMs.Value);
            }

            if(publicRequest.IsSetDownlinkJitterMs())
            {
                context.Writer.WritePropertyName("downlinkJitterMs");
                context.Writer.WriteNumberValue(publicRequest.DownlinkJitterMs.Value);
            }

            if(publicRequest.IsSetDownlinkLossPercent())
            {
                context.Writer.WritePropertyName("downlinkLossPercent");
                context.Writer.WriteNumberValue(publicRequest.DownlinkLossPercent.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            if(publicRequest.IsSetUplinkBandwidthBits())
            {
                context.Writer.WritePropertyName("uplinkBandwidthBits");
                context.Writer.WriteNumberValue(publicRequest.UplinkBandwidthBits.Value);
            }

            if(publicRequest.IsSetUplinkDelayMs())
            {
                context.Writer.WritePropertyName("uplinkDelayMs");
                context.Writer.WriteNumberValue(publicRequest.UplinkDelayMs.Value);
            }

            if(publicRequest.IsSetUplinkJitterMs())
            {
                context.Writer.WritePropertyName("uplinkJitterMs");
                context.Writer.WriteNumberValue(publicRequest.UplinkJitterMs.Value);
            }

            if(publicRequest.IsSetUplinkLossPercent())
            {
                context.Writer.WritePropertyName("uplinkLossPercent");
                context.Writer.WriteNumberValue(publicRequest.UplinkLossPercent.Value);
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
        private static UpdateNetworkProfileRequestMarshaller _instance = new UpdateNetworkProfileRequestMarshaller();        

        internal static UpdateNetworkProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNetworkProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}