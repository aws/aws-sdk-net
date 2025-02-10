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
    /// Response Unmarshaller for KPIOptions Object
    /// </summary>  
    public class KPIOptionsUnmarshaller : IJsonUnmarshaller<KPIOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public KPIOptions Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            KPIOptions unmarshalledObject = new KPIOptions();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Comparison", targetDepth))
                {
                    var unmarshaller = ComparisonConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Comparison = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrimaryValueDisplayType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrimaryValueDisplayType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrimaryValueFontConfiguration", targetDepth))
                {
                    var unmarshaller = FontConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PrimaryValueFontConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProgressBar", targetDepth))
                {
                    var unmarshaller = ProgressBarOptionsUnmarshaller.Instance;
                    unmarshalledObject.ProgressBar = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecondaryValue", targetDepth))
                {
                    var unmarshaller = SecondaryValueOptionsUnmarshaller.Instance;
                    unmarshalledObject.SecondaryValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecondaryValueFontConfiguration", targetDepth))
                {
                    var unmarshaller = FontConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SecondaryValueFontConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sparkline", targetDepth))
                {
                    var unmarshaller = KPISparklineOptionsUnmarshaller.Instance;
                    unmarshalledObject.Sparkline = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrendArrows", targetDepth))
                {
                    var unmarshaller = TrendArrowOptionsUnmarshaller.Instance;
                    unmarshalledObject.TrendArrows = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VisualLayoutOptions", targetDepth))
                {
                    var unmarshaller = KPIVisualLayoutOptionsUnmarshaller.Instance;
                    unmarshalledObject.VisualLayoutOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static KPIOptionsUnmarshaller _instance = new KPIOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KPIOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}