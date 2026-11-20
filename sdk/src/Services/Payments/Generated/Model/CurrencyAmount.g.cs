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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// A monetary amount expressed as a decimal string in the currency's standard unit.
    /// </summary>
    public partial class CurrencyAmount
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The ISO 4217 currency code for the amount (for example, <c>USD</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The amount, as a decimal string, such as <c>10.99</c>. The number of decimal places
        /// can differ between amounts, for example <c>0.0</c> and <c>1000.24</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
