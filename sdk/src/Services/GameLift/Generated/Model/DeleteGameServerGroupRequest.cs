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
    /// Container for the parameters to the DeleteGameServerGroup operation.
    /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Terminates a game server group and permanently deletes the game server group record.
    /// You have several options for how these resources are impacted when deleting the game
    /// server group. Depending on the type of delete operation selected, this operation might
    /// affect these resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The game server group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The corresponding Auto Scaling group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All game servers that are currently running in the group
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To delete a game server group, identify the game server group to delete and specify
    /// the type of delete operation to initiate. Game server groups can only be deleted if
    /// they are in <code>ACTIVE</code> or <code>ERROR</code> status.
    /// </para>
    ///  
    /// <para>
    /// If the delete request is successful, a series of operations are kicked off. The game
    /// server group status is changed to <code>DELETE_SCHEDULED</code>, which prevents new
    /// game servers from being registered and stops automatic scaling activity. Once all
    /// game servers in the game server group are deregistered, GameLift FleetIQ can begin
    /// deleting resources. If any of the delete operations fail, the game server group is
    /// placed in <code>ERROR</code> status.
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
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a> 
    /// </para>
    /// </summary>
    public partial class DeleteGameServerGroupRequest : AmazonGameLiftRequest
    {
        private GameServerGroupDeleteOption _deleteOption;
        private string _gameServerGroupName;

        /// <summary>
        /// Gets and sets the property DeleteOption. 
        /// <para>
        /// The type of delete to perform. Options include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SAFE_DELETE</code> – (default) Terminates the game server group and Amazon
        /// EC2 Auto Scaling group only when it has no game servers that are in <code>UTILIZED</code>
        /// status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FORCE_DELETE</code> – Terminates the game server group, including all active
        /// game servers regardless of their utilization status, and the Amazon EC2 Auto Scaling
        /// group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RETAIN</code> – Does a safe delete of the game server group but retains the
        /// Amazon EC2 Auto Scaling group as is.
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

    }
}