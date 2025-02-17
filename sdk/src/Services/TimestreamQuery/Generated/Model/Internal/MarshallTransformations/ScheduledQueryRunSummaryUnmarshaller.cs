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
    /// Response Unmarshaller for ScheduledQueryRunSummary Object
    /// </summary>  
    public class ScheduledQueryRunSummaryUnmarshaller : IUnmarshaller<ScheduledQueryRunSummary, XmlUnmarshallerContext>, IUnmarshaller<ScheduledQueryRunSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScheduledQueryRunSummary IUnmarshaller<ScheduledQueryRunSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ScheduledQueryRunSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ScheduledQueryRunSummary unmarshalledObject = new ScheduledQueryRunSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ErrorReportLocation", targetDepth))
                {
                    var unmarshaller = ErrorReportLocationUnmarshaller.Instance;
                    unmarshalledObject.ErrorReportLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionStats", targetDepth))
                {
                    var unmarshaller = ExecutionStatsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStats = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvocationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.InvocationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryInsightsResponse", targetDepth))
                {
                    var unmarshaller = ScheduledQueryInsightsResponseUnmarshaller.Instance;
                    unmarshalledObject.QueryInsightsResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TriggerTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TriggerTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScheduledQueryRunSummaryUnmarshaller _instance = new ScheduledQueryRunSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScheduledQueryRunSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}