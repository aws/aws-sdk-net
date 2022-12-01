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
    /// Represents a player session. Player sessions are created either for a specific game
    /// session, or as part of a game session placement or matchmaking request. A player session
    /// can represents a reserved player slot in a game session (when status is <code>RESERVED</code>)
    /// or actual player activity in a game session (when status is <code>ACTIVE</code>).
    /// A player session object, including player data, is automatically passed to a game
    /// session when the player connects to the game session and is validated. After the game
    /// session ends, player sessions information is retained for 30 days and then removed.
    /// 
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class PlayerSession
    {
        private DateTime? _creationTime;
        private string _dnsName;
        private string _fleetArn;
        private string _fleetId;
        private string _gameSessionId;
        private string _ipAddress;
        private string _playerData;
        private string _playerId;
        private string _playerSessionId;
        private int? _port;
        private PlayerSessionStatus _status;
        private DateTime? _terminationTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

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
        /// Gets and sets the property FleetArn. 
        /// <para>
        ///  The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift fleet that the player's game session is running on. 
        /// </para>
        /// </summary>
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the player's game session is running on.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// A unique identifier for the game session that the player session is connected to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GameSessionId
        {
            get { return this._gameSessionId; }
            set { this._gameSessionId = value; }
        }

        // Check to see if GameSessionId property is set
        internal bool IsSetGameSessionId()
        {
            return this._gameSessionId != null;
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
        /// Gets and sets the property PlayerData. 
        /// <para>
        /// Developer-defined information related to a player. GameLift does not use this data,
        /// so it can be formatted as needed for use in the game. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PlayerData
        {
            get { return this._playerData; }
            set { this._playerData = value; }
        }

        // Check to see if PlayerData property is set
        internal bool IsSetPlayerData()
        {
            return this._playerData != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player that is associated with this player session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PlayerId
        {
            get { return this._playerId; }
            set { this._playerId = value; }
        }

        // Check to see if PlayerId property is set
        internal bool IsSetPlayerId()
        {
            return this._playerId != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerSessionId. 
        /// <para>
        /// A unique identifier for a player session.
        /// </para>
        /// </summary>
        public string PlayerSessionId
        {
            get { return this._playerSessionId; }
            set { this._playerSessionId = value; }
        }

        // Check to see if PlayerSessionId property is set
        internal bool IsSetPlayerSessionId()
        {
            return this._playerSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Port number for the game session. To connect to a Amazon GameLift server process,
        /// an app needs both the IP address and port number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60000)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the player session.
        /// </para>
        ///  
        /// <para>
        /// Possible player session statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RESERVED</b> -- The player session request has been received, but the player has
        /// not yet connected to the server process and/or been validated. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- The player has been validated by the server process and is currently
        /// connected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPLETED</b> -- The player connection has been dropped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TIMEDOUT</b> -- A player session request was received, but the player did not
        /// connect and/or was not validated within the timeout limit (60 seconds).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PlayerSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// A time stamp indicating when this data object was terminated. Format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime TerminationTime
        {
            get { return this._terminationTime.GetValueOrDefault(); }
            set { this._terminationTime = value; }
        }

        // Check to see if TerminationTime property is set
        internal bool IsSetTerminationTime()
        {
            return this._terminationTime.HasValue; 
        }

    }
}