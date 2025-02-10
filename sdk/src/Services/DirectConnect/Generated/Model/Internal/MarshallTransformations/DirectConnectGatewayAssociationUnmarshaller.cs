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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DirectConnectGatewayAssociation Object
    /// </summary>  
    public class DirectConnectGatewayAssociationUnmarshaller : IJsonUnmarshaller<DirectConnectGatewayAssociation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DirectConnectGatewayAssociation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DirectConnectGatewayAssociation unmarshalledObject = new DirectConnectGatewayAssociation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("allowedPrefixesToDirectConnectGateway", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteFilterPrefix, RouteFilterPrefixUnmarshaller>(RouteFilterPrefixUnmarshaller.Instance);
                    unmarshalledObject.AllowedPrefixesToDirectConnectGateway = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("associatedCoreNetwork", targetDepth))
                {
                    var unmarshaller = AssociatedCoreNetworkUnmarshaller.Instance;
                    unmarshalledObject.AssociatedCoreNetwork = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("associatedGateway", targetDepth))
                {
                    var unmarshaller = AssociatedGatewayUnmarshaller.Instance;
                    unmarshalledObject.AssociatedGateway = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("associationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("associationState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("directConnectGatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectConnectGatewayId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("directConnectGatewayOwnerAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectConnectGatewayOwnerAccount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stateChangeError", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateChangeError = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("virtualGatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VirtualGatewayId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("virtualGatewayOwnerAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VirtualGatewayOwnerAccount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("virtualGatewayRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VirtualGatewayRegion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DirectConnectGatewayAssociationUnmarshaller _instance = new DirectConnectGatewayAssociationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DirectConnectGatewayAssociationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}