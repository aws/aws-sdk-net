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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MatterCluster Marshaller
    /// </summary>
    public class MatterClusterMarshaller : IRequestMarshaller<MatterCluster, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MatterCluster requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.Attributes);
            }

            if(requestObject.IsSetCommands())
            {
                context.Writer.WritePropertyName("commands");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCommandsKvp in requestObject.Commands)
                {
                    context.Writer.WritePropertyName(requestObjectCommandsKvp.Key);
                    var requestObjectCommandsValue = requestObjectCommandsKvp.Value;

                    Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObjectCommandsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEvents())
            {
                context.Writer.WritePropertyName("events");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEventsKvp in requestObject.Events)
                {
                    context.Writer.WritePropertyName(requestObjectEventsKvp.Key);
                    var requestObjectEventsValue = requestObjectEventsKvp.Value;

                    Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObjectEventsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MatterClusterMarshaller Instance = new MatterClusterMarshaller();

    }
}