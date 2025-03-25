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
    /// AddOutputRequest Marshaller
    /// </summary>
    public class AddOutputRequestMarshaller : IRequestMarshaller<AddOutputRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AddOutputRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCidrAllowList())
            {
                context.Writer.WritePropertyName("cidrAllowList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCidrAllowListListValue in requestObject.CidrAllowList)
                {
                        context.Writer.WriteStringValue(requestObjectCidrAllowListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStringValue(requestObject.Destination);
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxLatency())
            {
                context.Writer.WritePropertyName("maxLatency");
                context.Writer.WriteNumberValue(requestObject.MaxLatency.Value);
            }

            if(requestObject.IsSetMediaStreamOutputConfigurations())
            {
                context.Writer.WritePropertyName("mediaStreamOutputConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMediaStreamOutputConfigurationsListValue in requestObject.MediaStreamOutputConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MediaStreamOutputConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectMediaStreamOutputConfigurationsListValue, context);

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

            if(requestObject.IsSetNdiProgramName())
            {
                context.Writer.WritePropertyName("ndiProgramName");
                context.Writer.WriteStringValue(requestObject.NdiProgramName);
            }

            if(requestObject.IsSetNdiSpeedHqQuality())
            {
                context.Writer.WritePropertyName("ndiSpeedHqQuality");
                context.Writer.WriteNumberValue(requestObject.NdiSpeedHqQuality.Value);
            }

            if(requestObject.IsSetOutputStatus())
            {
                context.Writer.WritePropertyName("outputStatus");
                context.Writer.WriteStringValue(requestObject.OutputStatus);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetRemoteId())
            {
                context.Writer.WritePropertyName("remoteId");
                context.Writer.WriteStringValue(requestObject.RemoteId);
            }

            if(requestObject.IsSetSenderControlPort())
            {
                context.Writer.WritePropertyName("senderControlPort");
                context.Writer.WriteNumberValue(requestObject.SenderControlPort.Value);
            }

            if(requestObject.IsSetSmoothingLatency())
            {
                context.Writer.WritePropertyName("smoothingLatency");
                context.Writer.WriteNumberValue(requestObject.SmoothingLatency.Value);
            }

            if(requestObject.IsSetStreamId())
            {
                context.Writer.WritePropertyName("streamId");
                context.Writer.WriteStringValue(requestObject.StreamId);
            }

            if(requestObject.IsSetVpcInterfaceAttachment())
            {
                context.Writer.WritePropertyName("vpcInterfaceAttachment");
                context.Writer.WriteStartObject();

                var marshaller = VpcInterfaceAttachmentMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcInterfaceAttachment, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddOutputRequestMarshaller Instance = new AddOutputRequestMarshaller();

    }
}