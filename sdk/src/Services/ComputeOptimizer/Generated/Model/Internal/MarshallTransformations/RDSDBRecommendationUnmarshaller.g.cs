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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ComputeOptimizer.Model;
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
    public partial class RDSDBRecommendationUnmarshaller : ICborUnmarshaller<RDSDBRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RDSDBRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RDSDBRecommendation();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "accountId":
                        context.AddPathSegment("AccountId");
                        unmarshalledObject.AccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentDBInstanceClass":
                        context.AddPathSegment("CurrentDBInstanceClass");
                        unmarshalledObject.CurrentDBInstanceClass = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentInstancePerformanceRisk":
                        context.AddPathSegment("CurrentInstancePerformanceRisk");
                        unmarshalledObject.CurrentInstancePerformanceRisk = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentStorageConfiguration":
                        context.AddPathSegment("CurrentStorageConfiguration");
                        unmarshalledObject.CurrentStorageConfiguration = DBStorageConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentStorageEstimatedMonthlyVolumeIOPsCostVariation":
                        context.AddPathSegment("CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation");
                        unmarshalledObject.CurrentStorageEstimatedMonthlyVolumeIOPsCostVariation = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "dbClusterIdentifier":
                        context.AddPathSegment("DbClusterIdentifier");
                        unmarshalledObject.DbClusterIdentifier = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "effectiveRecommendationPreferences":
                        context.AddPathSegment("EffectiveRecommendationPreferences");
                        unmarshalledObject.EffectiveRecommendationPreferences = RDSEffectiveRecommendationPreferencesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "engine":
                        context.AddPathSegment("Engine");
                        unmarshalledObject.Engine = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "engineVersion":
                        context.AddPathSegment("EngineVersion");
                        unmarshalledObject.EngineVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "idle":
                        context.AddPathSegment("Idle");
                        unmarshalledObject.Idle = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "instanceFinding":
                        context.AddPathSegment("InstanceFinding");
                        unmarshalledObject.InstanceFinding = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "instanceFindingReasonCodes":
                        context.AddPathSegment("InstanceFindingReasonCodes");
                        unmarshalledObject.InstanceFindingReasonCodes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "instanceRecommendationOptions":
                        context.AddPathSegment("InstanceRecommendationOptions");
                        unmarshalledObject.InstanceRecommendationOptions = new CborListUnmarshaller<RDSDBInstanceRecommendationOption, RDSDBInstanceRecommendationOptionUnmarshaller>(RDSDBInstanceRecommendationOptionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastRefreshTimestamp":
                        context.AddPathSegment("LastRefreshTimestamp");
                        unmarshalledObject.LastRefreshTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lookbackPeriodInDays":
                        context.AddPathSegment("LookbackPeriodInDays");
                        unmarshalledObject.LookbackPeriodInDays = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "promotionTier":
                        context.AddPathSegment("PromotionTier");
                        unmarshalledObject.PromotionTier = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceArn":
                        context.AddPathSegment("ResourceArn");
                        unmarshalledObject.ResourceArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "storageFinding":
                        context.AddPathSegment("StorageFinding");
                        unmarshalledObject.StorageFinding = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "storageFindingReasonCodes":
                        context.AddPathSegment("StorageFindingReasonCodes");
                        unmarshalledObject.StorageFindingReasonCodes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "storageRecommendationOptions":
                        context.AddPathSegment("StorageRecommendationOptions");
                        unmarshalledObject.StorageRecommendationOptions = new CborListUnmarshaller<RDSDBStorageRecommendationOption, RDSDBStorageRecommendationOptionUnmarshaller>(RDSDBStorageRecommendationOptionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "utilizationMetrics":
                        context.AddPathSegment("UtilizationMetrics");
                        unmarshalledObject.UtilizationMetrics = new CborListUnmarshaller<RDSDBUtilizationMetric, RDSDBUtilizationMetricUnmarshaller>(RDSDBUtilizationMetricUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

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
        public static RDSDBRecommendationUnmarshaller Instance => _instance;
    }
}
