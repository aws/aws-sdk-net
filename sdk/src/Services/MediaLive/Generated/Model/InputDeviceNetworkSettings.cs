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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The network settings for the input device.
    /// </summary>
    public partial class InputDeviceNetworkSettings
    {
        private List<string> _dnsAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _gateway;
        private string _ipAddress;
        private InputDeviceIpScheme _ipScheme;
        private string _subnetMask;

        /// <summary>
        /// Gets and sets the property DnsAddresses. The DNS addresses of the input device.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsAddresses
        {
            get { return this._dnsAddresses; }
            set { this._dnsAddresses = value; }
        }

        // Check to see if DnsAddresses property is set
        internal bool IsSetDnsAddresses()
        {
            return this._dnsAddresses != null && (this._dnsAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Gateway. The network gateway IP address.
        /// </summary>
        public string Gateway
        {
            get { return this._gateway; }
            set { this._gateway = value; }
        }

        // Check to see if Gateway property is set
        internal bool IsSetGateway()
        {
            return this._gateway != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. The IP address of the input device.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IpScheme. Specifies whether the input device has been configured
        /// (outside of MediaLive) to use a dynamic IP address assignment (DHCP) or a static IP
        /// address.
        /// </summary>
        public InputDeviceIpScheme IpScheme
        {
            get { return this._ipScheme; }
            set { this._ipScheme = value; }
        }

        // Check to see if IpScheme property is set
        internal bool IsSetIpScheme()
        {
            return this._ipScheme != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetMask. The subnet mask of the input device.
        /// </summary>
        public string SubnetMask
        {
            get { return this._subnetMask; }
            set { this._subnetMask = value; }
        }

        // Check to see if SubnetMask property is set
        internal bool IsSetSubnetMask()
        {
            return this._subnetMask != null;
        }

    }
}