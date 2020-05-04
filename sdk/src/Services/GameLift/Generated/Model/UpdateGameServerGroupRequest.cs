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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGameServerGroup operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Updates GameLift FleetIQ-specific properties for a game server group. These properties
    /// include instance rebalancing and game server protection. Many Auto Scaling group properties
    /// are updated directly. These include autoscaling policies, minimum/maximum/desired
    /// instance counts, and launch template. 
    /// </para>
    ///  
    /// <para>
    /// To update the game server group, specify the game server group ID and provide the
    /// updated values.
    /// </para>
    ///  
    /// <para>
    /// Updated properties are validated to ensure that GameLift FleetIQ can continue to perform
    /// its core instance rebalancing activity. When you change Auto Scaling group properties
    /// directly and the changes cause errors with GameLift FleetIQ activities, an alert is
    /// sent.
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
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-asgroups.html">Updating
    /// a GameLift FleetIQ-Linked Auto Scaling Group</a> 
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
    public partial class UpdateGameServerGroupRequest : AmazonGameLiftRequest
    {
        private BalancingStrategy _balancingStrategy;
        private string _gameServerGroupName;
        private GameServerProtectionPolicy _gameServerProtectionPolicy;
        private List<InstanceDefinition> _instanceDefinitions = new List<InstanceDefinition>();
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BalancingStrategy. 
        /// <para>
        /// The fallback balancing method to use for the game server group when Spot instances
        /// in a Region become unavailable or are not viable for game hosting. Once triggered,
        /// this method remains active until Spot instances can once again be used. Method options
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SPOT_ONLY -- If Spot instances are unavailable, the game server group provides no
        /// hosting capacity. No new instances are started, and the existing nonviable Spot instances
        /// are terminated (once current gameplay ends) and not replaced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SPOT_PREFERRED -- If Spot instances are unavailable, the game server group continues
        /// to provide hosting capacity by using On-Demand instances. Existing nonviable Spot
        /// instances are terminated (once current gameplay ends) and replaced with new On-Demand
        /// instances. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BalancingStrategy BalancingStrategy
        {
            get { return this._balancingStrategy; }
            set { this._balancingStrategy = value; }
        }

        // Check to see if BalancingStrategy property is set
        internal bool IsSetBalancingStrategy()
        {
            return this._balancingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// The unique identifier of the game server group to update. Use either the <a>GameServerGroup</a>
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

        /// <summary>
        /// Gets and sets the property GameServerProtectionPolicy. 
        /// <para>
        /// A flag that indicates whether instances in the game server group are protected from
        /// early termination. Unprotected instances that have active game servers running may
        /// by terminated during a scale-down event, causing players to be dropped from the game.
        /// Protected instances cannot be terminated while there are active game servers running.
        /// An exception to this is Spot Instances, which may be terminated by AWS regardless
        /// of protection status. This property is set to NO_PROTECTION by default.
        /// </para>
        /// </summary>
        public GameServerProtectionPolicy GameServerProtectionPolicy
        {
            get { return this._gameServerProtectionPolicy; }
            set { this._gameServerProtectionPolicy = value; }
        }

        // Check to see if GameServerProtectionPolicy property is set
        internal bool IsSetGameServerProtectionPolicy()
        {
            return this._gameServerProtectionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceDefinitions. 
        /// <para>
        /// An updated list of EC2 instance types to use when creating instances in the group.
        /// The instance definition must specify instance types that are supported by GameLift
        /// FleetIQ, and must include at least two instance types. This updated list replaces
        /// the entire current list of instance definitions for the game server group. For more
        /// information on instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">EC2
        /// Instance Types</a> in the <i>Amazon EC2 User Guide</i>..
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=20)]
        public List<InstanceDefinition> InstanceDefinitions
        {
            get { return this._instanceDefinitions; }
            set { this._instanceDefinitions = value; }
        }

        // Check to see if InstanceDefinitions property is set
        internal bool IsSetInstanceDefinitions()
        {
            return this._instanceDefinitions != null && this._instanceDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// for an IAM role that allows Amazon GameLift to access your EC2 Auto Scaling groups.
        /// The submitted role is validated to ensure that it contains the necessary permissions
        /// for game server groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}