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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Network address(es) and port(s) for connecting to a game session.
    /// </summary>
    public partial class PlayerConnectionEndpoint
    {
        private string _ipAddress;
        private int? _port;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// IP address for connecting to the game session. When player gateway is enabled, this
        /// is a player gateway IP address. When player gateway is disabled, this is the game
        /// server IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property Port. 
        /// <para>
        /// Port number for connecting to the game session. When player gateway is enabled, this
        /// is a player gateway port. When player gateway is disabled, this is the game server
        /// port.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=60000)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}