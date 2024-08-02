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
    /// A security group connection tracking configuration that enables you to set the idle
    /// timeout for connection tracking on an Elastic network interface. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#connection-tracking-timeouts">Connection
    /// tracking timeouts</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class ConnectionTrackingConfiguration
    {
        private int? _tcpEstablishedTimeout;
        private int? _udpStreamTimeout;
        private int? _udpTimeout;

        /// <summary>
        /// Gets and sets the property TcpEstablishedTimeout. 
        /// <para>
        /// Timeout (in seconds) for idle TCP connections in an established state. Min: 60 seconds.
        /// Max: 432000 seconds (5 days). Default: 432000 seconds. Recommended: Less than 432000
        /// seconds.
        /// </para>
        /// </summary>
        public int? TcpEstablishedTimeout
        {
            get { return this._tcpEstablishedTimeout; }
            set { this._tcpEstablishedTimeout = value; }
        }

        // Check to see if TcpEstablishedTimeout property is set
        internal bool IsSetTcpEstablishedTimeout()
        {
            return this._tcpEstablishedTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UdpStreamTimeout. 
        /// <para>
        /// Timeout (in seconds) for idle UDP flows classified as streams which have seen more
        /// than one request-response transaction. Min: 60 seconds. Max: 180 seconds (3 minutes).
        /// Default: 180 seconds.
        /// </para>
        /// </summary>
        public int? UdpStreamTimeout
        {
            get { return this._udpStreamTimeout; }
            set { this._udpStreamTimeout = value; }
        }

        // Check to see if UdpStreamTimeout property is set
        internal bool IsSetUdpStreamTimeout()
        {
            return this._udpStreamTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UdpTimeout. 
        /// <para>
        /// Timeout (in seconds) for idle UDP flows that have seen traffic only in a single direction
        /// or a single request-response transaction. Min: 30 seconds. Max: 60 seconds. Default:
        /// 30 seconds.
        /// </para>
        /// </summary>
        public int? UdpTimeout
        {
            get { return this._udpTimeout; }
            set { this._udpTimeout = value; }
        }

        // Check to see if UdpTimeout property is set
        internal bool IsSetUdpTimeout()
        {
            return this._udpTimeout.HasValue; 
        }

    }
}