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
    /// Container for the parameters to the PutScalingPolicy operation.
    /// Creates or updates a scaling policy for a fleet. Scaling policies are used to automatically
    /// scale a fleet's hosting capacity to meet player demand. An active scaling policy instructs
    /// Amazon GameLift to track a fleet metric and automatically change the fleet's capacity
    /// when a certain threshold is reached. There are two types of scaling policies: target-based
    /// and rule-based. Use a target-based policy to quickly and efficiently manage fleet
    /// scaling; this option is the most commonly used. Use rule-based policies when you need
    /// to exert fine-grained control over auto-scaling. 
    /// 
    ///  
    /// <para>
    /// Fleets can have multiple scaling policies of each type in force at the same time;
    /// you can have one target-based policy, one or multiple rule-based scaling policies,
    /// or both. We recommend caution, however, because multiple auto-scaling policies can
    /// have unintended consequences.
    /// </para>
    ///  
    /// <para>
    /// Learn more about how to work with auto-scaling in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-autoscaling.html">Set
    /// Up Fleet Automatic Scaling</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Target-based policy</b> 
    /// </para>
    ///  
    /// <para>
    /// A target-based policy tracks a single metric: PercentAvailableGameSessions. This metric
    /// tells us how much of a fleet's hosting capacity is ready to host game sessions but
    /// is not currently in use. This is the fleet's buffer; it measures the additional player
    /// demand that the fleet could handle at current capacity. With a target-based policy,
    /// you set your ideal buffer size and leave it to Amazon GameLift to take whatever action
    /// is needed to maintain that target. 
    /// </para>
    ///  
    /// <para>
    /// For example, you might choose to maintain a 10% buffer for a fleet that has the capacity
    /// to host 100 simultaneous game sessions. This policy tells Amazon GameLift to take
    /// action whenever the fleet's available capacity falls below or rises above 10 game
    /// sessions. Amazon GameLift will start new instances or stop unused instances in order
    /// to return to the 10% buffer. 
    /// </para>
    ///  
    /// <para>
    /// To create or update a target-based policy, specify a fleet ID and name, and set the
    /// policy type to "TargetBased". Specify the metric to track (PercentAvailableGameSessions)
    /// and reference a <code>TargetConfiguration</code> object with your desired buffer value.
    /// Exclude all other parameters. On a successful request, the policy name is returned.
    /// The scaling policy is automatically in force as soon as it's successfully created.
    /// If the fleet's auto-scaling actions are temporarily suspended, the new policy will
    /// be in force once the fleet actions are restarted.
    /// </para>
    ///  
    /// <para>
    ///  <b>Rule-based policy</b> 
    /// </para>
    ///  
    /// <para>
    /// A rule-based policy tracks specified fleet metric, sets a threshold value, and specifies
    /// the type of action to initiate when triggered. With a rule-based policy, you can select
    /// from several available fleet metrics. Each policy specifies whether to scale up or
    /// scale down (and by how much), so you need one policy for each type of action. 
    /// </para>
    ///  
    /// <para>
    /// For example, a policy may make the following statement: "If the percentage of idle
    /// instances is greater than 20% for more than 15 minutes, then reduce the fleet capacity
    /// by 10%."
    /// </para>
    ///  
    /// <para>
    /// A policy's rule statement has the following structure:
    /// </para>
    ///  
    /// <para>
    /// If <code>[MetricName]</code> is <code>[ComparisonOperator]</code> <code>[Threshold]</code>
    /// for <code>[EvaluationPeriods]</code> minutes, then <code>[ScalingAdjustmentType]</code>
    /// to/by <code>[ScalingAdjustment]</code>.
    /// </para>
    ///  
    /// <para>
    /// To implement the example, the rule statement would look like this:
    /// </para>
    ///  
    /// <para>
    /// If <code>[PercentIdleInstances]</code> is <code>[GreaterThanThreshold]</code> <code>[20]</code>
    /// for <code>[15]</code> minutes, then <code>[PercentChangeInCapacity]</code> to/by <code>[10]</code>.
    /// </para>
    ///  
    /// <para>
    /// To create or update a scaling policy, specify a unique combination of name and fleet
    /// ID, and set the policy type to "RuleBased". Specify the parameter values for a policy
    /// rule statement. On a successful request, the policy name is returned. Scaling policies
    /// are automatically in force as soon as they're successfully created. If the fleet's
    /// auto-scaling actions are temporarily suspended, the new policy will be in force once
    /// the fleet actions are restarted.
    /// </para>
    /// </summary>
    public partial class PutScalingPolicyRequest : AmazonGameLiftRequest
    {
        private ComparisonOperatorType _comparisonOperator;
        private int? _evaluationPeriods;
        private string _fleetId;
        private MetricName _metricName;
        private string _name;
        private PolicyType _policyType;
        private int? _scalingAdjustment;
        private ScalingAdjustmentType _scalingAdjustmentType;
        private TargetConfiguration _targetConfiguration;
        private double? _threshold;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// Comparison operator to use when measuring the metric against the threshold value.
        /// </para>
        /// </summary>
        public ComparisonOperatorType ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// Length of time (in minutes) the metric must be at or beyond the threshold before a
        /// scaling event is triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int EvaluationPeriods
        {
            get { return this._evaluationPeriods.GetValueOrDefault(); }
            set { this._evaluationPeriods = value; }
        }

        // Check to see if EvaluationPeriods property is set
        internal bool IsSetEvaluationPeriods()
        {
            return this._evaluationPeriods.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to apply this policy to. You can use either the
        /// fleet ID or ARN value. The fleet cannot be in any of the following statuses: ERROR
        /// or DELETING.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Name of the Amazon GameLift-defined metric that is used to trigger a scaling adjustment.
        /// For detailed descriptions of fleet metrics, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html">Monitor
        /// Amazon GameLift with Amazon CloudWatch</a>. 
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
        ///  <b>AvailableGameSessions</b> -- Additional game sessions that fleet could host simultaneously,
        /// given current capacity.
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
        [AWSProperty(Required=true)]
        public MetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a fleet's scaling policy. Policy names
        /// do not need to be unique. A fleet can have only one scaling policy with the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of scaling policy to create. For a target-based policy, set the parameter
        /// <i>MetricName</i> to 'PercentAvailableGameSessions' and specify a <i>TargetConfiguration</i>.
        /// For a rule-based policy set the following parameters: <i>MetricName</i>, <i>ComparisonOperator</i>,
        /// <i>Threshold</i>, <i>EvaluationPeriods</i>, <i>ScalingAdjustmentType</i>, and <i>ScalingAdjustment</i>.
        /// </para>
        /// </summary>
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// Amount of adjustment to make, based on the scaling adjustment type.
        /// </para>
        /// </summary>
        public int ScalingAdjustment
        {
            get { return this._scalingAdjustment.GetValueOrDefault(); }
            set { this._scalingAdjustment = value; }
        }

        // Check to see if ScalingAdjustment property is set
        internal bool IsSetScalingAdjustment()
        {
            return this._scalingAdjustment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingAdjustmentType. 
        /// <para>
        /// The type of adjustment to make to a fleet's instance count:
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
        /// values scale down; for example, a value of "-10" scales the fleet down by 10%.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScalingAdjustmentType ScalingAdjustmentType
        {
            get { return this._scalingAdjustmentType; }
            set { this._scalingAdjustmentType = value; }
        }

        // Check to see if ScalingAdjustmentType property is set
        internal bool IsSetScalingAdjustmentType()
        {
            return this._scalingAdjustmentType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// An object that contains settings for a target-based scaling policy.
        /// </para>
        /// </summary>
        public TargetConfiguration TargetConfiguration
        {
            get { return this._targetConfiguration; }
            set { this._targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this._targetConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// Metric value used to trigger a scaling event.
        /// </para>
        /// </summary>
        public double Threshold
        {
            get { return this._threshold.GetValueOrDefault(); }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

    }
}