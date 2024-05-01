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
    /// The network configuration for a device.
    /// </summary>
    public partial class NetworkPayload
    {
        private EthernetPayload _ethernet0;
        private EthernetPayload _ethernet1;
        private NtpPayload _ntp;

        /// <summary>
        /// Gets and sets the property Ethernet0. 
        /// <para>
        /// Settings for Ethernet port 0.
        /// </para>
        /// </summary>
        public EthernetPayload Ethernet0
        {
            get { return this._ethernet0; }
            set { this._ethernet0 = value; }
        }

        // Check to see if Ethernet0 property is set
        internal bool IsSetEthernet0()
        {
            return this._ethernet0 != null;
        }

        /// <summary>
        /// Gets and sets the property Ethernet1. 
        /// <para>
        /// Settings for Ethernet port 1.
        /// </para>
        /// </summary>
        public EthernetPayload Ethernet1
        {
            get { return this._ethernet1; }
            set { this._ethernet1 = value; }
        }

        // Check to see if Ethernet1 property is set
        internal bool IsSetEthernet1()
        {
            return this._ethernet1 != null;
        }

        /// <summary>
        /// Gets and sets the property Ntp. 
        /// <para>
        /// Network time protocol (NTP) server settings.
        /// </para>
        /// </summary>
        public NtpPayload Ntp
        {
            get { return this._ntp; }
            set { this._ntp = value; }
        }

        // Check to see if Ntp property is set
        internal bool IsSetNtp()
        {
            return this._ntp != null;
        }

    }
}