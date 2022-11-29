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
    /// PieChartConfiguration Marshaller
    /// </summary>
    public class PieChartConfigurationMarshaller : IRequestMarshaller<PieChartConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PieChartConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCategoryLabelOptions())
            {
                context.Writer.WritePropertyName("CategoryLabelOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryLabelOptions, context);

                context.Writer.WriteObjectEnd();
            }

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

            if(requestObject.IsSetDonutOptions())
            {
                context.Writer.WritePropertyName("DonutOptions");
                context.Writer.WriteObjectStart();

                var marshaller = DonutOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DonutOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFieldWells())
            {
                context.Writer.WritePropertyName("FieldWells");
                context.Writer.WriteObjectStart();

                var marshaller = PieChartFieldWellsMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldWells, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLegend())
            {
                context.Writer.WritePropertyName("Legend");
                context.Writer.WriteObjectStart();

                var marshaller = LegendOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Legend, context);

                context.Writer.WriteObjectEnd();
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

                var marshaller = PieChartSortConfigurationMarshaller.Instance;
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

            if(requestObject.IsSetValueLabelOptions())
            {
                context.Writer.WritePropertyName("ValueLabelOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueLabelOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisualPalette())
            {
                context.Writer.WritePropertyName("VisualPalette");
                context.Writer.WriteObjectStart();

                var marshaller = VisualPaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualPalette, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PieChartConfigurationMarshaller Instance = new PieChartConfigurationMarshaller();

    }
}