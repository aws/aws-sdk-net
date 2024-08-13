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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
        private bool? _includeCredit;
        private bool? _includeDiscount;
        private bool? _includeOtherSubscription;
        private bool? _includeRecurring;
        private bool? _includeRefund;
        private bool? _includeSubscription;
        private bool? _includeSupport;
        private bool? _includeTax;
        private bool? _includeUpfront;
        private bool? _useAmortized;
        private bool? _useBlended;

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
        public bool? IncludeCredit
        {
            get { return this._includeCredit; }
            set { this._includeCredit = value; }
        }

        // Check to see if IncludeCredit property is set
        internal bool IsSetIncludeCredit()
        {
            return this._includeCredit.HasValue; 
        }

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
        public bool? IncludeDiscount
        {
            get { return this._includeDiscount; }
            set { this._includeDiscount = value; }
        }

        // Check to see if IncludeDiscount property is set
        internal bool IsSetIncludeDiscount()
        {
            return this._includeDiscount.HasValue; 
        }

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
        public bool? IncludeOtherSubscription
        {
            get { return this._includeOtherSubscription; }
            set { this._includeOtherSubscription = value; }
        }

        // Check to see if IncludeOtherSubscription property is set
        internal bool IsSetIncludeOtherSubscription()
        {
            return this._includeOtherSubscription.HasValue; 
        }

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
        public bool? IncludeRecurring
        {
            get { return this._includeRecurring; }
            set { this._includeRecurring = value; }
        }

        // Check to see if IncludeRecurring property is set
        internal bool IsSetIncludeRecurring()
        {
            return this._includeRecurring.HasValue; 
        }

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
        public bool? IncludeRefund
        {
            get { return this._includeRefund; }
            set { this._includeRefund = value; }
        }

        // Check to see if IncludeRefund property is set
        internal bool IsSetIncludeRefund()
        {
            return this._includeRefund.HasValue; 
        }

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
        public bool? IncludeSubscription
        {
            get { return this._includeSubscription; }
            set { this._includeSubscription = value; }
        }

        // Check to see if IncludeSubscription property is set
        internal bool IsSetIncludeSubscription()
        {
            return this._includeSubscription.HasValue; 
        }

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
        public bool? IncludeSupport
        {
            get { return this._includeSupport; }
            set { this._includeSupport = value; }
        }

        // Check to see if IncludeSupport property is set
        internal bool IsSetIncludeSupport()
        {
            return this._includeSupport.HasValue; 
        }

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
        public bool? IncludeTax
        {
            get { return this._includeTax; }
            set { this._includeTax = value; }
        }

        // Check to see if IncludeTax property is set
        internal bool IsSetIncludeTax()
        {
            return this._includeTax.HasValue; 
        }

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
        public bool? IncludeUpfront
        {
            get { return this._includeUpfront; }
            set { this._includeUpfront = value; }
        }

        // Check to see if IncludeUpfront property is set
        internal bool IsSetIncludeUpfront()
        {
            return this._includeUpfront.HasValue; 
        }

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
        public bool? UseAmortized
        {
            get { return this._useAmortized; }
            set { this._useAmortized = value; }
        }

        // Check to see if UseAmortized property is set
        internal bool IsSetUseAmortized()
        {
            return this._useAmortized.HasValue; 
        }

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
        public bool? UseBlended
        {
            get { return this._useBlended; }
            set { this._useBlended = value; }
        }

        // Check to see if UseBlended property is set
        internal bool IsSetUseBlended()
        {
            return this._useBlended.HasValue; 
        }

    }
}