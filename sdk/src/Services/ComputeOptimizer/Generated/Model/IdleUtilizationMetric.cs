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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the utilization metric of an idle resource.
    /// </summary>
    public partial class IdleUtilizationMetric
    {
        private IdleMetricName _name;
        private MetricStatistic _statistic;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the utilization metric.
        /// </para>
        /// </summary>
        public IdleMetricName Name
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
        ///  The statistic of the utilization metric. 
        /// </para>
        ///  
        /// <para>
        /// The Compute Optimizer API, Command Line Interface (CLI), and SDKs return utilization
        /// metrics using only the <c>Maximum</c> statistic, which is the highest value observed
        /// during the specified period.
        /// </para>
        ///  
        /// <para>
        /// The Compute Optimizer console displays graphs for some utilization metrics using the
        /// <c>Average</c> statistic, which is the value of <c>Sum</c> / <c>SampleCount</c> during
        /// the specified period. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/viewing-recommendations.html">Viewing
        /// resource recommendations</a> in the <i>Compute Optimizer User Guide</i>. You can also
        /// get averaged utilization metric data for your resources using Amazon CloudWatch. For
        /// more information, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/WhatIsCloudWatch.html">Amazon
        /// CloudWatch User Guide</a>.
        /// </para>
        /// </summary>
        public MetricStatistic Statistic
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the utilization metric.
        /// </para>
        /// </summary>
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}