/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReservationPurchaseRecommendationDetail Object
    /// </summary>  
    public class ReservationPurchaseRecommendationDetailUnmarshaller : IUnmarshaller<ReservationPurchaseRecommendationDetail, XmlUnmarshallerContext>, IUnmarshaller<ReservationPurchaseRecommendationDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReservationPurchaseRecommendationDetail IUnmarshaller<ReservationPurchaseRecommendationDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReservationPurchaseRecommendationDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReservationPurchaseRecommendationDetail unmarshalledObject = new ReservationPurchaseRecommendationDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AverageNormalizedUnitsUsedPerHour", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AverageNormalizedUnitsUsedPerHour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AverageNumberOfInstancesUsedPerHour", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AverageNumberOfInstancesUsedPerHour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AverageUtilization", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AverageUtilization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedBreakEvenInMonths", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedBreakEvenInMonths = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlyOnDemandCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlyOnDemandCost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlySavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlySavingsAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlySavingsPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlySavingsPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedReservationCostForLookbackPeriod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedReservationCostForLookbackPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceDetails", targetDepth))
                {
                    var unmarshaller = InstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.InstanceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumNormalizedUnitsUsedPerHour", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaximumNormalizedUnitsUsedPerHour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumNumberOfInstancesUsedPerHour", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaximumNumberOfInstancesUsedPerHour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinimumNormalizedUnitsUsedPerHour", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MinimumNormalizedUnitsUsedPerHour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinimumNumberOfInstancesUsedPerHour", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MinimumNumberOfInstancesUsedPerHour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecommendedNormalizedUnitsToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecommendedNormalizedUnitsToPurchase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecommendedNumberOfInstancesToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecommendedNumberOfInstancesToPurchase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecurringStandardMonthlyCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecurringStandardMonthlyCost = unmarshaller.Unmarshall(context);
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


        private static ReservationPurchaseRecommendationDetailUnmarshaller _instance = new ReservationPurchaseRecommendationDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReservationPurchaseRecommendationDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}