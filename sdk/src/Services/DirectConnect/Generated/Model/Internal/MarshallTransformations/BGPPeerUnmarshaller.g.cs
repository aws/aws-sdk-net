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
    /// Response Unmarshaller for BGPPeer Object
    /// </summary>
    public partial class BGPPeerUnmarshaller : ICborUnmarshaller<BGPPeer, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public BGPPeer Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new BGPPeer();
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

                    case "bgpPeerId":
                        context.AddPathSegment("BgpPeerId");
                        unmarshalledObject.BgpPeerId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "bgpPeerState":
                        context.AddPathSegment("BgpPeerState");
                        unmarshalledObject.BgpPeerState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "bgpStatus":
                        context.AddPathSegment("BgpStatus");
                        unmarshalledObject.BgpStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "customerAddress":
                        context.AddPathSegment("CustomerAddress");
                        unmarshalledObject.CustomerAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static BGPPeerUnmarshaller _instance = new BGPPeerUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BGPPeerUnmarshaller Instance => _instance;
    }
}
