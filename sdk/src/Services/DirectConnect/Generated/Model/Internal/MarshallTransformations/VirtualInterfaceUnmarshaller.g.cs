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

using Amazon.DirectConnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VirtualInterface Object
    /// </summary>
    public partial class VirtualInterfaceUnmarshaller : ICborUnmarshaller<VirtualInterface, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public VirtualInterface Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new VirtualInterface();
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
                    case "addressFamily":
                        context.AddPathSegment("AddressFamily");
                        unmarshalledObject.AddressFamily = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "amazonAddress":
                        context.AddPathSegment("AmazonAddress");
                        unmarshalledObject.AmazonAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "amazonSideAsn":
                        context.AddPathSegment("AmazonSideAsn");
                        unmarshalledObject.AmazonSideAsn = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "asn":
                        context.AddPathSegment("Asn");
                        unmarshalledObject.Asn = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "asnLong":
                        context.AddPathSegment("AsnLong");
                        unmarshalledObject.AsnLong = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "authKey":
                        context.AddPathSegment("AuthKey");
                        unmarshalledObject.AuthKey = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "awsDeviceV2":
                        context.AddPathSegment("AwsDeviceV2");
                        unmarshalledObject.AwsDeviceV2 = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "awsLogicalDeviceId":
                        context.AddPathSegment("AwsLogicalDeviceId");
                        unmarshalledObject.AwsLogicalDeviceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "bgpPeers":
                        context.AddPathSegment("BgpPeers");
                        unmarshalledObject.BgpPeers = new CborListUnmarshaller<BGPPeer, BGPPeerUnmarshaller>(BGPPeerUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "connectionId":
                        context.AddPathSegment("ConnectionId");
                        unmarshalledObject.ConnectionId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "customerAddress":
                        context.AddPathSegment("CustomerAddress");
                        unmarshalledObject.CustomerAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "customerRouterConfig":
                        context.AddPathSegment("CustomerRouterConfig");
                        unmarshalledObject.CustomerRouterConfig = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "directConnectGatewayId":
                        context.AddPathSegment("DirectConnectGatewayId");
                        unmarshalledObject.DirectConnectGatewayId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "jumboFrameCapable":
                        context.AddPathSegment("JumboFrameCapable");
                        unmarshalledObject.JumboFrameCapable = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "location":
                        context.AddPathSegment("Location");
                        unmarshalledObject.Location = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "mtu":
                        context.AddPathSegment("Mtu");
                        unmarshalledObject.Mtu = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ownerAccount":
                        context.AddPathSegment("OwnerAccount");
                        unmarshalledObject.OwnerAccount = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "prefixPoolAllocatedCountIpv4":
                        context.AddPathSegment("PrefixPoolAllocatedCountIpv4");
                        unmarshalledObject.PrefixPoolAllocatedCountIpv4 = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "prefixPoolAllocatedCountIpv6":
                        context.AddPathSegment("PrefixPoolAllocatedCountIpv6");
                        unmarshalledObject.PrefixPoolAllocatedCountIpv6 = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "rateLimit":
                        context.AddPathSegment("RateLimit");
                        unmarshalledObject.RateLimit = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "region":
                        context.AddPathSegment("Region");
                        unmarshalledObject.Region = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "routeFilterPrefixes":
                        context.AddPathSegment("RouteFilterPrefixes");
                        unmarshalledObject.RouteFilterPrefixes = new CborListUnmarshaller<RouteFilterPrefix, RouteFilterPrefixUnmarshaller>(RouteFilterPrefixUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "siteLinkEnabled":
                        context.AddPathSegment("SiteLinkEnabled");
                        unmarshalledObject.SiteLinkEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualGatewayId":
                        context.AddPathSegment("VirtualGatewayId");
                        unmarshalledObject.VirtualGatewayId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualInterfaceId":
                        context.AddPathSegment("VirtualInterfaceId");
                        unmarshalledObject.VirtualInterfaceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualInterfaceName":
                        context.AddPathSegment("VirtualInterfaceName");
                        unmarshalledObject.VirtualInterfaceName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualInterfaceState":
                        context.AddPathSegment("VirtualInterfaceState");
                        unmarshalledObject.VirtualInterfaceState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualInterfaceType":
                        context.AddPathSegment("VirtualInterfaceType");
                        unmarshalledObject.VirtualInterfaceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "vlan":
                        context.AddPathSegment("Vlan");
                        unmarshalledObject.Vlan = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static VirtualInterfaceUnmarshaller _instance = new VirtualInterfaceUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static VirtualInterfaceUnmarshaller Instance => _instance;
    }
}
