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
    /// <b>This data type is used with the GameLift FleetIQ and game server groups.</b> 
    /// 
    ///  
    /// <para>
    /// Properties that describe a game server group resource. A game server group manages
    /// certain properties related to a corresponding Amazon EC2 Auto Scaling group. 
    /// </para>
    ///  
    /// <para>
    /// A game server group is created by a successful call to <code>CreateGameServerGroup</code>
    /// and deleted by calling <code>DeleteGameServerGroup</code>. Game server group activity
    /// can be temporarily suspended and resumed by calling <code>SuspendGameServerGroup</code>
    /// and <code>ResumeGameServerGroup</code>, respectively. 
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
        /// A generated unique ID for the Amazon EC2 Auto Scaling group that is associated with
        /// this game server group.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
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
        /// A developer-defined identifier for the game server group. The name is unique for each
        /// Region in each Amazon Web Services account.
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
        /// early termination. Unprotected instances that have active game servers running might
        /// be terminated during a scale-down event, causing players to be dropped from the game.
        /// Protected instances cannot be terminated while there are active game servers running
        /// except in the event of a forced game server group deletion (see ). An exception to
        /// this is with Spot Instances, which can be terminated by Amazon Web Services regardless
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
        /// The set of Amazon EC2 instance types that GameLift FleetIQ can use when balancing
        /// and automatically scaling instances in the corresponding Auto Scaling group. 
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
        /// A timestamp that indicates when this game server group was last updated.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the game server group. Possible statuses include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEW</code> - GameLift FleetIQ has validated the <code>CreateGameServerGroup()</code>
        /// request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVATING</code> - GameLift FleetIQ is setting up a game server group, which
        /// includes creating an Auto Scaling group in your Amazon Web Services account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVE</code> - The game server group has been successfully created. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_SCHEDULED</code> - A request to delete the game server group has been
        /// received. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - GameLift FleetIQ has received a valid <code>DeleteGameServerGroup()</code>
        /// request and is processing it. GameLift FleetIQ must first complete and release hosts
        /// before it deletes the Auto Scaling group and the game server group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> - The game server group has been successfully deleted. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ERROR</code> - The asynchronous processes of activating or deleting a game
        /// server group has failed, resulting in an error state.
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
        /// might provide additional insight on groups that are in <code>ERROR</code> status.
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