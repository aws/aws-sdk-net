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
    /// Response Unmarshaller for DirectoryDescription Object
    /// </summary>
    public partial class DirectoryDescriptionUnmarshaller : ICborUnmarshaller<DirectoryDescription, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DirectoryDescription Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DirectoryDescription();
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
                    case "AccessUrl":
                        context.AddPathSegment("AccessUrl");
                        unmarshalledObject.AccessUrl = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Alias":
                        context.AddPathSegment("Alias");
                        unmarshalledObject.Alias = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConnectSettings":
                        context.AddPathSegment("ConnectSettings");
                        unmarshalledObject.ConnectSettings = DirectoryConnectSettingsDescriptionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DesiredNumberOfDomainControllers":
                        context.AddPathSegment("DesiredNumberOfDomainControllers");
                        unmarshalledObject.DesiredNumberOfDomainControllers = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DirectoryId":
                        context.AddPathSegment("DirectoryId");
                        unmarshalledObject.DirectoryId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsIpAddrs":
                        context.AddPathSegment("DnsIpAddrs");
                        unmarshalledObject.DnsIpAddrs = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsIpv6Addrs":
                        context.AddPathSegment("DnsIpv6Addrs");
                        unmarshalledObject.DnsIpv6Addrs = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Edition":
                        context.AddPathSegment("Edition");
                        unmarshalledObject.Edition = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HybridSettings":
                        context.AddPathSegment("HybridSettings");
                        unmarshalledObject.HybridSettings = HybridSettingsDescriptionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LaunchTime":
                        context.AddPathSegment("LaunchTime");
                        unmarshalledObject.LaunchTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkType":
                        context.AddPathSegment("NetworkType");
                        unmarshalledObject.NetworkType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OsVersion":
                        context.AddPathSegment("OsVersion");
                        unmarshalledObject.OsVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OwnerDirectoryDescription":
                        context.AddPathSegment("OwnerDirectoryDescription");
                        unmarshalledObject.OwnerDirectoryDescription = OwnerDirectoryDescriptionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RadiusSettings":
                        context.AddPathSegment("RadiusSettings");
                        unmarshalledObject.RadiusSettings = RadiusSettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RadiusStatus":
                        context.AddPathSegment("RadiusStatus");
                        unmarshalledObject.RadiusStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegionsInfo":
                        context.AddPathSegment("RegionsInfo");
                        unmarshalledObject.RegionsInfo = RegionsInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShareMethod":
                        context.AddPathSegment("ShareMethod");
                        unmarshalledObject.ShareMethod = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShareNotes":
                        context.AddPathSegment("ShareNotes");
                        unmarshalledObject.ShareNotes = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShareStatus":
                        context.AddPathSegment("ShareStatus");
                        unmarshalledObject.ShareStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShortName":
                        context.AddPathSegment("ShortName");
                        unmarshalledObject.ShortName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Size":
                        context.AddPathSegment("Size");
                        unmarshalledObject.Size = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SsoEnabled":
                        context.AddPathSegment("SsoEnabled");
                        unmarshalledObject.SsoEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Stage":
                        context.AddPathSegment("Stage");
                        unmarshalledObject.Stage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StageLastUpdatedDateTime":
                        context.AddPathSegment("StageLastUpdatedDateTime");
                        unmarshalledObject.StageLastUpdatedDateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StageReason":
                        context.AddPathSegment("StageReason");
                        unmarshalledObject.StageReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "VpcSettings":
                        context.AddPathSegment("VpcSettings");
                        unmarshalledObject.VpcSettings = DirectoryVpcSettingsDescriptionUnmarshaller.Instance.Unmarshall(context);
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

        private static DirectoryDescriptionUnmarshaller _instance = new DirectoryDescriptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DirectoryDescriptionUnmarshaller Instance => _instance;
    }
}
