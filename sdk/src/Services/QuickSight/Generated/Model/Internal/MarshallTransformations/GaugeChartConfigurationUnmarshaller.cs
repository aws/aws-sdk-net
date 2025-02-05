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
    /// Response Unmarshaller for GaugeChartConfiguration Object
    /// </summary>  
    public class GaugeChartConfigurationUnmarshaller : IJsonUnmarshaller<GaugeChartConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GaugeChartConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GaugeChartConfiguration unmarshalledObject = new GaugeChartConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ColorConfiguration", targetDepth))
                {
                    var unmarshaller = GaugeChartColorConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ColorConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataLabels", targetDepth))
                {
                    var unmarshaller = DataLabelOptionsUnmarshaller.Instance;
                    unmarshalledObject.DataLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FieldWells", targetDepth))
                {
                    var unmarshaller = GaugeChartFieldWellsUnmarshaller.Instance;
                    unmarshalledObject.FieldWells = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GaugeChartOptions", targetDepth))
                {
                    var unmarshaller = GaugeChartOptionsUnmarshaller.Instance;
                    unmarshalledObject.GaugeChartOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Interactions", targetDepth))
                {
                    var unmarshaller = VisualInteractionOptionsUnmarshaller.Instance;
                    unmarshalledObject.Interactions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TooltipOptions", targetDepth))
                {
                    var unmarshaller = TooltipOptionsUnmarshaller.Instance;
                    unmarshalledObject.TooltipOptions = unmarshaller.Unmarshall(context, ref reader);
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


        private static GaugeChartConfigurationUnmarshaller _instance = new GaugeChartConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GaugeChartConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}