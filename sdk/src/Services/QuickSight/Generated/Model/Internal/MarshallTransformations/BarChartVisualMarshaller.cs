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
    /// BarChartVisual Marshaller
    /// </summary>
    public class BarChartVisualMarshaller : IRequestMarshaller<BarChartVisual, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BarChartVisual requestObject, JsonMarshallerContext context)
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

                    var marshaller = VisualCustomActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetChartConfiguration())
            {
                context.Writer.WritePropertyName("ChartConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BarChartConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ChartConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetColumnHierarchies())
            {
                context.Writer.WritePropertyName("ColumnHierarchies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectColumnHierarchiesListValue in requestObject.ColumnHierarchies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ColumnHierarchyMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnHierarchiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubtitle())
            {
                context.Writer.WritePropertyName("Subtitle");
                context.Writer.WriteStartObject();

                var marshaller = VisualSubtitleLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Subtitle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStartObject();

                var marshaller = VisualTitleLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Title, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisualContentAltText())
            {
                context.Writer.WritePropertyName("VisualContentAltText");
                context.Writer.WriteStringValue(requestObject.VisualContentAltText);
            }

            if(requestObject.IsSetVisualId())
            {
                context.Writer.WritePropertyName("VisualId");
                context.Writer.WriteStringValue(requestObject.VisualId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BarChartVisualMarshaller Instance = new BarChartVisualMarshaller();

    }
}