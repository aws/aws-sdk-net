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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Stack Object
    /// </summary>  
    public class StackUnmarshaller : ICborUnmarshaller<Stack, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Stack Unmarshall(CborUnmarshallerContext context)
        {
            Stack unmarshalledObject = new Stack();
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
                    case "AccessEndpoints":
                        {
                            context.AddPathSegment("AccessEndpoints");
                            var unmarshaller = new CborListUnmarshaller<AccessEndpoint, AccessEndpointUnmarshaller>(AccessEndpointUnmarshaller.Instance);
                            unmarshalledObject.AccessEndpoints = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AgentAccessConfig":
                        {
                            context.AddPathSegment("AgentAccessConfig");
                            var unmarshaller = AgentAccessConfigUnmarshaller.Instance;
                            unmarshalledObject.AgentAccessConfig = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ApplicationSettings":
                        {
                            context.AddPathSegment("ApplicationSettings");
                            var unmarshaller = ApplicationSettingsResponseUnmarshaller.Instance;
                            unmarshalledObject.ApplicationSettings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ContentRedirection":
                        {
                            context.AddPathSegment("ContentRedirection");
                            var unmarshaller = ContentRedirectionUnmarshaller.Instance;
                            unmarshalledObject.ContentRedirection = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedTime":
                        {
                            context.AddPathSegment("CreatedTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
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
                    case "DisplayName":
                        {
                            context.AddPathSegment("DisplayName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EmbedHostDomains":
                        {
                            context.AddPathSegment("EmbedHostDomains");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.EmbedHostDomains = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FeedbackURL":
                        {
                            context.AddPathSegment("FeedbackURL");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FeedbackURL = unmarshaller.Unmarshall(context);
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
                    case "RedirectURL":
                        {
                            context.AddPathSegment("RedirectURL");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RedirectURL = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StackErrors":
                        {
                            context.AddPathSegment("StackErrors");
                            var unmarshaller = new CborListUnmarshaller<StackError, StackErrorUnmarshaller>(StackErrorUnmarshaller.Instance);
                            unmarshalledObject.StackErrors = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StorageConnectors":
                        {
                            context.AddPathSegment("StorageConnectors");
                            var unmarshaller = new CborListUnmarshaller<StorageConnector, StorageConnectorUnmarshaller>(StorageConnectorUnmarshaller.Instance);
                            unmarshalledObject.StorageConnectors = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StreamingExperienceSettings":
                        {
                            context.AddPathSegment("StreamingExperienceSettings");
                            var unmarshaller = StreamingExperienceSettingsUnmarshaller.Instance;
                            unmarshalledObject.StreamingExperienceSettings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UserSettings":
                        {
                            context.AddPathSegment("UserSettings");
                            var unmarshaller = new CborListUnmarshaller<UserSetting, UserSettingUnmarshaller>(UserSettingUnmarshaller.Instance);
                            unmarshalledObject.UserSettings = unmarshaller.Unmarshall(context);
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


        private static StackUnmarshaller _instance = new StackUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StackUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}