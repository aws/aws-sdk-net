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
    /// Response Unmarshaller for DirectoryConnectSettingsDescription Object
    /// </summary>
    public partial class DirectoryConnectSettingsDescriptionUnmarshaller : ICborUnmarshaller<DirectoryConnectSettingsDescription, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DirectoryConnectSettingsDescription Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DirectoryConnectSettingsDescription();
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
                    case "AvailabilityZones":
                        context.AddPathSegment("AvailabilityZones");
                        unmarshalledObject.AvailabilityZones = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConnectIps":
                        context.AddPathSegment("ConnectIps");
                        unmarshalledObject.ConnectIps = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConnectIpsV6":
                        context.AddPathSegment("ConnectIpsV6");
                        unmarshalledObject.ConnectIpsV6 = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CustomerUserName":
                        context.AddPathSegment("CustomerUserName");
                        unmarshalledObject.CustomerUserName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SecurityGroupId":
                        context.AddPathSegment("SecurityGroupId");
                        unmarshalledObject.SecurityGroupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubnetIds":
                        context.AddPathSegment("SubnetIds");
                        unmarshalledObject.SubnetIds = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcId":
                        context.AddPathSegment("VpcId");
                        unmarshalledObject.VpcId = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static DirectoryConnectSettingsDescriptionUnmarshaller _instance = new DirectoryConnectSettingsDescriptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DirectoryConnectSettingsDescriptionUnmarshaller Instance => _instance;
    }
}
