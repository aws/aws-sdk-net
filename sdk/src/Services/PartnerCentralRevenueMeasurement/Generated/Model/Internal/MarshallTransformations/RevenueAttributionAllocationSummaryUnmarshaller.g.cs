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
    /// Response Unmarshaller for RevenueAttributionAllocationSummary Object
    /// </summary>
    public partial class RevenueAttributionAllocationSummaryUnmarshaller : ICborUnmarshaller<RevenueAttributionAllocationSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RevenueAttributionAllocationSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RevenueAttributionAllocationSummary();
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
                    case "CustomerAwsAccountId":
                        context.AddPathSegment("CustomerAwsAccountId");
                        unmarshalledObject.CustomerAwsAccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "EntityIdentifier":
                        context.AddPathSegment("EntityIdentifier");
                        unmarshalledObject.EntityIdentifier = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EntityName":
                        context.AddPathSegment("EntityName");
                        unmarshalledObject.EntityName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EntityType":
                        context.AddPathSegment("EntityType");
                        unmarshalledObject.EntityType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RevenueAttributionAllocationId":
                        context.AddPathSegment("RevenueAttributionAllocationId");
                        unmarshalledObject.RevenueAttributionAllocationId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RevenueAttributionIdentifier":
                        context.AddPathSegment("RevenueAttributionIdentifier");
                        unmarshalledObject.RevenueAttributionIdentifier = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RevenueSharePercent":
                        context.AddPathSegment("RevenueSharePercent");
                        unmarshalledObject.RevenueSharePercent = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static RevenueAttributionAllocationSummaryUnmarshaller _instance = new RevenueAttributionAllocationSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RevenueAttributionAllocationSummaryUnmarshaller Instance => _instance;
    }
}
