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
    /// Container for the parameters to the ClaimGameServer operation.
    /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Locates an available game server and temporarily reserves it to host gameplay and
    /// players. This operation is called from a game client or client service (such as a
    /// matchmaker) to request hosting resources for a new game session. In response, GameLift
    /// FleetIQ locates an available game server, places it in <code>CLAIMED</code> status
    /// for 60 seconds, and returns connection information that players can use to connect
    /// to the game server. 
    /// </para>
    ///  
    /// <para>
    /// To claim a game server, identify a game server group. You can also specify a game
    /// server ID, although this approach bypasses GameLift FleetIQ placement optimization.
    /// Optionally, include game data to pass to the game server at the start of a game session,
    /// such as a game map or player information. 
    /// </para>
    ///  
    /// <para>
    /// When a game server is successfully claimed, connection information is returned. A
    /// claimed game server's utilization status remains <code>AVAILABLE</code> while the
    /// claim status is set to <code>CLAIMED</code> for up to 60 seconds. This time period
    /// gives the game server time to update its status to <code>UTILIZED</code> after players
    /// join. If the game server's status is not updated within 60 seconds, the game server
    /// reverts to unclaimed status and is available to be claimed by another request. The
    /// claim time period is a fixed value and is not configurable.
    /// </para>
    ///  
    /// <para>
    /// If you try to claim a specific game server, this request will fail in the following
    /// cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the game server utilization status is <code>UTILIZED</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the game server claim status is <code>CLAIMED</code>.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// When claiming a specific game server, this request will succeed even if the game server
    /// is running on an instance in <code>DRAINING</code> status. To avoid this, first check
    /// the instance status by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameServerInstances.html">DescribeGameServerInstances</a>
    /// .
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a> 
    /// </para>
    /// </summary>
    public partial class ClaimGameServerRequest : AmazonGameLiftRequest
    {
        private string _gameServerData;
        private string _gameServerGroupName;
        private string _gameServerId;

        /// <summary>
        /// Gets and sets the property GameServerData. 
        /// <para>
        /// A set of custom game server properties, formatted as a single string value. This data
        /// is passed to a game client or service when it requests information on game servers.
        /// 
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
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A unique identifier for the game server group where the game server is running. If
        /// you are not specifying a game server to claim, this value identifies where you want
        /// GameLift FleetIQ to look for an available game server to claim. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// A custom string that uniquely identifies the game server to claim. If this parameter
        /// is left empty, GameLift FleetIQ searches for an available game server in the specified
        /// game server group.
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

    }
}