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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The price per request for a payment network, specifying the amount and cryptocurrency.
    /// </summary>
    public partial class Price
    {
        private string _amount;
        private CryptoCurrency _currency;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The price per request as a decimal string in the specified currency. Minimum: 0.001.
        /// Maximum: 999999999.999. Supports up to 3 decimal places.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=13)]
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
        /// Gets and sets the property Currency. 
        /// <para>
        /// The cryptocurrency for payment. Currently only <c>USDC</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CryptoCurrency Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

    }
}