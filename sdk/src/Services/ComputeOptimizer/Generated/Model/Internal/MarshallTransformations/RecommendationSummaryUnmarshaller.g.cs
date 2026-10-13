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
    /// Response Unmarshaller for RecommendationSummary Object
    /// </summary>
    public partial class RecommendationSummaryUnmarshaller : ICborUnmarshaller<RecommendationSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RecommendationSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RecommendationSummary();
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

                    case "aggregatedSavingsOpportunity":
                        context.AddPathSegment("AggregatedSavingsOpportunity");
                        unmarshalledObject.AggregatedSavingsOpportunity = SavingsOpportunityUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentPerformanceRiskRatings":
                        context.AddPathSegment("CurrentPerformanceRiskRatings");
                        unmarshalledObject.CurrentPerformanceRiskRatings = CurrentPerformanceRiskRatingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "idleSavingsOpportunity":
                        context.AddPathSegment("IdleSavingsOpportunity");
                        unmarshalledObject.IdleSavingsOpportunity = SavingsOpportunityUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "idleSummaries":
                        context.AddPathSegment("IdleSummaries");
                        unmarshalledObject.IdleSummaries = new CborListUnmarshaller<IdleSummary, IdleSummaryUnmarshaller>(IdleSummaryUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "inferredWorkloadSavings":
                        context.AddPathSegment("InferredWorkloadSavings");
                        unmarshalledObject.InferredWorkloadSavings = new CborListUnmarshaller<InferredWorkloadSaving, InferredWorkloadSavingUnmarshaller>(InferredWorkloadSavingUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendationResourceType":
                        context.AddPathSegment("RecommendationResourceType");
                        unmarshalledObject.RecommendationResourceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "savingsOpportunity":
                        context.AddPathSegment("SavingsOpportunity");
                        unmarshalledObject.SavingsOpportunity = SavingsOpportunityUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "summaries":
                        context.AddPathSegment("Summaries");
                        unmarshalledObject.Summaries = new CborListUnmarshaller<Summary, SummaryUnmarshaller>(SummaryUnmarshaller.Instance).Unmarshall(context);
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

        private static RecommendationSummaryUnmarshaller _instance = new RecommendationSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RecommendationSummaryUnmarshaller Instance => _instance;
    }
}
