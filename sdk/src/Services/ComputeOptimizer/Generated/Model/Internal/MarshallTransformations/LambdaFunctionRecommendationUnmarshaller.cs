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
    /// Response Unmarshaller for LambdaFunctionRecommendation Object
    /// </summary>  
    public class LambdaFunctionRecommendationUnmarshaller : ICborUnmarshaller<LambdaFunctionRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LambdaFunctionRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            LambdaFunctionRecommendation unmarshalledObject = new LambdaFunctionRecommendation();
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
                    case "currentMemorySize":
                        {
                            context.AddPathSegment("CurrentMemorySize");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.CurrentMemorySize = unmarshaller.Unmarshall(context);
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
                            var unmarshaller = LambdaEffectiveRecommendationPreferencesUnmarshaller.Instance;
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
                    case "functionArn":
                        {
                            context.AddPathSegment("FunctionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FunctionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "functionVersion":
                        {
                            context.AddPathSegment("FunctionVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FunctionVersion = unmarshaller.Unmarshall(context);
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
                    case "memorySizeRecommendationOptions":
                        {
                            context.AddPathSegment("MemorySizeRecommendationOptions");
                            var unmarshaller = new CborListUnmarshaller<LambdaFunctionMemoryRecommendationOption, LambdaFunctionMemoryRecommendationOptionUnmarshaller>(LambdaFunctionMemoryRecommendationOptionUnmarshaller.Instance);
                            unmarshalledObject.MemorySizeRecommendationOptions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "numberOfInvocations":
                        {
                            context.AddPathSegment("NumberOfInvocations");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.NumberOfInvocations = unmarshaller.Unmarshall(context);
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
                            var unmarshaller = new CborListUnmarshaller<LambdaFunctionUtilizationMetric, LambdaFunctionUtilizationMetricUnmarshaller>(LambdaFunctionUtilizationMetricUnmarshaller.Instance);
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


        private static LambdaFunctionRecommendationUnmarshaller _instance = new LambdaFunctionRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LambdaFunctionRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}