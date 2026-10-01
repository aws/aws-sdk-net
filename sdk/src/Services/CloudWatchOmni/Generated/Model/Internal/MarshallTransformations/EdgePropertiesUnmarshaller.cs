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
    /// Response Unmarshaller for EdgeProperties Object
    /// </summary>  
    public class EdgePropertiesUnmarshaller : ICborUnmarshaller<EdgeProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EdgeProperties Unmarshall(CborUnmarshallerContext context)
        {
            EdgeProperties unmarshalledObject = new EdgeProperties();
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
                    case "blocked":
                        {
                            context.AddPathSegment("Blocked");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.Blocked = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "destinationPort":
                        {
                            context.AddPathSegment("DestinationPort");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DestinationPort = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "errorCode":
                        {
                            context.AddPathSegment("ErrorCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "httpMethod":
                        {
                            context.AddPathSegment("HttpMethod");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HttpMethod = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "httpStatusCode":
                        {
                            context.AddPathSegment("HttpStatusCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HttpStatusCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "protocol":
                        {
                            context.AddPathSegment("Protocol");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "serviceInitiated":
                        {
                            context.AddPathSegment("ServiceInitiated");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.ServiceInitiated = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "sourcePort":
                        {
                            context.AddPathSegment("SourcePort");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourcePort = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "trafficStats":
                        {
                            context.AddPathSegment("TrafficStats");
                            var unmarshaller = EdgeTrafficStatsUnmarshaller.Instance;
                            unmarshalledObject.TrafficStats = unmarshaller.Unmarshall(context);
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


        private static EdgePropertiesUnmarshaller _instance = new EdgePropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EdgePropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}