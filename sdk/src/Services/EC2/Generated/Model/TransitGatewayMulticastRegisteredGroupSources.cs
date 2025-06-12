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
    /// Describes the members registered with the transit gateway multicast group.
    /// </summary>
    public partial class TransitGatewayMulticastRegisteredGroupSources
    {
        private string _groupIpAddress;
        private List<string> _registeredNetworkInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _transitGatewayMulticastDomainId;

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
        /// Gets and sets the property RegisteredNetworkInterfaceIds. 
        /// <para>
        /// The IDs of the network interfaces members registered with the transit gateway multicast
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RegisteredNetworkInterfaceIds
        {
            get { return this._registeredNetworkInterfaceIds; }
            set { this._registeredNetworkInterfaceIds = value; }
        }

        // Check to see if RegisteredNetworkInterfaceIds property is set
        internal bool IsSetRegisteredNetworkInterfaceIds()
        {
            return this._registeredNetworkInterfaceIds != null && (this._registeredNetworkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
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