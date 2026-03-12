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
    /// Configuration settings for player gateway. Use these settings to specify advanced
    /// options for how player gateway handles connections.
    /// </summary>
    public partial class PlayerGatewayConfiguration
    {
        private GameServerIpProtocolSupported _gameServerIpProtocolSupported;

        /// <summary>
        /// Gets and sets the property GameServerIpProtocolSupported. 
        /// <para>
        /// The IP protocol that your game servers support for player connections through player
        /// gateway. If the value is set to <c>IPv4</c>, GameLift will install and execute a lightweight
        /// IP translation software on fleet instances to receive and transform incoming IPv6
        /// traffic to IPv4. If the value is set to <c>DUAL_STACK</c>, the lightweight IP translation
        /// software will not be installed on fleet instances. <c>DUAL_STACK</c> provides slightly
        /// better performance than <c>IPv4</c>.
        /// </para>
        /// </summary>
        public GameServerIpProtocolSupported GameServerIpProtocolSupported
        {
            get { return this._gameServerIpProtocolSupported; }
            set { this._gameServerIpProtocolSupported = value; }
        }

        // Check to see if GameServerIpProtocolSupported property is set
        internal bool IsSetGameServerIpProtocolSupported()
        {
            return this._gameServerIpProtocolSupported != null;
        }

    }
}