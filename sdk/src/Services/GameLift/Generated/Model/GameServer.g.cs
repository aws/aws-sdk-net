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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Properties describing a game server that is running on an instance in a game server
    /// group. 
    /// 
    ///  
    /// <para>
    /// A game server is created by a successful call to <c>RegisterGameServer</c> and deleted
    /// by calling <c>DeregisterGameServer</c>. A game server is claimed to host a game session
    /// by calling <c>ClaimGameServer</c>. 
    /// </para>
    /// </summary>
    public partial class GameServer
    {
        /// <summary>
        /// Gets and sets the property ClaimStatus. 
        /// <para>
        /// Indicates when an available game server has been reserved for gameplay but has not
        /// yet started hosting a game. Once it is claimed, the game server remains in <c>CLAIMED</c>
        /// status for a maximum of one minute. During this time, game clients connect to the
        /// game server to start the game and trigger the game server to update its utilization
        /// status. After one minute, the game server claim status reverts to null.
        /// </para>
        /// </summary>
        public GameServerClaimStatus ClaimStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClaimStatus property is set.
        /// </summary>
        internal bool IsSetClaimStatus() => this.ClaimStatus != null;

        /// <summary>
        /// Gets and sets the property ConnectionInfo. 
        /// <para>
        /// The port and IP address that must be used to establish a client connection to the
        /// game server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ConnectionInfo { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionInfo property is set.
        /// </summary>
        internal bool IsSetConnectionInfo() => this.ConnectionInfo != null;

        /// <summary>
        /// Gets and sets the property GameServerData. 
        /// <para>
        /// A set of custom game server properties, formatted as a single string value. This data
        /// is passed to a game client or service when it requests information on game servers.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string GameServerData { get; set; }

        /// <summary>
        /// Checks to see if the GameServerData property is set.
        /// </summary>
        internal bool IsSetGameServerData() => this.GameServerData != null;

        /// <summary>
        /// Gets and sets the property GameServerGroupArn. 
        /// <para>
        /// The ARN identifier for the game server group where the game server is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string GameServerGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the GameServerGroupArn property is set.
        /// </summary>
        internal bool IsSetGameServerGroupArn() => this.GameServerGroupArn != null;

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A unique identifier for the game server group where the game server is running.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GameServerGroupName { get; set; }

        /// <summary>
        /// Checks to see if the GameServerGroupName property is set.
        /// </summary>
        internal bool IsSetGameServerGroupName() => this.GameServerGroupName != null;

        /// <summary>
        /// Gets and sets the property GameServerId. 
        /// <para>
        /// A custom string that uniquely identifies the game server. Game server IDs are developer-defined
        /// and are unique across all game server groups in an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string GameServerId { get; set; }

        /// <summary>
        /// Checks to see if the GameServerId property is set.
        /// </summary>
        internal bool IsSetGameServerId() => this.GameServerId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the instance where the game server is running. This ID is
        /// available in the instance metadata. EC2 instance IDs use a 17-character format, for
        /// example: <c>i-1234567890abcdef0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property LastClaimTime. 
        /// <para>
        /// Timestamp that indicates the last time the game server was claimed. The format is
        /// a number expressed in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// This value is used to calculate when a claimed game server's status should revert
        /// to null.
        /// </para>
        /// </summary>
        public DateTime? LastClaimTime { get; set; }

        /// <summary>
        /// Checks to see if the LastClaimTime property is set.
        /// </summary>
        internal bool IsSetLastClaimTime() => this.LastClaimTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastHealthCheckTime. 
        /// <para>
        /// Timestamp that indicates the last time the game server was updated with health status.
        /// The format is a number expressed in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// After game server registration, this property is only changed when a game server update
        /// specifies a health check value.
        /// </para>
        /// </summary>
        public DateTime? LastHealthCheckTime { get; set; }

        /// <summary>
        /// Checks to see if the LastHealthCheckTime property is set.
        /// </summary>
        internal bool IsSetLastHealthCheckTime() => this.LastHealthCheckTime.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrationTime. 
        /// <para>
        /// Timestamp that indicates when the game server registered. The format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? RegistrationTime { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationTime property is set.
        /// </summary>
        internal bool IsSetRegistrationTime() => this.RegistrationTime.HasValue;

        /// <summary>
        /// Gets and sets the property UtilizationStatus. 
        /// <para>
        /// Indicates whether the game server is currently available for new games or is busy.
        /// Possible statuses include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The game server is available to be claimed. A game server that
        /// has been claimed remains in this status until it reports game hosting activity. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UTILIZED</c> - The game server is currently hosting a game session with players.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GameServerUtilizationStatus UtilizationStatus { get; set; }

        /// <summary>
        /// Checks to see if the UtilizationStatus property is set.
        /// </summary>
        internal bool IsSetUtilizationStatus() => this.UtilizationStatus != null;
    }
}
