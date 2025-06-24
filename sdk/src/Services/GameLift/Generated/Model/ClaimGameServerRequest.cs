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
    /// Container for the parameters to the ClaimGameServer operation.
    /// <b>This operation is used with the Amazon GameLift Servers FleetIQ solution and game
    /// server groups.</b> 
    /// 
    ///  
    /// <para>
    /// Locates an available game server and temporarily reserves it to host gameplay and
    /// players. This operation is called from a game client or client service (such as a
    /// matchmaker) to request hosting resources for a new game session. In response, Amazon
    /// GameLift Servers FleetIQ locates an available game server, places it in <c>CLAIMED</c>
    /// status for 60 seconds, and returns connection information that players can use to
    /// connect to the game server. 
    /// </para>
    ///  
    /// <para>
    /// To claim a game server, identify a game server group. You can also specify a game
    /// server ID, although this approach bypasses Amazon GameLift Servers FleetIQ placement
    /// optimization. Optionally, include game data to pass to the game server at the start
    /// of a game session, such as a game map or player information. Add filter options to
    /// further restrict how a game server is chosen, such as only allowing game servers on
    /// <c>ACTIVE</c> instances to be claimed.
    /// </para>
    ///  
    /// <para>
    /// When a game server is successfully claimed, connection information is returned. A
    /// claimed game server's utilization status remains <c>AVAILABLE</c> while the claim
    /// status is set to <c>CLAIMED</c> for up to 60 seconds. This time period gives the game
    /// server time to update its status to <c>UTILIZED</c> after players join. If the game
    /// server's status is not updated within 60 seconds, the game server reverts to unclaimed
    /// status and is available to be claimed by another request. The claim time period is
    /// a fixed value and is not configurable.
    /// </para>
    ///  
    /// <para>
    /// If you try to claim a specific game server, this request will fail in the following
    /// cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the game server utilization status is <c>UTILIZED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the game server claim status is <c>CLAIMED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the game server is running on an instance in <c>DRAINING</c> status and the provided
    /// filter option does not allow placing on <c>DRAINING</c> instances.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
    /// GameLift Servers FleetIQ Guide</a> 
    /// </para>
    /// </summary>
    public partial class ClaimGameServerRequest : AmazonGameLiftRequest
    {
        private ClaimFilterOption _filterOption;
        private string _gameServerData;
        private string _gameServerGroupName;
        private string _gameServerId;

        /// <summary>
        /// Gets and sets the property FilterOption. 
        /// <para>
        /// Object that restricts how a claimed game server is chosen.
        /// </para>
        /// </summary>
        public ClaimFilterOption FilterOption
        {
            get { return this._filterOption; }
            set { this._filterOption = value; }
        }

        // Check to see if FilterOption property is set
        internal bool IsSetFilterOption()
        {
            return this._filterOption != null;
        }

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
        /// Amazon GameLift Servers FleetIQ to look for an available game server to claim. 
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
        /// is left empty, Amazon GameLift Servers FleetIQ searches for an available game server
        /// in the specified game server group.
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