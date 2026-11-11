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
    /// Response Unmarshaller for DirectConnectGatewayAssociation Object
    /// </summary>
    public partial class DirectConnectGatewayAssociationUnmarshaller : ICborUnmarshaller<DirectConnectGatewayAssociation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DirectConnectGatewayAssociation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DirectConnectGatewayAssociation();
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
                    case "allowedPrefixesToDirectConnectGateway":
                        context.AddPathSegment("AllowedPrefixesToDirectConnectGateway");
                        unmarshalledObject.AllowedPrefixesToDirectConnectGateway = new CborListUnmarshaller<RouteFilterPrefix, RouteFilterPrefixUnmarshaller>(RouteFilterPrefixUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "associatedCoreNetwork":
                        context.AddPathSegment("AssociatedCoreNetwork");
                        unmarshalledObject.AssociatedCoreNetwork = AssociatedCoreNetworkUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "associatedGateway":
                        context.AddPathSegment("AssociatedGateway");
                        unmarshalledObject.AssociatedGateway = AssociatedGatewayUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "associationId":
                        context.AddPathSegment("AssociationId");
                        unmarshalledObject.AssociationId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "associationState":
                        context.AddPathSegment("AssociationState");
                        unmarshalledObject.AssociationState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "directConnectGatewayId":
                        context.AddPathSegment("DirectConnectGatewayId");
                        unmarshalledObject.DirectConnectGatewayId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "directConnectGatewayOwnerAccount":
                        context.AddPathSegment("DirectConnectGatewayOwnerAccount");
                        unmarshalledObject.DirectConnectGatewayOwnerAccount = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stateChangeError":
                        context.AddPathSegment("StateChangeError");
                        unmarshalledObject.StateChangeError = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualGatewayId":
                        context.AddPathSegment("VirtualGatewayId");
                        unmarshalledObject.VirtualGatewayId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualGatewayOwnerAccount":
                        context.AddPathSegment("VirtualGatewayOwnerAccount");
                        unmarshalledObject.VirtualGatewayOwnerAccount = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "virtualGatewayRegion":
                        context.AddPathSegment("VirtualGatewayRegion");
                        unmarshalledObject.VirtualGatewayRegion = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static DirectConnectGatewayAssociationUnmarshaller _instance = new DirectConnectGatewayAssociationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DirectConnectGatewayAssociationUnmarshaller Instance => _instance;
    }
}
