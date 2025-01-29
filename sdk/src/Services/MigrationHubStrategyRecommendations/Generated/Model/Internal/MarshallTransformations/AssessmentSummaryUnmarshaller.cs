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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssessmentSummary Object
    /// </summary>  
    public class AssessmentSummaryUnmarshaller : IJsonUnmarshaller<AssessmentSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AssessmentSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AssessmentSummary unmarshalledObject = new AssessmentSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("antipatternReportS3Object", targetDepth))
                {
                    var unmarshaller = S3ObjectUnmarshaller.Instance;
                    unmarshalledObject.AntipatternReportS3Object = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("antipatternReportStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AntipatternReportStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("antipatternReportStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AntipatternReportStatusMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastAnalyzedTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastAnalyzedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listAntipatternSeveritySummary", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AntipatternSeveritySummary, AntipatternSeveritySummaryUnmarshaller>(AntipatternSeveritySummaryUnmarshaller.Instance);
                    unmarshalledObject.ListAntipatternSeveritySummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listApplicationComponentStatusSummary", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ApplicationComponentStatusSummary, ApplicationComponentStatusSummaryUnmarshaller>(ApplicationComponentStatusSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListApplicationComponentStatusSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listApplicationComponentStrategySummary", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StrategySummary, StrategySummaryUnmarshaller>(StrategySummaryUnmarshaller.Instance);
                    unmarshalledObject.ListApplicationComponentStrategySummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listApplicationComponentSummary", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ApplicationComponentSummary, ApplicationComponentSummaryUnmarshaller>(ApplicationComponentSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListApplicationComponentSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listServerStatusSummary", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ServerStatusSummary, ServerStatusSummaryUnmarshaller>(ServerStatusSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListServerStatusSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listServerStrategySummary", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StrategySummary, StrategySummaryUnmarshaller>(StrategySummaryUnmarshaller.Instance);
                    unmarshalledObject.ListServerStrategySummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listServerSummary", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ServerSummary, ServerSummaryUnmarshaller>(ServerSummaryUnmarshaller.Instance);
                    unmarshalledObject.ListServerSummary = unmarshaller.Unmarshall(context, ref reader);
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