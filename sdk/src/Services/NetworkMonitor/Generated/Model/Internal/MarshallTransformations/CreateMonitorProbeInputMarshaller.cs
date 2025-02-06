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
 * Do not modify this file. This file is generated from the networkmonitor-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMonitorProbeInput Marshaller
    /// </summary>
    public class CreateMonitorProbeInputMarshaller : IRequestMarshaller<CreateMonitorProbeInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateMonitorProbeInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStringValue(requestObject.Destination);
            }

            if(requestObject.IsSetDestinationPort())
            {
                context.Writer.WritePropertyName("destinationPort");
                context.Writer.WriteNumberValue(requestObject.DestinationPort.Value);
            }

            if(requestObject.IsSetPacketSize())
            {
                context.Writer.WritePropertyName("packetSize");
                context.Writer.WriteNumberValue(requestObject.PacketSize.Value);
            }

            if(requestObject.IsSetProbeTags())
            {
                context.Writer.WritePropertyName("probeTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectProbeTagsKvp in requestObject.ProbeTags)
                {
                    context.Writer.WritePropertyName(requestObjectProbeTagsKvp.Key);
                    var requestObjectProbeTagsValue = requestObjectProbeTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectProbeTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetSourceArn())
            {
                context.Writer.WritePropertyName("sourceArn");
                context.Writer.WriteStringValue(requestObject.SourceArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateMonitorProbeInputMarshaller Instance = new CreateMonitorProbeInputMarshaller();

    }
}