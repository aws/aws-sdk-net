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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SavingsPlansPurchaseRecommendationDetail Object
    /// </summary>  
    public class SavingsPlansPurchaseRecommendationDetailUnmarshaller : IJsonUnmarshaller<SavingsPlansPurchaseRecommendationDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SavingsPlansPurchaseRecommendationDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SavingsPlansPurchaseRecommendationDetail unmarshalledObject = new SavingsPlansPurchaseRecommendationDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CurrencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CurrentAverageHourlyOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentAverageHourlyOnDemandSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CurrentMaximumHourlyOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentMaximumHourlyOnDemandSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CurrentMinimumHourlyOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentMinimumHourlyOnDemandSpend = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedAverageUtilization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedAverageUtilization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlySavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlySavingsAmount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedOnDemandCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedOnDemandCost = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedOnDemandCostWithCurrentCommitment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedOnDemandCostWithCurrentCommitment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedROI", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedROI = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedSavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedSavingsAmount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedSavingsPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedSavingsPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EstimatedSPCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedSPCost = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HourlyCommitmentToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HourlyCommitmentToPurchase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RecommendationDetailId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecommendationDetailId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SavingsPlansDetails", targetDepth))
                {
                    var unmarshaller = SavingsPlansDetailsUnmarshaller.Instance;
                    unmarshalledObject.SavingsPlansDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpfrontCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpfrontCost = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SavingsPlansPurchaseRecommendationDetailUnmarshaller _instance = new SavingsPlansPurchaseRecommendationDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SavingsPlansPurchaseRecommendationDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}