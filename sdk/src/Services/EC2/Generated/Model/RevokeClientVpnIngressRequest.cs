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
    /// Container for the parameters to the RevokeClientVpnIngress operation.
    /// Removes an ingress authorization rule from a Client VPN endpoint.
    /// </summary>
    public partial class RevokeClientVpnIngressRequest : AmazonEC2Request
    {
        private string _accessGroupId;
        private string _clientVpnEndpointId;
        private bool? _dryRun;
        private bool? _revokeAllGroups;
        private string _targetNetworkCidr;

        /// <summary>
        /// Gets and sets the property AccessGroupId. 
        /// <para>
        /// The ID of the Active Directory group for which to revoke access. 
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
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint with which the authorization rule is associated.
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
        /// Gets and sets the property RevokeAllGroups. 
        /// <para>
        /// Indicates whether access should be revoked for all groups for a single <c>TargetNetworkCidr</c>
        /// that earlier authorized ingress for all groups using <c>AuthorizeAllGroups</c>. This
        /// does not impact other authorization rules that allowed ingress to the same <c>TargetNetworkCidr</c>
        /// with a specific <c>AccessGroupId</c>.
        /// </para>
        /// </summary>
        public bool? RevokeAllGroups
        {
            get { return this._revokeAllGroups; }
            set { this._revokeAllGroups = value; }
        }

        // Check to see if RevokeAllGroups property is set
        internal bool IsSetRevokeAllGroups()
        {
            return this._revokeAllGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetNetworkCidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the network for which access is being
        /// removed.
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