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
    /// Response Unmarshaller for Computation Object
    /// </summary>  
    public class ComputationUnmarshaller : IUnmarshaller<Computation, XmlUnmarshallerContext>, IUnmarshaller<Computation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Computation IUnmarshaller<Computation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Computation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Computation unmarshalledObject = new Computation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Forecast", targetDepth))
                {
                    var unmarshaller = ForecastComputationUnmarshaller.Instance;
                    unmarshalledObject.Forecast = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GrowthRate", targetDepth))
                {
                    var unmarshaller = GrowthRateComputationUnmarshaller.Instance;
                    unmarshalledObject.GrowthRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumMinimum", targetDepth))
                {
                    var unmarshaller = MaximumMinimumComputationUnmarshaller.Instance;
                    unmarshalledObject.MaximumMinimum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricComparison", targetDepth))
                {
                    var unmarshaller = MetricComparisonComputationUnmarshaller.Instance;
                    unmarshalledObject.MetricComparison = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PeriodOverPeriod", targetDepth))
                {
                    var unmarshaller = PeriodOverPeriodComputationUnmarshaller.Instance;
                    unmarshalledObject.PeriodOverPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PeriodToDate", targetDepth))
                {
                    var unmarshaller = PeriodToDateComputationUnmarshaller.Instance;
                    unmarshalledObject.PeriodToDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TopBottomMovers", targetDepth))
                {
                    var unmarshaller = TopBottomMoversComputationUnmarshaller.Instance;
                    unmarshalledObject.TopBottomMovers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TopBottomRanked", targetDepth))
                {
                    var unmarshaller = TopBottomRankedComputationUnmarshaller.Instance;
                    unmarshalledObject.TopBottomRanked = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalAggregation", targetDepth))
                {
                    var unmarshaller = TotalAggregationComputationUnmarshaller.Instance;
                    unmarshalledObject.TotalAggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UniqueValues", targetDepth))
                {
                    var unmarshaller = UniqueValuesComputationUnmarshaller.Instance;
                    unmarshalledObject.UniqueValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ComputationUnmarshaller _instance = new ComputationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComputationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}