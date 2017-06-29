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
    /// Rule that controls how a fleet is scaled. Scaling policies are uniquely identified
    /// by the combination of name and fleet ID.
    /// 
    ///  
    /// <para>
    /// Fleet-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Describe fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetUtilization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeRuntimeConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetEvents</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Update fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRuntimeConfiguration</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Manage fleet capacity:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutScalingPolicy</a> (automatic scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScalingPolicies</a> (automatic scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScalingPolicy</a> (automatic scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ScalingPolicy
    {
        private ComparisonOperatorType _comparisonOperator;
        private int? _evaluationPeriods;
        private string _fleetId;
        private MetricName _metricName;
        private string _name;
        private int? _scalingAdjustment;
        private ScalingAdjustmentType _scalingAdjustmentType;
        private ScalingStatusType _status;
        private double? _threshold;

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
        /// Unique identifier for a fleet that is associated with this scaling policy.
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// Name of the Amazon GameLift-defined metric that is used to trigger an adjustment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ActivatingGameSessions</b> – number of game sessions in the process of being created
        /// (game session status = <code>ACTIVATING</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ActiveGameSessions</b> – number of game sessions currently running (game session
        /// status = <code>ACTIVE</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CurrentPlayerSessions</b> – number of active or reserved player sessions (player
        /// session status = <code>ACTIVE</code> or <code>RESERVED</code>). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AvailablePlayerSessions</b> – number of player session slots currently available
        /// in active game sessions across the fleet, calculated by subtracting a game session's
        /// current player session count from its maximum player session count. This number does
        /// include game sessions that are not currently accepting players (game session <code>PlayerSessionCreationPolicy</code>
        /// = <code>DENY_ALL</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ActiveInstances</b> – number of instances currently running a game session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IdleInstances</b> – number of instances not currently running a game session.
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
        /// Descriptive label that is associated with a scaling policy. Policy names do not need
        /// to be unique.
        /// </para>
        /// </summary>
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
        /// Type of adjustment to make to a fleet's instance count (see <a>FleetCapacity</a>):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ChangeInCapacity</b> – add (or subtract) the scaling adjustment value from the
        /// current instance count. Positive values scale up while negative values scale down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ExactCapacity</b> – set the instance count to the scaling adjustment value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PercentChangeInCapacity</b> – increase or reduce the current instance count by
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
        /// Current status of the scaling policy. The scaling policy is only in force when in
        /// an <code>ACTIVE</code> status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVE</b> – The scaling policy is currently in force.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATE_REQUESTED</b> – A request to update the scaling policy has been received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATING</b> – A change is being made to the scaling policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETE_REQUESTED</b> – A request to delete the scaling policy has been received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETING</b> – The scaling policy is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETED</b> – The scaling policy has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR</b> – An error occurred in creating the policy. It should be removed and
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