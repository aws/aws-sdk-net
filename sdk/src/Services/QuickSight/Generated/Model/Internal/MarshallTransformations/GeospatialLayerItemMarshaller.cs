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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeospatialLayerItem Marshaller
    /// </summary>
    public class GeospatialLayerItemMarshaller : IRequestMarshaller<GeospatialLayerItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GeospatialLayerItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LayerCustomActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteStartObject();

                var marshaller = GeospatialDataSourceItemMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJoinDefinition())
            {
                context.Writer.WritePropertyName("JoinDefinition");
                context.Writer.WriteStartObject();

                var marshaller = GeospatialLayerJoinDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.JoinDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLabel())
            {
                context.Writer.WritePropertyName("Label");
                context.Writer.WriteStringValue(requestObject.Label);
            }

            if(requestObject.IsSetLayerDefinition())
            {
                context.Writer.WritePropertyName("LayerDefinition");
                context.Writer.WriteStartObject();

                var marshaller = GeospatialLayerDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.LayerDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLayerId())
            {
                context.Writer.WritePropertyName("LayerId");
                context.Writer.WriteStringValue(requestObject.LayerId);
            }

            if(requestObject.IsSetLayerType())
            {
                context.Writer.WritePropertyName("LayerType");
                context.Writer.WriteStringValue(requestObject.LayerType);
            }

            if(requestObject.IsSetTooltip())
            {
                context.Writer.WritePropertyName("Tooltip");
                context.Writer.WriteStartObject();

                var marshaller = TooltipOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Tooltip, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisibility())
            {
                context.Writer.WritePropertyName("Visibility");
                context.Writer.WriteStringValue(requestObject.Visibility);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GeospatialLayerItemMarshaller Instance = new GeospatialLayerItemMarshaller();

    }
}