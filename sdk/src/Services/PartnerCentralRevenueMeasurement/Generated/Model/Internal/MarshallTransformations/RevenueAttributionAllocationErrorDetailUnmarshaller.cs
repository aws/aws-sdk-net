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
    /// Response Unmarshaller for RevenueAttributionAllocationErrorDetail Object
    /// </summary>  
    public class RevenueAttributionAllocationErrorDetailUnmarshaller : ICborUnmarshaller<RevenueAttributionAllocationErrorDetail, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RevenueAttributionAllocationErrorDetail Unmarshall(CborUnmarshallerContext context)
        {
            RevenueAttributionAllocationErrorDetail unmarshalledObject = new RevenueAttributionAllocationErrorDetail();
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
                    case "Action":
                        {
                            context.AddPathSegment("Action");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Action = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CustomerAwsAccountId":
                        {
                            context.AddPathSegment("CustomerAwsAccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CustomerAwsAccountId = unmarshaller.Unmarshall(context);
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
                    case "EntityId":
                        {
                            context.AddPathSegment("EntityId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EntityId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EntityType":
                        {
                            context.AddPathSegment("EntityType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EntityType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ErrorCode":
                        {
                            context.AddPathSegment("ErrorCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ErrorMessage":
                        {
                            context.AddPathSegment("ErrorMessage");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RevenueAttributionAllocationId":
                        {
                            context.AddPathSegment("RevenueAttributionAllocationId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RevenueAttributionAllocationId = unmarshaller.Unmarshall(context);
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


        private static RevenueAttributionAllocationErrorDetailUnmarshaller _instance = new RevenueAttributionAllocationErrorDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RevenueAttributionAllocationErrorDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}