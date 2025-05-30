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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RadarChartConfiguration Object
    /// </summary>  
    public class RadarChartConfigurationUnmarshaller : IJsonUnmarshaller<RadarChartConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RadarChartConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RadarChartConfiguration unmarshalledObject = new RadarChartConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AlternateBandColorsVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlternateBandColorsVisibility = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AlternateBandEvenColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlternateBandEvenColor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AlternateBandOddColor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlternateBandOddColor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AxesRangeScale", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AxesRangeScale = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BaseSeriesSettings", targetDepth))
                {
                    var unmarshaller = RadarChartSeriesSettingsUnmarshaller.Instance;
                    unmarshalledObject.BaseSeriesSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CategoryAxis", targetDepth))
                {
                    var unmarshaller = AxisDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.CategoryAxis = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CategoryLabelOptions", targetDepth))
                {
                    var unmarshaller = ChartAxisLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.CategoryLabelOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ColorAxis", targetDepth))
                {
                    var unmarshaller = AxisDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.ColorAxis = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ColorLabelOptions", targetDepth))
                {
                    var unmarshaller = ChartAxisLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.ColorLabelOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FieldWells", targetDepth))
                {
                    var unmarshaller = RadarChartFieldWellsUnmarshaller.Instance;
                    unmarshalledObject.FieldWells = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Interactions", targetDepth))
                {
                    var unmarshaller = VisualInteractionOptionsUnmarshaller.Instance;
                    unmarshalledObject.Interactions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Legend", targetDepth))
                {
                    var unmarshaller = LegendOptionsUnmarshaller.Instance;
                    unmarshalledObject.Legend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Shape", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Shape = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SortConfiguration", targetDepth))
                {
                    var unmarshaller = RadarChartSortConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SortConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartAngle", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.StartAngle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VisualPalette", targetDepth))
                {
                    var unmarshaller = VisualPaletteUnmarshaller.Instance;
                    unmarshalledObject.VisualPalette = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RadarChartConfigurationUnmarshaller _instance = new RadarChartConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RadarChartConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}