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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AllocatePublicVirtualInterface operation
    /// </summary>  
    public class AllocatePublicVirtualInterfaceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            AllocatePublicVirtualInterfaceResponse response = new AllocatePublicVirtualInterfaceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addressFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AddressFamily = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("amazonAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AmazonAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("amazonSideAsn", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.AmazonSideAsn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("asn", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Asn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("asnLong", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.AsnLong = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsDeviceV2", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AwsDeviceV2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsLogicalDeviceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AwsLogicalDeviceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bgpPeers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BGPPeer, BGPPeerUnmarshaller>(BGPPeerUnmarshaller.Instance);
                    response.BgpPeers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customerAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CustomerAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customerRouterConfig", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CustomerRouterConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("directConnectGatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DirectConnectGatewayId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jumboFrameCapable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.JumboFrameCapable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mtu", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Mtu = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ownerAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OwnerAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routeFilterPrefixes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteFilterPrefix, RouteFilterPrefixUnmarshaller>(RouteFilterPrefixUnmarshaller.Instance);
                    response.RouteFilterPrefixes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("siteLinkEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.SiteLinkEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualGatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualGatewayId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vlan", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Vlan = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectClientException"))
                {
                    return DirectConnectClientExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectServerException"))
                {
                    return DirectConnectServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DuplicateTagKeysException"))
                {
                    return DuplicateTagKeysExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyTagsException"))
                {
                    return TooManyTagsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonDirectConnectException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static AllocatePublicVirtualInterfaceResponseUnmarshaller _instance = new AllocatePublicVirtualInterfaceResponseUnmarshaller();        

        internal static AllocatePublicVirtualInterfaceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AllocatePublicVirtualInterfaceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}