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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Egress address of AgentEndpoint with an optional mtu.
    /// </summary>
    public partial class ConnectionDetails
    {
        private int? _mtu;
        private SocketAddress _socketAddress;

        /// <summary>
        /// Gets and sets the property Mtu. 
        /// <para>
        /// Maximum transmission unit (MTU) size in bytes of a dataflow endpoint.
        /// </para>
        /// </summary>
        public int Mtu
        {
            get { return this._mtu.GetValueOrDefault(); }
            set { this._mtu = value; }
        }

        // Check to see if Mtu property is set
        internal bool IsSetMtu()
        {
            return this._mtu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SocketAddress. 
        /// <para>
        /// A socket address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SocketAddress SocketAddress
        {
            get { return this._socketAddress; }
            set { this._socketAddress = value; }
        }

        // Check to see if SocketAddress property is set
        internal bool IsSetSocketAddress()
        {
            return this._socketAddress != null;
        }

    }
}