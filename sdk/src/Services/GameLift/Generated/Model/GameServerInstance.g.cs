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
    /// Additional properties, including status, that describe an EC2 instance in a game
    /// server group. Instance configurations are set with game server group properties (see
    /// <c>DescribeGameServerGroup</c>) and with the EC2 launch template that was used when
    /// creating the game server group. 
    /// 
    ///  
    /// <para>
    /// Retrieve game server instances for a game server group by calling <c>DescribeGameServerInstances</c>.
    /// 
    /// </para>
    /// </summary>
    public partial class GameServerInstance
    {
        /// <summary>
        /// Gets and sets the property GameServerGroupArn. 
        /// <para>
        /// A generated unique identifier for the game server group that includes the game server
        /// instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string GameServerGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the GameServerGroupArn property is set.
        /// </summary>
        internal bool IsSetGameServerGroupArn() => this.GameServerGroupArn != null;

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A developer-defined identifier for the game server group that includes the game server
        /// instance. The name is unique for each Region in each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GameServerGroupName { get; set; }

        /// <summary>
        /// Checks to see if the GameServerGroupName property is set.
        /// </summary>
        internal bool IsSetGameServerGroupName() => this.GameServerGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the instance where the game server is running. This ID is
        /// available in the instance metadata. EC2 instance IDs use a 17-character format, for
        /// example: <c>i-1234567890abcdef0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// Current status of the game server instance
        /// </para>
        /// </summary>
        public GameServerInstanceStatus InstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the InstanceStatus property is set.
        /// </summary>
        internal bool IsSetInstanceStatus() => this.InstanceStatus != null;
    }
}
