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

using Amazon.GameLift.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GameSessionQueue Object
    /// </summary>
    public partial class GameSessionQueueUnmarshaller : ICborUnmarshaller<GameSessionQueue, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public GameSessionQueue Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GameSessionQueue();
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
                    case "CustomEventData":
                        context.AddPathSegment("CustomEventData");
                        unmarshalledObject.CustomEventData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Destinations":
                        context.AddPathSegment("Destinations");
                        unmarshalledObject.Destinations = new CborListUnmarshaller<GameSessionQueueDestination, GameSessionQueueDestinationUnmarshaller>(GameSessionQueueDestinationUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilterConfiguration":
                        context.AddPathSegment("FilterConfiguration");
                        unmarshalledObject.FilterConfiguration = FilterConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionQueueArn":
                        context.AddPathSegment("GameSessionQueueArn");
                        unmarshalledObject.GameSessionQueueArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NotificationTarget":
                        context.AddPathSegment("NotificationTarget");
                        unmarshalledObject.NotificationTarget = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlayerLatencyPolicies":
                        context.AddPathSegment("PlayerLatencyPolicies");
                        unmarshalledObject.PlayerLatencyPolicies = new CborListUnmarshaller<PlayerLatencyPolicy, PlayerLatencyPolicyUnmarshaller>(PlayerLatencyPolicyUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PriorityConfiguration":
                        context.AddPathSegment("PriorityConfiguration");
                        unmarshalledObject.PriorityConfiguration = PriorityConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TimeoutInSeconds":
                        context.AddPathSegment("TimeoutInSeconds");
                        unmarshalledObject.TimeoutInSeconds = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static GameSessionQueueUnmarshaller _instance = new GameSessionQueueUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GameSessionQueueUnmarshaller Instance => _instance;
    }
}
