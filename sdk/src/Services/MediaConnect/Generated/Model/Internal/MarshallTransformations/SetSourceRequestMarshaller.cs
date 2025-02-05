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
                context.Writer.WriteStartObject();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Decryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetEntitlementArn())
            {
                context.Writer.WritePropertyName("entitlementArn");
                context.Writer.WriteStringValue(requestObject.EntitlementArn);
            }

            if(requestObject.IsSetGatewayBridgeSource())
            {
                context.Writer.WritePropertyName("gatewayBridgeSource");
                context.Writer.WriteStartObject();

                var marshaller = SetGatewayBridgeSourceRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.GatewayBridgeSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIngestPort())
            {
                context.Writer.WritePropertyName("ingestPort");
                context.Writer.WriteNumberValue(requestObject.IngestPort.Value);
            }

            if(requestObject.IsSetMaxBitrate())
            {
                context.Writer.WritePropertyName("maxBitrate");
                context.Writer.WriteNumberValue(requestObject.MaxBitrate.Value);
            }

            if(requestObject.IsSetMaxLatency())
            {
                context.Writer.WritePropertyName("maxLatency");
                context.Writer.WriteNumberValue(requestObject.MaxLatency.Value);
            }

            if(requestObject.IsSetMaxSyncBuffer())
            {
                context.Writer.WritePropertyName("maxSyncBuffer");
                context.Writer.WriteNumberValue(requestObject.MaxSyncBuffer.Value);
            }

            if(requestObject.IsSetMediaStreamSourceConfigurations())
            {
                context.Writer.WritePropertyName("mediaStreamSourceConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMediaStreamSourceConfigurationsListValue in requestObject.MediaStreamSourceConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MediaStreamSourceConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectMediaStreamSourceConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMinLatency())
            {
                context.Writer.WritePropertyName("minLatency");
                context.Writer.WriteNumberValue(requestObject.MinLatency.Value);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetSenderControlPort())
            {
                context.Writer.WritePropertyName("senderControlPort");
                context.Writer.WriteNumberValue(requestObject.SenderControlPort.Value);
            }

            if(requestObject.IsSetSenderIpAddress())
            {
                context.Writer.WritePropertyName("senderIpAddress");
                context.Writer.WriteStringValue(requestObject.SenderIpAddress);
            }

            if(requestObject.IsSetSourceListenerAddress())
            {
                context.Writer.WritePropertyName("sourceListenerAddress");
                context.Writer.WriteStringValue(requestObject.SourceListenerAddress);
            }

            if(requestObject.IsSetSourceListenerPort())
            {
                context.Writer.WritePropertyName("sourceListenerPort");
                context.Writer.WriteNumberValue(requestObject.SourceListenerPort.Value);
            }

            if(requestObject.IsSetStreamId())
            {
                context.Writer.WritePropertyName("streamId");
                context.Writer.WriteStringValue(requestObject.StreamId);
            }

            if(requestObject.IsSetVpcInterfaceName())
            {
                context.Writer.WritePropertyName("vpcInterfaceName");
                context.Writer.WriteStringValue(requestObject.VpcInterfaceName);
            }

            if(requestObject.IsSetWhitelistCidr())
            {
                context.Writer.WritePropertyName("whitelistCidr");
                context.Writer.WriteStringValue(requestObject.WhitelistCidr);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SetSourceRequestMarshaller Instance = new SetSourceRequestMarshaller();

    }
}