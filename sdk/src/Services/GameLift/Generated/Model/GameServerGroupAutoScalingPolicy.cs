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
    /// Configuration settings for intelligent autoscaling that uses target tracking. An autoscaling
    /// policy can be specified when a new game server group is created with <a>CreateGameServerGroup</a>.
    /// If a group has an autoscaling policy, the Auto Scaling group takes action based on
    /// this policy, in addition to (and potentially in conflict with) any other autoscaling
    /// policies that are separately applied to the Auto Scaling group. 
    /// </para>
    /// </summary>
    public partial class GameServerGroupAutoScalingPolicy
    {
        private int? _estimatedInstanceWarmup;
        private TargetTrackingConfiguration _targetTrackingConfiguration;

        /// <summary>
        /// Gets and sets the property EstimatedInstanceWarmup. 
        /// <para>
        /// Length of time, in seconds, it takes for a new instance to start new game server processes
        /// and register with GameLift FleetIQ. Specifying a warm-up time can be useful, particularly
        /// with game servers that take a long time to start up, because it avoids prematurely
        /// starting new instances 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int EstimatedInstanceWarmup
        {
            get { return this._estimatedInstanceWarmup.GetValueOrDefault(); }
            set { this._estimatedInstanceWarmup = value; }
        }

        // Check to see if EstimatedInstanceWarmup property is set
        internal bool IsSetEstimatedInstanceWarmup()
        {
            return this._estimatedInstanceWarmup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetTrackingConfiguration. 
        /// <para>
        /// Settings for a target-based scaling policy applied to Auto Scaling group. These settings
        /// are used to create a target-based policy that tracks the GameLift FleetIQ metric "PercentUtilizedGameServers"
        /// and specifies a target value for the metric. As player usage changes, the policy triggers
        /// to adjust the game server group capacity so that the metric returns to the target
        /// value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetTrackingConfiguration TargetTrackingConfiguration
        {
            get { return this._targetTrackingConfiguration; }
            set { this._targetTrackingConfiguration = value; }
        }

        // Check to see if TargetTrackingConfiguration property is set
        internal bool IsSetTargetTrackingConfiguration()
        {
            return this._targetTrackingConfiguration != null;
        }

    }
}