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

using Amazon.PartnerCentralRevenueMeasurement.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralRevenueMeasurement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MarketplaceRevenueShareSummary Object
    /// </summary>
    public partial class MarketplaceRevenueShareSummaryUnmarshaller : ICborUnmarshaller<MarketplaceRevenueShareSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public MarketplaceRevenueShareSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new MarketplaceRevenueShareSummary();
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
                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Catalog":
                        context.AddPathSegment("Catalog");
                        unmarshalledObject.Catalog = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedDate":
                        context.AddPathSegment("CreatedDate");
                        unmarshalledObject.CreatedDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastModifiedDate":
                        context.AddPathSegment("LastModifiedDate");
                        unmarshalledObject.LastModifiedDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LatestRevision":
                        context.AddPathSegment("LatestRevision");
                        unmarshalledObject.LatestRevision = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProductCode":
                        context.AddPathSegment("ProductCode");
                        unmarshalledObject.ProductCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProductId":
                        context.AddPathSegment("ProductId");
                        unmarshalledObject.ProductId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProductName":
                        context.AddPathSegment("ProductName");
                        unmarshalledObject.ProductName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TotalActiveMarketplaceRevenueShareAllocationCount":
                        context.AddPathSegment("TotalActiveMarketplaceRevenueShareAllocationCount");
                        unmarshalledObject.TotalActiveMarketplaceRevenueShareAllocationCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TotalMarketplaceRevenueShareAllocationCount":
                        context.AddPathSegment("TotalMarketplaceRevenueShareAllocationCount");
                        unmarshalledObject.TotalMarketplaceRevenueShareAllocationCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static MarketplaceRevenueShareSummaryUnmarshaller _instance = new MarketplaceRevenueShareSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MarketplaceRevenueShareSummaryUnmarshaller Instance => _instance;
    }
}
