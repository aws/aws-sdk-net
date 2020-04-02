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
    /// Container for the parameters to the DeleteGameServerGroup operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Terminates a game server group and permanently deletes the game server group record.
    /// You have several options for how these resources are impacted when deleting the game
    /// server group. Depending on the type of delete action selected, this action may affect
    /// three types of resources: the game server group, the corresponding Auto Scaling group,
    /// and all game servers currently running in the group. 
    /// </para>
    ///  
    /// <para>
    /// To delete a game server group, identify the game server group to delete and specify
    /// the type of delete action to initiate. Game server groups can only be deleted if they
    /// are in ACTIVE or ERROR status.
    /// </para>
    ///  
    /// <para>
    /// If the delete request is successful, a series of actions are kicked off. The game
    /// server group status is changed to DELETE_SCHEDULED, which prevents new game servers
    /// from being registered and stops autoscaling activity. Once all game servers in the
    /// game server group are de-registered, GameLift FleetIQ can begin deleting resources.
    /// If any of the delete actions fail, the game server group is placed in ERROR status.
    /// </para>
    ///  
    /// <para>
    /// GameLift FleetIQ emits delete events to Amazon CloudWatch.
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
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteGameServerGroupRequest : AmazonGameLiftRequest
    {
        private GameServerGroupDeleteOption _deleteOption;
        private string _gameServerGroupName;

        /// <summary>
        /// Gets and sets the property DeleteOption. 
        /// <para>
        /// The type of delete to perform. Options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SAFE_DELETE – Terminates the game server group and EC2 Auto Scaling group only when
        /// it has no game servers that are in IN_USE status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FORCE_DELETE – Terminates the game server group, including all active game servers
        /// regardless of their utilization status, and the EC2 Auto Scaling group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RETAIN – Does a safe delete of the game server group but retains the EC2 Auto Scaling
        /// group as is.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GameServerGroupDeleteOption DeleteOption
        {
            get { return this._deleteOption; }
            set { this._deleteOption = value; }
        }

        // Check to see if DeleteOption property is set
        internal bool IsSetDeleteOption()
        {
            return this._deleteOption != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// The unique identifier of the game server group to delete. Use either the <a>GameServerGroup</a>
        /// name or ARN value.
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

    }
}