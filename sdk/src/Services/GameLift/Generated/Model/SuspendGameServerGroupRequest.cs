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
    /// Container for the parameters to the SuspendGameServerGroup operation.
    /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Temporarily stops activity on a game server group without terminating instances or
    /// the game server group. You can restart activity by calling <a href="gamelift/latest/apireference/API_ResumeGameServerGroup.html">ResumeGameServerGroup</a>.
    /// You can suspend the following activity:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Instance type replacement</b> - This activity evaluates the current game hosting
    /// viability of all Spot instance types that are defined for the game server group. It
    /// updates the Auto Scaling group to remove nonviable Spot Instance types, which have
    /// a higher chance of game server interruptions. It then balances capacity across the
    /// remaining viable Spot Instance types. When this activity is suspended, the Auto Scaling
    /// group continues with its current balance, regardless of viability. Instance protection,
    /// utilization metrics, and capacity scaling activities continue to be active. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To suspend activity, specify a game server group ARN and the type of activity to be
    /// suspended. If successful, a <code>GameServerGroup</code> object is returned showing
    /// that the activity is listed in <code>SuspendedActions</code>.
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
    public partial class SuspendGameServerGroupRequest : AmazonGameLiftRequest
    {
        private string _gameServerGroupName;
        private List<string> _suspendActions = new List<string>();

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A unique identifier for the game server group. Use either the name or ARN value.
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
        /// The activity to suspend for this game server group.
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