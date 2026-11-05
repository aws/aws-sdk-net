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
    /// Response Unmarshaller for MatchmakingConfiguration Object
    /// </summary>
    public partial class MatchmakingConfigurationUnmarshaller : ICborUnmarshaller<MatchmakingConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public MatchmakingConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new MatchmakingConfiguration();
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
                    case "AcceptanceRequired":
                        context.AddPathSegment("AcceptanceRequired");
                        unmarshalledObject.AcceptanceRequired = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AcceptanceTimeoutSeconds":
                        context.AddPathSegment("AcceptanceTimeoutSeconds");
                        unmarshalledObject.AcceptanceTimeoutSeconds = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AdditionalPlayerCount":
                        context.AddPathSegment("AdditionalPlayerCount");
                        unmarshalledObject.AdditionalPlayerCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BackfillMode":
                        context.AddPathSegment("BackfillMode");
                        unmarshalledObject.BackfillMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConfigurationArn":
                        context.AddPathSegment("ConfigurationArn");
                        unmarshalledObject.ConfigurationArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationTime":
                        context.AddPathSegment("CreationTime");
                        unmarshalledObject.CreationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CustomEventData":
                        context.AddPathSegment("CustomEventData");
                        unmarshalledObject.CustomEventData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FlexMatchMode":
                        context.AddPathSegment("FlexMatchMode");
                        unmarshalledObject.FlexMatchMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameProperties":
                        context.AddPathSegment("GameProperties");
                        unmarshalledObject.GameProperties = new CborListUnmarshaller<GameProperty, GamePropertyUnmarshaller>(GamePropertyUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionData":
                        context.AddPathSegment("GameSessionData");
                        unmarshalledObject.GameSessionData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GameSessionQueueArns":
                        context.AddPathSegment("GameSessionQueueArns");
                        unmarshalledObject.GameSessionQueueArns = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
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

                    case "RequestTimeoutSeconds":
                        context.AddPathSegment("RequestTimeoutSeconds");
                        unmarshalledObject.RequestTimeoutSeconds = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RuleSetArn":
                        context.AddPathSegment("RuleSetArn");
                        unmarshalledObject.RuleSetArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RuleSetName":
                        context.AddPathSegment("RuleSetName");
                        unmarshalledObject.RuleSetName = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static MatchmakingConfigurationUnmarshaller _instance = new MatchmakingConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MatchmakingConfigurationUnmarshaller Instance => _instance;
    }
}
