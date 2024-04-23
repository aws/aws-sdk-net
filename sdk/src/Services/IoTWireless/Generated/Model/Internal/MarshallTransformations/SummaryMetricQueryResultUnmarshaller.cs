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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SummaryMetricQueryResult Object
    /// </summary>  
    public class SummaryMetricQueryResultUnmarshaller : IUnmarshaller<SummaryMetricQueryResult, XmlUnmarshallerContext>, IUnmarshaller<SummaryMetricQueryResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SummaryMetricQueryResult IUnmarshaller<SummaryMetricQueryResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SummaryMetricQueryResult Unmarshall(JsonUnmarshallerContext context)
        {
            SummaryMetricQueryResult unmarshalledObject = new SummaryMetricQueryResult();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AggregationPeriod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AggregationPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dimensions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dimension, DimensionUnmarshaller>(DimensionUnmarshaller.Instance);
                    unmarshalledObject.Dimensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Error", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueryStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timestamps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateTime, DateTimeUnmarshaller>(DateTimeUnmarshaller.Instance);
                    unmarshalledObject.Timestamps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Values", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricQueryValue, MetricQueryValueUnmarshaller>(MetricQueryValueUnmarshaller.Instance);
                    unmarshalledObject.Values = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SummaryMetricQueryResultUnmarshaller _instance = new SummaryMetricQueryResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SummaryMetricQueryResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618