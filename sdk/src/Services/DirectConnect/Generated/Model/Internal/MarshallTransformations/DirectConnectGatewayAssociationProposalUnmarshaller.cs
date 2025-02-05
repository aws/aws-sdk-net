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
    /// Response Unmarshaller for DirectConnectGatewayAssociationProposal Object
    /// </summary>  
    public class DirectConnectGatewayAssociationProposalUnmarshaller : IJsonUnmarshaller<DirectConnectGatewayAssociationProposal, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DirectConnectGatewayAssociationProposal Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DirectConnectGatewayAssociationProposal unmarshalledObject = new DirectConnectGatewayAssociationProposal();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("associatedGateway", targetDepth))
                {
                    var unmarshaller = AssociatedGatewayUnmarshaller.Instance;
                    unmarshalledObject.AssociatedGateway = unmarshaller.Unmarshall(context, ref reader);
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
                if (context.TestExpression("existingAllowedPrefixesToDirectConnectGateway", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteFilterPrefix, RouteFilterPrefixUnmarshaller>(RouteFilterPrefixUnmarshaller.Instance);
                    unmarshalledObject.ExistingAllowedPrefixesToDirectConnectGateway = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("proposalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProposalId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("proposalState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProposalState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requestedAllowedPrefixesToDirectConnectGateway", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RouteFilterPrefix, RouteFilterPrefixUnmarshaller>(RouteFilterPrefixUnmarshaller.Instance);
                    unmarshalledObject.RequestedAllowedPrefixesToDirectConnectGateway = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DirectConnectGatewayAssociationProposalUnmarshaller _instance = new DirectConnectGatewayAssociationProposalUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DirectConnectGatewayAssociationProposalUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}