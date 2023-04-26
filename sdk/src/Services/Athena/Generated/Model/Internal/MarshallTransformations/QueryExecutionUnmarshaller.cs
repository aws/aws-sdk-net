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

namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for QueryExecution Object
    /// </summary>  
    public class QueryExecutionUnmarshaller : IUnmarshaller<QueryExecution, XmlUnmarshallerContext>, IUnmarshaller<QueryExecution, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        QueryExecution IUnmarshaller<QueryExecution, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public QueryExecution Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            QueryExecution unmarshalledObject = new QueryExecution();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = EngineVersionUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionParameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExecutionParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Query", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Query = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryExecutionContext", targetDepth))
                {
                    var unmarshaller = QueryExecutionContextUnmarshaller.Instance;
                    unmarshalledObject.QueryExecutionContext = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueryExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultConfiguration", targetDepth))
                {
                    var unmarshaller = ResultConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResultConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultReuseConfiguration", targetDepth))
                {
                    var unmarshaller = ResultReuseConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResultReuseConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatementType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatementType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Statistics", targetDepth))
                {
                    var unmarshaller = QueryExecutionStatisticsUnmarshaller.Instance;
                    unmarshalledObject.Statistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = QueryExecutionStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubstatementType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubstatementType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkGroup = unmarshaller.Unmarshall(context);
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