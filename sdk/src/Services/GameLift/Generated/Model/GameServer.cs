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
    /// <b>This data type is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Properties describing a game server resource. 
    /// </para>
    ///  
    /// <para>
    /// A game server resource is created by a successful call to <a>RegisterGameServer</a>
    /// and deleted by calling <a>DeregisterGameServer</a>. 
    /// </para>
    /// </summary>
    public partial class GameServer
    {
        private GameServerClaimStatus _claimStatus;
        private string _connectionInfo;
        private string _customSortKey;
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
        /// Indicates when an available game server has been reserved but has not yet started
        /// hosting a game. Once it is claimed, game server remains in CLAIMED status for a maximum
        /// of one minute. During this time, game clients must connect to the game server and
        /// start the game, which triggers the game server to update its utilization status. After
        /// one minute, the game server claim status reverts to null.
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
        /// Gets and sets the property CustomSortKey. 
        /// <para>
        /// A game server tag that can be used to request sorted lists of game servers when calling
        /// <a>ListGameServers</a>. Custom sort keys are developer-defined. This property can
        /// be updated using <a>UpdateGameServer</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomSortKey
        {
            get { return this._customSortKey; }
            set { this._customSortKey = value; }
        }

        // Check to see if CustomSortKey property is set
        internal bool IsSetCustomSortKey()
        {
            return this._customSortKey != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerData. 
        /// <para>
        /// A set of custom game server properties, formatted as a single string value. This data
        /// is passed to a game client or service in response to requests <a>ListGameServers</a>
        /// or <a>ClaimGameServer</a>. This property can be updated using <a>UpdateGameServer</a>.
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
        /// The name identifier for the game server group where the game server is located.
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
        /// and are unique across all game server groups in an AWS account.
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
        /// The unique identifier for the instance where the game server is located.
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
        /// Time stamp indicating the last time the game server was claimed with a <a>ClaimGameServer</a>
        /// request. Format is a number expressed in Unix time as milliseconds (for example "1469498468.057").
        /// This value is used to calculate when the game server's claim status.
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
        /// Time stamp indicating the last time the game server was updated with health status
        /// using an <a>UpdateGameServer</a> request. Format is a number expressed in Unix time
        /// as milliseconds (for example "1469498468.057"). After game server registration, this
        /// property is only changed when a game server update specifies a health check value.
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
        /// Time stamp indicating when the game server resource was created with a <a>RegisterGameServer</a>
        /// request. Format is a number expressed in Unix time as milliseconds (for example "1469498468.057").
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
        /// AVAILABLE - The game server is available to be claimed. A game server that has been
        /// claimed remains in this status until it reports game hosting activity. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN_USE - The game server is currently hosting a game session with players. 
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