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
    /// UpdateFlowOutput Request Marshaller
    /// </summary>       
    public class UpdateFlowOutputRequestMarshaller : IMarshaller<IRequest, UpdateFlowOutputRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFlowOutputRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFlowOutputRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFlowArn())
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            request.AddPathResource("{FlowArn}", StringUtils.FromString(publicRequest.FlowArn));
            if (!publicRequest.IsSetOutputArn())
                throw new AmazonMediaConnectException("Request object does not have required field OutputArn set");
            request.AddPathResource("{OutputArn}", StringUtils.FromString(publicRequest.OutputArn));
            request.ResourcePath = "/v1/flows/{FlowArn}/outputs/{OutputArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCidrAllowList())
            {
                context.Writer.WritePropertyName("cidrAllowList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCidrAllowListListValue in publicRequest.CidrAllowList)
                {
                        context.Writer.WriteStringValue(publicRequestCidrAllowListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStringValue(publicRequest.Destination);
            }

            if(publicRequest.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteStartObject();

                var marshaller = UpdateEncryptionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Encryption, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxLatency())
            {
                context.Writer.WritePropertyName("maxLatency");
                context.Writer.WriteNumberValue(publicRequest.MaxLatency.Value);
            }

            if(publicRequest.IsSetMediaStreamOutputConfigurations())
            {
                context.Writer.WritePropertyName("mediaStreamOutputConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMediaStreamOutputConfigurationsListValue in publicRequest.MediaStreamOutputConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MediaStreamOutputConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestMediaStreamOutputConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMinLatency())
            {
                context.Writer.WritePropertyName("minLatency");
                context.Writer.WriteNumberValue(publicRequest.MinLatency.Value);
            }

            if(publicRequest.IsSetNdiProgramName())
            {
                context.Writer.WritePropertyName("ndiProgramName");
                context.Writer.WriteStringValue(publicRequest.NdiProgramName);
            }

            if(publicRequest.IsSetNdiSpeedHqQuality())
            {
                context.Writer.WritePropertyName("ndiSpeedHqQuality");
                context.Writer.WriteNumberValue(publicRequest.NdiSpeedHqQuality.Value);
            }

            if(publicRequest.IsSetOutputStatus())
            {
                context.Writer.WritePropertyName("outputStatus");
                context.Writer.WriteStringValue(publicRequest.OutputStatus);
            }

            if(publicRequest.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(publicRequest.Port.Value);
            }

            if(publicRequest.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(publicRequest.Protocol);
            }

            if(publicRequest.IsSetRemoteId())
            {
                context.Writer.WritePropertyName("remoteId");
                context.Writer.WriteStringValue(publicRequest.RemoteId);
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

            if(publicRequest.IsSetSmoothingLatency())
            {
                context.Writer.WritePropertyName("smoothingLatency");
                context.Writer.WriteNumberValue(publicRequest.SmoothingLatency.Value);
            }

            if(publicRequest.IsSetStreamId())
            {
                context.Writer.WritePropertyName("streamId");
                context.Writer.WriteStringValue(publicRequest.StreamId);
            }

            if(publicRequest.IsSetVpcInterfaceAttachment())
            {
                context.Writer.WritePropertyName("vpcInterfaceAttachment");
                context.Writer.WriteStartObject();

                var marshaller = VpcInterfaceAttachmentMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcInterfaceAttachment, context);

                context.Writer.WriteEndObject();
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
        private static UpdateFlowOutputRequestMarshaller _instance = new UpdateFlowOutputRequestMarshaller();        

        internal static UpdateFlowOutputRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFlowOutputRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}