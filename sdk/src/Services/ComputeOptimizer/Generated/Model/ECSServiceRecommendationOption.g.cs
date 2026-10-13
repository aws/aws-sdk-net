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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes the recommendation options for an Amazon ECS service.
    /// </summary>
    public partial class ECSServiceRecommendationOption
    {
        /// <summary>
        /// Gets and sets the property ContainerRecommendations. 
        /// <para>
        ///  The CPU and memory size recommendations for the containers within the task of your
        /// Amazon ECS service. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerRecommendation> ContainerRecommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerRecommendation>() : null;

        /// <summary>
        /// Checks to see if the ContainerRecommendations property is set.
        /// </summary>
        internal bool IsSetContainerRecommendations() => this.ContainerRecommendations != null && (this.ContainerRecommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        ///  The CPU size of the Amazon ECS service recommendation option. 
        /// </para>
        /// </summary>
        public int? Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu.HasValue;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        ///  The memory size of the Amazon ECS service recommendation option. 
        /// </para>
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectedUtilizationMetrics. 
        /// <para>
        ///  An array of objects that describe the projected utilization metrics of the Amazon
        /// ECS service recommendation option. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ECSServiceProjectedUtilizationMetric> ProjectedUtilizationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<ECSServiceProjectedUtilizationMetric>() : null;

        /// <summary>
        /// Checks to see if the ProjectedUtilizationMetrics property is set.
        /// </summary>
        internal bool IsSetProjectedUtilizationMetrics() => this.ProjectedUtilizationMetrics != null && (this.ProjectedUtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SavingsOpportunity.
        /// </summary>
        public SavingsOpportunity SavingsOpportunity { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunity property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunity() => this.SavingsOpportunity != null;

        /// <summary>
        /// Gets and sets the property SavingsOpportunityAfterDiscounts. 
        /// <para>
        ///  Describes the savings opportunity for Amazon ECS service recommendations or for the
        /// recommendation option. 
        /// </para>
        ///  
        /// <para>
        /// Savings opportunity represents the estimated monthly savings after applying Savings
        /// Plans discounts. You can achieve this by implementing a given Compute Optimizer recommendation.
        /// </para>
        /// </summary>
        public ECSSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunityAfterDiscounts property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunityAfterDiscounts() => this.SavingsOpportunityAfterDiscounts != null;
    }
}
