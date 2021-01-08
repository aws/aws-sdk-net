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
    /// Describes a recommendation option for an Auto Scaling group.
    /// </summary>
    public partial class AutoScalingGroupRecommendationOption
    {
        private AutoScalingGroupConfiguration _configuration;
        private double? _performanceRisk;
        private List<UtilizationMetric> _projectedUtilizationMetrics = new List<UtilizationMetric>();
        private int? _rank;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// An array of objects that describe an Auto Scaling group configuration.
        /// </para>
        /// </summary>
        public AutoScalingGroupConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceRisk. 
        /// <para>
        /// The performance risk of the Auto Scaling group configuration recommendation.
        /// </para>
        ///  
        /// <para>
        /// Performance risk is the likelihood of the recommended instance type not meeting the
        /// performance requirement of your workload.
        /// </para>
        ///  
        /// <para>
        /// The lowest performance risk is categorized as <code>0</code>, and the highest as <code>5</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public double PerformanceRisk
        {
            get { return this._performanceRisk.GetValueOrDefault(); }
            set { this._performanceRisk = value; }
        }

        // Check to see if PerformanceRisk property is set
        internal bool IsSetPerformanceRisk()
        {
            return this._performanceRisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectedUtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the projected utilization metrics of the Auto Scaling
        /// group recommendation option.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Cpu</code> and <code>Memory</code> metrics are the only projected utilization
        /// metrics returned. Additionally, the <code>Memory</code> metric is returned only for
        /// resources that have the unified CloudWatch agent installed on them. For more information,
        /// see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public List<UtilizationMetric> ProjectedUtilizationMetrics
        {
            get { return this._projectedUtilizationMetrics; }
            set { this._projectedUtilizationMetrics = value; }
        }

        // Check to see if ProjectedUtilizationMetrics property is set
        internal bool IsSetProjectedUtilizationMetrics()
        {
            return this._projectedUtilizationMetrics != null && this._projectedUtilizationMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// The rank of the Auto Scaling group recommendation option.
        /// </para>
        ///  
        /// <para>
        /// The top recommendation option is ranked as <code>1</code>.
        /// </para>
        /// </summary>
        public int Rank
        {
            get { return this._rank.GetValueOrDefault(); }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

    }
}