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

#pragma warning disable CS0612,CS0618
namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PredictorMonitorEvaluation Object
    /// </summary>  
    public class PredictorMonitorEvaluationUnmarshaller : IUnmarshaller<PredictorMonitorEvaluation, XmlUnmarshallerContext>, IUnmarshaller<PredictorMonitorEvaluation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PredictorMonitorEvaluation IUnmarshaller<PredictorMonitorEvaluation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PredictorMonitorEvaluation Unmarshall(JsonUnmarshallerContext context)
        {
            PredictorMonitorEvaluation unmarshalledObject = new PredictorMonitorEvaluation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EvaluationState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EvaluationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricResults", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricResult, MetricResultUnmarshaller>(MetricResultUnmarshaller.Instance);
                    unmarshalledObject.MetricResults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MonitorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitorDataSource", targetDepth))
                {
                    var unmarshaller = MonitorDataSourceUnmarshaller.Instance;
                    unmarshalledObject.MonitorDataSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumItemsEvaluated", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumItemsEvaluated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictorEvent", targetDepth))
                {
                    var unmarshaller = PredictorEventUnmarshaller.Instance;
                    unmarshalledObject.PredictorEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WindowEndDatetime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.WindowEndDatetime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WindowStartDatetime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.WindowStartDatetime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PredictorMonitorEvaluationUnmarshaller _instance = new PredictorMonitorEvaluationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PredictorMonitorEvaluationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}