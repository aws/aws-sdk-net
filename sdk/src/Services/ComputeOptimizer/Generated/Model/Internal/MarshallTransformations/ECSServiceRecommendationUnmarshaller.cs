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
    /// Response Unmarshaller for ECSServiceRecommendation Object
    /// </summary>  
    public class ECSServiceRecommendationUnmarshaller : ICborUnmarshaller<ECSServiceRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ECSServiceRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            ECSServiceRecommendation unmarshalledObject = new ECSServiceRecommendation();
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
                    case "currentPerformanceRisk":
                        {
                            context.AddPathSegment("CurrentPerformanceRisk");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentPerformanceRisk = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentServiceConfiguration":
                        {
                            context.AddPathSegment("CurrentServiceConfiguration");
                            var unmarshaller = ServiceConfigurationUnmarshaller.Instance;
                            unmarshalledObject.CurrentServiceConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "effectiveRecommendationPreferences":
                        {
                            context.AddPathSegment("EffectiveRecommendationPreferences");
                            var unmarshaller = ECSEffectiveRecommendationPreferencesUnmarshaller.Instance;
                            unmarshalledObject.EffectiveRecommendationPreferences = unmarshaller.Unmarshall(context);
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
                    case "lastRefreshTimestamp":
                        {
                            context.AddPathSegment("LastRefreshTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastRefreshTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "launchType":
                        {
                            context.AddPathSegment("LaunchType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LaunchType = unmarshaller.Unmarshall(context);
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
                    case "serviceArn":
                        {
                            context.AddPathSegment("ServiceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ServiceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "serviceRecommendationOptions":
                        {
                            context.AddPathSegment("ServiceRecommendationOptions");
                            var unmarshaller = new CborListUnmarshaller<ECSServiceRecommendationOption, ECSServiceRecommendationOptionUnmarshaller>(ECSServiceRecommendationOptionUnmarshaller.Instance);
                            unmarshalledObject.ServiceRecommendationOptions = unmarshaller.Unmarshall(context);
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
                            var unmarshaller = new CborListUnmarshaller<ECSServiceUtilizationMetric, ECSServiceUtilizationMetricUnmarshaller>(ECSServiceUtilizationMetricUnmarshaller.Instance);
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


        private static ECSServiceRecommendationUnmarshaller _instance = new ECSServiceRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ECSServiceRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}