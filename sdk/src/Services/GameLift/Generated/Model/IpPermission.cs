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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A range of IP addresses and port settings that allow inbound traffic to connect to
    /// server processes on an instance in a fleet. New game sessions are assigned an IP address/port
    /// number combination, which must fall into the fleet's allowed ranges. Fleets with custom
    /// game builds must have permissions explicitly set. For Realtime Servers fleets, GameLift
    /// automatically opens two port ranges, one for TCP messaging and one for UDP.
    /// </summary>
    public partial class IpPermission
    {
        private int? _fromPort;
        private string _ipRange;
        private IpProtocol _protocol;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// A starting value for a range of allowed port numbers.
        /// </para>
        ///  
        /// <para>
        /// For fleets using Windows and Linux builds, only ports 1026-60000 are valid.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60000)]
        public int FromPort
        {
            get { return this._fromPort.GetValueOrDefault(); }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpRange. 
        /// <para>
        /// A range of allowed IP addresses. This value must be expressed in CIDR notation. Example:
        /// "<code>000.000.000.000/[subnet mask]</code>" or optionally the shortened version "<code>0.0.0.0/[subnet
        /// mask]</code>".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpRange
        {
            get { return this._ipRange; }
            set { this._ipRange = value; }
        }

        // Check to see if IpRange property is set
        internal bool IsSetIpRange()
        {
            return this._ipRange != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network communication protocol used by the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IpProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// An ending value for a range of allowed port numbers. Port numbers are end-inclusive.
        /// This value must be higher than <code>FromPort</code>.
        /// </para>
        ///  
        /// <para>
        /// For fleets using Windows and Linux builds, only ports 1026-60000 are valid.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60000)]
        public int ToPort
        {
            get { return this._toPort.GetValueOrDefault(); }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}