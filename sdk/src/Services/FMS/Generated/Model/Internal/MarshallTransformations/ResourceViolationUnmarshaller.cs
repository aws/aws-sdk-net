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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceViolation Object
    /// </summary>  
    public class ResourceViolationUnmarshaller : IJsonUnmarshaller<ResourceViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceViolation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResourceViolation unmarshalledObject = new ResourceViolation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AwsEc2InstanceViolation", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2InstanceViolationUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2InstanceViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2NetworkInterfaceViolation", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2NetworkInterfaceViolationUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2NetworkInterfaceViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsVPCSecurityGroupViolation", targetDepth, ref reader))
                {
                    var unmarshaller = AwsVPCSecurityGroupViolationUnmarshaller.Instance;
                    unmarshalledObject.AwsVPCSecurityGroupViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsDuplicateRuleGroupViolation", targetDepth, ref reader))
                {
                    var unmarshaller = DnsDuplicateRuleGroupViolationUnmarshaller.Instance;
                    unmarshalledObject.DnsDuplicateRuleGroupViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsRuleGroupLimitExceededViolation", targetDepth, ref reader))
                {
                    var unmarshaller = DnsRuleGroupLimitExceededViolationUnmarshaller.Instance;
                    unmarshalledObject.DnsRuleGroupLimitExceededViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsRuleGroupPriorityConflictViolation", targetDepth, ref reader))
                {
                    var unmarshaller = DnsRuleGroupPriorityConflictViolationUnmarshaller.Instance;
                    unmarshalledObject.DnsRuleGroupPriorityConflictViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallSubnetIsOutOfScopeViolation", targetDepth, ref reader))
                {
                    var unmarshaller = FirewallSubnetIsOutOfScopeViolationUnmarshaller.Instance;
                    unmarshalledObject.FirewallSubnetIsOutOfScopeViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallSubnetMissingVPCEndpointViolation", targetDepth, ref reader))
                {
                    var unmarshaller = FirewallSubnetMissingVPCEndpointViolationUnmarshaller.Instance;
                    unmarshalledObject.FirewallSubnetMissingVPCEndpointViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InvalidNetworkAclEntriesViolation", targetDepth, ref reader))
                {
                    var unmarshaller = InvalidNetworkAclEntriesViolationUnmarshaller.Instance;
                    unmarshalledObject.InvalidNetworkAclEntriesViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallBlackHoleRouteDetectedViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallBlackHoleRouteDetectedViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallBlackHoleRouteDetectedViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallInternetTrafficNotInspectedViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallInternetTrafficNotInspectedViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallInternetTrafficNotInspectedViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallInvalidRouteConfigurationViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallInvalidRouteConfigurationViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingExpectedRoutesViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallMissingExpectedRoutesViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingExpectedRoutesViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingExpectedRTViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallMissingExpectedRTViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingExpectedRTViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingFirewallViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallMissingFirewallViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingFirewallViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallMissingSubnetViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallMissingSubnetViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallMissingSubnetViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallPolicyModifiedViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallPolicyModifiedViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallPolicyModifiedViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallUnexpectedFirewallRoutesViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallUnexpectedFirewallRoutesViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallUnexpectedFirewallRoutesViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkFirewallUnexpectedGatewayRoutesViolation", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller.Instance;
                    unmarshalledObject.NetworkFirewallUnexpectedGatewayRoutesViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PossibleRemediationActions", targetDepth, ref reader))
                {
                    var unmarshaller = PossibleRemediationActionsUnmarshaller.Instance;
                    unmarshalledObject.PossibleRemediationActions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RouteHasOutOfScopeEndpointViolation", targetDepth, ref reader))
                {
                    var unmarshaller = RouteHasOutOfScopeEndpointViolationUnmarshaller.Instance;
                    unmarshalledObject.RouteHasOutOfScopeEndpointViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThirdPartyFirewallMissingExpectedRouteTableViolation", targetDepth, ref reader))
                {
                    var unmarshaller = ThirdPartyFirewallMissingExpectedRouteTableViolationUnmarshaller.Instance;
                    unmarshalledObject.ThirdPartyFirewallMissingExpectedRouteTableViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThirdPartyFirewallMissingFirewallViolation", targetDepth, ref reader))
                {
                    var unmarshaller = ThirdPartyFirewallMissingFirewallViolationUnmarshaller.Instance;
                    unmarshalledObject.ThirdPartyFirewallMissingFirewallViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ThirdPartyFirewallMissingSubnetViolation", targetDepth, ref reader))
                {
                    var unmarshaller = ThirdPartyFirewallMissingSubnetViolationUnmarshaller.Instance;
                    unmarshalledObject.ThirdPartyFirewallMissingSubnetViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WebACLHasIncompatibleConfigurationViolation", targetDepth, ref reader))
                {
                    var unmarshaller = WebACLHasIncompatibleConfigurationViolationUnmarshaller.Instance;
                    unmarshalledObject.WebACLHasIncompatibleConfigurationViolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WebACLHasOutOfScopeResourcesViolation", targetDepth, ref reader))
                {
                    var unmarshaller = WebACLHasOutOfScopeResourcesViolationUnmarshaller.Instance;
                    unmarshalledObject.WebACLHasOutOfScopeResourcesViolation = unmarshaller.Unmarshall(context, ref reader);
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