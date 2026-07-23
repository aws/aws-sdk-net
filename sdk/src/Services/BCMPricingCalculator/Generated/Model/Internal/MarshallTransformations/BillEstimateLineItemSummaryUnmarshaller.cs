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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BillEstimateLineItemSummary Object
    /// </summary>  
    public class BillEstimateLineItemSummaryUnmarshaller : ICborUnmarshaller<BillEstimateLineItemSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BillEstimateLineItemSummary Unmarshall(CborUnmarshallerContext context)
        {
            BillEstimateLineItemSummary unmarshalledObject = new BillEstimateLineItemSummary();
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
                    case "availabilityZone":
                        {
                            context.AddPathSegment("AvailabilityZone");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "estimatedCost":
                        {
                            context.AddPathSegment("EstimatedCost");
                            var unmarshaller = CostAmountUnmarshaller.Instance;
                            unmarshalledObject.EstimatedCost = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "estimatedUsageQuantity":
                        {
                            context.AddPathSegment("EstimatedUsageQuantity");
                            var unmarshaller = UsageQuantityResultUnmarshaller.Instance;
                            unmarshalledObject.EstimatedUsageQuantity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "historicalCost":
                        {
                            context.AddPathSegment("HistoricalCost");
                            var unmarshaller = CostAmountUnmarshaller.Instance;
                            unmarshalledObject.HistoricalCost = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "historicalUsageQuantity":
                        {
                            context.AddPathSegment("HistoricalUsageQuantity");
                            var unmarshaller = UsageQuantityResultUnmarshaller.Instance;
                            unmarshalledObject.HistoricalUsageQuantity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "id":
                        {
                            context.AddPathSegment("Id");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lineItemId":
                        {
                            context.AddPathSegment("LineItemId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LineItemId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lineItemType":
                        {
                            context.AddPathSegment("LineItemType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LineItemType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "location":
                        {
                            context.AddPathSegment("Location");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Location = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "operation":
                        {
                            context.AddPathSegment("Operation");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Operation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "payerAccountId":
                        {
                            context.AddPathSegment("PayerAccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PayerAccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "savingsPlanArns":
                        {
                            context.AddPathSegment("SavingsPlanArns");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.SavingsPlanArns = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "serviceCode":
                        {
                            context.AddPathSegment("ServiceCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ServiceCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "usageAccountId":
                        {
                            context.AddPathSegment("UsageAccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UsageAccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "usageType":
                        {
                            context.AddPathSegment("UsageType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UsageType = unmarshaller.Unmarshall(context);
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


        private static BillEstimateLineItemSummaryUnmarshaller _instance = new BillEstimateLineItemSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BillEstimateLineItemSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}