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
    /// This is the response object from the UnassignIpv6Addresses operation.
    /// </summary>
    public partial class UnassignIpv6AddressesResponse : AmazonWebServiceResponse
    {
        private string _networkInterfaceId;
        private List<string> _unassignedIpv6Addresses = new List<string>();

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

        /// <summary>
        /// Gets and sets the property UnassignedIpv6Addresses. 
        /// <para>
        /// The IPv6 addresses that have been unassigned from the network interface.
        /// </para>
        /// </summary>
        public List<string> UnassignedIpv6Addresses
        {
            get { return this._unassignedIpv6Addresses; }
            set { this._unassignedIpv6Addresses = value; }
        }

        // Check to see if UnassignedIpv6Addresses property is set
        internal bool IsSetUnassignedIpv6Addresses()
        {
            return this._unassignedIpv6Addresses != null && this._unassignedIpv6Addresses.Count > 0; 
        }

    }
}