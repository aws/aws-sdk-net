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
    /// Describes a recommendation option for an AWS Lambda function.
    /// </summary>
    public partial class LambdaFunctionMemoryRecommendationOption
    {
        private int? _memorySize;
        private List<LambdaFunctionMemoryProjectedMetric> _projectedUtilizationMetrics = new List<LambdaFunctionMemoryProjectedMetric>();
        private int? _rank;

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The memory size, in MB, of the function recommendation option.
        /// </para>
        /// </summary>
        public int MemorySize
        {
            get { return this._memorySize.GetValueOrDefault(); }
            set { this._memorySize = value; }
        }

        // Check to see if MemorySize property is set
        internal bool IsSetMemorySize()
        {
            return this._memorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectedUtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the projected utilization metrics of the function
        /// recommendation option.
        /// </para>
        /// </summary>
        public List<LambdaFunctionMemoryProjectedMetric> ProjectedUtilizationMetrics
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
        /// The rank of the function recommendation option.
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