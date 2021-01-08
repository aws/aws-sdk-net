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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Metrics Object
    /// </summary>  
    public class MetricsUnmarshaller : IUnmarshaller<Metrics, XmlUnmarshallerContext>, IUnmarshaller<Metrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Metrics IUnmarshaller<Metrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Metrics Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Metrics unmarshalledObject = new Metrics();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ErrorMetrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ErrorMetric, ErrorMetricUnmarshaller>(ErrorMetricUnmarshaller.Instance);
                    unmarshalledObject.ErrorMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RMSE", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.RMSE = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WeightedQuantileLosses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WeightedQuantileLoss, WeightedQuantileLossUnmarshaller>(WeightedQuantileLossUnmarshaller.Instance);
                    unmarshalledObject.WeightedQuantileLosses = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MetricsUnmarshaller _instance = new MetricsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}