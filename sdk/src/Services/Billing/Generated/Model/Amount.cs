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
    /// A monetary amount with a currency code. Used throughout the Billing API to represent
    /// credit balances, allocations, and adjustments.
    /// </summary>
    public partial class Amount
    {
        private string _currencyAmount;
        private string _currencyCode;

        /// <summary>
        /// Gets and sets the property CurrencyAmount. 
        /// <para>
        /// The amount as a decimal string (for example, <c>"743.21"</c>). Negative values represent
        /// credits that reduce a bill.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrencyAmount
        {
            get { return this._currencyAmount; }
            set { this._currencyAmount = value; }
        }

        // Check to see if CurrencyAmount property is set
        internal bool IsSetCurrencyAmount()
        {
            return this._currencyAmount != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The ISO 4217 currency code for the amount (for example, <c>USD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}