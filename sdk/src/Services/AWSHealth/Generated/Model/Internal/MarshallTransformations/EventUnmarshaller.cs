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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Event Object
    /// </summary>  
    public class EventUnmarshaller : ICborUnmarshaller<Event, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Event Unmarshall(CborUnmarshallerContext context)
        {
            Event unmarshalledObject = new Event();
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
                    case "actionability":
                        {
                            context.AddPathSegment("Actionability");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Actionability = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "availabilityZone":
                        {
                            context.AddPathSegment("AvailabilityZone");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "endTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventScopeCode":
                        {
                            context.AddPathSegment("EventScopeCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventScopeCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventTypeCategory":
                        {
                            context.AddPathSegment("EventTypeCategory");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventTypeCategory = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventTypeCode":
                        {
                            context.AddPathSegment("EventTypeCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventTypeCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastUpdatedTime":
                        {
                            context.AddPathSegment("LastUpdatedTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "personas":
                        {
                            context.AddPathSegment("Personas");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.Personas = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "region":
                        {
                            context.AddPathSegment("Region");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "service":
                        {
                            context.AddPathSegment("Service");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Service = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "startTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "statusCode":
                        {
                            context.AddPathSegment("StatusCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusCode = unmarshaller.Unmarshall(context);
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


        private static EventUnmarshaller _instance = new EventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}