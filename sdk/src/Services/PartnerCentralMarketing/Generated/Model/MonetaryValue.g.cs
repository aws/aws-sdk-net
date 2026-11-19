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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// An amount of money in a named currency. 
    /// &lt;para&gt;
    /// The amount is a decimal string, not a float: a budget is exact, and binary floating
    /// point cannot represent every two-decimal value. Mirrors the Partner Central Selling
    /// API's `ExpectedCustomerSpend.Amount`.
    /// </summary>
    public partial class MonetaryValue
    {
        /// <summary>
        /// Gets and sets the property Amount. The amount, as a decimal string with at most two
        /// decimal places.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. The ISO 4217 currency the amount is denominated
        /// in.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;
    }
}
