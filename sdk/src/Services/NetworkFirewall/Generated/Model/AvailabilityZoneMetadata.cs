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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// High-level information about an Availability Zone where the firewall has an endpoint
    /// defined.
    /// </summary>
    public partial class AvailabilityZoneMetadata
    {
        private IPAddressType _ipAddressType;

        /// <summary>
        /// Gets and sets the property IPAddressType. 
        /// <para>
        /// The IP address type of the Firewall subnet in the Availability Zone. You can't change
        /// the IP address type after you create the subnet.
        /// </para>
        /// </summary>
        public IPAddressType IPAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IPAddressType property is set
        internal bool IsSetIPAddressType()
        {
            return this._ipAddressType != null;
        }

    }
}