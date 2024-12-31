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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SavingsPlansPurchaseAnalysisDetails Object
    /// </summary>  
    public class SavingsPlansPurchaseAnalysisDetailsUnmarshaller : IUnmarshaller<SavingsPlansPurchaseAnalysisDetails, XmlUnmarshallerContext>, IUnmarshaller<SavingsPlansPurchaseAnalysisDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SavingsPlansPurchaseAnalysisDetails IUnmarshaller<SavingsPlansPurchaseAnalysisDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SavingsPlansPurchaseAnalysisDetails Unmarshall(JsonUnmarshallerContext context)
        {
            SavingsPlansPurchaseAnalysisDetails unmarshalledObject = new SavingsPlansPurchaseAnalysisDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalMetadata", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdditionalMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentAverageCoverage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentAverageCoverage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentAverageHourlyOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentAverageHourlyOnDemandSpend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentMaximumHourlyOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentMaximumHourlyOnDemandSpend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentMinimumHourlyOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentMinimumHourlyOnDemandSpend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentOnDemandSpend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedAverageCoverage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedAverageCoverage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedAverageUtilization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedAverageUtilization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedCommitmentCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedCommitmentCost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlySavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlySavingsAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedOnDemandCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedOnDemandCost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedOnDemandCostWithCurrentCommitment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedOnDemandCostWithCurrentCommitment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedROI", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedROI = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedSavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedSavingsAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedSavingsPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedSavingsPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExistingHourlyCommitment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExistingHourlyCommitment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HourlyCommitmentToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HourlyCommitmentToPurchase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestUsageTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LatestUsageTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LookbackPeriodInHours", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LookbackPeriodInHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricsOverLookbackPeriod", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RecommendationDetailHourlyMetrics, RecommendationDetailHourlyMetricsUnmarshaller>(RecommendationDetailHourlyMetricsUnmarshaller.Instance);
                    unmarshalledObject.MetricsOverLookbackPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpfrontCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpfrontCost = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SavingsPlansPurchaseAnalysisDetailsUnmarshaller _instance = new SavingsPlansPurchaseAnalysisDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SavingsPlansPurchaseAnalysisDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}