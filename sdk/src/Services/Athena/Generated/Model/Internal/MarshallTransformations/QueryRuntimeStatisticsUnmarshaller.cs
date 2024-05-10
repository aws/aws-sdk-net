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
    /// Response Unmarshaller for QueryRuntimeStatistics Object
    /// </summary>  
    public class QueryRuntimeStatisticsUnmarshaller : IUnmarshaller<QueryRuntimeStatistics, XmlUnmarshallerContext>, IUnmarshaller<QueryRuntimeStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        QueryRuntimeStatistics IUnmarshaller<QueryRuntimeStatistics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public QueryRuntimeStatistics Unmarshall(JsonUnmarshallerContext context)
        {
            QueryRuntimeStatistics unmarshalledObject = new QueryRuntimeStatistics();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("OutputStage", targetDepth))
                {
                    var unmarshaller = QueryStageUnmarshaller.Instance;
                    unmarshalledObject.OutputStage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Rows", targetDepth))
                {
                    var unmarshaller = QueryRuntimeStatisticsRowsUnmarshaller.Instance;
                    unmarshalledObject.Rows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timeline", targetDepth))
                {
                    var unmarshaller = QueryRuntimeStatisticsTimelineUnmarshaller.Instance;
                    unmarshalledObject.Timeline = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static QueryRuntimeStatisticsUnmarshaller _instance = new QueryRuntimeStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryRuntimeStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}