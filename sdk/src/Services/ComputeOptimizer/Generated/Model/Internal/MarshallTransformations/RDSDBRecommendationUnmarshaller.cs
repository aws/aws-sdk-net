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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RDSDBRecommendation Object
    /// </summary>  
    public class RDSDBRecommendationUnmarshaller : ICborUnmarshaller<RDSDBRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RDSDBRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            RDSDBRecommendation unmarshalledObject = new RDSDBRecommendation();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "accountId":
                        {
                            context.AddPathSegment("AccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentDBInstanceClass":
                        {
                            context.AddPathSegment("CurrentDBInstanceClass");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentDBInstanceClass = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentInstancePerformanceRisk":
                        {
                            context.AddPathSegment("CurrentInstancePerformanceRisk");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentInstancePerformanceRisk = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentStorageConfiguration":
                        {
                            context.AddPathSegment("CurrentStorageConfiguration");
                            var unmarshaller = DBStorageConfigurationUnmarshaller.Instance;
                            unmarshalledObject.CurrentStorageConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentStorageEstimatedMonthlyVolumeIOPsCostVariation":
                        {
                            context.AddPathSegment("CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "dbClusterIdentifier":
                        {
                            context.AddPathSegment("DbClusterIdentifier");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DbClusterIdentifier = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "effectiveRecommendationPreferences":
                        {
                            context.AddPathSegment("EffectiveRecommendationPreferences");
                            var unmarshaller = RDSEffectiveRecommendationPreferencesUnmarshaller.Instance;
                            unmarshalledObject.EffectiveRecommendationPreferences = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "engine":
                        {
                            context.AddPathSegment("Engine");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "engineVersion":
                        {
                            context.AddPathSegment("EngineVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "idle":
                        {
                            context.AddPathSegment("Idle");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Idle = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "instanceFinding":
                        {
                            context.AddPathSegment("InstanceFinding");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceFinding = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "instanceFindingReasonCodes":
                        {
                            context.AddPathSegment("InstanceFindingReasonCodes");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.InstanceFindingReasonCodes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "instanceRecommendationOptions":
                        {
                            context.AddPathSegment("InstanceRecommendationOptions");
                            var unmarshaller = new CborListUnmarshaller<RDSDBInstanceRecommendationOption, RDSDBInstanceRecommendationOptionUnmarshaller>(RDSDBInstanceRecommendationOptionUnmarshaller.Instance);
                            unmarshalledObject.InstanceRecommendationOptions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastRefreshTimestamp":
                        {
                            context.AddPathSegment("LastRefreshTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastRefreshTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lookbackPeriodInDays":
                        {
                            context.AddPathSegment("LookbackPeriodInDays");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.LookbackPeriodInDays = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "promotionTier":
                        {
                            context.AddPathSegment("PromotionTier");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.PromotionTier = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceArn":
                        {
                            context.AddPathSegment("ResourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "storageFinding":
                        {
                            context.AddPathSegment("StorageFinding");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StorageFinding = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "storageFindingReasonCodes":
                        {
                            context.AddPathSegment("StorageFindingReasonCodes");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.StorageFindingReasonCodes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "storageRecommendationOptions":
                        {
                            context.AddPathSegment("StorageRecommendationOptions");
                            var unmarshaller = new CborListUnmarshaller<RDSDBStorageRecommendationOption, RDSDBStorageRecommendationOptionUnmarshaller>(RDSDBStorageRecommendationOptionUnmarshaller.Instance);
                            unmarshalledObject.StorageRecommendationOptions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "tags":
                        {
                            context.AddPathSegment("Tags");
                            var unmarshaller = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                            unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "utilizationMetrics":
                        {
                            context.AddPathSegment("UtilizationMetrics");
                            var unmarshaller = new CborListUnmarshaller<RDSDBUtilizationMetric, RDSDBUtilizationMetricUnmarshaller>(RDSDBUtilizationMetricUnmarshaller.Instance);
                            unmarshalledObject.UtilizationMetrics = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
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