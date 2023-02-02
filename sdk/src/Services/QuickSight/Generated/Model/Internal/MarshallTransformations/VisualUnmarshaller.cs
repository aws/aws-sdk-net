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
using System.Net;
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
    /// Response Unmarshaller for Visual Object
    /// </summary>  
    public class VisualUnmarshaller : IUnmarshaller<Visual, XmlUnmarshallerContext>, IUnmarshaller<Visual, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Visual IUnmarshaller<Visual, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Visual Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Visual unmarshalledObject = new Visual();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BarChartVisual", targetDepth))
                {
                    var unmarshaller = BarChartVisualUnmarshaller.Instance;
                    unmarshalledObject.BarChartVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BoxPlotVisual", targetDepth))
                {
                    var unmarshaller = BoxPlotVisualUnmarshaller.Instance;
                    unmarshalledObject.BoxPlotVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComboChartVisual", targetDepth))
                {
                    var unmarshaller = ComboChartVisualUnmarshaller.Instance;
                    unmarshalledObject.ComboChartVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomContentVisual", targetDepth))
                {
                    var unmarshaller = CustomContentVisualUnmarshaller.Instance;
                    unmarshalledObject.CustomContentVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmptyVisual", targetDepth))
                {
                    var unmarshaller = EmptyVisualUnmarshaller.Instance;
                    unmarshalledObject.EmptyVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilledMapVisual", targetDepth))
                {
                    var unmarshaller = FilledMapVisualUnmarshaller.Instance;
                    unmarshalledObject.FilledMapVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunnelChartVisual", targetDepth))
                {
                    var unmarshaller = FunnelChartVisualUnmarshaller.Instance;
                    unmarshalledObject.FunnelChartVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GaugeChartVisual", targetDepth))
                {
                    var unmarshaller = GaugeChartVisualUnmarshaller.Instance;
                    unmarshalledObject.GaugeChartVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeospatialMapVisual", targetDepth))
                {
                    var unmarshaller = GeospatialMapVisualUnmarshaller.Instance;
                    unmarshalledObject.GeospatialMapVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HeatMapVisual", targetDepth))
                {
                    var unmarshaller = HeatMapVisualUnmarshaller.Instance;
                    unmarshalledObject.HeatMapVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HistogramVisual", targetDepth))
                {
                    var unmarshaller = HistogramVisualUnmarshaller.Instance;
                    unmarshalledObject.HistogramVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsightVisual", targetDepth))
                {
                    var unmarshaller = InsightVisualUnmarshaller.Instance;
                    unmarshalledObject.InsightVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KPIVisual", targetDepth))
                {
                    var unmarshaller = KPIVisualUnmarshaller.Instance;
                    unmarshalledObject.KPIVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LineChartVisual", targetDepth))
                {
                    var unmarshaller = LineChartVisualUnmarshaller.Instance;
                    unmarshalledObject.LineChartVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PieChartVisual", targetDepth))
                {
                    var unmarshaller = PieChartVisualUnmarshaller.Instance;
                    unmarshalledObject.PieChartVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PivotTableVisual", targetDepth))
                {
                    var unmarshaller = PivotTableVisualUnmarshaller.Instance;
                    unmarshalledObject.PivotTableVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RadarChartVisual", targetDepth))
                {
                    var unmarshaller = RadarChartVisualUnmarshaller.Instance;
                    unmarshalledObject.RadarChartVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SankeyDiagramVisual", targetDepth))
                {
                    var unmarshaller = SankeyDiagramVisualUnmarshaller.Instance;
                    unmarshalledObject.SankeyDiagramVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScatterPlotVisual", targetDepth))
                {
                    var unmarshaller = ScatterPlotVisualUnmarshaller.Instance;
                    unmarshalledObject.ScatterPlotVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableVisual", targetDepth))
                {
                    var unmarshaller = TableVisualUnmarshaller.Instance;
                    unmarshalledObject.TableVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TreeMapVisual", targetDepth))
                {
                    var unmarshaller = TreeMapVisualUnmarshaller.Instance;
                    unmarshalledObject.TreeMapVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WaterfallVisual", targetDepth))
                {
                    var unmarshaller = WaterfallVisualUnmarshaller.Instance;
                    unmarshalledObject.WaterfallVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WordCloudVisual", targetDepth))
                {
                    var unmarshaller = WordCloudVisualUnmarshaller.Instance;
                    unmarshalledObject.WordCloudVisual = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VisualUnmarshaller _instance = new VisualUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VisualUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}