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
    /// Connection information for a new game session that is created in response to a start
    /// matchmaking request. Once a match is made, the FlexMatch engine creates a new game
    /// session for it. This information, including the game session endpoint and player sessions
    /// for each player in the original matchmaking request, is added to the matchmaking ticket.
    /// </summary>
    public partial class GameSessionConnectionInfo
    {
        private string _dnsName;
        private string _gameSessionArn;
        private string _ipAddress;
        private List<MatchedPlayerSession> _matchedPlayerSessions = new List<MatchedPlayerSession>();
        private int? _port;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS identifier assigned to the instance that is running the game session. Values
        /// have the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TLS-enabled fleets: <code>&lt;unique identifier&gt;.&lt;region identifier&gt;.amazongamelift.com</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Non-TLS-enabled fleets: <code>ec2-&lt;unique identifier&gt;.compute.amazonaws.com</code>.
        /// (See <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-instance-addressing.html#concepts-public-addresses">Amazon
        /// EC2 Instance IP Addressing</a>.)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When connecting to a game session that is running on a TLS-enabled fleet, you must
        /// use the DNS name, not the IP address.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionArn. 
        /// <para>
        /// A unique identifier for the game session. Use the game session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GameSessionArn
        {
            get { return this._gameSessionArn; }
            set { this._gameSessionArn = value; }
        }

        // Check to see if GameSessionArn property is set
        internal bool IsSetGameSessionArn()
        {
            return this._gameSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the game session. To connect to a GameLift game server, an app needs
        /// both the IP address and port number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property MatchedPlayerSessions. 
        /// <para>
        /// A collection of player session IDs, one for each player ID that was included in the
        /// original matchmaking request. 
        /// </para>
        /// </summary>
        public List<MatchedPlayerSession> MatchedPlayerSessions
        {
            get { return this._matchedPlayerSessions; }
            set { this._matchedPlayerSessions = value; }
        }

        // Check to see if MatchedPlayerSessions property is set
        internal bool IsSetMatchedPlayerSessions()
        {
            return this._matchedPlayerSessions != null && this._matchedPlayerSessions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for the game session. To connect to a GameLift game server, an app
        /// needs both the IP address and port number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}