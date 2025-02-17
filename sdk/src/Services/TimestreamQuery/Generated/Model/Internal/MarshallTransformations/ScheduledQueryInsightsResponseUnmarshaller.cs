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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScheduledQueryInsightsResponse Object
    /// </summary>  
    public class ScheduledQueryInsightsResponseUnmarshaller : IUnmarshaller<ScheduledQueryInsightsResponse, XmlUnmarshallerContext>, IUnmarshaller<ScheduledQueryInsightsResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScheduledQueryInsightsResponse IUnmarshaller<ScheduledQueryInsightsResponse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ScheduledQueryInsightsResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ScheduledQueryInsightsResponse unmarshalledObject = new ScheduledQueryInsightsResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
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
                if (context.TestExpression("QuerySpatialCoverage", targetDepth))
                {
                    var unmarshaller = QuerySpatialCoverageUnmarshaller.Instance;
                    unmarshalledObject.QuerySpatialCoverage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryTableCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.QueryTableCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryTemporalRange", targetDepth))
                {
                    var unmarshaller = QueryTemporalRangeUnmarshaller.Instance;
                    unmarshalledObject.QueryTemporalRange = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScheduledQueryInsightsResponseUnmarshaller _instance = new ScheduledQueryInsightsResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScheduledQueryInsightsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}