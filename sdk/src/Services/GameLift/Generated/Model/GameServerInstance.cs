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
    /// <b>This data type is used with the Amazon GameLift FleetIQ and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    ///  Additional properties, including status, that describe an EC2 instance in a game
    /// server group. Instance configurations are set with game server group properties (see
    /// <code>DescribeGameServerGroup</code> and with the EC2 launch template that was used
    /// when creating the game server group. 
    /// </para>
    ///  
    /// <para>
    /// Retrieve game server instances for a game server group by calling <code>DescribeGameServerInstances</code>.
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateGameServerGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGameServerGroups</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameServerGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameServerGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteGameServerGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ResumeGameServerGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>SuspendGameServerGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameServerInstances</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GameServerInstance
    {
        private string _gameServerGroupArn;
        private string _gameServerGroupName;
        private string _instanceId;
        private GameServerInstanceStatus _instanceStatus;

        /// <summary>
        /// Gets and sets the property GameServerGroupArn. 
        /// <para>
        /// A generated unique identifier for the game server group that includes the game server
        /// instance. 
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
        /// A developer-defined identifier for the game server group that includes the game server
        /// instance. The name is unique for each Region in each AWS account.
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
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        ///  Current status of the game server instance. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- The instance is viable for hosting game servers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DRAINING</b> -- The instance is not viable for hosting game servers. Existing
        /// game servers are in the process of ending, and new game servers are not started on
        /// this instance unless no other resources are available. When the instance is put in
        /// DRAINING, a new instance is started up to replace it. Once the instance has no UTILIZED
        /// game servers, it will be terminated in favor of the new instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SPOT_TERMINATING</b> -- The instance is in the process of shutting down due to
        /// a Spot instance interruption. No new game servers are started on this instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GameServerInstanceStatus InstanceStatus
        {
            get { return this._instanceStatus; }
            set { this._instanceStatus = value; }
        }

        // Check to see if InstanceStatus property is set
        internal bool IsSetInstanceStatus()
        {
            return this._instanceStatus != null;
        }

    }
}