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
    /// Describes a projected utilization metric of a recommendation option.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>Cpu</c> and <c>Memory</c> metrics are the only projected utilization metrics
    /// returned when you run the <a>GetEC2RecommendationProjectedMetrics</a> action. Additionally,
    /// the <c>Memory</c> metric is returned only for resources that have the unified CloudWatch
    /// agent installed on them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
    /// Memory Utilization with the CloudWatch Agent</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RecommendedOptionProjectedMetric
    {
        private List<ProjectedMetric> _projectedMetrics = AWSConfigs.InitializeCollections ? new List<ProjectedMetric>() : null;
        private int? _rank;
        private string _recommendedInstanceType;

        /// <summary>
        /// Gets and sets the property ProjectedMetrics. 
        /// <para>
        /// An array of objects that describe a projected utilization metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectedMetric> ProjectedMetrics
        {
            get { return this._projectedMetrics; }
            set { this._projectedMetrics = value; }
        }

        // Check to see if ProjectedMetrics property is set
        internal bool IsSetProjectedMetrics()
        {
            return this._projectedMetrics != null && (this._projectedMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// The rank of the recommendation option projected metric.
        /// </para>
        ///  
        /// <para>
        /// The top recommendation option is ranked as <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// The projected metric rank correlates to the recommendation option rank. For example,
        /// the projected metric ranked as <c>1</c> is related to the recommendation option that
        /// is also ranked as <c>1</c> in the same response.
        /// </para>
        /// </summary>
        public int? Rank
        {
            get { return this._rank; }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedInstanceType. 
        /// <para>
        /// The recommended instance type.
        /// </para>
        /// </summary>
        public string RecommendedInstanceType
        {
            get { return this._recommendedInstanceType; }
            set { this._recommendedInstanceType = value; }
        }

        // Check to see if RecommendedInstanceType property is set
        internal bool IsSetRecommendedInstanceType()
        {
            return this._recommendedInstanceType != null;
        }

    }
}