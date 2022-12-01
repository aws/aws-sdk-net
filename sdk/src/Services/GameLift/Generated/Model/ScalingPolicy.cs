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
    /// Rule that controls how a fleet is scaled. Scaling policies are uniquely identified
    /// by the combination of name and fleet ID.
    /// </summary>
    public partial class ScalingPolicy
    {
        private ComparisonOperatorType _comparisonOperator;
        private int? _evaluationPeriods;
        private string _fleetArn;
        private string _fleetId;
        private string _location;
        private MetricName _metricName;
        private string _name;
        private PolicyType _policyType;
        private int? _scalingAdjustment;
        private ScalingAdjustmentType _scalingAdjustmentType;
        private ScalingStatusType _status;
        private TargetConfiguration _targetConfiguration;
        private double? _threshold;
        private LocationUpdateStatus _updateStatus;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// Comparison operator to use when measuring a metric against the threshold value.
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
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a GameLift fleet resource and uniquely identifies it. ARNs are
        /// unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</code>.
        /// </para>
        /// </summary>
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that is associated with this scaling policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Location. 
        /// <para>
        ///  The fleet location. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
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
        /// do not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the scaling policy. The scaling policy can be in force only when
        /// in an <code>ACTIVE</code> status. Scaling policies can be suspended for individual
        /// fleets. If the policy is suspended for a fleet, the policy status does not change.
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
        public ScalingStatusType Status
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

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The current status of the fleet's scaling policies in a requested fleet location.
        /// The status <code>PENDING_UPDATE</code> indicates that an update was requested for
        /// the fleet but has not yet been completed for the location.
        /// </para>
        /// </summary>
        public LocationUpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

    }
}