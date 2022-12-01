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
    /// <b>This data type is used with the GameLift FleetIQ and game server groups.</b> 
    /// 
    ///  
    /// <para>
    /// Properties describing a game server that is running on an instance in a game server
    /// group. 
    /// </para>
    ///  
    /// <para>
    /// A game server is created by a successful call to <code>RegisterGameServer</code> and
    /// deleted by calling <code>DeregisterGameServer</code>. A game server is claimed to
    /// host a game session by calling <code>ClaimGameServer</code>. 
    /// </para>
    /// </summary>
    public partial class GameServer
    {
        private GameServerClaimStatus _claimStatus;
        private string _connectionInfo;
        private string _gameServerData;
        private string _gameServerGroupArn;
        private string _gameServerGroupName;
        private string _gameServerId;
        private string _instanceId;
        private DateTime? _lastClaimTime;
        private DateTime? _lastHealthCheckTime;
        private DateTime? _registrationTime;
        private GameServerUtilizationStatus _utilizationStatus;

        /// <summary>
        /// Gets and sets the property ClaimStatus. 
        /// <para>
        /// Indicates when an available game server has been reserved for gameplay but has not
        /// yet started hosting a game. Once it is claimed, the game server remains in <code>CLAIMED</code>
        /// status for a maximum of one minute. During this time, game clients connect to the
        /// game server to start the game and trigger the game server to update its utilization
        /// status. After one minute, the game server claim status reverts to null.
        /// </para>
        /// </summary>
        public GameServerClaimStatus ClaimStatus
        {
            get { return this._claimStatus; }
            set { this._claimStatus = value; }
        }

        // Check to see if ClaimStatus property is set
        internal bool IsSetClaimStatus()
        {
            return this._claimStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionInfo. 
        /// <para>
        /// The port and IP address that must be used to establish a client connection to the
        /// game server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ConnectionInfo
        {
            get { return this._connectionInfo; }
            set { this._connectionInfo = value; }
        }

        // Check to see if ConnectionInfo property is set
        internal bool IsSetConnectionInfo()
        {
            return this._connectionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerData. 
        /// <para>
        /// A set of custom game server properties, formatted as a single string value. This data
        /// is passed to a game client or service when it requests information on game servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GameServerData
        {
            get { return this._gameServerData; }
            set { this._gameServerData = value; }
        }

        // Check to see if GameServerData property is set
        internal bool IsSetGameServerData()
        {
            return this._gameServerData != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerGroupArn. 
        /// <para>
        /// The ARN identifier for the game server group where the game server is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GameServerGroupArn
        {
            get { return this._gameServerGroupArn; }
            set { this._gameServerGroupArn = value; }
        }

        // Check to see if GameServerGroupArn property is set
        internal bool IsSetGameServerGroupArn()
        {
            return this._gameServerGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A unique identifier for the game server group where the game server is running.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string GameServerGroupName
        {
            get { return this._gameServerGroupName; }
            set { this._gameServerGroupName = value; }
        }

        // Check to see if GameServerGroupName property is set
        internal bool IsSetGameServerGroupName()
        {
            return this._gameServerGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerId. 
        /// <para>
        /// A custom string that uniquely identifies the game server. Game server IDs are developer-defined
        /// and are unique across all game server groups in an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string GameServerId
        {
            get { return this._gameServerId; }
            set { this._gameServerId = value; }
        }

        // Check to see if GameServerId property is set
        internal bool IsSetGameServerId()
        {
            return this._gameServerId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the instance where the game server is running. This ID is
        /// available in the instance metadata. EC2 instance IDs use a 17-character format, for
        /// example: <code>i-1234567890abcdef0</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LastClaimTime. 
        /// <para>
        /// Timestamp that indicates the last time the game server was claimed. The format is
        /// a number expressed in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// This value is used to calculate when a claimed game server's status should revert
        /// to null.
        /// </para>
        /// </summary>
        public DateTime LastClaimTime
        {
            get { return this._lastClaimTime.GetValueOrDefault(); }
            set { this._lastClaimTime = value; }
        }

        // Check to see if LastClaimTime property is set
        internal bool IsSetLastClaimTime()
        {
            return this._lastClaimTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastHealthCheckTime. 
        /// <para>
        /// Timestamp that indicates the last time the game server was updated with health status.
        /// The format is a number expressed in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// After game server registration, this property is only changed when a game server update
        /// specifies a health check value.
        /// </para>
        /// </summary>
        public DateTime LastHealthCheckTime
        {
            get { return this._lastHealthCheckTime.GetValueOrDefault(); }
            set { this._lastHealthCheckTime = value; }
        }

        // Check to see if LastHealthCheckTime property is set
        internal bool IsSetLastHealthCheckTime()
        {
            return this._lastHealthCheckTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationTime. 
        /// <para>
        /// Timestamp that indicates when the game server registered. The format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime RegistrationTime
        {
            get { return this._registrationTime.GetValueOrDefault(); }
            set { this._registrationTime = value; }
        }

        // Check to see if RegistrationTime property is set
        internal bool IsSetRegistrationTime()
        {
            return this._registrationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtilizationStatus. 
        /// <para>
        /// Indicates whether the game server is currently available for new games or is busy.
        /// Possible statuses include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - The game server is available to be claimed. A game server
        /// that has been claimed remains in this status until it reports game hosting activity.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UTILIZED</code> - The game server is currently hosting a game session with
        /// players. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GameServerUtilizationStatus UtilizationStatus
        {
            get { return this._utilizationStatus; }
            set { this._utilizationStatus = value; }
        }

        // Check to see if UtilizationStatus property is set
        internal bool IsSetUtilizationStatus()
        {
            return this._utilizationStatus != null;
        }

    }
}