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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The configuration based on which FinSpace will scale in or scale out nodes in your
    /// cluster.
    /// </summary>
    public partial class AutoScalingConfiguration
    {
        private AutoScalingMetric _autoScalingMetric;
        private int? _maxNodeCount;
        private double? _metricTarget;
        private int? _minNodeCount;
        private double? _scaleInCooldownSeconds;
        private double? _scaleOutCooldownSeconds;

        /// <summary>
        /// Gets and sets the property AutoScalingMetric. 
        /// <para>
        ///  The metric your cluster will track in order to scale in and out. For example, <c>CPU_UTILIZATION_PERCENTAGE</c>
        /// is the average CPU usage across all the nodes in a cluster.
        /// </para>
        /// </summary>
        public AutoScalingMetric AutoScalingMetric
        {
            get { return this._autoScalingMetric; }
            set { this._autoScalingMetric = value; }
        }

        // Check to see if AutoScalingMetric property is set
        internal bool IsSetAutoScalingMetric()
        {
            return this._autoScalingMetric != null;
        }

        /// <summary>
        /// Gets and sets the property MaxNodeCount. 
        /// <para>
        /// The highest number of nodes to scale. This value cannot be greater than 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxNodeCount
        {
            get { return this._maxNodeCount; }
            set { this._maxNodeCount = value; }
        }

        // Check to see if MaxNodeCount property is set
        internal bool IsSetMaxNodeCount()
        {
            return this._maxNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricTarget. 
        /// <para>
        /// The desired value of the chosen <c>autoScalingMetric</c>. When the metric drops below
        /// this value, the cluster will scale in. When the metric goes above this value, the
        /// cluster will scale out. You can set the target value between 1 and 100 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public double? MetricTarget
        {
            get { return this._metricTarget; }
            set { this._metricTarget = value; }
        }

        // Check to see if MetricTarget property is set
        internal bool IsSetMetricTarget()
        {
            return this._metricTarget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinNodeCount. 
        /// <para>
        /// The lowest number of nodes to scale. This value must be at least 1 and less than the
        /// <c>maxNodeCount</c>. If the nodes in a cluster belong to multiple availability zones,
        /// then <c>minNodeCount</c> must be at least 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MinNodeCount
        {
            get { return this._minNodeCount; }
            set { this._minNodeCount = value; }
        }

        // Check to see if MinNodeCount property is set
        internal bool IsSetMinNodeCount()
        {
            return this._minNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleInCooldownSeconds. 
        /// <para>
        /// The duration in seconds that FinSpace will wait after a scale in event before initiating
        /// another scaling event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public double? ScaleInCooldownSeconds
        {
            get { return this._scaleInCooldownSeconds; }
            set { this._scaleInCooldownSeconds = value; }
        }

        // Check to see if ScaleInCooldownSeconds property is set
        internal bool IsSetScaleInCooldownSeconds()
        {
            return this._scaleInCooldownSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleOutCooldownSeconds. 
        /// <para>
        /// The duration in seconds that FinSpace will wait after a scale out event before initiating
        /// another scaling event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public double? ScaleOutCooldownSeconds
        {
            get { return this._scaleOutCooldownSeconds; }
            set { this._scaleOutCooldownSeconds = value; }
        }

        // Check to see if ScaleOutCooldownSeconds property is set
        internal bool IsSetScaleOutCooldownSeconds()
        {
            return this._scaleOutCooldownSeconds.HasValue; 
        }

    }
}