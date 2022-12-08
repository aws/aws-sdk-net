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
    /// Response Unmarshaller for ServerDetail Object
    /// </summary>  
    public class ServerDetailUnmarshaller : IUnmarshaller<ServerDetail, XmlUnmarshallerContext>, IUnmarshaller<ServerDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServerDetail IUnmarshaller<ServerDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServerDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ServerDetail unmarshalledObject = new ServerDetail();
        
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
                if (context.TestExpression("applicationComponentStrategySummary", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StrategySummary, StrategySummaryUnmarshaller>(StrategySummaryUnmarshaller.Instance);
                    unmarshalledObject.ApplicationComponentStrategySummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataCollectionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataCollectionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendationSet", targetDepth))
                {
                    var unmarshaller = RecommendationSetUnmarshaller.Instance;
                    unmarshalledObject.RecommendationSet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serverError", targetDepth))
                {
                    var unmarshaller = ServerErrorUnmarshaller.Instance;
                    unmarshalledObject.ServerError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serverType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("systemInfo", targetDepth))
                {
                    var unmarshaller = SystemInfoUnmarshaller.Instance;
                    unmarshalledObject.SystemInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ServerDetailUnmarshaller _instance = new ServerDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServerDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}