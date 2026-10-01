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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// A discount applied to a Business Support account charge, including the discount amount,
    /// percentage, type, and source.
    /// </summary>
    public partial class BusinessSupportDiscount
    {
        private string _discountAmount;
        private string _discountPercentage;
        private string _discountSource;
        private string _discountType;

        /// <summary>
        /// Gets and sets the property DiscountAmount. 
        /// <para>
        /// The discount amount applied to the Business Support charge. This value is negative,
        /// representing a reduction in the charge.
        /// </para>
        /// </summary>
        public string DiscountAmount
        {
            get { return this._discountAmount; }
            set { this._discountAmount = value; }
        }

        // Check to see if DiscountAmount property is set
        internal bool IsSetDiscountAmount()
        {
            return this._discountAmount != null;
        }

        /// <summary>
        /// Gets and sets the property DiscountPercentage. 
        /// <para>
        /// The discount percentage applied to the Business Support charge, expressed as a decimal
        /// (for example, <c>0.12</c> for a 12% discount).
        /// </para>
        /// </summary>
        public string DiscountPercentage
        {
            get { return this._discountPercentage; }
            set { this._discountPercentage = value; }
        }

        // Check to see if DiscountPercentage property is set
        internal bool IsSetDiscountPercentage()
        {
            return this._discountPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property DiscountSource. 
        /// <para>
        /// The source or program through which the discount was applied.
        /// </para>
        /// </summary>
        public string DiscountSource
        {
            get { return this._discountSource; }
            set { this._discountSource = value; }
        }

        // Check to see if DiscountSource property is set
        internal bool IsSetDiscountSource()
        {
            return this._discountSource != null;
        }

        /// <summary>
        /// Gets and sets the property DiscountType. 
        /// <para>
        /// The type of discount applied. Valid values: <c>Distributor_Discount</c> (a discount
        /// applied through a distributor arrangement), <c>SPP_Discount</c> (a discount applied
        /// through the Solution Provider Program).
        /// </para>
        /// </summary>
        public string DiscountType
        {
            get { return this._discountType; }
            set { this._discountType = value; }
        }

        // Check to see if DiscountType property is set
        internal bool IsSetDiscountType()
        {
            return this._discountType != null;
        }

    }
}