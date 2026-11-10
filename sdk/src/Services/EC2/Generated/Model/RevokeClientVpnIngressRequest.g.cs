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

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeClientVpnIngress operation. Removes an ingress
    /// authorization rule from a Client VPN endpoint.
    /// </summary>
    public partial class RevokeClientVpnIngressRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AccessGroupId. 
        /// <para>
        /// The ID of the Active Directory group for which to revoke access. 
        /// </para>
        /// </summary>
        public string AccessGroupId { get; set; }

        /// <summary>
        /// Checks to see if the AccessGroupId property is set.
        /// </summary>
        internal bool IsSetAccessGroupId() => this.AccessGroupId != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint with which the authorization rule is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property RevokeAllGroups. 
        /// <para>
        /// Indicates whether access should be revoked for all groups for a single <c>TargetNetworkCidr</c>
        /// that earlier authorized ingress for all groups using <c>AuthorizeAllGroups</c>. This
        /// does not impact other authorization rules that allowed ingress to the same <c>TargetNetworkCidr</c>
        /// with a specific <c>AccessGroupId</c>.
        /// </para>
        /// </summary>
        public bool? RevokeAllGroups { get; set; }

        /// <summary>
        /// Checks to see if the RevokeAllGroups property is set.
        /// </summary>
        internal bool IsSetRevokeAllGroups() => this.RevokeAllGroups.HasValue;

        /// <summary>
        /// Gets and sets the property TargetNetworkCidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the network for which access is being
        /// removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetNetworkCidr { get; set; }

        /// <summary>
        /// Checks to see if the TargetNetworkCidr property is set.
        /// </summary>
        internal bool IsSetTargetNetworkCidr() => this.TargetNetworkCidr != null;
    }
}
