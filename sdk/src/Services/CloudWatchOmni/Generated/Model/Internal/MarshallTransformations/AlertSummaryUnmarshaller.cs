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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AlertSummary Object
    /// </summary>  
    public class AlertSummaryUnmarshaller : ICborUnmarshaller<AlertSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AlertSummary Unmarshall(CborUnmarshallerContext context)
        {
            AlertSummary unmarshalledObject = new AlertSummary();
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
                    case "alertArn":
                        {
                            context.AddPathSegment("AlertArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AlertArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "alertId":
                        {
                            context.AddPathSegment("AlertId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AlertId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "createdAt":
                        {
                            context.AddPathSegment("CreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "notificationStatus":
                        {
                            context.AddPathSegment("NotificationStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NotificationStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "profileId":
                        {
                            context.AddPathSegment("ProfileId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ProfileId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "spaceId":
                        {
                            context.AddPathSegment("SpaceId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SpaceId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "state":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = AlertStateInfoUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "updatedAt":
                        {
                            context.AddPathSegment("UpdatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
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


        private static AlertSummaryUnmarshaller _instance = new AlertSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AlertSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}