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
    /// Response Unmarshaller for ScheduledQueryDescription Object
    /// </summary>  
    public class ScheduledQueryDescriptionUnmarshaller : IUnmarshaller<ScheduledQueryDescription, XmlUnmarshallerContext>, IUnmarshaller<ScheduledQueryDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScheduledQueryDescription IUnmarshaller<ScheduledQueryDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ScheduledQueryDescription Unmarshall(JsonUnmarshallerContext context)
        {
            ScheduledQueryDescription unmarshalledObject = new ScheduledQueryDescription();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorReportConfiguration", targetDepth))
                {
                    var unmarshaller = ErrorReportConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ErrorReportConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastRunSummary", targetDepth))
                {
                    var unmarshaller = ScheduledQueryRunSummaryUnmarshaller.Instance;
                    unmarshalledObject.LastRunSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextInvocationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.NextInvocationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotificationConfiguration", targetDepth))
                {
                    var unmarshaller = NotificationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NotificationConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviousInvocationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.PreviousInvocationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueryString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecentlyFailedRuns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ScheduledQueryRunSummary, ScheduledQueryRunSummaryUnmarshaller>(ScheduledQueryRunSummaryUnmarshaller.Instance);
                    unmarshalledObject.RecentlyFailedRuns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleConfiguration", targetDepth))
                {
                    var unmarshaller = ScheduleConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ScheduleConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledQueryExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduledQueryExecutionRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetConfiguration", targetDepth))
                {
                    var unmarshaller = TargetConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TargetConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScheduledQueryDescriptionUnmarshaller _instance = new ScheduledQueryDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScheduledQueryDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618