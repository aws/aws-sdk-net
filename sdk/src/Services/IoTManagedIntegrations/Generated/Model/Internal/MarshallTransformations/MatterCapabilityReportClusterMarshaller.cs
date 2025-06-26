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
    /// MatterCapabilityReportCluster Marshaller
    /// </summary>
    public class MatterCapabilityReportClusterMarshaller : IRequestMarshaller<MatterCapabilityReportCluster, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MatterCapabilityReportCluster requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributesListValue in requestObject.Attributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MatterCapabilityReportAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCommands())
            {
                context.Writer.WritePropertyName("commands");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommandsListValue in requestObject.Commands)
                {
                        context.Writer.WriteStringValue(requestObjectCommandsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEvents())
            {
                context.Writer.WritePropertyName("events");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventsListValue in requestObject.Events)
                {
                        context.Writer.WriteStringValue(requestObjectEventsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFabricIndex())
            {
                context.Writer.WritePropertyName("fabricIndex");
                context.Writer.WriteNumberValue(requestObject.FabricIndex.Value);
            }

            if(requestObject.IsSetFeatureMap())
            {
                context.Writer.WritePropertyName("featureMap");
                context.Writer.WriteNumberValue(requestObject.FeatureMap.Value);
            }

            if(requestObject.IsSetGeneratedCommands())
            {
                context.Writer.WritePropertyName("generatedCommands");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGeneratedCommandsListValue in requestObject.GeneratedCommands)
                {
                        context.Writer.WriteStringValue(requestObjectGeneratedCommandsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPublicId())
            {
                context.Writer.WritePropertyName("publicId");
                context.Writer.WriteStringValue(requestObject.PublicId);
            }

            if(requestObject.IsSetRevision())
            {
                context.Writer.WritePropertyName("revision");
                context.Writer.WriteNumberValue(requestObject.Revision.Value);
            }

            if(requestObject.IsSetSpecVersion())
            {
                context.Writer.WritePropertyName("specVersion");
                context.Writer.WriteStringValue(requestObject.SpecVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MatterCapabilityReportClusterMarshaller Instance = new MatterCapabilityReportClusterMarshaller();

    }
}