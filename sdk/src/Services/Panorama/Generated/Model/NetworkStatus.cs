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
    /// The network status of a device.
    /// </summary>
    public partial class NetworkStatus
    {
        private EthernetStatus _ethernet0Status;
        private EthernetStatus _ethernet1Status;
        private DateTime? _lastUpdatedTime;
        private NtpStatus _ntpStatus;

        /// <summary>
        /// Gets and sets the property Ethernet0Status. 
        /// <para>
        /// The status of Ethernet port 0.
        /// </para>
        /// </summary>
        public EthernetStatus Ethernet0Status
        {
            get { return this._ethernet0Status; }
            set { this._ethernet0Status = value; }
        }

        // Check to see if Ethernet0Status property is set
        internal bool IsSetEthernet0Status()
        {
            return this._ethernet0Status != null;
        }

        /// <summary>
        /// Gets and sets the property Ethernet1Status. 
        /// <para>
        /// The status of Ethernet port 1.
        /// </para>
        /// </summary>
        public EthernetStatus Ethernet1Status
        {
            get { return this._ethernet1Status; }
            set { this._ethernet1Status = value; }
        }

        // Check to see if Ethernet1Status property is set
        internal bool IsSetEthernet1Status()
        {
            return this._ethernet1Status != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// When the network status changed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NtpStatus. 
        /// <para>
        /// Details about a network time protocol (NTP) server connection.
        /// </para>
        /// </summary>
        public NtpStatus NtpStatus
        {
            get { return this._ntpStatus; }
            set { this._ntpStatus = value; }
        }

        // Check to see if NtpStatus property is set
        internal bool IsSetNtpStatus()
        {
            return this._ntpStatus != null;
        }

    }
}