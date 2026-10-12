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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Contains pricing information about the specified resource.
    /// </summary>
    public partial class ResourcePricing
    {
        /// <summary>
        /// Gets and sets the property EstimatedCostAfterDiscounts. 
        /// <para>
        /// The savings estimate incorporating all discounts with Amazon Web Services, such as
        /// Reserved Instances and Savings Plans.
        /// </para>
        /// </summary>
        public double? EstimatedCostAfterDiscounts { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCostAfterDiscounts property is set.
        /// </summary>
        internal bool IsSetEstimatedCostAfterDiscounts() => this.EstimatedCostAfterDiscounts.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedCostBeforeDiscounts. 
        /// <para>
        /// The savings estimate using Amazon Web Services public pricing without incorporating
        /// any discounts.
        /// </para>
        /// </summary>
        public double? EstimatedCostBeforeDiscounts { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCostBeforeDiscounts property is set.
        /// </summary>
        internal bool IsSetEstimatedCostBeforeDiscounts() => this.EstimatedCostBeforeDiscounts.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedDiscounts. 
        /// <para>
        /// The estimated discounts for a recommendation.
        /// </para>
        /// </summary>
        public EstimatedDiscounts EstimatedDiscounts { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedDiscounts property is set.
        /// </summary>
        internal bool IsSetEstimatedDiscounts() => this.EstimatedDiscounts != null;

        /// <summary>
        /// Gets and sets the property EstimatedNetUnusedAmortizedCommitments. 
        /// <para>
        /// The estimated net unused amortized commitment for the recommendation.
        /// </para>
        /// </summary>
        public double? EstimatedNetUnusedAmortizedCommitments { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedNetUnusedAmortizedCommitments property is set.
        /// </summary>
        internal bool IsSetEstimatedNetUnusedAmortizedCommitments() => this.EstimatedNetUnusedAmortizedCommitments.HasValue;
    }
}
