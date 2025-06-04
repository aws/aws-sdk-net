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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Details about how the total amount was calculated and categorized.
    /// </summary>
    public partial class AmountBreakdown
    {
        private DiscountsBreakdown _discounts;
        private FeesBreakdown _fees;
        private string _subTotalAmount;
        private TaxesBreakdown _taxes;

        /// <summary>
        /// Gets and sets the property Discounts. 
        /// <para>
        ///  The discounted amount. 
        /// </para>
        /// </summary>
        public DiscountsBreakdown Discounts
        {
            get { return this._discounts; }
            set { this._discounts = value; }
        }

        // Check to see if Discounts property is set
        internal bool IsSetDiscounts()
        {
            return this._discounts != null;
        }

        /// <summary>
        /// Gets and sets the property Fees. 
        /// <para>
        ///  The fee amount. 
        /// </para>
        /// </summary>
        public FeesBreakdown Fees
        {
            get { return this._fees; }
            set { this._fees = value; }
        }

        // Check to see if Fees property is set
        internal bool IsSetFees()
        {
            return this._fees != null;
        }

        /// <summary>
        /// Gets and sets the property SubTotalAmount. 
        /// <para>
        ///  The total of a set of the breakdown. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SubTotalAmount
        {
            get { return this._subTotalAmount; }
            set { this._subTotalAmount = value; }
        }

        // Check to see if SubTotalAmount property is set
        internal bool IsSetSubTotalAmount()
        {
            return this._subTotalAmount != null;
        }

        /// <summary>
        /// Gets and sets the property Taxes. 
        /// <para>
        ///  The tax amount. 
        /// </para>
        /// </summary>
        public TaxesBreakdown Taxes
        {
            get { return this._taxes; }
            set { this._taxes = value; }
        }

        // Check to see if Taxes property is set
        internal bool IsSetTaxes()
        {
            return this._taxes != null;
        }

    }
}