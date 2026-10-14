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

using Amazon.Snowball.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LongTermPricingListEntry Object
    /// </summary>
    public partial class LongTermPricingListEntryUnmarshaller : ICborUnmarshaller<LongTermPricingListEntry, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public LongTermPricingListEntry Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new LongTermPricingListEntry();
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
                    case "CurrentActiveJob":
                        context.AddPathSegment("CurrentActiveJob");
                        unmarshalledObject.CurrentActiveJob = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IsLongTermPricingAutoRenew":
                        context.AddPathSegment("IsLongTermPricingAutoRenew");
                        unmarshalledObject.IsLongTermPricingAutoRenew = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobIds":
                        context.AddPathSegment("JobIds");
                        unmarshalledObject.JobIds = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LongTermPricingEndDate":
                        context.AddPathSegment("LongTermPricingEndDate");
                        unmarshalledObject.LongTermPricingEndDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LongTermPricingId":
                        context.AddPathSegment("LongTermPricingId");
                        unmarshalledObject.LongTermPricingId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LongTermPricingStartDate":
                        context.AddPathSegment("LongTermPricingStartDate");
                        unmarshalledObject.LongTermPricingStartDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LongTermPricingStatus":
                        context.AddPathSegment("LongTermPricingStatus");
                        unmarshalledObject.LongTermPricingStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LongTermPricingType":
                        context.AddPathSegment("LongTermPricingType");
                        unmarshalledObject.LongTermPricingType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ReplacementJob":
                        context.AddPathSegment("ReplacementJob");
                        unmarshalledObject.ReplacementJob = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnowballType":
                        context.AddPathSegment("SnowballType");
                        unmarshalledObject.SnowballType = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static LongTermPricingListEntryUnmarshaller _instance = new LongTermPricingListEntryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static LongTermPricingListEntryUnmarshaller Instance => _instance;
    }
}
