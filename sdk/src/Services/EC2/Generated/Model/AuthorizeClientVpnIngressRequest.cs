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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the AuthorizeClientVpnIngress operation.
    /// Adds an ingress authorization rule to a Client VPN endpoint. Ingress authorization
    /// rules act as firewall rules that grant access to networks. You must configure ingress
    /// authorization rules to enable clients to access resources in Amazon Web Services or
    /// on-premises networks.
    /// </summary>
    public partial class AuthorizeClientVpnIngressRequest : AmazonEC2Request
    {
        private string _accessGroupId;
        private bool? _authorizeAllGroups;
        private string _clientToken;
        private string _clientVpnEndpointId;
        private string _description;
        private bool? _dryRun;
        private string _targetNetworkCidr;

        /// <summary>
        /// Gets and sets the property AccessGroupId. 
        /// <para>
        /// The ID of the group to grant access to, for example, the Active Directory group or
        /// identity provider (IdP) group. Required if <c>AuthorizeAllGroups</c> is <c>false</c>
        /// or not specified.
        /// </para>
        /// </summary>
        public string AccessGroupId
        {
            get { return this._accessGroupId; }
            set { this._accessGroupId = value; }
        }

        // Check to see if AccessGroupId property is set
        internal bool IsSetAccessGroupId()
        {
            return this._accessGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizeAllGroups. 
        /// <para>
        /// Indicates whether to grant access to all clients. Specify <c>true</c> to grant all
        /// clients who successfully establish a VPN connection access to the network. Must be
        /// set to <c>true</c> if <c>AccessGroupId</c> is not specified.
        /// </para>
        /// </summary>
        public bool? AuthorizeAllGroups
        {
            get { return this._authorizeAllGroups; }
            set { this._authorizeAllGroups = value; }
        }

        // Check to see if AuthorizeAllGroups property is set
        internal bool IsSetAuthorizeAllGroups()
        {
            return this._authorizeAllGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the authorization rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetNetworkCidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the network for which access is being
        /// authorized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetNetworkCidr
        {
            get { return this._targetNetworkCidr; }
            set { this._targetNetworkCidr = value; }
        }

        // Check to see if TargetNetworkCidr property is set
        internal bool IsSetTargetNetworkCidr()
        {
            return this._targetNetworkCidr != null;
        }

    }
}