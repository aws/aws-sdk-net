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
    /// Information about an authorization rule.
    /// </summary>
    public partial class AuthorizationRule
    {
        private bool? _accessAll;
        private string _clientVpnEndpointId;
        private string _description;
        private string _destinationCidr;
        private string _groupId;
        private ClientVpnAuthorizationRuleStatus _status;

        /// <summary>
        /// Gets and sets the property AccessAll. 
        /// <para>
        /// Indicates whether the authorization rule grants access to all clients.
        /// </para>
        /// </summary>
        public bool? AccessAll
        {
            get { return this._accessAll; }
            set { this._accessAll = value; }
        }

        // Check to see if AccessAll property is set
        internal bool IsSetAccessAll()
        {
            return this._accessAll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint with which the authorization rule is associated.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the network to which the authorization
        /// rule applies.
        /// </para>
        /// </summary>
        public string DestinationCidr
        {
            get { return this._destinationCidr; }
            set { this._destinationCidr = value; }
        }

        // Check to see if DestinationCidr property is set
        internal bool IsSetDestinationCidr()
        {
            return this._destinationCidr != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the Active Directory group to which the authorization rule grants access.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the authorization rule.
        /// </para>
        /// </summary>
        public ClientVpnAuthorizationRuleStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}