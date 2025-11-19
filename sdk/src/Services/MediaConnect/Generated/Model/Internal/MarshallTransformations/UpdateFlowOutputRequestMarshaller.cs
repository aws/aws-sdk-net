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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCidrAllowList())
                {
                    context.Writer.WritePropertyName("cidrAllowList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCidrAllowListListValue in publicRequest.CidrAllowList)
                    {
                            context.Writer.Write(publicRequestCidrAllowListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDestination())
                {
                    context.Writer.WritePropertyName("destination");
                    context.Writer.Write(publicRequest.Destination);
                }

                if(publicRequest.IsSetEncryption())
                {
                    context.Writer.WritePropertyName("encryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Encryption, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxLatency())
                {
                    context.Writer.WritePropertyName("maxLatency");
                    context.Writer.Write(publicRequest.MaxLatency);
                }

                if(publicRequest.IsSetMediaStreamOutputConfigurations())
                {
                    context.Writer.WritePropertyName("mediaStreamOutputConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMediaStreamOutputConfigurationsListValue in publicRequest.MediaStreamOutputConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MediaStreamOutputConfigurationRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestMediaStreamOutputConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMinLatency())
                {
                    context.Writer.WritePropertyName("minLatency");
                    context.Writer.Write(publicRequest.MinLatency);
                }

                if(publicRequest.IsSetNdiProgramName())
                {
                    context.Writer.WritePropertyName("ndiProgramName");
                    context.Writer.Write(publicRequest.NdiProgramName);
                }

                if(publicRequest.IsSetNdiSpeedHqQuality())
                {
                    context.Writer.WritePropertyName("ndiSpeedHqQuality");
                    context.Writer.Write(publicRequest.NdiSpeedHqQuality);
                }

                if(publicRequest.IsSetOutputStatus())
                {
                    context.Writer.WritePropertyName("outputStatus");
                    context.Writer.Write(publicRequest.OutputStatus);
                }

                if(publicRequest.IsSetPort())
                {
                    context.Writer.WritePropertyName("port");
                    context.Writer.Write(publicRequest.Port);
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetRemoteId())
                {
                    context.Writer.WritePropertyName("remoteId");
                    context.Writer.Write(publicRequest.RemoteId);
                }

                if(publicRequest.IsSetRouterIntegrationState())
                {
                    context.Writer.WritePropertyName("routerIntegrationState");
                    context.Writer.Write(publicRequest.RouterIntegrationState);
                }

                if(publicRequest.IsSetRouterIntegrationTransitEncryption())
                {
                    context.Writer.WritePropertyName("routerIntegrationTransitEncryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = FlowTransitEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RouterIntegrationTransitEncryption, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSenderControlPort())
                {
                    context.Writer.WritePropertyName("senderControlPort");
                    context.Writer.Write(publicRequest.SenderControlPort);
                }

                if(publicRequest.IsSetSenderIpAddress())
                {
                    context.Writer.WritePropertyName("senderIpAddress");
                    context.Writer.Write(publicRequest.SenderIpAddress);
                }

                if(publicRequest.IsSetSmoothingLatency())
                {
                    context.Writer.WritePropertyName("smoothingLatency");
                    context.Writer.Write(publicRequest.SmoothingLatency);
                }

                if(publicRequest.IsSetStreamId())
                {
                    context.Writer.WritePropertyName("streamId");
                    context.Writer.Write(publicRequest.StreamId);
                }

                if(publicRequest.IsSetVpcInterfaceAttachment())
                {
                    context.Writer.WritePropertyName("vpcInterfaceAttachment");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcInterfaceAttachmentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcInterfaceAttachment, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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