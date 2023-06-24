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
using ThirdParty.Json.LitJson;

namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecommendationSummary Object
    /// </summary>  
    public class RecommendationSummaryUnmarshaller : IUnmarshaller<RecommendationSummary, XmlUnmarshallerContext>, IUnmarshaller<RecommendationSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecommendationSummary IUnmarshaller<RecommendationSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecommendationSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecommendationSummary unmarshalledObject = new RecommendationSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentPerformanceRiskRatings", targetDepth))
                {
                    var unmarshaller = CurrentPerformanceRiskRatingsUnmarshaller.Instance;
                    unmarshalledObject.CurrentPerformanceRiskRatings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inferredWorkloadSavings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InferredWorkloadSaving, InferredWorkloadSavingUnmarshaller>(InferredWorkloadSavingUnmarshaller.Instance);
                    unmarshalledObject.InferredWorkloadSavings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendationResourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecommendationResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("savingsOpportunity", targetDepth))
                {
                    var unmarshaller = SavingsOpportunityUnmarshaller.Instance;
                    unmarshalledObject.SavingsOpportunity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("summaries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Summary, SummaryUnmarshaller>(SummaryUnmarshaller.Instance);
                    unmarshalledObject.Summaries = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
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