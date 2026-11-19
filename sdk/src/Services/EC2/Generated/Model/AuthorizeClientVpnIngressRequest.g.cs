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
    /// Container for the parameters to the AuthorizeClientVpnIngress operation. Adds an ingress
    /// authorization rule to a Client VPN endpoint. Ingress authorization rules act as firewall
    /// rules that grant access to networks. You must configure ingress authorization rules
    /// to enable clients to access resources in Amazon Web Services or on-premises networks.
    /// </summary>
    public partial class AuthorizeClientVpnIngressRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AccessGroupId. 
        /// <para>
        /// The ID of the group to grant access to, for example, the Active Directory group or
        /// identity provider (IdP) group. Required if <c>AuthorizeAllGroups</c> is <c>false</c>
        /// or not specified.
        /// </para>
        /// </summary>
        public string AccessGroupId { get; set; }

        /// <summary>
        /// Checks to see if the AccessGroupId property is set.
        /// </summary>
        internal bool IsSetAccessGroupId() => this.AccessGroupId != null;

        /// <summary>
        /// Gets and sets the property AuthorizeAllGroups. 
        /// <para>
        /// Indicates whether to grant access to all clients. Specify <c>true</c> to grant all
        /// clients who successfully establish a VPN connection access to the network. Must be
        /// set to <c>true</c> if <c>AccessGroupId</c> is not specified.
        /// </para>
        /// </summary>
        public bool? AuthorizeAllGroups { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizeAllGroups property is set.
        /// </summary>
        internal bool IsSetAuthorizeAllGroups() => this.AuthorizeAllGroups.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the authorization rule.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property TargetNetworkCidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the network for which access is being
        /// authorized.
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
