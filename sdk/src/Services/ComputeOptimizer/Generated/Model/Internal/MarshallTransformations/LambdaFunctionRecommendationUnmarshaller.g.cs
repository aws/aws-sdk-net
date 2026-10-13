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
    /// Response Unmarshaller for LambdaFunctionRecommendation Object
    /// </summary>
    public partial class LambdaFunctionRecommendationUnmarshaller : ICborUnmarshaller<LambdaFunctionRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public LambdaFunctionRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new LambdaFunctionRecommendation();
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

                    case "currentMemorySize":
                        context.AddPathSegment("CurrentMemorySize");
                        unmarshalledObject.CurrentMemorySize = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentPerformanceRisk":
                        context.AddPathSegment("CurrentPerformanceRisk");
                        unmarshalledObject.CurrentPerformanceRisk = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "effectiveRecommendationPreferences":
                        context.AddPathSegment("EffectiveRecommendationPreferences");
                        unmarshalledObject.EffectiveRecommendationPreferences = LambdaEffectiveRecommendationPreferencesUnmarshaller.Instance.Unmarshall(context);
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

                    case "functionArn":
                        context.AddPathSegment("FunctionArn");
                        unmarshalledObject.FunctionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "functionVersion":
                        context.AddPathSegment("FunctionVersion");
                        unmarshalledObject.FunctionVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "memorySizeRecommendationOptions":
                        context.AddPathSegment("MemorySizeRecommendationOptions");
                        unmarshalledObject.MemorySizeRecommendationOptions = new CborListUnmarshaller<LambdaFunctionMemoryRecommendationOption, LambdaFunctionMemoryRecommendationOptionUnmarshaller>(LambdaFunctionMemoryRecommendationOptionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "numberOfInvocations":
                        context.AddPathSegment("NumberOfInvocations");
                        unmarshalledObject.NumberOfInvocations = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "utilizationMetrics":
                        context.AddPathSegment("UtilizationMetrics");
                        unmarshalledObject.UtilizationMetrics = new CborListUnmarshaller<LambdaFunctionUtilizationMetric, LambdaFunctionUtilizationMetricUnmarshaller>(LambdaFunctionUtilizationMetricUnmarshaller.Instance).Unmarshall(context);
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

        private static LambdaFunctionRecommendationUnmarshaller _instance = new LambdaFunctionRecommendationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static LambdaFunctionRecommendationUnmarshaller Instance => _instance;
    }
}
