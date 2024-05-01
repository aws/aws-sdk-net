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
    /// Information about a Client VPN endpoint route.
    /// </summary>
    public partial class ClientVpnRoute
    {
        private string _clientVpnEndpointId;
        private string _description;
        private string _destinationCidr;
        private string _origin;
        private ClientVpnRouteStatus _status;
        private string _targetSubnet;
        private string _type;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint with which the route is associated.
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
        /// A brief description of the route.
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
        /// The IPv4 address range, in CIDR notation, of the route destination.
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
        /// Gets and sets the property Origin. 
        /// <para>
        /// Indicates how the route was associated with the Client VPN endpoint. <c>associate</c>
        /// indicates that the route was automatically added when the target network was associated
        /// with the Client VPN endpoint. <c>add-route</c> indicates that the route was manually
        /// added using the <b>CreateClientVpnRoute</b> action.
        /// </para>
        /// </summary>
        public string Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the route.
        /// </para>
        /// </summary>
        public ClientVpnRouteStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSubnet. 
        /// <para>
        /// The ID of the subnet through which traffic is routed.
        /// </para>
        /// </summary>
        public string TargetSubnet
        {
            get { return this._targetSubnet; }
            set { this._targetSubnet = value; }
        }

        // Check to see if TargetSubnet property is set
        internal bool IsSetTargetSubnet()
        {
            return this._targetSubnet != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The route type.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}