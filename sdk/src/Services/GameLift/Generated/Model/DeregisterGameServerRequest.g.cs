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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeregisterGameServer operation. <b>This API works
    /// with the following fleet types:</b> EC2 (FleetIQ) <para> Removes the game server from
    /// a game server group. As a result of this operation, the deregistered game server can
    /// no longer be claimed and will not be returned in a list of active game servers. </para>
    /// <para> To deregister a game server, specify the game server group and game server
    /// ID. If successful, this operation emits a CloudWatch event with termination timestamp
    /// and reason. </para> <para> <b>Learn more</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
    /// GameLift Servers FleetIQ Guide</a> </para>
    /// </summary>
    public partial class DeregisterGameServerRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A unique identifier for the game server group where the game server is running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string GameServerGroupName { get; set; }

        /// <summary>
        /// Checks to see if the GameServerGroupName property is set.
        /// </summary>
        internal bool IsSetGameServerGroupName() => this.GameServerGroupName != null;

        /// <summary>
        /// Gets and sets the property GameServerId. 
        /// <para>
        /// A custom string that uniquely identifies the game server to deregister.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 128)]
        public string GameServerId { get; set; }

        /// <summary>
        /// Checks to see if the GameServerId property is set.
        /// </summary>
        internal bool IsSetGameServerId() => this.GameServerId != null;
    }
}
