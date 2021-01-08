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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the deregistered transit gateway multicast group sources.
    /// </summary>
    public partial class TransitGatewayMulticastDeregisteredGroupSources
    {
        private List<string> _deregisteredNetworkInterfaceIds = new List<string>();
        private string _groupIpAddress;
        private string _transitGatewayMulticastDomainId;

        /// <summary>
        /// Gets and sets the property DeregisteredNetworkInterfaceIds. 
        /// <para>
        /// The network interface IDs of the non-registered members.
        /// </para>
        /// </summary>
        public List<string> DeregisteredNetworkInterfaceIds
        {
            get { return this._deregisteredNetworkInterfaceIds; }
            set { this._deregisteredNetworkInterfaceIds = value; }
        }

        // Check to see if DeregisteredNetworkInterfaceIds property is set
        internal bool IsSetDeregisteredNetworkInterfaceIds()
        {
            return this._deregisteredNetworkInterfaceIds != null && this._deregisteredNetworkInterfaceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupIpAddress. 
        /// <para>
        /// The IP address assigned to the transit gateway multicast group.
        /// </para>
        /// </summary>
        public string GroupIpAddress
        {
            get { return this._groupIpAddress; }
            set { this._groupIpAddress = value; }
        }

        // Check to see if GroupIpAddress property is set
        internal bool IsSetGroupIpAddress()
        {
            return this._groupIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayMulticastDomainId. 
        /// <para>
        /// The ID of the transit gateway multicast domain.
        /// </para>
        /// </summary>
        public string TransitGatewayMulticastDomainId
        {
            get { return this._transitGatewayMulticastDomainId; }
            set { this._transitGatewayMulticastDomainId = value; }
        }

        // Check to see if TransitGatewayMulticastDomainId property is set
        internal bool IsSetTransitGatewayMulticastDomainId()
        {
            return this._transitGatewayMulticastDomainId != null;
        }

    }
}