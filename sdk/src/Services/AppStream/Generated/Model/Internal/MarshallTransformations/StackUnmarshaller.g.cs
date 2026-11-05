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

using Amazon.AppStream.Model;
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
    public partial class StackUnmarshaller : ICborUnmarshaller<Stack, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Stack Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Stack();
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
                    case "AccessEndpoints":
                        context.AddPathSegment("AccessEndpoints");
                        unmarshalledObject.AccessEndpoints = new CborListUnmarshaller<AccessEndpoint, AccessEndpointUnmarshaller>(AccessEndpointUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AgentAccessConfig":
                        context.AddPathSegment("AgentAccessConfig");
                        unmarshalledObject.AgentAccessConfig = AgentAccessConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ApplicationSettings":
                        context.AddPathSegment("ApplicationSettings");
                        unmarshalledObject.ApplicationSettings = ApplicationSettingsResponseUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ContentRedirection":
                        context.AddPathSegment("ContentRedirection");
                        unmarshalledObject.ContentRedirection = ContentRedirectionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedTime":
                        context.AddPathSegment("CreatedTime");
                        unmarshalledObject.CreatedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DisplayName":
                        context.AddPathSegment("DisplayName");
                        unmarshalledObject.DisplayName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EmbedHostDomains":
                        context.AddPathSegment("EmbedHostDomains");
                        unmarshalledObject.EmbedHostDomains = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FeedbackURL":
                        context.AddPathSegment("FeedbackURL");
                        unmarshalledObject.FeedbackURL = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RedirectURL":
                        context.AddPathSegment("RedirectURL");
                        unmarshalledObject.RedirectURL = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StackErrors":
                        context.AddPathSegment("StackErrors");
                        unmarshalledObject.StackErrors = new CborListUnmarshaller<StackError, StackErrorUnmarshaller>(StackErrorUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StorageConnectorAuthentication":
                        context.AddPathSegment("StorageConnectorAuthentication");
                        unmarshalledObject.StorageConnectorAuthentication = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StorageConnectors":
                        context.AddPathSegment("StorageConnectors");
                        unmarshalledObject.StorageConnectors = new CborListUnmarshaller<StorageConnector, StorageConnectorUnmarshaller>(StorageConnectorUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StreamingExperienceSettings":
                        context.AddPathSegment("StreamingExperienceSettings");
                        unmarshalledObject.StreamingExperienceSettings = StreamingExperienceSettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UserSettings":
                        context.AddPathSegment("UserSettings");
                        unmarshalledObject.UserSettings = new CborListUnmarshaller<UserSetting, UserSettingUnmarshaller>(UserSettingUnmarshaller.Instance).Unmarshall(context);
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

        private static StackUnmarshaller _instance = new StackUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StackUnmarshaller Instance => _instance;
    }
}
