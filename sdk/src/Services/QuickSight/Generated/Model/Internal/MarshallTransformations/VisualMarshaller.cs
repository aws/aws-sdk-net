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
            if(requestObject == null)
                return;
            if(requestObject.IsSetBarChartVisual())
            {
                context.Writer.WritePropertyName("BarChartVisual");
                context.Writer.WriteStartObject();

                var marshaller = BarChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.BarChartVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBoxPlotVisual())
            {
                context.Writer.WritePropertyName("BoxPlotVisual");
                context.Writer.WriteStartObject();

                var marshaller = BoxPlotVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.BoxPlotVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetComboChartVisual())
            {
                context.Writer.WritePropertyName("ComboChartVisual");
                context.Writer.WriteStartObject();

                var marshaller = ComboChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.ComboChartVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomContentVisual())
            {
                context.Writer.WritePropertyName("CustomContentVisual");
                context.Writer.WriteStartObject();

                var marshaller = CustomContentVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomContentVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmptyVisual())
            {
                context.Writer.WritePropertyName("EmptyVisual");
                context.Writer.WriteStartObject();

                var marshaller = EmptyVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.EmptyVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilledMapVisual())
            {
                context.Writer.WritePropertyName("FilledMapVisual");
                context.Writer.WriteStartObject();

                var marshaller = FilledMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.FilledMapVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFunnelChartVisual())
            {
                context.Writer.WritePropertyName("FunnelChartVisual");
                context.Writer.WriteStartObject();

                var marshaller = FunnelChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.FunnelChartVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGaugeChartVisual())
            {
                context.Writer.WritePropertyName("GaugeChartVisual");
                context.Writer.WriteStartObject();

                var marshaller = GaugeChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.GaugeChartVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGeospatialMapVisual())
            {
                context.Writer.WritePropertyName("GeospatialMapVisual");
                context.Writer.WriteStartObject();

                var marshaller = GeospatialMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.GeospatialMapVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHeatMapVisual())
            {
                context.Writer.WritePropertyName("HeatMapVisual");
                context.Writer.WriteStartObject();

                var marshaller = HeatMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.HeatMapVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHistogramVisual())
            {
                context.Writer.WritePropertyName("HistogramVisual");
                context.Writer.WriteStartObject();

                var marshaller = HistogramVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.HistogramVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInsightVisual())
            {
                context.Writer.WritePropertyName("InsightVisual");
                context.Writer.WriteStartObject();

                var marshaller = InsightVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.InsightVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKPIVisual())
            {
                context.Writer.WritePropertyName("KPIVisual");
                context.Writer.WriteStartObject();

                var marshaller = KPIVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.KPIVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLayerMapVisual())
            {
                context.Writer.WritePropertyName("LayerMapVisual");
                context.Writer.WriteStartObject();

                var marshaller = LayerMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.LayerMapVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLineChartVisual())
            {
                context.Writer.WritePropertyName("LineChartVisual");
                context.Writer.WriteStartObject();

                var marshaller = LineChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.LineChartVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPieChartVisual())
            {
                context.Writer.WritePropertyName("PieChartVisual");
                context.Writer.WriteStartObject();

                var marshaller = PieChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.PieChartVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPivotTableVisual())
            {
                context.Writer.WritePropertyName("PivotTableVisual");
                context.Writer.WriteStartObject();

                var marshaller = PivotTableVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.PivotTableVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPluginVisual())
            {
                context.Writer.WritePropertyName("PluginVisual");
                context.Writer.WriteStartObject();

                var marshaller = PluginVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.PluginVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRadarChartVisual())
            {
                context.Writer.WritePropertyName("RadarChartVisual");
                context.Writer.WriteStartObject();

                var marshaller = RadarChartVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.RadarChartVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSankeyDiagramVisual())
            {
                context.Writer.WritePropertyName("SankeyDiagramVisual");
                context.Writer.WriteStartObject();

                var marshaller = SankeyDiagramVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.SankeyDiagramVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScatterPlotVisual())
            {
                context.Writer.WritePropertyName("ScatterPlotVisual");
                context.Writer.WriteStartObject();

                var marshaller = ScatterPlotVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.ScatterPlotVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTableVisual())
            {
                context.Writer.WritePropertyName("TableVisual");
                context.Writer.WriteStartObject();

                var marshaller = TableVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.TableVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTreeMapVisual())
            {
                context.Writer.WritePropertyName("TreeMapVisual");
                context.Writer.WriteStartObject();

                var marshaller = TreeMapVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.TreeMapVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWaterfallVisual())
            {
                context.Writer.WritePropertyName("WaterfallVisual");
                context.Writer.WriteStartObject();

                var marshaller = WaterfallVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.WaterfallVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWordCloudVisual())
            {
                context.Writer.WritePropertyName("WordCloudVisual");
                context.Writer.WriteStartObject();

                var marshaller = WordCloudVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.WordCloudVisual, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VisualMarshaller Instance = new VisualMarshaller();

    }
}