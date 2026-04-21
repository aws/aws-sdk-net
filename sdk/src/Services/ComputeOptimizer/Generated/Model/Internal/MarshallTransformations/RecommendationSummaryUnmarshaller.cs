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
    /// Response Unmarshaller for RecommendationSummary Object
    /// </summary>  
    public class RecommendationSummaryUnmarshaller : ICborUnmarshaller<RecommendationSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RecommendationSummary Unmarshall(CborUnmarshallerContext context)
        {
            RecommendationSummary unmarshalledObject = new RecommendationSummary();
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
                    case "aggregatedSavingsOpportunity":
                        {
                            context.AddPathSegment("AggregatedSavingsOpportunity");
                            var unmarshaller = SavingsOpportunityUnmarshaller.Instance;
                            unmarshalledObject.AggregatedSavingsOpportunity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentPerformanceRiskRatings":
                        {
                            context.AddPathSegment("CurrentPerformanceRiskRatings");
                            var unmarshaller = CurrentPerformanceRiskRatingsUnmarshaller.Instance;
                            unmarshalledObject.CurrentPerformanceRiskRatings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "idleSavingsOpportunity":
                        {
                            context.AddPathSegment("IdleSavingsOpportunity");
                            var unmarshaller = SavingsOpportunityUnmarshaller.Instance;
                            unmarshalledObject.IdleSavingsOpportunity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "idleSummaries":
                        {
                            context.AddPathSegment("IdleSummaries");
                            var unmarshaller = new CborListUnmarshaller<IdleSummary, IdleSummaryUnmarshaller>(IdleSummaryUnmarshaller.Instance);
                            unmarshalledObject.IdleSummaries = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "inferredWorkloadSavings":
                        {
                            context.AddPathSegment("InferredWorkloadSavings");
                            var unmarshaller = new CborListUnmarshaller<InferredWorkloadSaving, InferredWorkloadSavingUnmarshaller>(InferredWorkloadSavingUnmarshaller.Instance);
                            unmarshalledObject.InferredWorkloadSavings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendationResourceType":
                        {
                            context.AddPathSegment("RecommendationResourceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RecommendationResourceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "savingsOpportunity":
                        {
                            context.AddPathSegment("SavingsOpportunity");
                            var unmarshaller = SavingsOpportunityUnmarshaller.Instance;
                            unmarshalledObject.SavingsOpportunity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "summaries":
                        {
                            context.AddPathSegment("Summaries");
                            var unmarshaller = new CborListUnmarshaller<Summary, SummaryUnmarshaller>(SummaryUnmarshaller.Instance);
                            unmarshalledObject.Summaries = unmarshaller.Unmarshall(context);
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


        private static RecommendationSummaryUnmarshaller _instance = new RecommendationSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecommendationSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}