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
    /// Container for the parameters to the ResumeGameServerGroup operation.
    /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Reinstates activity on a game server group after it has been suspended. A game server
    /// group might be suspended by the <a href="gamelift/latest/apireference/API_SuspendGameServerGroup.html">SuspendGameServerGroup</a>
    /// operation, or it might be suspended involuntarily due to a configuration problem.
    /// In the second case, you can manually resume activity on the group once the configuration
    /// problem has been resolved. Refer to the game server group status and status reason
    /// for more information on why group activity is suspended.
    /// </para>
    ///  
    /// <para>
    /// To resume activity, specify a game server group ARN and the type of activity to be
    /// resumed. If successful, a <code>GameServerGroup</code> object is returned showing
    /// that the resumed activity is no longer listed in <code>SuspendedActions</code>. 
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
    public partial class ResumeGameServerGroupRequest : AmazonGameLiftRequest
    {
        private string _gameServerGroupName;
        private List<string> _resumeActions = new List<string>();

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
        /// Gets and sets the property ResumeActions. 
        /// <para>
        /// The activity to resume for this game server group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> ResumeActions
        {
            get { return this._resumeActions; }
            set { this._resumeActions = value; }
        }

        // Check to see if ResumeActions property is set
        internal bool IsSetResumeActions()
        {
            return this._resumeActions != null && this._resumeActions.Count > 0; 
        }

    }
}