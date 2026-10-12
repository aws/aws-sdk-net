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
    /// Estimated discount details of the current and recommended resource configuration for
    /// a recommendation.
    /// </summary>
    public partial class EstimatedDiscounts
    {
        /// <summary>
        /// Gets and sets the property OtherDiscount. 
        /// <para>
        /// Estimated other discounts include all discounts that are not itemized. Itemized discounts
        /// include <c>reservedInstanceDiscount</c> and <c>savingsPlansDiscount</c>.
        /// </para>
        /// </summary>
        public double? OtherDiscount { get; set; }

        /// <summary>
        /// Checks to see if the OtherDiscount property is set.
        /// </summary>
        internal bool IsSetOtherDiscount() => this.OtherDiscount.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedInstancesDiscount. 
        /// <para>
        /// Estimated reserved instance discounts.
        /// </para>
        /// </summary>
        public double? ReservedInstancesDiscount { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstancesDiscount property is set.
        /// </summary>
        internal bool IsSetReservedInstancesDiscount() => this.ReservedInstancesDiscount.HasValue;

        /// <summary>
        /// Gets and sets the property SavingsPlansDiscount. 
        /// <para>
        /// Estimated Savings Plans discounts.
        /// </para>
        /// </summary>
        public double? SavingsPlansDiscount { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansDiscount property is set.
        /// </summary>
        internal bool IsSetSavingsPlansDiscount() => this.SavingsPlansDiscount.HasValue;
    }
}
