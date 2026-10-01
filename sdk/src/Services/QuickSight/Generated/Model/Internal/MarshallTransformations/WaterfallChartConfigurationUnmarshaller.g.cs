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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WaterfallChartConfiguration Object
    /// </summary>
    public partial class WaterfallChartConfigurationUnmarshaller : IJsonUnmarshaller<WaterfallChartConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public WaterfallChartConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new WaterfallChartConfiguration();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CategoryAxisDisplayOptions", targetDepth, ref reader))
                {
                    var unmarshaller = AxisDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.CategoryAxisDisplayOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CategoryAxisLabelOptions", targetDepth, ref reader))
                {
                    var unmarshaller = ChartAxisLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.CategoryAxisLabelOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ColorConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = WaterfallChartColorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ColorConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DataLabels", targetDepth, ref reader))
                {
                    var unmarshaller = DataLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.DataLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FieldWells", targetDepth, ref reader))
                {
                    var unmarshaller = WaterfallChartFieldWellsUnmarshaller.Instance;
                    unmarshalledObject.FieldWells = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Interactions", targetDepth, ref reader))
                {
                    var unmarshaller = VisualInteractionOptionsUnmarshaller.Instance;
                    unmarshalledObject.Interactions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Legend", targetDepth, ref reader))
                {
                    var unmarshaller = LegendOptionsUnmarshaller.Instance;
                    unmarshalledObject.Legend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PrimaryYAxisDisplayOptions", targetDepth, ref reader))
                {
                    var unmarshaller = AxisDisplayOptionsUnmarshaller.Instance;
                    unmarshalledObject.PrimaryYAxisDisplayOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PrimaryYAxisLabelOptions", targetDepth, ref reader))
                {
                    var unmarshaller = ChartAxisLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.PrimaryYAxisLabelOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SortConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = WaterfallChartSortConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SortConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VisualPalette", targetDepth, ref reader))
                {
                    var unmarshaller = VisualPaletteUnmarshaller.Instance;
                    unmarshalledObject.VisualPalette = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("WaterfallChartOptions", targetDepth, ref reader))
                {
                    var unmarshaller = WaterfallChartOptionsUnmarshaller.Instance;
                    unmarshalledObject.WaterfallChartOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static WaterfallChartConfigurationUnmarshaller _instance = new WaterfallChartConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static WaterfallChartConfigurationUnmarshaller Instance => _instance;
    }
}
