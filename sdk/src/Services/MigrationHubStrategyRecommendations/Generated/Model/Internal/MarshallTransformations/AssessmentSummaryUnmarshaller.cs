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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssessmentSummary Object
    /// </summary>  
    public class AssessmentSummaryUnmarshaller : IUnmarshaller<AssessmentSummary, XmlUnmarshallerContext>, IUnmarshaller<AssessmentSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssessmentSummary IUnmarshaller<AssessmentSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssessmentSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssessmentSummary unmarshalledObject = new AssessmentSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("antipatternReportS3Object", targetDepth))
                {
                    var unmarshaller = S3ObjectUnmarshaller.Instance;
                    unmarshalledObject.AntipatternReportS3Object = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("antipatternReportStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AntipatternReportStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("antipatternReportStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AntipatternReportStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastAnalyzedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastAnalyzedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listAntipatternSeveritySummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AntipatternSeveritySummary, AntipatternSeveritySummaryUnmarshaller>(AntipatternSeveritySummaryUnmarshaller.Instance);
                    unmarshalledObject.ListAntipatternSeveritySummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listApplicationComponentStatusSummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ApplicationComponentStatusSummary, ApplicationComponentStatusSummaryUnmarshaller>(ApplicationComponentStatusSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListApplicationComponentStatusSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listApplicationComponentStrategySummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StrategySummary, StrategySummaryUnmarshaller>(StrategySummaryUnmarshaller.Instance);
                    unmarshalledObject.ListApplicationComponentStrategySummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listApplicationComponentSummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ApplicationComponentSummary, ApplicationComponentSummaryUnmarshaller>(ApplicationComponentSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListApplicationComponentSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listServerStatusSummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServerStatusSummary, ServerStatusSummaryUnmarshaller>(ServerStatusSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListServerStatusSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listServerStrategySummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StrategySummary, StrategySummaryUnmarshaller>(StrategySummaryUnmarshaller.Instance);
                    unmarshalledObject.ListServerStrategySummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listServerSummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServerSummary, ServerSummaryUnmarshaller>(ServerSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListServerSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AssessmentSummaryUnmarshaller _instance = new AssessmentSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssessmentSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}