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
    /// Response Unmarshaller for InstanceRecommendation Object
    /// </summary>
    public partial class InstanceRecommendationUnmarshaller : ICborUnmarshaller<InstanceRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public InstanceRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new InstanceRecommendation();
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

                    case "currentInstanceGpuInfo":
                        context.AddPathSegment("CurrentInstanceGpuInfo");
                        unmarshalledObject.CurrentInstanceGpuInfo = GpuInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentInstanceType":
                        context.AddPathSegment("CurrentInstanceType");
                        unmarshalledObject.CurrentInstanceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentPerformanceRisk":
                        context.AddPathSegment("CurrentPerformanceRisk");
                        unmarshalledObject.CurrentPerformanceRisk = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "effectiveRecommendationPreferences":
                        context.AddPathSegment("EffectiveRecommendationPreferences");
                        unmarshalledObject.EffectiveRecommendationPreferences = EffectiveRecommendationPreferencesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "externalMetricStatus":
                        context.AddPathSegment("ExternalMetricStatus");
                        unmarshalledObject.ExternalMetricStatus = ExternalMetricStatusUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "finding":
                        context.AddPathSegment("Finding");
                        unmarshalledObject.Finding = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "findingReasonCodes":
                        context.AddPathSegment("FindingReasonCodes");
                        unmarshalledObject.FindingReasonCodes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "idle":
                        context.AddPathSegment("Idle");
                        unmarshalledObject.Idle = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "inferredWorkloadTypes":
                        context.AddPathSegment("InferredWorkloadTypes");
                        unmarshalledObject.InferredWorkloadTypes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "instanceArn":
                        context.AddPathSegment("InstanceArn");
                        unmarshalledObject.InstanceArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "instanceName":
                        context.AddPathSegment("InstanceName");
                        unmarshalledObject.InstanceName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "instanceState":
                        context.AddPathSegment("InstanceState");
                        unmarshalledObject.InstanceState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastRefreshTimestamp":
                        context.AddPathSegment("LastRefreshTimestamp");
                        unmarshalledObject.LastRefreshTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lookBackPeriodInDays":
                        context.AddPathSegment("LookBackPeriodInDays");
                        unmarshalledObject.LookBackPeriodInDays = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendationOptions":
                        context.AddPathSegment("RecommendationOptions");
                        unmarshalledObject.RecommendationOptions = new CborListUnmarshaller<InstanceRecommendationOption, InstanceRecommendationOptionUnmarshaller>(InstanceRecommendationOptionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendationSources":
                        context.AddPathSegment("RecommendationSources");
                        unmarshalledObject.RecommendationSources = new CborListUnmarshaller<RecommendationSource, RecommendationSourceUnmarshaller>(RecommendationSourceUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "utilizationMetrics":
                        context.AddPathSegment("UtilizationMetrics");
                        unmarshalledObject.UtilizationMetrics = new CborListUnmarshaller<UtilizationMetric, UtilizationMetricUnmarshaller>(UtilizationMetricUnmarshaller.Instance).Unmarshall(context);
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

        private static InstanceRecommendationUnmarshaller _instance = new InstanceRecommendationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InstanceRecommendationUnmarshaller Instance => _instance;
    }
}
