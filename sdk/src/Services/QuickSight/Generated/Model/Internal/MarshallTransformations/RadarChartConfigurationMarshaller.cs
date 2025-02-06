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
    /// RadarChartConfiguration Marshaller
    /// </summary>
    public class RadarChartConfigurationMarshaller : IRequestMarshaller<RadarChartConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RadarChartConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlternateBandColorsVisibility())
            {
                context.Writer.WritePropertyName("AlternateBandColorsVisibility");
                context.Writer.WriteStringValue(requestObject.AlternateBandColorsVisibility);
            }

            if(requestObject.IsSetAlternateBandEvenColor())
            {
                context.Writer.WritePropertyName("AlternateBandEvenColor");
                context.Writer.WriteStringValue(requestObject.AlternateBandEvenColor);
            }

            if(requestObject.IsSetAlternateBandOddColor())
            {
                context.Writer.WritePropertyName("AlternateBandOddColor");
                context.Writer.WriteStringValue(requestObject.AlternateBandOddColor);
            }

            if(requestObject.IsSetAxesRangeScale())
            {
                context.Writer.WritePropertyName("AxesRangeScale");
                context.Writer.WriteStringValue(requestObject.AxesRangeScale);
            }

            if(requestObject.IsSetBaseSeriesSettings())
            {
                context.Writer.WritePropertyName("BaseSeriesSettings");
                context.Writer.WriteStartObject();

                var marshaller = RadarChartSeriesSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.BaseSeriesSettings, context);

                context.Writer.WriteEndObject();
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

            if(requestObject.IsSetColorAxis())
            {
                context.Writer.WritePropertyName("ColorAxis");
                context.Writer.WriteStartObject();

                var marshaller = AxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorAxis, context);

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

                var marshaller = RadarChartFieldWellsMarshaller.Instance;
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

            if(requestObject.IsSetShape())
            {
                context.Writer.WritePropertyName("Shape");
                context.Writer.WriteStringValue(requestObject.Shape);
            }

            if(requestObject.IsSetSortConfiguration())
            {
                context.Writer.WritePropertyName("SortConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RadarChartSortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SortConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStartAngle())
            {
                context.Writer.WritePropertyName("StartAngle");
                if(StringUtils.IsSpecialDoubleValue(requestObject.StartAngle.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.StartAngle.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.StartAngle.Value);
                }
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
        public readonly static RadarChartConfigurationMarshaller Instance = new RadarChartConfigurationMarshaller();

    }
}