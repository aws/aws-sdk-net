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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralRevenueMeasurement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralRevenueMeasurement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MarketplaceRevenueShareAllocationSummary Object
    /// </summary>  
    public class MarketplaceRevenueShareAllocationSummaryUnmarshaller : ICborUnmarshaller<MarketplaceRevenueShareAllocationSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MarketplaceRevenueShareAllocationSummary Unmarshall(CborUnmarshallerContext context)
        {
            MarketplaceRevenueShareAllocationSummary unmarshalledObject = new MarketplaceRevenueShareAllocationSummary();
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
                    case "Arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedDate":
                        {
                            context.AddPathSegment("CreatedDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EffectiveFrom":
                        {
                            context.AddPathSegment("EffectiveFrom");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EffectiveFrom = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EffectiveUntil":
                        {
                            context.AddPathSegment("EffectiveUntil");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EffectiveUntil = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastModifiedDate":
                        {
                            context.AddPathSegment("LastModifiedDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MarketplaceRevenueShareAllocationId":
                        {
                            context.AddPathSegment("MarketplaceRevenueShareAllocationId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MarketplaceRevenueShareAllocationId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ProductId":
                        {
                            context.AddPathSegment("ProductId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ProductId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ProductName":
                        {
                            context.AddPathSegment("ProductName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ProductName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RevenueSharePercent":
                        {
                            context.AddPathSegment("RevenueSharePercent");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RevenueSharePercent = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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


        private static MarketplaceRevenueShareAllocationSummaryUnmarshaller _instance = new MarketplaceRevenueShareAllocationSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MarketplaceRevenueShareAllocationSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}