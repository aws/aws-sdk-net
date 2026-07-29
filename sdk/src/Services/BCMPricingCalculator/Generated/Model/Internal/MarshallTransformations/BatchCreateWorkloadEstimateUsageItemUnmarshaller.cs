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
    /// Response Unmarshaller for BatchCreateWorkloadEstimateUsageItem Object
    /// </summary>  
    public class BatchCreateWorkloadEstimateUsageItemUnmarshaller : ICborUnmarshaller<BatchCreateWorkloadEstimateUsageItem, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BatchCreateWorkloadEstimateUsageItem Unmarshall(CborUnmarshallerContext context)
        {
            BatchCreateWorkloadEstimateUsageItem unmarshalledObject = new BatchCreateWorkloadEstimateUsageItem();
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
                    case "cost":
                        {
                            context.AddPathSegment("Cost");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.Cost = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currency":
                        {
                            context.AddPathSegment("Currency");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Currency = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "group":
                        {
                            context.AddPathSegment("Group");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Group = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "historicalUsage":
                        {
                            context.AddPathSegment("HistoricalUsage");
                            var unmarshaller = HistoricalUsageEntityUnmarshaller.Instance;
                            unmarshalledObject.HistoricalUsage = unmarshaller.Unmarshall(context);
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
                    case "key":
                        {
                            context.AddPathSegment("Key");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Key = unmarshaller.Unmarshall(context);
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
                    case "quantity":
                        {
                            context.AddPathSegment("Quantity");
                            var unmarshaller = WorkloadEstimateUsageQuantityUnmarshaller.Instance;
                            unmarshalledObject.Quantity = unmarshaller.Unmarshall(context);
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
                    case "status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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


        private static BatchCreateWorkloadEstimateUsageItemUnmarshaller _instance = new BatchCreateWorkloadEstimateUsageItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchCreateWorkloadEstimateUsageItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}