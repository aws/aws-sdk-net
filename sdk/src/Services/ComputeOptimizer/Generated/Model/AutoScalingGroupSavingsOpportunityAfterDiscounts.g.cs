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
    /// Describes the savings opportunity for Auto Scaling group recommendations after applying
    /// the Savings Plans and Reserved Instances discounts. 
    /// 
    ///  
    /// <para>
    /// Savings opportunity represents the estimated monthly savings you can achieve by implementing
    /// Compute Optimizer recommendations.
    /// </para>
    /// </summary>
    public partial class AutoScalingGroupSavingsOpportunityAfterDiscounts
    {
        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        ///  An object that describes the estimated monthly savings possible by adopting Compute
        /// Optimizer’s Auto Scaling group recommendations. This is based on the Savings Plans
        /// and Reserved Instances pricing discounts. 
        /// </para>
        /// </summary>
        public AutoScalingGroupEstimatedMonthlySavings EstimatedMonthlySavings { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavings property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavings() => this.EstimatedMonthlySavings != null;

        /// <summary>
        /// Gets and sets the property SavingsOpportunityPercentage. 
        /// <para>
        ///  The estimated monthly savings possible as a percentage of monthly cost after applying
        /// the Savings Plans and Reserved Instances discounts. This saving can be achieved by
        /// adopting Compute Optimizer’s Auto Scaling group recommendations. 
        /// </para>
        /// </summary>
        public double? SavingsOpportunityPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunityPercentage property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunityPercentage() => this.SavingsOpportunityPercentage.HasValue;
    }
}
