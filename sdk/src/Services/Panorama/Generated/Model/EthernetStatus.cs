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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A device's Ethernet status.
    /// </summary>
    public partial class EthernetStatus
    {
        private NetworkConnectionStatus _connectionStatus;
        private string _hwAddress;
        private string _ipAddress;

        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// The device's connection status.
        /// </para>
        /// </summary>
        public NetworkConnectionStatus ConnectionStatus
        {
            get { return this._connectionStatus; }
            set { this._connectionStatus = value; }
        }

        // Check to see if ConnectionStatus property is set
        internal bool IsSetConnectionStatus()
        {
            return this._connectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HwAddress. 
        /// <para>
        /// The device's physical address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string HwAddress
        {
            get { return this._hwAddress; }
            set { this._hwAddress = value; }
        }

        // Check to see if HwAddress property is set
        internal bool IsSetHwAddress()
        {
            return this._hwAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The device's IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

    }
}