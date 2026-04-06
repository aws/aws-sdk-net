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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Monetary amounts associated with an invoice line item group.
    /// </summary>
    public partial class PricingCurrencyAmount
    {
        private string _amount;
        private string _currencyCode;
        private string _maxAdjustmentAmount;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The monetary amount before tax.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The 3-letter ISO 4217 currency code (e.g., <c>USD</c>, <c>EUR</c>, <c>JPY</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAdjustmentAmount. 
        /// <para>
        /// The maximum refundable amount as a string representation of a decimal number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string MaxAdjustmentAmount
        {
            get { return this._maxAdjustmentAmount; }
            set { this._maxAdjustmentAmount = value; }
        }

        // Check to see if MaxAdjustmentAmount property is set
        internal bool IsSetMaxAdjustmentAmount()
        {
            return this._maxAdjustmentAmount != null;
        }

    }
}