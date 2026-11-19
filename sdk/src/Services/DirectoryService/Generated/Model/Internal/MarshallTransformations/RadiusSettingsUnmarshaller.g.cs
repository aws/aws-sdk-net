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

using Amazon.DirectoryService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RadiusSettings Object
    /// </summary>
    public partial class RadiusSettingsUnmarshaller : ICborUnmarshaller<RadiusSettings, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RadiusSettings Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RadiusSettings();
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
                    case "AuthenticationProtocol":
                        context.AddPathSegment("AuthenticationProtocol");
                        unmarshalledObject.AuthenticationProtocol = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DisplayLabel":
                        context.AddPathSegment("DisplayLabel");
                        unmarshalledObject.DisplayLabel = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RadiusPort":
                        context.AddPathSegment("RadiusPort");
                        unmarshalledObject.RadiusPort = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RadiusRetries":
                        context.AddPathSegment("RadiusRetries");
                        unmarshalledObject.RadiusRetries = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RadiusServers":
                        context.AddPathSegment("RadiusServers");
                        unmarshalledObject.RadiusServers = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RadiusServersIpv6":
                        context.AddPathSegment("RadiusServersIpv6");
                        unmarshalledObject.RadiusServersIpv6 = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RadiusTimeout":
                        context.AddPathSegment("RadiusTimeout");
                        unmarshalledObject.RadiusTimeout = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SharedSecret":
                        context.AddPathSegment("SharedSecret");
                        unmarshalledObject.SharedSecret = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UseSameUsername":
                        context.AddPathSegment("UseSameUsername");
                        unmarshalledObject.UseSameUsername = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
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

        private static RadiusSettingsUnmarshaller _instance = new RadiusSettingsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RadiusSettingsUnmarshaller Instance => _instance;
    }
}
