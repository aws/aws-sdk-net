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
    /// Information about an authorization rule.
    /// </summary>
    public partial class AuthorizationRule
    {
        /// <summary>
        /// Gets and sets the property AccessAll. 
        /// <para>
        /// Indicates whether the authorization rule grants access to all clients.
        /// </para>
        /// </summary>
        public bool? AccessAll { get; set; }

        /// <summary>
        /// Checks to see if the AccessAll property is set.
        /// </summary>
        internal bool IsSetAccessAll() => this.AccessAll.HasValue;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint with which the authorization rule is associated.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the network to which the authorization
        /// rule applies.
        /// </para>
        /// </summary>
        public string DestinationCidr { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidr property is set.
        /// </summary>
        internal bool IsSetDestinationCidr() => this.DestinationCidr != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the Active Directory group to which the authorization rule grants access.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the authorization rule.
        /// </para>
        /// </summary>
        public ClientVpnAuthorizationRuleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
