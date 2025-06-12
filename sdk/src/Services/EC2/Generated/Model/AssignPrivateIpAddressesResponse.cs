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
    /// This is the response object from the AssignPrivateIpAddresses operation.
    /// </summary>
    public partial class AssignPrivateIpAddressesResponse : AmazonWebServiceResponse
    {
        private List<Ipv4PrefixSpecification> _assignedIpv4Prefixes = AWSConfigs.InitializeCollections ? new List<Ipv4PrefixSpecification>() : null;
        private List<AssignedPrivateIpAddress> _assignedPrivateIpAddresses = AWSConfigs.InitializeCollections ? new List<AssignedPrivateIpAddress>() : null;
        private string _networkInterfaceId;

        /// <summary>
        /// Gets and sets the property AssignedIpv4Prefixes. 
        /// <para>
        /// The IPv4 prefixes that are assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv4PrefixSpecification> AssignedIpv4Prefixes
        {
            get { return this._assignedIpv4Prefixes; }
            set { this._assignedIpv4Prefixes = value; }
        }

        // Check to see if AssignedIpv4Prefixes property is set
        internal bool IsSetAssignedIpv4Prefixes()
        {
            return this._assignedIpv4Prefixes != null && (this._assignedIpv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssignedPrivateIpAddresses. 
        /// <para>
        /// The private IP addresses assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssignedPrivateIpAddress> AssignedPrivateIpAddresses
        {
            get { return this._assignedPrivateIpAddresses; }
            set { this._assignedPrivateIpAddresses = value; }
        }

        // Check to see if AssignedPrivateIpAddresses property is set
        internal bool IsSetAssignedPrivateIpAddresses()
        {
            return this._assignedPrivateIpAddresses != null && (this._assignedPrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

    }
}