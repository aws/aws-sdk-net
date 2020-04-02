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
    /// Container for the parameters to the SuspendGameServerGroup operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Temporarily stops activity on a game server group without terminating instances or
    /// the game server group. Activity can be restarted by calling <a>ResumeGameServerGroup</a>.
    /// Activities that can suspended are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Instance type replacement. This activity evaluates the current Spot viability of all
    /// instance types that are defined for the game server group. It updates the Auto Scaling
    /// group to remove nonviable Spot instance types (which have a higher chance of game
    /// server interruptions) and rebalances capacity across the remaining viable Spot instance
    /// types. When this activity is suspended, the Auto Scaling group continues with its
    /// current balance, regardless of viability. Instance protection, utilization metrics,
    /// and capacity autoscaling activities continue to be active. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To suspend activity, specify a game server group ARN and the type of activity to be
    /// suspended.
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
    public partial class SuspendGameServerGroupRequest : AmazonGameLiftRequest
    {
        private string _gameServerGroupName;
        private List<string> _suspendActions = new List<string>();

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// The unique identifier of the game server group to stop activity on. Use either the
        /// <a>GameServerGroup</a> name or ARN value.
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
        /// Gets and sets the property SuspendActions. 
        /// <para>
        /// The action to suspend for this game server group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> SuspendActions
        {
            get { return this._suspendActions; }
            set { this._suspendActions = value; }
        }

        // Check to see if SuspendActions property is set
        internal bool IsSetSuspendActions()
        {
            return this._suspendActions != null && this._suspendActions.Count > 0; 
        }

    }
}