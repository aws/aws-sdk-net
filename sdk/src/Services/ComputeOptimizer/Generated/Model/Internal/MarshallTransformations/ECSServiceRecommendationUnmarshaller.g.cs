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
    /// Response Unmarshaller for ECSServiceRecommendation Object
    /// </summary>
    public partial class ECSServiceRecommendationUnmarshaller : ICborUnmarshaller<ECSServiceRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ECSServiceRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ECSServiceRecommendation();
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

                    case "currentPerformanceRisk":
                        context.AddPathSegment("CurrentPerformanceRisk");
                        unmarshalledObject.CurrentPerformanceRisk = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentServiceConfiguration":
                        context.AddPathSegment("CurrentServiceConfiguration");
                        unmarshalledObject.CurrentServiceConfiguration = ServiceConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "effectiveRecommendationPreferences":
                        context.AddPathSegment("EffectiveRecommendationPreferences");
                        unmarshalledObject.EffectiveRecommendationPreferences = ECSEffectiveRecommendationPreferencesUnmarshaller.Instance.Unmarshall(context);
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

                    case "lastRefreshTimestamp":
                        context.AddPathSegment("LastRefreshTimestamp");
                        unmarshalledObject.LastRefreshTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "launchType":
                        context.AddPathSegment("LaunchType");
                        unmarshalledObject.LaunchType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lookbackPeriodInDays":
                        context.AddPathSegment("LookbackPeriodInDays");
                        unmarshalledObject.LookbackPeriodInDays = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "serviceArn":
                        context.AddPathSegment("ServiceArn");
                        unmarshalledObject.ServiceArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "serviceRecommendationOptions":
                        context.AddPathSegment("ServiceRecommendationOptions");
                        unmarshalledObject.ServiceRecommendationOptions = new CborListUnmarshaller<ECSServiceRecommendationOption, ECSServiceRecommendationOptionUnmarshaller>(ECSServiceRecommendationOptionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "utilizationMetrics":
                        context.AddPathSegment("UtilizationMetrics");
                        unmarshalledObject.UtilizationMetrics = new CborListUnmarshaller<ECSServiceUtilizationMetric, ECSServiceUtilizationMetricUnmarshaller>(ECSServiceUtilizationMetricUnmarshaller.Instance).Unmarshall(context);
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

        private static ECSServiceRecommendationUnmarshaller _instance = new ECSServiceRecommendationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ECSServiceRecommendationUnmarshaller Instance => _instance;
    }
}
