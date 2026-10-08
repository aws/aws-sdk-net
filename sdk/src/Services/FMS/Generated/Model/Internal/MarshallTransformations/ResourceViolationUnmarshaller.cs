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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceViolation Object
    /// </summary>  
    public class ResourceViolationUnmarshaller : ICborUnmarshaller<ResourceViolation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceViolation Unmarshall(CborUnmarshallerContext context)
        {
            ResourceViolation unmarshalledObject = new ResourceViolation();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AwsEc2InstanceViolation":
                        {
                            context.AddPathSegment("AwsEc2InstanceViolation");
                            var unmarshaller = AwsEc2InstanceViolationUnmarshaller.Instance;
                            unmarshalledObject.AwsEc2InstanceViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AwsEc2NetworkInterfaceViolation":
                        {
                            context.AddPathSegment("AwsEc2NetworkInterfaceViolation");
                            var unmarshaller = AwsEc2NetworkInterfaceViolationUnmarshaller.Instance;
                            unmarshalledObject.AwsEc2NetworkInterfaceViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AwsVPCSecurityGroupViolation":
                        {
                            context.AddPathSegment("AwsVPCSecurityGroupViolation");
                            var unmarshaller = AwsVPCSecurityGroupViolationUnmarshaller.Instance;
                            unmarshalledObject.AwsVPCSecurityGroupViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DnsDuplicateRuleGroupViolation":
                        {
                            context.AddPathSegment("DnsDuplicateRuleGroupViolation");
                            var unmarshaller = DnsDuplicateRuleGroupViolationUnmarshaller.Instance;
                            unmarshalledObject.DnsDuplicateRuleGroupViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DnsRuleGroupLimitExceededViolation":
                        {
                            context.AddPathSegment("DnsRuleGroupLimitExceededViolation");
                            var unmarshaller = DnsRuleGroupLimitExceededViolationUnmarshaller.Instance;
                            unmarshalledObject.DnsRuleGroupLimitExceededViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DnsRuleGroupPriorityConflictViolation":
                        {
                            context.AddPathSegment("DnsRuleGroupPriorityConflictViolation");
                            var unmarshaller = DnsRuleGroupPriorityConflictViolationUnmarshaller.Instance;
                            unmarshalledObject.DnsRuleGroupPriorityConflictViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FirewallSubnetIsOutOfScopeViolation":
                        {
                            context.AddPathSegment("FirewallSubnetIsOutOfScopeViolation");
                            var unmarshaller = FirewallSubnetIsOutOfScopeViolationUnmarshaller.Instance;
                            unmarshalledObject.FirewallSubnetIsOutOfScopeViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FirewallSubnetMissingVPCEndpointViolation":
                        {
                            context.AddPathSegment("FirewallSubnetMissingVPCEndpointViolation");
                            var unmarshaller = FirewallSubnetMissingVPCEndpointViolationUnmarshaller.Instance;
                            unmarshalledObject.FirewallSubnetMissingVPCEndpointViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InvalidNetworkAclEntriesViolation":
                        {
                            context.AddPathSegment("InvalidNetworkAclEntriesViolation");
                            var unmarshaller = InvalidNetworkAclEntriesViolationUnmarshaller.Instance;
                            unmarshalledObject.InvalidNetworkAclEntriesViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallBlackHoleRouteDetectedViolation":
                        {
                            context.AddPathSegment("NetworkFirewallBlackHoleRouteDetectedViolation");
                            var unmarshaller = NetworkFirewallBlackHoleRouteDetectedViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallBlackHoleRouteDetectedViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallInternetTrafficNotInspectedViolation":
                        {
                            context.AddPathSegment("NetworkFirewallInternetTrafficNotInspectedViolation");
                            var unmarshaller = NetworkFirewallInternetTrafficNotInspectedViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallInternetTrafficNotInspectedViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallInvalidRouteConfigurationViolation":
                        {
                            context.AddPathSegment("NetworkFirewallInvalidRouteConfigurationViolation");
                            var unmarshaller = NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallInvalidRouteConfigurationViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallMissingExpectedRoutesViolation":
                        {
                            context.AddPathSegment("NetworkFirewallMissingExpectedRoutesViolation");
                            var unmarshaller = NetworkFirewallMissingExpectedRoutesViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallMissingExpectedRoutesViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallMissingExpectedRTViolation":
                        {
                            context.AddPathSegment("NetworkFirewallMissingExpectedRTViolation");
                            var unmarshaller = NetworkFirewallMissingExpectedRTViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallMissingExpectedRTViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallMissingFirewallViolation":
                        {
                            context.AddPathSegment("NetworkFirewallMissingFirewallViolation");
                            var unmarshaller = NetworkFirewallMissingFirewallViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallMissingFirewallViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallMissingSubnetViolation":
                        {
                            context.AddPathSegment("NetworkFirewallMissingSubnetViolation");
                            var unmarshaller = NetworkFirewallMissingSubnetViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallMissingSubnetViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallPolicyModifiedViolation":
                        {
                            context.AddPathSegment("NetworkFirewallPolicyModifiedViolation");
                            var unmarshaller = NetworkFirewallPolicyModifiedViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallPolicyModifiedViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallUnexpectedFirewallRoutesViolation":
                        {
                            context.AddPathSegment("NetworkFirewallUnexpectedFirewallRoutesViolation");
                            var unmarshaller = NetworkFirewallUnexpectedFirewallRoutesViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallUnexpectedFirewallRoutesViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NetworkFirewallUnexpectedGatewayRoutesViolation":
                        {
                            context.AddPathSegment("NetworkFirewallUnexpectedGatewayRoutesViolation");
                            var unmarshaller = NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller.Instance;
                            unmarshalledObject.NetworkFirewallUnexpectedGatewayRoutesViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PossibleRemediationActions":
                        {
                            context.AddPathSegment("PossibleRemediationActions");
                            var unmarshaller = PossibleRemediationActionsUnmarshaller.Instance;
                            unmarshalledObject.PossibleRemediationActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RouteHasOutOfScopeEndpointViolation":
                        {
                            context.AddPathSegment("RouteHasOutOfScopeEndpointViolation");
                            var unmarshaller = RouteHasOutOfScopeEndpointViolationUnmarshaller.Instance;
                            unmarshalledObject.RouteHasOutOfScopeEndpointViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ThirdPartyFirewallMissingExpectedRouteTableViolation":
                        {
                            context.AddPathSegment("ThirdPartyFirewallMissingExpectedRouteTableViolation");
                            var unmarshaller = ThirdPartyFirewallMissingExpectedRouteTableViolationUnmarshaller.Instance;
                            unmarshalledObject.ThirdPartyFirewallMissingExpectedRouteTableViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ThirdPartyFirewallMissingFirewallViolation":
                        {
                            context.AddPathSegment("ThirdPartyFirewallMissingFirewallViolation");
                            var unmarshaller = ThirdPartyFirewallMissingFirewallViolationUnmarshaller.Instance;
                            unmarshalledObject.ThirdPartyFirewallMissingFirewallViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ThirdPartyFirewallMissingSubnetViolation":
                        {
                            context.AddPathSegment("ThirdPartyFirewallMissingSubnetViolation");
                            var unmarshaller = ThirdPartyFirewallMissingSubnetViolationUnmarshaller.Instance;
                            unmarshalledObject.ThirdPartyFirewallMissingSubnetViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "WebACLHasIncompatibleConfigurationViolation":
                        {
                            context.AddPathSegment("WebACLHasIncompatibleConfigurationViolation");
                            var unmarshaller = WebACLHasIncompatibleConfigurationViolationUnmarshaller.Instance;
                            unmarshalledObject.WebACLHasIncompatibleConfigurationViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "WebACLHasOutOfScopeResourcesViolation":
                        {
                            context.AddPathSegment("WebACLHasOutOfScopeResourcesViolation");
                            var unmarshaller = WebACLHasOutOfScopeResourcesViolationUnmarshaller.Instance;
                            unmarshalledObject.WebACLHasOutOfScopeResourcesViolation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
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