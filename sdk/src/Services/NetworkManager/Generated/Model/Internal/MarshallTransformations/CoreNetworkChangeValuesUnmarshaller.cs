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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CoreNetworkChangeValues Object
    /// </summary>  
    public class CoreNetworkChangeValuesUnmarshaller : IUnmarshaller<CoreNetworkChangeValues, XmlUnmarshallerContext>, IUnmarshaller<CoreNetworkChangeValues, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CoreNetworkChangeValues IUnmarshaller<CoreNetworkChangeValues, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CoreNetworkChangeValues Unmarshall(JsonUnmarshallerContext context)
        {
            CoreNetworkChangeValues unmarshalledObject = new CoreNetworkChangeValues();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Asn", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Asn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AttachmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttachmentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Cidr", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cidr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsSupport", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DnsSupport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EdgeLocations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EdgeLocations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsideCidrBlocks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InsideCidrBlocks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFunctionGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkFunctionGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PeerEdgeLocations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PeerEdgeLocations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoutingPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoutingPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoutingPolicyAssociationDetails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RoutingPolicyAssociationDetail, RoutingPolicyAssociationDetailUnmarshaller>(RoutingPolicyAssociationDetailUnmarshaller.Instance);
                    unmarshalledObject.RoutingPolicyAssociationDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoutingPolicyDirection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoutingPolicyDirection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroupReferencingSupport", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SecurityGroupReferencingSupport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceInsertionActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServiceInsertionAction, ServiceInsertionActionUnmarshaller>(ServiceInsertionActionUnmarshaller.Instance);
                    unmarshalledObject.ServiceInsertionActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharedSegments", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SharedSegments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpnEcmpSupport", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.VpnEcmpSupport = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CoreNetworkChangeValuesUnmarshaller _instance = new CoreNetworkChangeValuesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CoreNetworkChangeValuesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}