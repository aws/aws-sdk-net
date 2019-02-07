/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Connection information for the new game session that is created with matchmaking.
    /// (with <a>StartMatchmaking</a>). Once a match is set, the FlexMatch engine places the
    /// match and creates a new game session for it. This information, including the game
    /// session endpoint and player sessions for each player in the original matchmaking request,
    /// is added to the <a>MatchmakingTicket</a>, which can be retrieved by calling <a>DescribeMatchmaking</a>.
    /// </summary>
    public partial class GameSessionConnectionInfo
    {
        private string _gameSessionArn;
        private string _ipAddress;
        private List<MatchedPlayerSession> _matchedPlayerSessions = new List<MatchedPlayerSession>();
        private int? _port;

        /// <summary>
        /// Gets and sets the property GameSessionArn. 
        /// <para>
        /// Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a game session and uniquely identifies it.
        /// </para>
        /// </summary>
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
        /// IP address of the game session. To connect to a Amazon GameLift game server, an app
        /// needs both the IP address and port number.
        /// </para>
        /// </summary>
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
        /// Collection of player session IDs, one for each player ID that was included in the
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
        /// Port number for the game session. To connect to a Amazon GameLift game server, an
        /// app needs both the IP address and port number.
        /// </para>
        /// </summary>
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