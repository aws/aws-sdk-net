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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for QueryExecution Object
    /// </summary>  
    public class QueryExecutionUnmarshaller : IJsonUnmarshaller<QueryExecution, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public QueryExecution Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            QueryExecution unmarshalledObject = new QueryExecution();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = EngineVersionUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExecutionParameters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExecutionParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManagedQueryResultsConfiguration", targetDepth))
                {
                    var unmarshaller = ManagedQueryResultsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ManagedQueryResultsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Query", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Query = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QueryExecutionContext", targetDepth))
                {
                    var unmarshaller = QueryExecutionContextUnmarshaller.Instance;
                    unmarshalledObject.QueryExecutionContext = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QueryExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueryExecutionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QueryResultsS3AccessGrantsConfiguration", targetDepth))
                {
                    var unmarshaller = QueryResultsS3AccessGrantsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.QueryResultsS3AccessGrantsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResultConfiguration", targetDepth))
                {
                    var unmarshaller = ResultConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResultConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResultReuseConfiguration", targetDepth))
                {
                    var unmarshaller = ResultReuseConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResultReuseConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatementType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatementType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Statistics", targetDepth))
                {
                    var unmarshaller = QueryExecutionStatisticsUnmarshaller.Instance;
                    unmarshalledObject.Statistics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = QueryExecutionStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubstatementType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubstatementType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static QueryExecutionUnmarshaller _instance = new QueryExecutionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryExecutionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}