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
    /// ComboChartConfiguration Marshaller
    /// </summary>
    public class ComboChartConfigurationMarshaller : IRequestMarshaller<ComboChartConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComboChartConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBarDataLabels())
            {
                context.Writer.WritePropertyName("BarDataLabels");
                context.Writer.WriteStartObject();

                var marshaller = DataLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.BarDataLabels, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBarsArrangement())
            {
                context.Writer.WritePropertyName("BarsArrangement");
                context.Writer.WriteStringValue(requestObject.BarsArrangement);
            }

            if(requestObject.IsSetCategoryAxis())
            {
                context.Writer.WritePropertyName("CategoryAxis");
                context.Writer.WriteStartObject();

                var marshaller = AxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryAxis, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCategoryLabelOptions())
            {
                context.Writer.WritePropertyName("CategoryLabelOptions");
                context.Writer.WriteStartObject();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryLabelOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetColorLabelOptions())
            {
                context.Writer.WritePropertyName("ColorLabelOptions");
                context.Writer.WriteStartObject();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorLabelOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFieldWells())
            {
                context.Writer.WritePropertyName("FieldWells");
                context.Writer.WriteStartObject();

                var marshaller = ComboChartFieldWellsMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldWells, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInteractions())
            {
                context.Writer.WritePropertyName("Interactions");
                context.Writer.WriteStartObject();

                var marshaller = VisualInteractionOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Interactions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLegend())
            {
                context.Writer.WritePropertyName("Legend");
                context.Writer.WriteStartObject();

                var marshaller = LegendOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Legend, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLineDataLabels())
            {
                context.Writer.WritePropertyName("LineDataLabels");
                context.Writer.WriteStartObject();

                var marshaller = DataLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.LineDataLabels, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrimaryYAxisDisplayOptions())
            {
                context.Writer.WritePropertyName("PrimaryYAxisDisplayOptions");
                context.Writer.WriteStartObject();

                var marshaller = AxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryYAxisDisplayOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrimaryYAxisLabelOptions())
            {
                context.Writer.WritePropertyName("PrimaryYAxisLabelOptions");
                context.Writer.WriteStartObject();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryYAxisLabelOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReferenceLines())
            {
                context.Writer.WritePropertyName("ReferenceLines");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReferenceLinesListValue in requestObject.ReferenceLines)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReferenceLineMarshaller.Instance;
                    marshaller.Marshall(requestObjectReferenceLinesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecondaryYAxisDisplayOptions())
            {
                context.Writer.WritePropertyName("SecondaryYAxisDisplayOptions");
                context.Writer.WriteStartObject();

                var marshaller = AxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SecondaryYAxisDisplayOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecondaryYAxisLabelOptions())
            {
                context.Writer.WritePropertyName("SecondaryYAxisLabelOptions");
                context.Writer.WriteStartObject();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SecondaryYAxisLabelOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSingleAxisOptions())
            {
                context.Writer.WritePropertyName("SingleAxisOptions");
                context.Writer.WriteStartObject();

                var marshaller = SingleAxisOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SingleAxisOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSortConfiguration())
            {
                context.Writer.WritePropertyName("SortConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ComboChartSortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SortConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTooltip())
            {
                context.Writer.WritePropertyName("Tooltip");
                context.Writer.WriteStartObject();

                var marshaller = TooltipOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Tooltip, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisualPalette())
            {
                context.Writer.WritePropertyName("VisualPalette");
                context.Writer.WriteStartObject();

                var marshaller = VisualPaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualPalette, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComboChartConfigurationMarshaller Instance = new ComboChartConfigurationMarshaller();

    }
}