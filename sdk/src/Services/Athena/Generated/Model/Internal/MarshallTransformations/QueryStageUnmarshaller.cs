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
    /// Response Unmarshaller for QueryStage Object
    /// </summary>  
    public class QueryStageUnmarshaller : IUnmarshaller<QueryStage, XmlUnmarshallerContext>, IUnmarshaller<QueryStage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        QueryStage IUnmarshaller<QueryStage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public QueryStage Unmarshall(JsonUnmarshallerContext context)
        {
            QueryStage unmarshalledObject = new QueryStage();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExecutionTime", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ExecutionTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.InputBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputRows", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.InputRows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.OutputBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputRows", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.OutputRows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryStagePlan", targetDepth))
                {
                    var unmarshaller = QueryStagePlanNodeUnmarshaller.Instance;
                    unmarshalledObject.QueryStagePlan = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StageId", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubStages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<QueryStage, QueryStageUnmarshaller>(QueryStageUnmarshaller.Instance);
                    unmarshalledObject.SubStages = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static QueryStageUnmarshaller _instance = new QueryStageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryStageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618