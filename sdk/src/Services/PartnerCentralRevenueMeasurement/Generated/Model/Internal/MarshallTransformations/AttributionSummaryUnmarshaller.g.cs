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
    /// Response Unmarshaller for AttributionSummary Object
    /// </summary>
    public partial class AttributionSummaryUnmarshaller : ICborUnmarshaller<AttributionSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AttributionSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AttributionSummary();
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

                    case "EffectiveFrom":
                        context.AddPathSegment("EffectiveFrom");
                        unmarshalledObject.EffectiveFrom = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EffectiveUntil":
                        context.AddPathSegment("EffectiveUntil");
                        unmarshalledObject.EffectiveUntil = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastModifiedDate":
                        context.AddPathSegment("LastModifiedDate");
                        unmarshalledObject.LastModifiedDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LatestRevision":
                        context.AddPathSegment("LatestRevision");
                        unmarshalledObject.LatestRevision = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MarketplaceProduct":
                        context.AddPathSegment("MarketplaceProduct");
                        unmarshalledObject.MarketplaceProduct = MarketplaceProductSummaryUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TenancyModel":
                        context.AddPathSegment("TenancyModel");
                        unmarshalledObject.TenancyModel = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TotalActiveRevenueAttributionAllocationCount":
                        context.AddPathSegment("TotalActiveRevenueAttributionAllocationCount");
                        unmarshalledObject.TotalActiveRevenueAttributionAllocationCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TotalRevenueAttributionAllocationCount":
                        context.AddPathSegment("TotalRevenueAttributionAllocationCount");
                        unmarshalledObject.TotalRevenueAttributionAllocationCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static AttributionSummaryUnmarshaller _instance = new AttributionSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AttributionSummaryUnmarshaller Instance => _instance;
    }
}
