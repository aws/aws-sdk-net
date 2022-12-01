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
    /// Container for the parameters to the CreateGameServerGroup operation.
    /// <b>This operation is used with the GameLift FleetIQ solution and game server groups.</b>
    /// 
    /// 
    ///  
    /// <para>
    /// Creates a GameLift FleetIQ game server group for managing game hosting on a collection
    /// of Amazon Elastic Compute Cloud instances for game hosting. This operation creates
    /// the game server group, creates an Auto Scaling group in your Amazon Web Services account,
    /// and establishes a link between the two groups. You can view the status of your game
    /// server groups in the GameLift console. Game server group metrics and events are emitted
    /// to Amazon CloudWatch.
    /// </para>
    ///  
    /// <para>
    /// Before creating a new game server group, you must have the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An Amazon Elastic Compute Cloud launch template that specifies how to launch Amazon
    /// Elastic Compute Cloud instances with your game server build. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">
    /// Launching an Instance from a Launch Template</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An IAM role that extends limited access to your Amazon Web Services account to allow
    /// GameLift FleetIQ to create and interact with the Auto Scaling group. For more information,
    /// see <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-iam-permissions-roles.html">Create
    /// IAM roles for cross-service interaction</a> in the <i>GameLift FleetIQ Developer Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To create a new game server group, specify a unique group name, IAM role and Amazon
    /// Elastic Compute Cloud launch template, and provide a list of instance types that can
    /// be used in the group. You must also set initial maximum and minimum limits on the
    /// group's instance count. You can optionally set an Auto Scaling policy with target
    /// tracking based on a GameLift FleetIQ metric.
    /// </para>
    ///  
    /// <para>
    /// Once the game server group and corresponding Auto Scaling group are created, you have
    /// full access to change the Auto Scaling group's configuration as needed. Several properties
    /// that are set when creating a game server group, including maximum/minimum size and
    /// auto-scaling policy settings, must be updated directly in the Auto Scaling group.
    /// Keep in mind that some Auto Scaling group properties are periodically updated by GameLift
    /// FleetIQ as part of its balancing activities to optimize for availability and cost.
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
    public partial class CreateGameServerGroupRequest : AmazonGameLiftRequest
    {
        private GameServerGroupAutoScalingPolicy _autoScalingPolicy;
        private BalancingStrategy _balancingStrategy;
        private string _gameServerGroupName;
        private GameServerProtectionPolicy _gameServerProtectionPolicy;
        private List<InstanceDefinition> _instanceDefinitions = new List<InstanceDefinition>();
        private LaunchTemplateSpecification _launchTemplate;
        private int? _maxSize;
        private int? _minSize;
        private string _roleArn;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _vpcSubnets = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoScalingPolicy. 
        /// <para>
        /// Configuration settings to define a scaling policy for the Auto Scaling group that
        /// is optimized for game hosting. The scaling policy uses the metric <code>"PercentUtilizedGameServers"</code>
        /// to maintain a buffer of idle game servers that can immediately accommodate new games
        /// and players. After the Auto Scaling group is created, update this value directly in
        /// the Auto Scaling group using the Amazon Web Services console or APIs.
        /// </para>
        /// </summary>
        public GameServerGroupAutoScalingPolicy AutoScalingPolicy
        {
            get { return this._autoScalingPolicy; }
            set { this._autoScalingPolicy = value; }
        }

        // Check to see if AutoScalingPolicy property is set
        internal bool IsSetAutoScalingPolicy()
        {
            return this._autoScalingPolicy != null;
        }

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
        /// An identifier for the new game server group. This value is used to generate unique
        /// ARN identifiers for the Amazon EC2 Auto Scaling group and the GameLift FleetIQ game
        /// server group. The name must be unique per Region per Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The Amazon EC2 instance types and sizes to use in the Auto Scaling group. The instance
        /// definitions must specify at least two different instance types that are supported
        /// by GameLift FleetIQ. For more information on instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">EC2
        /// Instance Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. You can
        /// optionally specify capacity weighting for each instance type. If no weight value is
        /// specified for an instance type, it is set to the default value "1". For more information
        /// about capacity weighting, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-weighting.html">
        /// Instance Weighting for Amazon EC2 Auto Scaling</a> in the Amazon EC2 Auto Scaling
        /// User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=20)]
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
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The Amazon EC2 launch template that contains configuration settings and game server
        /// code to be deployed to all instances in the game server group. You can specify the
        /// template using either the template name or ID. For help with creating a launch template,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-template.html">Creating
        /// a Launch Template for an Auto Scaling Group</a> in the <i>Amazon Elastic Compute Cloud
        /// Auto Scaling User Guide</i>. After the Auto Scaling group is created, update this
        /// value directly in the Auto Scaling group using the Amazon Web Services console or
        /// APIs.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify network interfaces in your launch template, you must explicitly set
        /// the property <code>AssociatePublicIpAddress</code> to "true". If no network interface
        /// is specified in the launch template, GameLift FleetIQ uses your account's default
        /// VPC.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum number of instances allowed in the Amazon EC2 Auto Scaling group. During
        /// automatic scaling events, GameLift FleetIQ and EC2 do not scale up the group above
        /// this maximum. After the Auto Scaling group is created, update this value directly
        /// in the Auto Scaling group using the Amazon Web Services console or APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of instances allowed in the Amazon EC2 Auto Scaling group. During
        /// automatic scaling events, GameLift FleetIQ and Amazon EC2 do not scale down the group
        /// below this minimum. In production, this value should be set to at least 1. After the
        /// Auto Scaling group is created, update this value directly in the Auto Scaling group
        /// using the Amazon Web Services console or APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// for an IAM role that allows Amazon GameLift to access your Amazon EC2 Auto Scaling
        /// groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new game server group resource. Tags are developer-defined
        /// key-value pairs. Tagging Amazon Web Services resources is useful for resource management,
        /// access management, and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcSubnets. 
        /// <para>
        /// A list of virtual private cloud (VPC) subnets to use with instances in the game server
        /// group. By default, all GameLift FleetIQ-supported Availability Zones are used. You
        /// can use this parameter to specify VPCs that you've set up. This property cannot be
        /// updated after the game server group is created, and the corresponding Auto Scaling
        /// group will always use the property value that is set with this request, even if the
        /// Auto Scaling group is updated directly.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> VpcSubnets
        {
            get { return this._vpcSubnets; }
            set { this._vpcSubnets = value; }
        }

        // Check to see if VpcSubnets property is set
        internal bool IsSetVpcSubnets()
        {
            return this._vpcSubnets != null && this._vpcSubnets.Count > 0; 
        }

    }
}