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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MatchmakingTicket Object
    /// </summary>  
    public class MatchmakingTicketUnmarshaller : ICborUnmarshaller<MatchmakingTicket, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MatchmakingTicket Unmarshall(CborUnmarshallerContext context)
        {
            MatchmakingTicket unmarshalledObject = new MatchmakingTicket();
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
                    case "ConfigurationArn":
                        {
                            context.AddPathSegment("ConfigurationArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ConfigurationArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ConfigurationName":
                        {
                            context.AddPathSegment("ConfigurationName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ConfigurationName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EndTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EstimatedWaitTime":
                        {
                            context.AddPathSegment("EstimatedWaitTime");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.EstimatedWaitTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionConnectionInfo":
                        {
                            context.AddPathSegment("GameSessionConnectionInfo");
                            var unmarshaller = GameSessionConnectionInfoUnmarshaller.Instance;
                            unmarshalledObject.GameSessionConnectionInfo = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Players":
                        {
                            context.AddPathSegment("Players");
                            var unmarshaller = new CborListUnmarshaller<Player, PlayerUnmarshaller>(PlayerUnmarshaller.Instance);
                            unmarshalledObject.Players = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StartTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
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
                    case "StatusMessage":
                        {
                            context.AddPathSegment("StatusMessage");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatusReason":
                        {
                            context.AddPathSegment("StatusReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TicketId":
                        {
                            context.AddPathSegment("TicketId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.TicketId = unmarshaller.Unmarshall(context);
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


        private static MatchmakingTicketUnmarshaller _instance = new MatchmakingTicketUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MatchmakingTicketUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}