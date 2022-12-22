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
    /// Describes the projected metrics of an Amazon ECS service recommendation option. 
    /// 
    ///  
    /// <para>
    /// To determine the performance difference between your current ECS service and the recommended
    /// option, compare the metric data of your service against its projected metric data.
    /// </para>
    /// </summary>
    public partial class ECSServiceRecommendedOptionProjectedMetric
    {
        private List<ECSServiceProjectedMetric> _projectedMetrics = new List<ECSServiceProjectedMetric>();
        private int? _recommendedCpuUnits;
        private int? _recommendedMemorySize;

        /// <summary>
        /// Gets and sets the property ProjectedMetrics. 
        /// <para>
        ///  An array of objects that describe the projected metric. 
        /// </para>
        /// </summary>
        public List<ECSServiceProjectedMetric> ProjectedMetrics
        {
            get { return this._projectedMetrics; }
            set { this._projectedMetrics = value; }
        }

        // Check to see if ProjectedMetrics property is set
        internal bool IsSetProjectedMetrics()
        {
            return this._projectedMetrics != null && this._projectedMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedCpuUnits. 
        /// <para>
        ///  The recommended CPU size for the ECS service. 
        /// </para>
        /// </summary>
        public int RecommendedCpuUnits
        {
            get { return this._recommendedCpuUnits.GetValueOrDefault(); }
            set { this._recommendedCpuUnits = value; }
        }

        // Check to see if RecommendedCpuUnits property is set
        internal bool IsSetRecommendedCpuUnits()
        {
            return this._recommendedCpuUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedMemorySize. 
        /// <para>
        ///  The recommended memory size for the ECS service. 
        /// </para>
        /// </summary>
        public int RecommendedMemorySize
        {
            get { return this._recommendedMemorySize.GetValueOrDefault(); }
            set { this._recommendedMemorySize = value; }
        }

        // Check to see if RecommendedMemorySize property is set
        internal bool IsSetRecommendedMemorySize()
        {
            return this._recommendedMemorySize.HasValue; 
        }

    }
}