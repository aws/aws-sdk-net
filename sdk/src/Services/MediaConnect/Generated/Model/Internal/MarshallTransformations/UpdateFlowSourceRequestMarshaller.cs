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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
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
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFlowSource Request Marshaller
    /// </summary>       
    public class UpdateFlowSourceRequestMarshaller : IMarshaller<IRequest, UpdateFlowSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFlowSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFlowSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFlowArn())
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            request.AddPathResource("{FlowArn}", StringUtils.FromString(publicRequest.FlowArn));
            if (!publicRequest.IsSetSourceArn())
                throw new AmazonMediaConnectException("Request object does not have required field SourceArn set");
            request.AddPathResource("{SourceArn}", StringUtils.FromString(publicRequest.SourceArn));
            request.ResourcePath = "/v1/flows/{FlowArn}/source/{SourceArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDecryption())
            {
                context.Writer.WritePropertyName("decryption");
                context.Writer.WriteStartObject();

                var marshaller = UpdateEncryptionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Decryption, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEntitlementArn())
            {
                context.Writer.WritePropertyName("entitlementArn");
                context.Writer.WriteStringValue(publicRequest.EntitlementArn);
            }

            if(publicRequest.IsSetGatewayBridgeSource())
            {
                context.Writer.WritePropertyName("gatewayBridgeSource");
                context.Writer.WriteStartObject();

                var marshaller = UpdateGatewayBridgeSourceRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.GatewayBridgeSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIngestPort())
            {
                context.Writer.WritePropertyName("ingestPort");
                context.Writer.WriteNumberValue(publicRequest.IngestPort.Value);
            }

            if(publicRequest.IsSetMaxBitrate())
            {
                context.Writer.WritePropertyName("maxBitrate");
                context.Writer.WriteNumberValue(publicRequest.MaxBitrate.Value);
            }

            if(publicRequest.IsSetMaxLatency())
            {
                context.Writer.WritePropertyName("maxLatency");
                context.Writer.WriteNumberValue(publicRequest.MaxLatency.Value);
            }

            if(publicRequest.IsSetMaxSyncBuffer())
            {
                context.Writer.WritePropertyName("maxSyncBuffer");
                context.Writer.WriteNumberValue(publicRequest.MaxSyncBuffer.Value);
            }

            if(publicRequest.IsSetMediaStreamSourceConfigurations())
            {
                context.Writer.WritePropertyName("mediaStreamSourceConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMediaStreamSourceConfigurationsListValue in publicRequest.MediaStreamSourceConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MediaStreamSourceConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestMediaStreamSourceConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMinLatency())
            {
                context.Writer.WritePropertyName("minLatency");
                context.Writer.WriteNumberValue(publicRequest.MinLatency.Value);
            }

            if(publicRequest.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(publicRequest.Protocol);
            }

            if(publicRequest.IsSetSenderControlPort())
            {
                context.Writer.WritePropertyName("senderControlPort");
                context.Writer.WriteNumberValue(publicRequest.SenderControlPort.Value);
            }

            if(publicRequest.IsSetSenderIpAddress())
            {
                context.Writer.WritePropertyName("senderIpAddress");
                context.Writer.WriteStringValue(publicRequest.SenderIpAddress);
            }

            if(publicRequest.IsSetSourceListenerAddress())
            {
                context.Writer.WritePropertyName("sourceListenerAddress");
                context.Writer.WriteStringValue(publicRequest.SourceListenerAddress);
            }

            if(publicRequest.IsSetSourceListenerPort())
            {
                context.Writer.WritePropertyName("sourceListenerPort");
                context.Writer.WriteNumberValue(publicRequest.SourceListenerPort.Value);
            }

            if(publicRequest.IsSetStreamId())
            {
                context.Writer.WritePropertyName("streamId");
                context.Writer.WriteStringValue(publicRequest.StreamId);
            }

            if(publicRequest.IsSetVpcInterfaceName())
            {
                context.Writer.WritePropertyName("vpcInterfaceName");
                context.Writer.WriteStringValue(publicRequest.VpcInterfaceName);
            }

            if(publicRequest.IsSetWhitelistCidr())
            {
                context.Writer.WritePropertyName("whitelistCidr");
                context.Writer.WriteStringValue(publicRequest.WhitelistCidr);
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
        private static UpdateFlowSourceRequestMarshaller _instance = new UpdateFlowSourceRequestMarshaller();        

        internal static UpdateFlowSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFlowSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}