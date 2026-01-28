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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDecryption())
                {
                    context.Writer.WritePropertyName("decryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Decryption, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEntitlementArn())
                {
                    context.Writer.WritePropertyName("entitlementArn");
                    context.Writer.Write(publicRequest.EntitlementArn);
                }

                if(publicRequest.IsSetGatewayBridgeSource())
                {
                    context.Writer.WritePropertyName("gatewayBridgeSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateGatewayBridgeSourceRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GatewayBridgeSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIngestPort())
                {
                    context.Writer.WritePropertyName("ingestPort");
                    context.Writer.Write(publicRequest.IngestPort);
                }

                if(publicRequest.IsSetMaxBitrate())
                {
                    context.Writer.WritePropertyName("maxBitrate");
                    context.Writer.Write(publicRequest.MaxBitrate);
                }

                if(publicRequest.IsSetMaxLatency())
                {
                    context.Writer.WritePropertyName("maxLatency");
                    context.Writer.Write(publicRequest.MaxLatency);
                }

                if(publicRequest.IsSetMaxSyncBuffer())
                {
                    context.Writer.WritePropertyName("maxSyncBuffer");
                    context.Writer.Write(publicRequest.MaxSyncBuffer);
                }

                if(publicRequest.IsSetMediaStreamSourceConfigurations())
                {
                    context.Writer.WritePropertyName("mediaStreamSourceConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMediaStreamSourceConfigurationsListValue in publicRequest.MediaStreamSourceConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MediaStreamSourceConfigurationRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestMediaStreamSourceConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMinLatency())
                {
                    context.Writer.WritePropertyName("minLatency");
                    context.Writer.Write(publicRequest.MinLatency);
                }

                if(publicRequest.IsSetNdiSourceSettings())
                {
                    context.Writer.WritePropertyName("ndiSourceSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = NdiSourceSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NdiSourceSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetRouterIntegrationState())
                {
                    context.Writer.WritePropertyName("routerIntegrationState");
                    context.Writer.Write(publicRequest.RouterIntegrationState);
                }

                if(publicRequest.IsSetRouterIntegrationTransitDecryption())
                {
                    context.Writer.WritePropertyName("routerIntegrationTransitDecryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = FlowTransitEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RouterIntegrationTransitDecryption, context);

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

                if(publicRequest.IsSetSourceListenerAddress())
                {
                    context.Writer.WritePropertyName("sourceListenerAddress");
                    context.Writer.Write(publicRequest.SourceListenerAddress);
                }

                if(publicRequest.IsSetSourceListenerPort())
                {
                    context.Writer.WritePropertyName("sourceListenerPort");
                    context.Writer.Write(publicRequest.SourceListenerPort);
                }

                if(publicRequest.IsSetStreamId())
                {
                    context.Writer.WritePropertyName("streamId");
                    context.Writer.Write(publicRequest.StreamId);
                }

                if(publicRequest.IsSetVpcInterfaceName())
                {
                    context.Writer.WritePropertyName("vpcInterfaceName");
                    context.Writer.Write(publicRequest.VpcInterfaceName);
                }

                if(publicRequest.IsSetWhitelistCidr())
                {
                    context.Writer.WritePropertyName("whitelistCidr");
                    context.Writer.Write(publicRequest.WhitelistCidr);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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