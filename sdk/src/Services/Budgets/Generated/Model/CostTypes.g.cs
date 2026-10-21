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

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The types of cost that are included in a <c>COST</c> budget, such as tax and subscriptions.
    /// 
    ///  
    /// <para>
    ///  <c>USAGE</c>, <c>RI_UTILIZATION</c>, <c>RI_COVERAGE</c>, <c>SAVINGS_PLANS_UTILIZATION</c>,
    /// and <c>SAVINGS_PLANS_COVERAGE</c> budgets don't have <c>CostTypes</c>.
    /// </para>
    /// </summary>
    public partial class CostTypes
    {
        /// <summary>
        /// Gets and sets the property IncludeCredit. 
        /// <para>
        /// Specifies whether a budget includes credits.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeCredit { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCredit property is set.
        /// </summary>
        internal bool IsSetIncludeCredit() => this.IncludeCredit.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeDiscount. 
        /// <para>
        /// Specifies whether a budget includes discounts.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeDiscount { get; set; }

        /// <summary>
        /// Checks to see if the IncludeDiscount property is set.
        /// </summary>
        internal bool IsSetIncludeDiscount() => this.IncludeDiscount.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeOtherSubscription. 
        /// <para>
        /// Specifies whether a budget includes non-RI subscription costs.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeOtherSubscription { get; set; }

        /// <summary>
        /// Checks to see if the IncludeOtherSubscription property is set.
        /// </summary>
        internal bool IsSetIncludeOtherSubscription() => this.IncludeOtherSubscription.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeRecurring. 
        /// <para>
        /// Specifies whether a budget includes recurring fees such as monthly RI fees.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeRecurring { get; set; }

        /// <summary>
        /// Checks to see if the IncludeRecurring property is set.
        /// </summary>
        internal bool IsSetIncludeRecurring() => this.IncludeRecurring.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeRefund. 
        /// <para>
        /// Specifies whether a budget includes refunds.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeRefund { get; set; }

        /// <summary>
        /// Checks to see if the IncludeRefund property is set.
        /// </summary>
        internal bool IsSetIncludeRefund() => this.IncludeRefund.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeSubscription. 
        /// <para>
        /// Specifies whether a budget includes subscriptions.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeSubscription { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSubscription property is set.
        /// </summary>
        internal bool IsSetIncludeSubscription() => this.IncludeSubscription.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeSupport. 
        /// <para>
        /// Specifies whether a budget includes support subscription fees.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeSupport { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSupport property is set.
        /// </summary>
        internal bool IsSetIncludeSupport() => this.IncludeSupport.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeTax. 
        /// <para>
        /// Specifies whether a budget includes taxes.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeTax { get; set; }

        /// <summary>
        /// Checks to see if the IncludeTax property is set.
        /// </summary>
        internal bool IsSetIncludeTax() => this.IncludeTax.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeUpfront. 
        /// <para>
        /// Specifies whether a budget includes upfront RI costs.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeUpfront { get; set; }

        /// <summary>
        /// Checks to see if the IncludeUpfront property is set.
        /// </summary>
        internal bool IsSetIncludeUpfront() => this.IncludeUpfront.HasValue;

        /// <summary>
        /// Gets and sets the property UseAmortized. 
        /// <para>
        /// Specifies whether a budget uses the amortized rate.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? UseAmortized { get; set; }

        /// <summary>
        /// Checks to see if the UseAmortized property is set.
        /// </summary>
        internal bool IsSetUseAmortized() => this.UseAmortized.HasValue;

        /// <summary>
        /// Gets and sets the property UseBlended. 
        /// <para>
        /// Specifies whether a budget uses a blended rate.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? UseBlended { get; set; }

        /// <summary>
        /// Checks to see if the UseBlended property is set.
        /// </summary>
        internal bool IsSetUseBlended() => this.UseBlended.HasValue;
    }
}
