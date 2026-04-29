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
    /// Response Unmarshaller for InstanceRecommendation Object
    /// </summary>  
    public class InstanceRecommendationUnmarshaller : ICborUnmarshaller<InstanceRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            InstanceRecommendation unmarshalledObject = new InstanceRecommendation();
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
                    case "currentInstanceGpuInfo":
                        {
                            context.AddPathSegment("CurrentInstanceGpuInfo");
                            var unmarshaller = GpuInfoUnmarshaller.Instance;
                            unmarshalledObject.CurrentInstanceGpuInfo = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentInstanceType":
                        {
                            context.AddPathSegment("CurrentInstanceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentInstanceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentPerformanceRisk":
                        {
                            context.AddPathSegment("CurrentPerformanceRisk");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentPerformanceRisk = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "effectiveRecommendationPreferences":
                        {
                            context.AddPathSegment("EffectiveRecommendationPreferences");
                            var unmarshaller = EffectiveRecommendationPreferencesUnmarshaller.Instance;
                            unmarshalledObject.EffectiveRecommendationPreferences = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "externalMetricStatus":
                        {
                            context.AddPathSegment("ExternalMetricStatus");
                            var unmarshaller = ExternalMetricStatusUnmarshaller.Instance;
                            unmarshalledObject.ExternalMetricStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "finding":
                        {
                            context.AddPathSegment("Finding");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Finding = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "findingReasonCodes":
                        {
                            context.AddPathSegment("FindingReasonCodes");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.FindingReasonCodes = unmarshaller.Unmarshall(context);
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
                    case "inferredWorkloadTypes":
                        {
                            context.AddPathSegment("InferredWorkloadTypes");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.InferredWorkloadTypes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "instanceArn":
                        {
                            context.AddPathSegment("InstanceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "instanceName":
                        {
                            context.AddPathSegment("InstanceName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "instanceState":
                        {
                            context.AddPathSegment("InstanceState");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceState = unmarshaller.Unmarshall(context);
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
                    case "lookBackPeriodInDays":
                        {
                            context.AddPathSegment("LookBackPeriodInDays");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.LookBackPeriodInDays = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendationOptions":
                        {
                            context.AddPathSegment("RecommendationOptions");
                            var unmarshaller = new CborListUnmarshaller<InstanceRecommendationOption, InstanceRecommendationOptionUnmarshaller>(InstanceRecommendationOptionUnmarshaller.Instance);
                            unmarshalledObject.RecommendationOptions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendationSources":
                        {
                            context.AddPathSegment("RecommendationSources");
                            var unmarshaller = new CborListUnmarshaller<RecommendationSource, RecommendationSourceUnmarshaller>(RecommendationSourceUnmarshaller.Instance);
                            unmarshalledObject.RecommendationSources = unmarshaller.Unmarshall(context);
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
                            var unmarshaller = new CborListUnmarshaller<UtilizationMetric, UtilizationMetricUnmarshaller>(UtilizationMetricUnmarshaller.Instance);
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


        private static InstanceRecommendationUnmarshaller _instance = new InstanceRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}