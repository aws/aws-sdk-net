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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines connection tracking parameters for network interfaces.
    /// </summary>
    public partial class ConnectionTrackingSpecificationRequest
    {
        private int? _tcpEstablishedTimeout;
        private int? _udpStreamTimeout;
        private int? _udpTimeout;

        /// <summary>
        /// Gets and sets the property TcpEstablishedTimeout. 
        /// <para>
        /// Timeout for established TCP connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Timeout for UDP stream connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// General timeout for UDP connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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