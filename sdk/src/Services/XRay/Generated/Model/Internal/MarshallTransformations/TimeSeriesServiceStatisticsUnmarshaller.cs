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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TimeSeriesServiceStatistics Object
    /// </summary>  
    public class TimeSeriesServiceStatisticsUnmarshaller : IUnmarshaller<TimeSeriesServiceStatistics, XmlUnmarshallerContext>, IUnmarshaller<TimeSeriesServiceStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TimeSeriesServiceStatistics IUnmarshaller<TimeSeriesServiceStatistics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TimeSeriesServiceStatistics Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TimeSeriesServiceStatistics unmarshalledObject = new TimeSeriesServiceStatistics();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EdgeSummaryStatistics", targetDepth))
                {
                    var unmarshaller = EdgeStatisticsUnmarshaller.Instance;
                    unmarshalledObject.EdgeSummaryStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResponseTimeHistogram", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HistogramEntry, HistogramEntryUnmarshaller>(HistogramEntryUnmarshaller.Instance);
                    unmarshalledObject.ResponseTimeHistogram = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceForecastStatistics", targetDepth))
                {
                    var unmarshaller = ForecastStatisticsUnmarshaller.Instance;
                    unmarshalledObject.ServiceForecastStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceSummaryStatistics", targetDepth))
                {
                    var unmarshaller = ServiceStatisticsUnmarshaller.Instance;
                    unmarshalledObject.ServiceSummaryStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TimeSeriesServiceStatisticsUnmarshaller _instance = new TimeSeriesServiceStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TimeSeriesServiceStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}