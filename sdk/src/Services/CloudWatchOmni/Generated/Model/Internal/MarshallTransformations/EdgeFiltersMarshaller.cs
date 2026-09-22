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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EdgeFilters Marshaller
    /// </summary>
    public class EdgeFiltersMarshaller : IRequestMarshaller<EdgeFilters, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EdgeFilters requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetEdgeId())
            {
                context.Writer.WriteTextString("edgeId");
                context.Writer.WriteTextString(requestObject.EdgeId);
            }
            if (requestObject.IsSetEdgeType())
            {
                context.Writer.WriteTextString("edgeType");
                context.Writer.WriteTextString(requestObject.EdgeType);
            }
            if (requestObject.IsSetFrom())
            {
                context.Writer.WriteTextString("from");
                context.Writer.WriteTextString(requestObject.From);
            }
            if (requestObject.IsSetOperations())
            {
                context.Writer.WriteTextString("operations");
                context.Writer.WriteStartArray(requestObject.Operations.Count);
                foreach(var requestObjectOperationsListValue in requestObject.Operations)
                {
                        context.Writer.WriteTextString(requestObjectOperationsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSources())
            {
                context.Writer.WriteTextString("sources");
                context.Writer.WriteStartArray(requestObject.Sources.Count);
                foreach(var requestObjectSourcesListValue in requestObject.Sources)
                {
                        context.Writer.WriteTextString(requestObjectSourcesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTelemetryAttributes())
            {
                context.Writer.WriteTextString("telemetryAttributes");
                context.Writer.WriteStartArray(requestObject.TelemetryAttributes.Count);
                foreach(var requestObjectTelemetryAttributesListValue in requestObject.TelemetryAttributes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = KeyFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTelemetryAttributesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTo())
            {
                context.Writer.WriteTextString("to");
                context.Writer.WriteTextString(requestObject.To);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EdgeFiltersMarshaller Instance = new EdgeFiltersMarshaller();

    }
}