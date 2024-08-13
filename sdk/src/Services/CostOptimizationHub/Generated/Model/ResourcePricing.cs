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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
        private double? _estimatedCostAfterDiscounts;
        private double? _estimatedCostBeforeDiscounts;
        private EstimatedDiscounts _estimatedDiscounts;
        private double? _estimatedNetUnusedAmortizedCommitments;

        /// <summary>
        /// Gets and sets the property EstimatedCostAfterDiscounts. 
        /// <para>
        /// The savings estimate incorporating all discounts with Amazon Web Services, such as
        /// Reserved Instances and Savings Plans.
        /// </para>
        /// </summary>
        public double? EstimatedCostAfterDiscounts
        {
            get { return this._estimatedCostAfterDiscounts; }
            set { this._estimatedCostAfterDiscounts = value; }
        }

        // Check to see if EstimatedCostAfterDiscounts property is set
        internal bool IsSetEstimatedCostAfterDiscounts()
        {
            return this._estimatedCostAfterDiscounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedCostBeforeDiscounts. 
        /// <para>
        /// The savings estimate using Amazon Web Services public pricing without incorporating
        /// any discounts.
        /// </para>
        /// </summary>
        public double? EstimatedCostBeforeDiscounts
        {
            get { return this._estimatedCostBeforeDiscounts; }
            set { this._estimatedCostBeforeDiscounts = value; }
        }

        // Check to see if EstimatedCostBeforeDiscounts property is set
        internal bool IsSetEstimatedCostBeforeDiscounts()
        {
            return this._estimatedCostBeforeDiscounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedDiscounts. 
        /// <para>
        /// The estimated discounts for a recommendation.
        /// </para>
        /// </summary>
        public EstimatedDiscounts EstimatedDiscounts
        {
            get { return this._estimatedDiscounts; }
            set { this._estimatedDiscounts = value; }
        }

        // Check to see if EstimatedDiscounts property is set
        internal bool IsSetEstimatedDiscounts()
        {
            return this._estimatedDiscounts != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedNetUnusedAmortizedCommitments. 
        /// <para>
        /// The estimated net unused amortized commitment for the recommendation.
        /// </para>
        /// </summary>
        public double? EstimatedNetUnusedAmortizedCommitments
        {
            get { return this._estimatedNetUnusedAmortizedCommitments; }
            set { this._estimatedNetUnusedAmortizedCommitments = value; }
        }

        // Check to see if EstimatedNetUnusedAmortizedCommitments property is set
        internal bool IsSetEstimatedNetUnusedAmortizedCommitments()
        {
            return this._estimatedNetUnusedAmortizedCommitments.HasValue; 
        }

    }
}