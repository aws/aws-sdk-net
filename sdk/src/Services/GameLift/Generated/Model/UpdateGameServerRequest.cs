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
    /// Container for the parameters to the UpdateGameServer operation.
    /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Updates information about a registered game server to help GameLift FleetIQ to track
    /// game server availability. This operation is called by a game server process that is
    /// running on an instance in a game server group. 
    /// </para>
    ///  
    /// <para>
    /// Use this operation to update the following types of game server information. You can
    /// make all three types of updates in the same request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To update the game server's utilization status, identify the game server and game
    /// server group and specify the current utilization status. Use this status to identify
    /// when game servers are currently hosting games and when they are available to be claimed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To report health status, identify the game server and game server group and set health
    /// check to <code>HEALTHY</code>. If a game server does not report health status for
    /// a certain length of time, the game server is no longer considered healthy. As a result,
    /// it will be eventually deregistered from the game server group to avoid affecting utilization
    /// metrics. The best practice is to report health every 60 seconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To change game server metadata, provide updated game server data.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Once a game server is successfully updated, the relevant statuses and timestamps are
    /// updated.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a> 
    /// </para>
    /// </summary>
    public partial class UpdateGameServerRequest : AmazonGameLiftRequest
    {
        private string _gameServerData;
        private string _gameServerGroupName;
        private string _gameServerId;
        private GameServerHealthCheck _healthCheck;
        private GameServerUtilizationStatus _utilizationStatus;

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
        /// A unique identifier for the game server group where the game server is running.
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
        /// A custom string that uniquely identifies the game server to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// Indicates health status of the game server. A request that includes this parameter
        /// updates the game server's <i>LastHealthCheckTime</i> timestamp. 
        /// </para>
        /// </summary>
        public GameServerHealthCheck HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property UtilizationStatus. 
        /// <para>
        /// Indicates whether the game server is available or is currently hosting gameplay.
        /// </para>
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