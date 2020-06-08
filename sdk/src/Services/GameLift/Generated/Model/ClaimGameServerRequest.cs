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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ClaimGameServer operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Locates an available game server and temporarily reserves it to host gameplay and
    /// players. This action is called by a game client or client service (such as a matchmaker)
    /// to request hosting resources for a new game session. In response, GameLift FleetIQ
    /// searches for an available game server in the specified game server group, places the
    /// game server in "claimed" status for 60 seconds, and returns connection information
    /// back to the requester so that players can connect to the game server. 
    /// </para>
    ///  
    /// <para>
    /// There are two ways you can claim a game server. For the first option, you provide
    /// a game server group ID only, which prompts GameLift FleetIQ to search for an available
    /// game server in the specified group and claim it. With this option, GameLift FleetIQ
    /// attempts to consolidate gameplay on as few instances as possible to minimize hosting
    /// costs. For the second option, you request a specific game server by its ID. This option
    /// results in a less efficient claiming process because it does not take advantage of
    /// consolidation and may fail if the requested game server is unavailable. 
    /// </para>
    ///  
    /// <para>
    /// To claim a game server, identify a game server group and (optionally) a game server
    /// ID. If your game requires that game data be provided to the game server at the start
    /// of a game, such as a game map or player information, you can provide it in your claim
    /// request. 
    /// </para>
    ///  
    /// <para>
    /// When a game server is successfully claimed, connection information is returned. A
    /// claimed game server's utilization status remains AVAILABLE, while the claim status
    /// is set to CLAIMED for up to 60 seconds. This time period allows the game server to
    /// be prompted to update its status to UTILIZED (using <a>UpdateGameServer</a>). If the
    /// game server's status is not updated within 60 seconds, the game server reverts to
    /// unclaimed status and is available to be claimed by another request.
    /// </para>
    ///  
    /// <para>
    /// If you try to claim a specific game server, this request will fail in the following
    /// cases: (1) if the game server utilization status is UTILIZED, (2) if the game server
    /// claim status is CLAIMED, or (3) if the instance that the game server is running on
    /// is flagged as draining.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>RegisterGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGameServers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ClaimGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeregisterGameServer</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ClaimGameServerRequest : AmazonGameLiftRequest
    {
        private string _gameServerData;
        private string _gameServerGroupName;
        private string _gameServerId;

        /// <summary>
        /// Gets and sets the property GameServerData. 
        /// <para>
        /// A set of custom game server properties, formatted as a single string value, to be
        /// passed to the claimed game server. 
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
        /// An identifier for the game server group. When claiming a specific game server, this
        /// is the game server group whether the game server is located. When requesting that
        /// GameLift FleetIQ locate an available game server, this is the game server group to
        /// search on. You can use either the <a>GameServerGroup</a> name or ARN value.
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