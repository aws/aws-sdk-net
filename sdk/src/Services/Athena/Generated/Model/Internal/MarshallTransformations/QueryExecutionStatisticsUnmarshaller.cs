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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Athena.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for QueryExecutionStatistics Object
    /// </summary>  
    public class QueryExecutionStatisticsUnmarshaller : IUnmarshaller<QueryExecutionStatistics, XmlUnmarshallerContext>, IUnmarshaller<QueryExecutionStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        QueryExecutionStatistics IUnmarshaller<QueryExecutionStatistics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public QueryExecutionStatistics Unmarshall(JsonUnmarshallerContext context)
        {
            QueryExecutionStatistics unmarshalledObject = new QueryExecutionStatistics();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DataManifestLocation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataManifestLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataScannedInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DataScannedInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DpuCount", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DpuCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineExecutionTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.EngineExecutionTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryPlanningTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.QueryPlanningTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryQueueTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.QueryQueueTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultReuseInformation", targetDepth))
                {
                    var unmarshaller = ResultReuseInformationUnmarshaller.Instance;
                    unmarshalledObject.ResultReuseInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServicePreProcessingTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ServicePreProcessingTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceProcessingTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ServiceProcessingTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalExecutionTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalExecutionTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static QueryExecutionStatisticsUnmarshaller _instance = new QueryExecutionStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryExecutionStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}