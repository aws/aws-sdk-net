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
    /// Response Unmarshaller for ApplicationComponentDetail Object
    /// </summary>  
    public class ApplicationComponentDetailUnmarshaller : IUnmarshaller<ApplicationComponentDetail, XmlUnmarshallerContext>, IUnmarshaller<ApplicationComponentDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ApplicationComponentDetail IUnmarshaller<ApplicationComponentDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ApplicationComponentDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ApplicationComponentDetail unmarshalledObject = new ApplicationComponentDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("analysisStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnalysisStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
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
                if (context.TestExpression("appType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("appUnitError", targetDepth))
                {
                    var unmarshaller = AppUnitErrorUnmarshaller.Instance;
                    unmarshalledObject.AppUnitError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("associatedServerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociatedServerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("databaseConfigDetail", targetDepth))
                {
                    var unmarshaller = DatabaseConfigDetailUnmarshaller.Instance;
                    unmarshalledObject.DatabaseConfigDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inclusionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InclusionStatus = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("moreServerAssociationExists", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MoreServerAssociationExists = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("osDriver", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OsDriver = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("osVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OsVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendationSet", targetDepth))
                {
                    var unmarshaller = RecommendationSetUnmarshaller.Instance;
                    unmarshalledObject.RecommendationSet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceSubType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceSubType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resultList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Result, ResultUnmarshaller>(ResultUnmarshaller.Instance);
                    unmarshalledObject.ResultList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runtimeStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuntimeStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runtimeStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuntimeStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceCodeRepositories", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SourceCodeRepository, SourceCodeRepositoryUnmarshaller>(SourceCodeRepositoryUnmarshaller.Instance);
                    unmarshalledObject.SourceCodeRepositories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ApplicationComponentDetailUnmarshaller _instance = new ApplicationComponentDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationComponentDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}