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
    /// This is the response object from the AssignIpv6Addresses operation.
    /// </summary>
    public partial class AssignIpv6AddressesResponse : AmazonWebServiceResponse
    {
        private List<string> _assignedIpv6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _assignedIpv6Prefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _networkInterfaceId;

        /// <summary>
        /// Gets and sets the property AssignedIpv6Addresses. 
        /// <para>
        /// The new IPv6 addresses assigned to the network interface. Existing IPv6 addresses
        /// that were assigned to the network interface before the request are not included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssignedIpv6Addresses
        {
            get { return this._assignedIpv6Addresses; }
            set { this._assignedIpv6Addresses = value; }
        }

        // Check to see if AssignedIpv6Addresses property is set
        internal bool IsSetAssignedIpv6Addresses()
        {
            return this._assignedIpv6Addresses != null && (this._assignedIpv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssignedIpv6Prefixes. 
        /// <para>
        /// The IPv6 prefixes that are assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssignedIpv6Prefixes
        {
            get { return this._assignedIpv6Prefixes; }
            set { this._assignedIpv6Prefixes = value; }
        }

        // Check to see if AssignedIpv6Prefixes property is set
        internal bool IsSetAssignedIpv6Prefixes()
        {
            return this._assignedIpv6Prefixes != null && (this._assignedIpv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
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