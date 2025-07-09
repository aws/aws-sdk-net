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
    /// MatterCapabilityReportEndpoint Marshaller
    /// </summary>
    public class MatterCapabilityReportEndpointMarshaller : IRequestMarshaller<MatterCapabilityReportEndpoint, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MatterCapabilityReportEndpoint requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClientClusters())
            {
                context.Writer.WritePropertyName("clientClusters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClientClustersListValue in requestObject.ClientClusters)
                {
                        context.Writer.WriteStringValue(requestObjectClientClustersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetClusters())
            {
                context.Writer.WritePropertyName("clusters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClustersListValue in requestObject.Clusters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MatterCapabilityReportClusterMarshaller.Instance;
                    marshaller.Marshall(requestObjectClustersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDeviceTypes())
            {
                context.Writer.WritePropertyName("deviceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDeviceTypesListValue in requestObject.DeviceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectDeviceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetParts())
            {
                context.Writer.WritePropertyName("parts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPartsListValue in requestObject.Parts)
                {
                        context.Writer.WriteStringValue(requestObjectPartsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSemanticTags())
            {
                context.Writer.WritePropertyName("semanticTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSemanticTagsListValue in requestObject.SemanticTags)
                {
                        context.Writer.WriteStringValue(requestObjectSemanticTagsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MatterCapabilityReportEndpointMarshaller Instance = new MatterCapabilityReportEndpointMarshaller();

    }
}