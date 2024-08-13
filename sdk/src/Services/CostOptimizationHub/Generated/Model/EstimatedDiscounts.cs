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
    /// Estimated discount details of the current and recommended resource configuration for
    /// a recommendation.
    /// </summary>
    public partial class EstimatedDiscounts
    {
        private double? _otherDiscount;
        private double? _reservedInstancesDiscount;
        private double? _savingsPlansDiscount;

        /// <summary>
        /// Gets and sets the property OtherDiscount. 
        /// <para>
        /// Estimated other discounts include all discounts that are not itemized. Itemized discounts
        /// include <c>reservedInstanceDiscount</c> and <c>savingsPlansDiscount</c>.
        /// </para>
        /// </summary>
        public double? OtherDiscount
        {
            get { return this._otherDiscount; }
            set { this._otherDiscount = value; }
        }

        // Check to see if OtherDiscount property is set
        internal bool IsSetOtherDiscount()
        {
            return this._otherDiscount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesDiscount. 
        /// <para>
        /// Estimated reserved instance discounts.
        /// </para>
        /// </summary>
        public double? ReservedInstancesDiscount
        {
            get { return this._reservedInstancesDiscount; }
            set { this._reservedInstancesDiscount = value; }
        }

        // Check to see if ReservedInstancesDiscount property is set
        internal bool IsSetReservedInstancesDiscount()
        {
            return this._reservedInstancesDiscount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansDiscount. 
        /// <para>
        /// Estimated Savings Plans discounts.
        /// </para>
        /// </summary>
        public double? SavingsPlansDiscount
        {
            get { return this._savingsPlansDiscount; }
            set { this._savingsPlansDiscount = value; }
        }

        // Check to see if SavingsPlansDiscount property is set
        internal bool IsSetSavingsPlansDiscount()
        {
            return this._savingsPlansDiscount.HasValue; 
        }

    }
}