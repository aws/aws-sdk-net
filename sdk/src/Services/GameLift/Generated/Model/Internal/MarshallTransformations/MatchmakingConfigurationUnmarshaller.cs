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
    /// Response Unmarshaller for MatchmakingConfiguration Object
    /// </summary>  
    public class MatchmakingConfigurationUnmarshaller : ICborUnmarshaller<MatchmakingConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MatchmakingConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            MatchmakingConfiguration unmarshalledObject = new MatchmakingConfiguration();
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
                    case "AcceptanceRequired":
                        {
                            context.AddPathSegment("AcceptanceRequired");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.AcceptanceRequired = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AcceptanceTimeoutSeconds":
                        {
                            context.AddPathSegment("AcceptanceTimeoutSeconds");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.AcceptanceTimeoutSeconds = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AdditionalPlayerCount":
                        {
                            context.AddPathSegment("AdditionalPlayerCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.AdditionalPlayerCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BackfillMode":
                        {
                            context.AddPathSegment("BackfillMode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.BackfillMode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ConfigurationArn":
                        {
                            context.AddPathSegment("ConfigurationArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ConfigurationArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CustomEventData":
                        {
                            context.AddPathSegment("CustomEventData");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CustomEventData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FlexMatchMode":
                        {
                            context.AddPathSegment("FlexMatchMode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FlexMatchMode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameProperties":
                        {
                            context.AddPathSegment("GameProperties");
                            var unmarshaller = new CborListUnmarshaller<GameProperty, GamePropertyUnmarshaller>(GamePropertyUnmarshaller.Instance);
                            unmarshalledObject.GameProperties = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionData":
                        {
                            context.AddPathSegment("GameSessionData");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GameSessionData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GameSessionQueueArns":
                        {
                            context.AddPathSegment("GameSessionQueueArns");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.GameSessionQueueArns = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NotificationTarget":
                        {
                            context.AddPathSegment("NotificationTarget");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NotificationTarget = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RequestTimeoutSeconds":
                        {
                            context.AddPathSegment("RequestTimeoutSeconds");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.RequestTimeoutSeconds = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RuleSetArn":
                        {
                            context.AddPathSegment("RuleSetArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RuleSetArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RuleSetName":
                        {
                            context.AddPathSegment("RuleSetName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RuleSetName = unmarshaller.Unmarshall(context);
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


        private static MatchmakingConfigurationUnmarshaller _instance = new MatchmakingConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MatchmakingConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}