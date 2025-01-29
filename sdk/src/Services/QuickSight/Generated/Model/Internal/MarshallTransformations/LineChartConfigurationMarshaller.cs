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
    /// LineChartConfiguration Marshaller
    /// </summary>
    public class LineChartConfigurationMarshaller : IRequestMarshaller<LineChartConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LineChartConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContributionAnalysisDefaults())
            {
                context.Writer.WritePropertyName("ContributionAnalysisDefaults");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContributionAnalysisDefaultsListValue in requestObject.ContributionAnalysisDefaults)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContributionAnalysisDefaultMarshaller.Instance;
                    marshaller.Marshall(requestObjectContributionAnalysisDefaultsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataLabels())
            {
                context.Writer.WritePropertyName("DataLabels");
                context.Writer.WriteStartObject();

                var marshaller = DataLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataLabels, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultSeriesSettings())
            {
                context.Writer.WritePropertyName("DefaultSeriesSettings");
                context.Writer.WriteStartObject();

                var marshaller = LineChartDefaultSeriesSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultSeriesSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFieldWells())
            {
                context.Writer.WritePropertyName("FieldWells");
                context.Writer.WriteStartObject();

                var marshaller = LineChartFieldWellsMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldWells, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetForecastConfigurations())
            {
                context.Writer.WritePropertyName("ForecastConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectForecastConfigurationsListValue in requestObject.ForecastConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ForecastConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectForecastConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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

            if(requestObject.IsSetPrimaryYAxisDisplayOptions())
            {
                context.Writer.WritePropertyName("PrimaryYAxisDisplayOptions");
                context.Writer.WriteStartObject();

                var marshaller = LineSeriesAxisDisplayOptionsMarshaller.Instance;
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

                var marshaller = LineSeriesAxisDisplayOptionsMarshaller.Instance;
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

            if(requestObject.IsSetSeries())
            {
                context.Writer.WritePropertyName("Series");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSeriesListValue in requestObject.Series)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SeriesItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSingleAxisOptions())
            {
                context.Writer.WritePropertyName("SingleAxisOptions");
                context.Writer.WriteStartObject();

                var marshaller = SingleAxisOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SingleAxisOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSmallMultiplesOptions())
            {
                context.Writer.WritePropertyName("SmallMultiplesOptions");
                context.Writer.WriteStartObject();

                var marshaller = SmallMultiplesOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SmallMultiplesOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSortConfiguration())
            {
                context.Writer.WritePropertyName("SortConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LineChartSortConfigurationMarshaller.Instance;
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

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetVisualPalette())
            {
                context.Writer.WritePropertyName("VisualPalette");
                context.Writer.WriteStartObject();

                var marshaller = VisualPaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualPalette, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetXAxisDisplayOptions())
            {
                context.Writer.WritePropertyName("XAxisDisplayOptions");
                context.Writer.WriteStartObject();

                var marshaller = AxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.XAxisDisplayOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetXAxisLabelOptions())
            {
                context.Writer.WritePropertyName("XAxisLabelOptions");
                context.Writer.WriteStartObject();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.XAxisLabelOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LineChartConfigurationMarshaller Instance = new LineChartConfigurationMarshaller();

    }
}