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

using Amazon.FMS.Model;
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
    public partial class ResourceViolationUnmarshaller : ICborUnmarshaller<ResourceViolation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ResourceViolation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ResourceViolation();
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
                    case "AwsEc2InstanceViolation":
                        context.AddPathSegment("AwsEc2InstanceViolation");
                        unmarshalledObject.AwsEc2InstanceViolation = AwsEc2InstanceViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AwsEc2NetworkInterfaceViolation":
                        context.AddPathSegment("AwsEc2NetworkInterfaceViolation");
                        unmarshalledObject.AwsEc2NetworkInterfaceViolation = AwsEc2NetworkInterfaceViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AwsVPCSecurityGroupViolation":
                        context.AddPathSegment("AwsVPCSecurityGroupViolation");
                        unmarshalledObject.AwsVPCSecurityGroupViolation = AwsVPCSecurityGroupViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsDuplicateRuleGroupViolation":
                        context.AddPathSegment("DnsDuplicateRuleGroupViolation");
                        unmarshalledObject.DnsDuplicateRuleGroupViolation = DnsDuplicateRuleGroupViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsRuleGroupLimitExceededViolation":
                        context.AddPathSegment("DnsRuleGroupLimitExceededViolation");
                        unmarshalledObject.DnsRuleGroupLimitExceededViolation = DnsRuleGroupLimitExceededViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsRuleGroupPriorityConflictViolation":
                        context.AddPathSegment("DnsRuleGroupPriorityConflictViolation");
                        unmarshalledObject.DnsRuleGroupPriorityConflictViolation = DnsRuleGroupPriorityConflictViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallSubnetIsOutOfScopeViolation":
                        context.AddPathSegment("FirewallSubnetIsOutOfScopeViolation");
                        unmarshalledObject.FirewallSubnetIsOutOfScopeViolation = FirewallSubnetIsOutOfScopeViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FirewallSubnetMissingVPCEndpointViolation":
                        context.AddPathSegment("FirewallSubnetMissingVPCEndpointViolation");
                        unmarshalledObject.FirewallSubnetMissingVPCEndpointViolation = FirewallSubnetMissingVPCEndpointViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InvalidNetworkAclEntriesViolation":
                        context.AddPathSegment("InvalidNetworkAclEntriesViolation");
                        unmarshalledObject.InvalidNetworkAclEntriesViolation = InvalidNetworkAclEntriesViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallBlackHoleRouteDetectedViolation":
                        context.AddPathSegment("NetworkFirewallBlackHoleRouteDetectedViolation");
                        unmarshalledObject.NetworkFirewallBlackHoleRouteDetectedViolation = NetworkFirewallBlackHoleRouteDetectedViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallInternetTrafficNotInspectedViolation":
                        context.AddPathSegment("NetworkFirewallInternetTrafficNotInspectedViolation");
                        unmarshalledObject.NetworkFirewallInternetTrafficNotInspectedViolation = NetworkFirewallInternetTrafficNotInspectedViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallInvalidRouteConfigurationViolation":
                        context.AddPathSegment("NetworkFirewallInvalidRouteConfigurationViolation");
                        unmarshalledObject.NetworkFirewallInvalidRouteConfigurationViolation = NetworkFirewallInvalidRouteConfigurationViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallMissingExpectedRTViolation":
                        context.AddPathSegment("NetworkFirewallMissingExpectedRTViolation");
                        unmarshalledObject.NetworkFirewallMissingExpectedRTViolation = NetworkFirewallMissingExpectedRTViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallMissingExpectedRoutesViolation":
                        context.AddPathSegment("NetworkFirewallMissingExpectedRoutesViolation");
                        unmarshalledObject.NetworkFirewallMissingExpectedRoutesViolation = NetworkFirewallMissingExpectedRoutesViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallMissingFirewallViolation":
                        context.AddPathSegment("NetworkFirewallMissingFirewallViolation");
                        unmarshalledObject.NetworkFirewallMissingFirewallViolation = NetworkFirewallMissingFirewallViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallMissingSubnetViolation":
                        context.AddPathSegment("NetworkFirewallMissingSubnetViolation");
                        unmarshalledObject.NetworkFirewallMissingSubnetViolation = NetworkFirewallMissingSubnetViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallPolicyModifiedViolation":
                        context.AddPathSegment("NetworkFirewallPolicyModifiedViolation");
                        unmarshalledObject.NetworkFirewallPolicyModifiedViolation = NetworkFirewallPolicyModifiedViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallUnexpectedFirewallRoutesViolation":
                        context.AddPathSegment("NetworkFirewallUnexpectedFirewallRoutesViolation");
                        unmarshalledObject.NetworkFirewallUnexpectedFirewallRoutesViolation = NetworkFirewallUnexpectedFirewallRoutesViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NetworkFirewallUnexpectedGatewayRoutesViolation":
                        context.AddPathSegment("NetworkFirewallUnexpectedGatewayRoutesViolation");
                        unmarshalledObject.NetworkFirewallUnexpectedGatewayRoutesViolation = NetworkFirewallUnexpectedGatewayRoutesViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PossibleRemediationActions":
                        context.AddPathSegment("PossibleRemediationActions");
                        unmarshalledObject.PossibleRemediationActions = PossibleRemediationActionsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RouteHasOutOfScopeEndpointViolation":
                        context.AddPathSegment("RouteHasOutOfScopeEndpointViolation");
                        unmarshalledObject.RouteHasOutOfScopeEndpointViolation = RouteHasOutOfScopeEndpointViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ThirdPartyFirewallMissingExpectedRouteTableViolation":
                        context.AddPathSegment("ThirdPartyFirewallMissingExpectedRouteTableViolation");
                        unmarshalledObject.ThirdPartyFirewallMissingExpectedRouteTableViolation = ThirdPartyFirewallMissingExpectedRouteTableViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ThirdPartyFirewallMissingFirewallViolation":
                        context.AddPathSegment("ThirdPartyFirewallMissingFirewallViolation");
                        unmarshalledObject.ThirdPartyFirewallMissingFirewallViolation = ThirdPartyFirewallMissingFirewallViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ThirdPartyFirewallMissingSubnetViolation":
                        context.AddPathSegment("ThirdPartyFirewallMissingSubnetViolation");
                        unmarshalledObject.ThirdPartyFirewallMissingSubnetViolation = ThirdPartyFirewallMissingSubnetViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WebACLHasIncompatibleConfigurationViolation":
                        context.AddPathSegment("WebACLHasIncompatibleConfigurationViolation");
                        unmarshalledObject.WebACLHasIncompatibleConfigurationViolation = WebACLHasIncompatibleConfigurationViolationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WebACLHasOutOfScopeResourcesViolation":
                        context.AddPathSegment("WebACLHasOutOfScopeResourcesViolation");
                        unmarshalledObject.WebACLHasOutOfScopeResourcesViolation = WebACLHasOutOfScopeResourcesViolationUnmarshaller.Instance.Unmarshall(context);
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

        private static ResourceViolationUnmarshaller _instance = new ResourceViolationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ResourceViolationUnmarshaller Instance => _instance;
    }
}
