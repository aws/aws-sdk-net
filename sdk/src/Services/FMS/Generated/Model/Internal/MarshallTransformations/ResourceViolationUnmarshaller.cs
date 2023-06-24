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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceViolation Object
    /// </summary>  
    public class ResourceViolationUnmarshaller : IUnmarshaller<ResourceViolation, XmlUnmarshallerContext>, IUnmarshaller<ResourceViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceViolation IUnmarshaller<ResourceViolation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceViolation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResourceViolation unmarshalledObject = new ResourceViolation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AwsEc2InstanceViolation", targetDepth))
                {
                    var unmarshaller = AwsEc2InstanceViolationUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2InstanceViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2NetworkInterfaceViolation", targetDepth))
                {
                    var unmarshaller = AwsEc2NetworkInterfaceViolationUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2NetworkInterfaceViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsVPCSecurityGroupViolation", targetDepth))
                {
                    var unmarshaller = AwsVPCSecurityGroupViolationUnmarshaller.Instance;
                    unmarshalledObject.AwsVPCSecurityGroupViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsDuplicateRuleGroupViolation", targetDepth))
                {
                    var unmarshaller = DnsDuplicateRuleGroupViolationUnmarshaller.Instance;
                    unmarshalledObject.DnsDuplicateRuleGroupViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsRuleGroupLimitExceededViolation", targetDepth))
                {
                    var unmarshaller = DnsRuleGroupLimitExceededViolationUnmarshaller.Instance;
                    unmarshalledObject.DnsRuleGroupLimitExceededViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsRuleGroupPriorityConflictViolation", targetDepth))
                {
                    var unmarshaller = DnsRuleGroupPriorityConflictViolationUnmarshaller.Instance;
                    unmarshalledObject.DnsRuleGroupPriorityConflictViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallSubnetIsOutOfScopeViolation", targetDepth))
                {
                    var unmarshaller = FirewallSubnetIsOutOfScopeViolationUnmarshaller.Instance;
                    unmarshalledObject.FirewallSubnetIsOutOfScopeViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirewallSubnetMissingVPCEndpointViolation", targetDepth))
                {
                    var unmarshaller = FirewallSubnetMissingVPCEndpointViolationUnmarshaller.Instance;
                    unmarshalledObject.FirewallSubnetMissingVPCEndpointViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallBlackHoleRouteDetectedViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallBlackHoleRouteDetectedViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallBlackHoleRouteDetectedViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallInternetTrafficNotInspectedViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallInternetTrafficNotInspectedViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallInternetTrafficNotInspectedViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallInvalidRouteConfigurationViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallInvalidRouteConfigurationViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingExpectedRoutesViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallMissingExpectedRoutesViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingExpectedRoutesViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingExpectedRTViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallMissingExpectedRTViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingExpectedRTViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingFirewallViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallMissingFirewallViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingFirewallViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingSubnetViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallMissingSubnetViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingSubnetViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallPolicyModifiedViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallPolicyModifiedViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallPolicyModifiedViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallUnexpectedFirewallRoutesViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallUnexpectedFirewallRoutesViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallUnexpectedFirewallRoutesViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallUnexpectedGatewayRoutesViolation", targetDepth))
                {
                    var unmarshaller = NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallUnexpectedGatewayRoutesViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PossibleRemediationActions", targetDepth))
                {
                    var unmarshaller = PossibleRemediationActionsUnmarshaller.Instance;
                    unmarshalledObject.PossibleRemediationActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteHasOutOfScopeEndpointViolation", targetDepth))
                {
                    var unmarshaller = RouteHasOutOfScopeEndpointViolationUnmarshaller.Instance;
                    unmarshalledObject.RouteHasOutOfScopeEndpointViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThirdPartyFirewallMissingExpectedRouteTableViolation", targetDepth))
                {
                    var unmarshaller = ThirdPartyFirewallMissingExpectedRouteTableViolationUnmarshaller.Instance;
                    unmarshalledObject.ThirdPartyFirewallMissingExpectedRouteTableViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThirdPartyFirewallMissingFirewallViolation", targetDepth))
                {
                    var unmarshaller = ThirdPartyFirewallMissingFirewallViolationUnmarshaller.Instance;
                    unmarshalledObject.ThirdPartyFirewallMissingFirewallViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThirdPartyFirewallMissingSubnetViolation", targetDepth))
                {
                    var unmarshaller = ThirdPartyFirewallMissingSubnetViolationUnmarshaller.Instance;
                    unmarshalledObject.ThirdPartyFirewallMissingSubnetViolation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResourceViolationUnmarshaller _instance = new ResourceViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}