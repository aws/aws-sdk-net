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
    /// Response Unmarshaller for LineChartConfiguration Object
    /// </summary>  
    public class LineChartConfigurationUnmarshaller : IUnmarshaller<LineChartConfiguration, XmlUnmarshallerContext>, IUnmarshaller<LineChartConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LineChartConfiguration IUnmarshaller<LineChartConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LineChartConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LineChartConfiguration unmarshalledObject = new LineChartConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContributionAnalysisDefaults", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContributionAnalysisDefault, ContributionAnalysisDefaultUnmarshaller>(ContributionAnalysisDefaultUnmarshaller.Instance);
                    unmarshalledObject.ContributionAnalysisDefaults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataLabels", targetDepth))
                {
                    var unmarshaller = DataLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.DataLabels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultSeriesSettings", targetDepth))
                {
                    var unmarshaller = LineChartDefaultSeriesSettingsUnmarshaller.Instance;
                    unmarshalledObject.DefaultSeriesSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FieldWells", targetDepth))
                {
                    var unmarshaller = LineChartFieldWellsUnmarshaller.Instance;
                    unmarshalledObject.FieldWells = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForecastConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ForecastConfiguration, ForecastConfigurationUnmarshaller>(ForecastConfigurationUnmarshaller.Instance);
                    unmarshalledObject.ForecastConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Legend", targetDepth))
                {
                    var unmarshaller = LegendOptionsUnmarshaller.Instance;
                    unmarshalledObject.Legend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryYAxisDisplayOptions", targetDepth))
                {
                    var unmarshaller = LineSeriesAxisDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.PrimaryYAxisDisplayOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryYAxisLabelOptions", targetDepth))
                {
                    var unmarshaller = ChartAxisLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.PrimaryYAxisLabelOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReferenceLines", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ReferenceLine, ReferenceLineUnmarshaller>(ReferenceLineUnmarshaller.Instance);
                    unmarshalledObject.ReferenceLines = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecondaryYAxisDisplayOptions", targetDepth))
                {
                    var unmarshaller = LineSeriesAxisDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.SecondaryYAxisDisplayOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecondaryYAxisLabelOptions", targetDepth))
                {
                    var unmarshaller = ChartAxisLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.SecondaryYAxisLabelOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Series", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SeriesItem, SeriesItemUnmarshaller>(SeriesItemUnmarshaller.Instance);
                    unmarshalledObject.Series = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SmallMultiplesOptions", targetDepth))
                {
                    var unmarshaller = SmallMultiplesOptionsUnmarshaller.Instance;
                    unmarshalledObject.SmallMultiplesOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SortConfiguration", targetDepth))
                {
                    var unmarshaller = LineChartSortConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SortConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tooltip", targetDepth))
                {
                    var unmarshaller = TooltipOptionsUnmarshaller.Instance;
                    unmarshalledObject.Tooltip = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisualPalette", targetDepth))
                {
                    var unmarshaller = VisualPaletteUnmarshaller.Instance;
                    unmarshalledObject.VisualPalette = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XAxisDisplayOptions", targetDepth))
                {
                    var unmarshaller = AxisDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.XAxisDisplayOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XAxisLabelOptions", targetDepth))
                {
                    var unmarshaller = ChartAxisLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.XAxisLabelOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LineChartConfigurationUnmarshaller _instance = new LineChartConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LineChartConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}