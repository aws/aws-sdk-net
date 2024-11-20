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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RDSDBRecommendation Object
    /// </summary>  
    public class RDSDBRecommendationUnmarshaller : IUnmarshaller<RDSDBRecommendation, XmlUnmarshallerContext>, IUnmarshaller<RDSDBRecommendation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RDSDBRecommendation IUnmarshaller<RDSDBRecommendation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RDSDBRecommendation Unmarshall(JsonUnmarshallerContext context)
        {
            RDSDBRecommendation unmarshalledObject = new RDSDBRecommendation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentDBInstanceClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentDBInstanceClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentInstancePerformanceRisk", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentInstancePerformanceRisk = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentStorageConfiguration", targetDepth))
                {
                    var unmarshaller = DBStorageConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CurrentStorageConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dbClusterIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbClusterIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("effectiveRecommendationPreferences", targetDepth))
                {
                    var unmarshaller = RDSEffectiveRecommendationPreferencesUnmarshaller.Instance;
                    unmarshalledObject.EffectiveRecommendationPreferences = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("engine", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("engineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("idle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Idle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceFinding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceFinding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceFindingReasonCodes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InstanceFindingReasonCodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceRecommendationOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RDSDBInstanceRecommendationOption, RDSDBInstanceRecommendationOptionUnmarshaller>(RDSDBInstanceRecommendationOptionUnmarshaller.Instance);
                    unmarshalledObject.InstanceRecommendationOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastRefreshTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastRefreshTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lookbackPeriodInDays", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LookbackPeriodInDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("promotionTier", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PromotionTier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageFinding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageFinding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageFindingReasonCodes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StorageFindingReasonCodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageRecommendationOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RDSDBStorageRecommendationOption, RDSDBStorageRecommendationOptionUnmarshaller>(RDSDBStorageRecommendationOptionUnmarshaller.Instance);
                    unmarshalledObject.StorageRecommendationOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utilizationMetrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RDSDBUtilizationMetric, RDSDBUtilizationMetricUnmarshaller>(RDSDBUtilizationMetricUnmarshaller.Instance);
                    unmarshalledObject.UtilizationMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RDSDBRecommendationUnmarshaller _instance = new RDSDBRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RDSDBRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}