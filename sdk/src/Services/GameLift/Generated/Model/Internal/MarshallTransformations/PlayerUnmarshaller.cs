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
    /// Response Unmarshaller for Player Object
    /// </summary>  
    public class PlayerUnmarshaller : ICborUnmarshaller<Player, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Player Unmarshall(CborUnmarshallerContext context)
        {
            Player unmarshalledObject = new Player();
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
                    case "LatencyInMs":
                        {
                            context.AddPathSegment("LatencyInMs");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, int, CborStringUnmarshaller, CborIntUnmarshaller>(CborStringUnmarshaller.Instance, CborIntUnmarshaller.Instance);
                            unmarshalledObject.LatencyInMs = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlayerAttributes":
                        {
                            context.AddPathSegment("PlayerAttributes");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, AttributeValue, CborStringUnmarshaller, AttributeValueUnmarshaller>(CborStringUnmarshaller.Instance, AttributeValueUnmarshaller.Instance);
                            unmarshalledObject.PlayerAttributes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlayerId":
                        {
                            context.AddPathSegment("PlayerId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PlayerId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Team":
                        {
                            context.AddPathSegment("Team");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Team = unmarshaller.Unmarshall(context);
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


        private static PlayerUnmarshaller _instance = new PlayerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PlayerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}