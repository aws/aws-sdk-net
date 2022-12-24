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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the projected utilization metrics of an Amazon ECS service recommendation
    /// option. 
    /// 
    ///  
    /// <para>
    /// To determine the performance difference between your current ECS service and the recommended
    /// option, compare the utilization metric data of your service against its projected
    /// utilization metric data.
    /// </para>
    /// </summary>
    public partial class ECSServiceProjectedUtilizationMetric
    {
        private double? _lowerBoundValue;
        private ECSServiceMetricName _name;
        private ECSServiceMetricStatistic _statistic;
        private double? _upperBoundValue;

        /// <summary>
        /// Gets and sets the property LowerBoundValue. 
        /// <para>
        ///  The lower bound values for the projected utilization metrics. 
        /// </para>
        /// </summary>
        public double LowerBoundValue
        {
            get { return this._lowerBoundValue.GetValueOrDefault(); }
            set { this._lowerBoundValue = value; }
        }

        // Check to see if LowerBoundValue property is set
        internal bool IsSetLowerBoundValue()
        {
            return this._lowerBoundValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the projected utilization metric. 
        /// </para>
        ///  
        /// <para>
        /// The following utilization metrics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CPU</code> — The percentage of allocated compute units that are currently in
        /// use on the ECS service tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Memory</code> — The percentage of memory that is currently in use on the ECS
        /// service tasks.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ECSServiceMetricName Name
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
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic of the projected utilization metric.
        /// </para>
        ///  
        /// <para>
        /// The Compute Optimizer API, Command Line Interface (CLI), and SDKs return utilization
        /// metrics using only the <code>Maximum</code> statistic, which is the highest value
        /// observed during the specified period.
        /// </para>
        ///  
        /// <para>
        /// The Compute Optimizer console displays graphs for some utilization metrics using the
        /// <code>Average</code> statistic, which is the value of <code>Sum</code> / <code>SampleCount</code>
        /// during the specified period. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/viewing-recommendations.html">Viewing
        /// resource recommendations</a> in the <i>Compute Optimizer User Guide</i>. You can also
        /// get averaged utilization metric data for your resources using Amazon CloudWatch. For
        /// more information, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/WhatIsCloudWatch.html">Amazon
        /// CloudWatch User Guide</a>.
        /// </para>
        /// </summary>
        public ECSServiceMetricStatistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property UpperBoundValue. 
        /// <para>
        ///  The upper bound values for the projected utilization metrics. 
        /// </para>
        /// </summary>
        public double UpperBoundValue
        {
            get { return this._upperBoundValue.GetValueOrDefault(); }
            set { this._upperBoundValue = value; }
        }

        // Check to see if UpperBoundValue property is set
        internal bool IsSetUpperBoundValue()
        {
            return this._upperBoundValue.HasValue; 
        }

    }
}