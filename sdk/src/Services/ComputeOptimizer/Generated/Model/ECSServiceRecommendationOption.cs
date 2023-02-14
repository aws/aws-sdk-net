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
    /// Describes the recommendation options for an Amazon ECS service.
    /// </summary>
    public partial class ECSServiceRecommendationOption
    {
        private List<ContainerRecommendation> _containerRecommendations = new List<ContainerRecommendation>();
        private int? _cpu;
        private int? _memory;
        private List<ECSServiceProjectedUtilizationMetric> _projectedUtilizationMetrics = new List<ECSServiceProjectedUtilizationMetric>();
        private SavingsOpportunity _savingsOpportunity;

        /// <summary>
        /// Gets and sets the property ContainerRecommendations. 
        /// <para>
        ///  The CPU and memory size recommendations for the containers within the task of your
        /// Amazon ECS service. 
        /// </para>
        /// </summary>
        public List<ContainerRecommendation> ContainerRecommendations
        {
            get { return this._containerRecommendations; }
            set { this._containerRecommendations = value; }
        }

        // Check to see if ContainerRecommendations property is set
        internal bool IsSetContainerRecommendations()
        {
            return this._containerRecommendations != null && this._containerRecommendations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        ///  The CPU size of the Amazon ECS service recommendation option. 
        /// </para>
        /// </summary>
        public int Cpu
        {
            get { return this._cpu.GetValueOrDefault(); }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        ///  The memory size of the Amazon ECS service recommendation option. 
        /// </para>
        /// </summary>
        public int Memory
        {
            get { return this._memory.GetValueOrDefault(); }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectedUtilizationMetrics. 
        /// <para>
        ///  An array of objects that describe the projected utilization metrics of the Amazon
        /// ECS service recommendation option. 
        /// </para>
        /// </summary>
        public List<ECSServiceProjectedUtilizationMetric> ProjectedUtilizationMetrics
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
        /// Gets and sets the property SavingsOpportunity.
        /// </summary>
        public SavingsOpportunity SavingsOpportunity
        {
            get { return this._savingsOpportunity; }
            set { this._savingsOpportunity = value; }
        }

        // Check to see if SavingsOpportunity property is set
        internal bool IsSetSavingsOpportunity()
        {
            return this._savingsOpportunity != null;
        }

    }
}