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
    /// Rule that controls how a fleet is scaled. Scaling policies are uniquely identified
    /// by the combination of name and fleet ID.
    /// </summary>
    public partial class ScalingPolicy
    {
        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// Comparison operator to use when measuring a metric against the threshold value.
        /// </para>
        /// </summary>
        public ComparisonOperatorType ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// Length of time (in minutes) the metric must be at or beyond the threshold before a
        /// scaling event is triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? EvaluationPeriods { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationPeriods property is set.
        /// </summary>
        internal bool IsSetEvaluationPeriods() => this.EvaluationPeriods.HasValue;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetArn property is set.
        /// </summary>
        internal bool IsSetFleetArn() => this.FleetArn != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that is associated with this scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The fleet location. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Name of the Amazon GameLift Servers-defined metric that is used to trigger a scaling
        /// adjustment. For detailed descriptions of fleet metrics, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html">Monitor
        /// Amazon GameLift Servers with Amazon CloudWatch</a>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ActivatingGameSessions</b> -- Game sessions in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ActiveGameSessions</b> -- Game sessions that are currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ActiveInstances</b> -- Fleet instances that are currently running at least one
        /// game session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AvailableGameSessions</b> -- Additional game sessions that a fleet could host
        /// simultaneously, given current capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AvailablePlayerSessions</b> -- Empty player slots in currently active game sessions.
        /// This includes game sessions that are not currently accepting players. Reserved player
        /// slots are not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CurrentPlayerSessions</b> -- Player slots in active game sessions that are being
        /// used by a player or are reserved for a player. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IdleInstances</b> -- Active instances that are currently hosting zero game sessions.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PercentAvailableGameSessions</b> -- Unused percentage of the total number of game
        /// sessions that a fleet could host simultaneously, given current capacity. Use this
        /// metric for a target-based scaling policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PercentIdleInstances</b> -- Percentage of the total number of active instances
        /// that are hosting zero game sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>QueueDepth</b> -- Pending game session placement requests, in any queue, where
        /// the current fleet is the top-priority destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WaitTime</b> -- Current wait time for pending game session placement requests,
        /// in any queue, where the current fleet is the top-priority destination. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MetricName MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a fleet's scaling policy. Policy names
        /// do not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of scaling policy to create. For a target-based policy, set the parameter
        /// <i>MetricName</i> to 'PercentAvailableGameSessions' and specify a <i>TargetConfiguration</i>.
        /// For a rule-based policy set the following parameters: <i>MetricName</i>, <i>ComparisonOperator</i>,
        /// <i>Threshold</i>, <i>EvaluationPeriods</i>, <i>ScalingAdjustmentType</i>, and <i>ScalingAdjustment</i>.
        /// </para>
        /// </summary>
        public PolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// Amount of adjustment to make, based on the scaling adjustment type.
        /// </para>
        /// </summary>
        public int? ScalingAdjustment { get; set; }

        /// <summary>
        /// Checks to see if the ScalingAdjustment property is set.
        /// </summary>
        internal bool IsSetScalingAdjustment() => this.ScalingAdjustment.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingAdjustmentType. 
        /// <para>
        /// The type of adjustment to make to a fleet's instance count.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ChangeInCapacity</b> -- add (or subtract) the scaling adjustment value from the
        /// current instance count. Positive values scale up while negative values scale down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ExactCapacity</b> -- set the instance count to the scaling adjustment value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PercentChangeInCapacity</b> -- increase or reduce the current instance count by
        /// the scaling adjustment, read as a percentage. Positive values scale up while negative
        /// values scale down.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScalingAdjustmentType ScalingAdjustmentType { get; set; }

        /// <summary>
        /// Checks to see if the ScalingAdjustmentType property is set.
        /// </summary>
        internal bool IsSetScalingAdjustmentType() => this.ScalingAdjustmentType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the scaling policy. The scaling policy can be in force only when
        /// in an <c>ACTIVE</c> status. Scaling policies can be suspended for individual fleets.
        /// If the policy is suspended for a fleet, the policy status does not change.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- The scaling policy can be used for auto-scaling a fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATE_REQUESTED</b> -- A request to update the scaling policy has been received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATING</b> -- A change is being made to the scaling policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETE_REQUESTED</b> -- A request to delete the scaling policy has been received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETING</b> -- The scaling policy is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETED</b> -- The scaling policy has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR</b> -- An error occurred in creating the policy. It should be removed and
        /// recreated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScalingStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// An object that contains settings for a target-based scaling policy.
        /// </para>
        /// </summary>
        public TargetConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// Metric value used to trigger a scaling event.
        /// </para>
        /// </summary>
        public double? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The current status of the fleet's scaling policies in a requested fleet location.
        /// The status <c>PENDING_UPDATE</c> indicates that an update was requested for the fleet
        /// but has not yet been completed for the location.
        /// </para>
        /// </summary>
        public LocationUpdateStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;
    }
}
