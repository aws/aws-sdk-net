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
    /// This is the response object from the CreateGameServerGroup operation.
    /// </summary>
    public partial class CreateGameServerGroupResponse : AmazonWebServiceResponse
    {
        private GameServerGroup _gameServerGroup;

        /// <summary>
        /// Gets and sets the property GameServerGroup. 
        /// <para>
        /// The newly created game server group object, including the new ARN value for the Amazon
        /// GameLift Servers FleetIQ game server group and the object's status. The Amazon EC2
        /// Auto Scaling group ARN is initially null, since the group has not yet been created.
        /// This value is added once the game server group status reaches <c>ACTIVE</c>. 
        /// </para>
        /// </summary>
        public GameServerGroup GameServerGroup
        {
            get { return this._gameServerGroup; }
            set { this._gameServerGroup = value; }
        }

        // Check to see if GameServerGroup property is set
        internal bool IsSetGameServerGroup()
        {
            return this._gameServerGroup != null;
        }

    }
}