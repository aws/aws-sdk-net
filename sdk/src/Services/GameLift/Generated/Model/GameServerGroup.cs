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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// <b>This data type is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Properties describing a game server group resource. A game server group manages certain
    /// properties of a corresponding EC2 Auto Scaling group. 
    /// </para>
    ///  
    /// <para>
    /// A game server group is created by a successful call to <a>CreateGameServerGroup</a>
    /// and deleted by calling <a>DeleteGameServerGroup</a>. Game server group activity can
    /// be temporarily suspended and resumed by calling <a>SuspendGameServerGroup</a> and
    /// <a>ResumeGameServerGroup</a>. 
    /// </para>
    /// </summary>
    public partial class GameServerGroup
    {
        private string _autoScalingGroupArn;
        private BalancingStrategy _balancingStrategy;
        private DateTime? _creationTime;
        private string _gameServerGroupArn;
        private string _gameServerGroupName;
        private GameServerProtectionPolicy _gameServerProtectionPolicy;
        private List<InstanceDefinition> _instanceDefinitions = new List<InstanceDefinition>();
        private DateTime? _lastUpdatedTime;
        private string _roleArn;
        private GameServerGroupStatus _status;
        private string _statusReason;
        private List<string> _suspendedActions = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoScalingGroupArn. 
        /// <para>
        /// A generated unique ID for the EC2 Auto Scaling group with is associated with this
        /// game server group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AutoScalingGroupArn
        {
            get { return this._autoScalingGroupArn; }
            set { this._autoScalingGroupArn = value; }
        }

        // Check to see if AutoScalingGroupArn property is set
        internal bool IsSetAutoScalingGroupArn()
        {
            return this._autoScalingGroupArn != null;
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example "1469498468.057").
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GameServerGroupArn. 
        /// <para>
        /// A generated unique ID for the game server group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GameServerGroupArn
        {
            get { return this._gameServerGroupArn; }
            set { this._gameServerGroupArn = value; }
        }

        // Check to see if GameServerGroupArn property is set
        internal bool IsSetGameServerGroupArn()
        {
            return this._gameServerGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A developer-defined identifier for the game server group. The name is unique per Region
        /// per AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// be terminated during a scale-down event, causing players to be dropped from the game.
        /// Protected instances cannot be terminated while there are active game servers running
        /// except in the event of a forced game server group deletion (see <a>DeleteGameServerGroup</a>).
        /// An exception to this is Spot Instances, which may be terminated by AWS regardless
        /// of protection status.
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
        /// The set of EC2 instance types that GameLift FleetIQ can use when rebalancing and autoscaling
        /// instances in the group. 
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// A time stamp indicating when this game server group was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the game server group. Possible statuses include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  NEW - GameLift FleetIQ has validated the <code>CreateGameServerGroup()</code> request.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVATING - GameLift FleetIQ is setting up a game server group, which includes creating
        /// an autoscaling group in your AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE - The game server group has been successfully created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_SCHEDULED - A request to delete the game server group has been received. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING - GameLift FleetIQ has received a valid <code>DeleteGameServerGroup()</code>
        /// request and is processing it. GameLift FleetIQ must first complete and release hosts
        /// before it deletes the autoscaling group and the game server group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETED - The game server group has been successfully deleted. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERROR - The asynchronous processes of activating or deleting a game server group has
        /// failed, resulting in an error state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GameServerGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current game server group status. This information
        /// may provide additional insight on groups that in ERROR status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SuspendedActions. 
        /// <para>
        /// A list of activities that are currently suspended for this game server group. If this
        /// property is empty, all activities are occurring.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SuspendedActions
        {
            get { return this._suspendedActions; }
            set { this._suspendedActions = value; }
        }

        // Check to see if SuspendedActions property is set
        internal bool IsSetSuspendedActions()
        {
            return this._suspendedActions != null && this._suspendedActions.Count > 0; 
        }

    }
}