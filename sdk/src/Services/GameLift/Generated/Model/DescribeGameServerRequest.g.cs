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
    /// Container for the parameters to the DescribeGameServer operation. <b>This API works
    /// with the following fleet types:</b> EC2 (FleetIQ) <para> Retrieves information for
    /// a registered game server. Information includes game server status, health check info,
    /// and the instance that the game server is running on. </para> <para> To retrieve game
    /// server information, specify the game server ID. If successful, the requested game
    /// server object is returned. </para> <para> <b>Learn more</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
    /// GameLift Servers FleetIQ Guide</a> </para>
    /// </summary>
    public partial class DescribeGameServerRequest : AmazonGameLiftRequest
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
        /// A custom string that uniquely identifies the game server information to be retrieved.
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
