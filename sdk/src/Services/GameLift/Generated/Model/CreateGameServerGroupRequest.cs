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
    /// Container for the parameters to the CreateGameServerGroup operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Creates a GameLift FleetIQ game server group to manage a collection of EC2 instances
    /// for game hosting. In addition to creating the game server group, this action also
    /// creates an Auto Scaling group in your AWS account and establishes a link between the
    /// two groups. You have full control over configuration of the Auto Scaling group, but
    /// GameLift FleetIQ routinely certain Auto Scaling group properties in order to optimize
    /// the group's instances for low-cost game hosting. You can view the status of your game
    /// server groups in the GameLift Console. Game server group metrics and events are emitted
    /// to Amazon CloudWatch.
    /// </para>
    ///  
    /// <para>
    /// Prior creating a new game server group, you must set up the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An EC2 launch template. The template provides configuration settings for a set of
    /// EC2 instances and includes the game server build that you want to deploy and run on
    /// each instance. For more information on creating a launch template, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">
    /// Launching an Instance from a Launch Template</a> in the <i>Amazon EC2 User Guide</i>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An IAM role. The role sets up limited access to your AWS account, allowing GameLift
    /// FleetIQ to create and manage the EC2 Auto Scaling group, get instance data, and emit
    /// metrics and events to CloudWatch. For more information on setting up an IAM permissions
    /// policy with principal access for GameLift, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-bucket-user-policy-specifying-principal-intro.html">
    /// Specifying a Principal in a Policy</a> in the <i>Amazon S3 Developer Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To create a new game server group, provide a name and specify the IAM role and EC2
    /// launch template. You also need to provide a list of instance types to be used in the
    /// group and set initial maximum and minimum limits on the group's instance count. You
    /// can optionally set an autoscaling policy with target tracking based on a GameLift
    /// FleetIQ metric.
    /// </para>
    ///  
    /// <para>
    /// Once the game server group and corresponding Auto Scaling group are created, you have
    /// full access to change the Auto Scaling group's configuration as needed. Keep in mind,
    /// however, that some properties are periodically updated by GameLift FleetIQ as it balances
    /// the group's instances based on availability and cost.
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
        /// is optimized for game hosting. The scaling policy uses the metric "PercentUtilizedGameServers"
        /// to maintain a buffer of idle game servers that can immediately accommodate new games
        /// and players. Once the game server and Auto Scaling groups are created, you can update
        /// the scaling policy settings directly in Auto Scaling Groups.
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
        /// An identifier for the new game server group. This value is used to generate unique
        /// ARN identifiers for the EC2 Auto Scaling group and the GameLift FleetIQ game server
        /// group. The name must be unique per Region per AWS account.
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
        /// A set of EC2 instance types to use when creating instances in the group. The instance
        /// definitions must specify at least two different instance types that are supported
        /// by GameLift FleetIQ. For more information on instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">EC2
        /// Instance Types</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// The EC2 launch template that contains configuration settings and game server code
        /// to be deployed to all instances in the game server group. You can specify the template
        /// using either the template name or ID. For help with creating a launch template, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-template.html">Creating
        /// a Launch Template for an Auto Scaling Group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
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
        /// The maximum number of instances allowed in the EC2 Auto Scaling group. During autoscaling
        /// events, GameLift FleetIQ and EC2 do not scale up the group above this maximum.
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
        /// The minimum number of instances allowed in the EC2 Auto Scaling group. During autoscaling
        /// events, GameLift FleetIQ and EC2 do not scale down the group below this minimum. In
        /// production, this value should be set to at least 1.
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
        /// for an IAM role that allows Amazon GameLift to access your EC2 Auto Scaling groups.
        /// The submitted role is validated to ensure that it contains the necessary permissions
        /// for game server groups.
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
        /// key-value pairs. Tagging AWS resources are useful for resource management, access
        /// management, and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging AWS Resources</a> in the <i>AWS General Reference</i>. Once the resource is
        /// created, you can use <a>TagResource</a>, <a>UntagResource</a>, and <a>ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the AWS General Reference for actual tagging limits.
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
        /// group. By default, all GameLift FleetIQ-supported availability zones are used; this
        /// parameter allows you to specify VPCs that you've set up. 
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