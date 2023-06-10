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
    /// Visual Marshaller
    /// </summary>
    public class VisualMarshaller : IRequestMarshaller<Visual, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Visual requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBarChartVisual())
            {
                context.Writer.WritePropertyName("BarChartVisual");
                context.Writer.WriteObjectStart();

                var marshaller = BarChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.BarChartVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBoxPlotVisual())
            {
                context.Writer.WritePropertyName("BoxPlotVisual");
                context.Writer.WriteObjectStart();

                var marshaller = BoxPlotVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.BoxPlotVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetComboChartVisual())
            {
                context.Writer.WritePropertyName("ComboChartVisual");
                context.Writer.WriteObjectStart();

                var marshaller = ComboChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.ComboChartVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCustomContentVisual())
            {
                context.Writer.WritePropertyName("CustomContentVisual");
                context.Writer.WriteObjectStart();

                var marshaller = CustomContentVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomContentVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEmptyVisual())
            {
                context.Writer.WritePropertyName("EmptyVisual");
                context.Writer.WriteObjectStart();

                var marshaller = EmptyVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.EmptyVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilledMapVisual())
            {
                context.Writer.WritePropertyName("FilledMapVisual");
                context.Writer.WriteObjectStart();

                var marshaller = FilledMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.FilledMapVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFunnelChartVisual())
            {
                context.Writer.WritePropertyName("FunnelChartVisual");
                context.Writer.WriteObjectStart();

                var marshaller = FunnelChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.FunnelChartVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGaugeChartVisual())
            {
                context.Writer.WritePropertyName("GaugeChartVisual");
                context.Writer.WriteObjectStart();

                var marshaller = GaugeChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.GaugeChartVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGeospatialMapVisual())
            {
                context.Writer.WritePropertyName("GeospatialMapVisual");
                context.Writer.WriteObjectStart();

                var marshaller = GeospatialMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.GeospatialMapVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeatMapVisual())
            {
                context.Writer.WritePropertyName("HeatMapVisual");
                context.Writer.WriteObjectStart();

                var marshaller = HeatMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.HeatMapVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHistogramVisual())
            {
                context.Writer.WritePropertyName("HistogramVisual");
                context.Writer.WriteObjectStart();

                var marshaller = HistogramVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.HistogramVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInsightVisual())
            {
                context.Writer.WritePropertyName("InsightVisual");
                context.Writer.WriteObjectStart();

                var marshaller = InsightVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.InsightVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKPIVisual())
            {
                context.Writer.WritePropertyName("KPIVisual");
                context.Writer.WriteObjectStart();

                var marshaller = KPIVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.KPIVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLineChartVisual())
            {
                context.Writer.WritePropertyName("LineChartVisual");
                context.Writer.WriteObjectStart();

                var marshaller = LineChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.LineChartVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPieChartVisual())
            {
                context.Writer.WritePropertyName("PieChartVisual");
                context.Writer.WriteObjectStart();

                var marshaller = PieChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.PieChartVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPivotTableVisual())
            {
                context.Writer.WritePropertyName("PivotTableVisual");
                context.Writer.WriteObjectStart();

                var marshaller = PivotTableVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.PivotTableVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRadarChartVisual())
            {
                context.Writer.WritePropertyName("RadarChartVisual");
                context.Writer.WriteObjectStart();

                var marshaller = RadarChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.RadarChartVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSankeyDiagramVisual())
            {
                context.Writer.WritePropertyName("SankeyDiagramVisual");
                context.Writer.WriteObjectStart();

                var marshaller = SankeyDiagramVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.SankeyDiagramVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScatterPlotVisual())
            {
                context.Writer.WritePropertyName("ScatterPlotVisual");
                context.Writer.WriteObjectStart();

                var marshaller = ScatterPlotVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.ScatterPlotVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTableVisual())
            {
                context.Writer.WritePropertyName("TableVisual");
                context.Writer.WriteObjectStart();

                var marshaller = TableVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.TableVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTreeMapVisual())
            {
                context.Writer.WritePropertyName("TreeMapVisual");
                context.Writer.WriteObjectStart();

                var marshaller = TreeMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.TreeMapVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWaterfallVisual())
            {
                context.Writer.WritePropertyName("WaterfallVisual");
                context.Writer.WriteObjectStart();

                var marshaller = WaterfallVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.WaterfallVisual, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWordCloudVisual())
            {
                context.Writer.WritePropertyName("WordCloudVisual");
                context.Writer.WriteObjectStart();

                var marshaller = WordCloudVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.WordCloudVisual, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VisualMarshaller Instance = new VisualMarshaller();

    }
}