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
    /// SetSourceRequest Marshaller
    /// </summary>
    public class SetSourceRequestMarshaller : IRequestMarshaller<SetSourceRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SetSourceRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDecryption())
            {
                context.Writer.WritePropertyName("decryption");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Decryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEntitlementArn())
            {
                context.Writer.WritePropertyName("entitlementArn");
                context.Writer.Write(requestObject.EntitlementArn);
            }

            if(requestObject.IsSetGatewayBridgeSource())
            {
                context.Writer.WritePropertyName("gatewayBridgeSource");
                context.Writer.WriteObjectStart();

                var marshaller = SetGatewayBridgeSourceRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.GatewayBridgeSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIngestPort())
            {
                context.Writer.WritePropertyName("ingestPort");
                context.Writer.Write(requestObject.IngestPort);
            }

            if(requestObject.IsSetMaxBitrate())
            {
                context.Writer.WritePropertyName("maxBitrate");
                context.Writer.Write(requestObject.MaxBitrate);
            }

            if(requestObject.IsSetMaxLatency())
            {
                context.Writer.WritePropertyName("maxLatency");
                context.Writer.Write(requestObject.MaxLatency);
            }

            if(requestObject.IsSetMaxSyncBuffer())
            {
                context.Writer.WritePropertyName("maxSyncBuffer");
                context.Writer.Write(requestObject.MaxSyncBuffer);
            }

            if(requestObject.IsSetMediaStreamSourceConfigurations())
            {
                context.Writer.WritePropertyName("mediaStreamSourceConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMediaStreamSourceConfigurationsListValue in requestObject.MediaStreamSourceConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MediaStreamSourceConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectMediaStreamSourceConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMinLatency())
            {
                context.Writer.WritePropertyName("minLatency");
                context.Writer.Write(requestObject.MinLatency);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.Write(requestObject.Protocol);
            }

            if(requestObject.IsSetRouterIntegrationState())
            {
                context.Writer.WritePropertyName("routerIntegrationState");
                context.Writer.Write(requestObject.RouterIntegrationState);
            }

            if(requestObject.IsSetRouterIntegrationTransitDecryption())
            {
                context.Writer.WritePropertyName("routerIntegrationTransitDecryption");
                context.Writer.WriteObjectStart();

                var marshaller = FlowTransitEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.RouterIntegrationTransitDecryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSenderControlPort())
            {
                context.Writer.WritePropertyName("senderControlPort");
                context.Writer.Write(requestObject.SenderControlPort);
            }

            if(requestObject.IsSetSenderIpAddress())
            {
                context.Writer.WritePropertyName("senderIpAddress");
                context.Writer.Write(requestObject.SenderIpAddress);
            }

            if(requestObject.IsSetSourceListenerAddress())
            {
                context.Writer.WritePropertyName("sourceListenerAddress");
                context.Writer.Write(requestObject.SourceListenerAddress);
            }

            if(requestObject.IsSetSourceListenerPort())
            {
                context.Writer.WritePropertyName("sourceListenerPort");
                context.Writer.Write(requestObject.SourceListenerPort);
            }

            if(requestObject.IsSetSourceTags())
            {
                context.Writer.WritePropertyName("sourceTags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSourceTagsKvp in requestObject.SourceTags)
                {
                    context.Writer.WritePropertyName(requestObjectSourceTagsKvp.Key);
                    var requestObjectSourceTagsValue = requestObjectSourceTagsKvp.Value;

                        context.Writer.Write(requestObjectSourceTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStreamId())
            {
                context.Writer.WritePropertyName("streamId");
                context.Writer.Write(requestObject.StreamId);
            }

            if(requestObject.IsSetVpcInterfaceName())
            {
                context.Writer.WritePropertyName("vpcInterfaceName");
                context.Writer.Write(requestObject.VpcInterfaceName);
            }

            if(requestObject.IsSetWhitelistCidr())
            {
                context.Writer.WritePropertyName("whitelistCidr");
                context.Writer.Write(requestObject.WhitelistCidr);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SetSourceRequestMarshaller Instance = new SetSourceRequestMarshaller();

    }
}