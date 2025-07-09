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
    /// MatterCapabilityReport Marshaller
    /// </summary>
    public class MatterCapabilityReportMarshaller : IRequestMarshaller<MatterCapabilityReport, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MatterCapabilityReport requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEndpoints())
            {
                context.Writer.WritePropertyName("endpoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEndpointsListValue in requestObject.Endpoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MatterCapabilityReportEndpointMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNodeId())
            {
                context.Writer.WritePropertyName("nodeId");
                context.Writer.WriteStringValue(requestObject.NodeId);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MatterCapabilityReportMarshaller Instance = new MatterCapabilityReportMarshaller();

    }
}