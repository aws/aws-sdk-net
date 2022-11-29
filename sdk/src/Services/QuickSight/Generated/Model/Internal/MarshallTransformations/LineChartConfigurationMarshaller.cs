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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetContributionAnalysisDefaults())
            {
                context.Writer.WritePropertyName("ContributionAnalysisDefaults");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContributionAnalysisDefaultsListValue in requestObject.ContributionAnalysisDefaults)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ContributionAnalysisDefaultMarshaller.Instance;
                    marshaller.Marshall(requestObjectContributionAnalysisDefaultsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataLabels())
            {
                context.Writer.WritePropertyName("DataLabels");
                context.Writer.WriteObjectStart();

                var marshaller = DataLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataLabels, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultSeriesSettings())
            {
                context.Writer.WritePropertyName("DefaultSeriesSettings");
                context.Writer.WriteObjectStart();

                var marshaller = LineChartDefaultSeriesSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultSeriesSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFieldWells())
            {
                context.Writer.WritePropertyName("FieldWells");
                context.Writer.WriteObjectStart();

                var marshaller = LineChartFieldWellsMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldWells, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetForecastConfigurations())
            {
                context.Writer.WritePropertyName("ForecastConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectForecastConfigurationsListValue in requestObject.ForecastConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ForecastConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectForecastConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLegend())
            {
                context.Writer.WritePropertyName("Legend");
                context.Writer.WriteObjectStart();

                var marshaller = LegendOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Legend, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrimaryYAxisDisplayOptions())
            {
                context.Writer.WritePropertyName("PrimaryYAxisDisplayOptions");
                context.Writer.WriteObjectStart();

                var marshaller = LineSeriesAxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryYAxisDisplayOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrimaryYAxisLabelOptions())
            {
                context.Writer.WritePropertyName("PrimaryYAxisLabelOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryYAxisLabelOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReferenceLines())
            {
                context.Writer.WritePropertyName("ReferenceLines");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReferenceLinesListValue in requestObject.ReferenceLines)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ReferenceLineMarshaller.Instance;
                    marshaller.Marshall(requestObjectReferenceLinesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecondaryYAxisDisplayOptions())
            {
                context.Writer.WritePropertyName("SecondaryYAxisDisplayOptions");
                context.Writer.WriteObjectStart();

                var marshaller = LineSeriesAxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SecondaryYAxisDisplayOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSecondaryYAxisLabelOptions())
            {
                context.Writer.WritePropertyName("SecondaryYAxisLabelOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SecondaryYAxisLabelOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSeries())
            {
                context.Writer.WritePropertyName("Series");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSeriesListValue in requestObject.Series)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SeriesItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeriesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSmallMultiplesOptions())
            {
                context.Writer.WritePropertyName("SmallMultiplesOptions");
                context.Writer.WriteObjectStart();

                var marshaller = SmallMultiplesOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SmallMultiplesOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSortConfiguration())
            {
                context.Writer.WritePropertyName("SortConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = LineChartSortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SortConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTooltip())
            {
                context.Writer.WritePropertyName("Tooltip");
                context.Writer.WriteObjectStart();

                var marshaller = TooltipOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Tooltip, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetVisualPalette())
            {
                context.Writer.WritePropertyName("VisualPalette");
                context.Writer.WriteObjectStart();

                var marshaller = VisualPaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualPalette, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetXAxisDisplayOptions())
            {
                context.Writer.WritePropertyName("XAxisDisplayOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AxisDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.XAxisDisplayOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetXAxisLabelOptions())
            {
                context.Writer.WritePropertyName("XAxisLabelOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.XAxisLabelOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LineChartConfigurationMarshaller Instance = new LineChartConfigurationMarshaller();

    }
}