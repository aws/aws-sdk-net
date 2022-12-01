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
    /// Container for the parameters to the UpdateGameServerGroup operation.
    /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Updates GameLift FleetIQ-specific properties for a game server group. Many Auto Scaling
    /// group properties are updated on the Auto Scaling group directly, including the launch
    /// template, Auto Scaling policies, and maximum/minimum/desired instance counts.
    /// </para>
    ///  
    /// <para>
    /// To update the game server group, specify the game server group ID and provide the
    /// updated values. Before applying the updates, the new values are validated to ensure
    /// that GameLift FleetIQ can continue to perform instance balancing activity. If successful,
    /// a <code>GameServerGroup</code> object is returned.
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
        /// Indicates how GameLift FleetIQ balances the use of Spot Instances and On-Demand Instances
        /// in the game server group. Method options include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SPOT_ONLY</code> - Only Spot Instances are used in the game server group. If
        /// Spot Instances are unavailable or not viable for game hosting, the game server group
        /// provides no hosting capacity until Spot Instances can again be used. Until then, no
        /// new instances are started, and the existing nonviable Spot Instances are terminated
        /// (after current gameplay ends) and are not replaced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SPOT_PREFERRED</code> - (default value) Spot Instances are used whenever available
        /// in the game server group. If Spot Instances are unavailable, the game server group
        /// continues to provide hosting capacity by falling back to On-Demand Instances. Existing
        /// nonviable Spot Instances are terminated (after current gameplay ends) and are replaced
        /// with new On-Demand Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ON_DEMAND_ONLY</code> - Only On-Demand Instances are used in the game server
        /// group. No Spot Instances are used, even when available, while this balancing strategy
        /// is in force.
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
        /// Gets and sets the property GameServerProtectionPolicy. 
        /// <para>
        /// A flag that indicates whether instances in the game server group are protected from
        /// early termination. Unprotected instances that have active game servers running might
        /// be terminated during a scale-down event, causing players to be dropped from the game.
        /// Protected instances cannot be terminated while there are active game servers running
        /// except in the event of a forced game server group deletion (see ). An exception to
        /// this is with Spot Instances, which can be terminated by Amazon Web Services regardless
        /// of protection status. This property is set to <code>NO_PROTECTION</code> by default.
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
        /// An updated list of Amazon EC2 instance types to use in the Auto Scaling group. The
        /// instance definitions must specify at least two different instance types that are supported
        /// by GameLift FleetIQ. This updated list replaces the entire current list of instance
        /// definitions for the game server group. For more information on instance types, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">EC2
        /// Instance Types</a> in the <i>Amazon EC2 User Guide</i>. You can optionally specify
        /// capacity weighting for each instance type. If no weight value is specified for an
        /// instance type, it is set to the default value "1". For more information about capacity
        /// weighting, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-weighting.html">
        /// Instance Weighting for Amazon EC2 Auto Scaling</a> in the Amazon EC2 Auto Scaling
        /// User Guide.
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
        /// for an IAM role that allows Amazon GameLift to access your Amazon EC2 Auto Scaling
        /// groups.
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