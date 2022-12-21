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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Customer's consent for the owner change request.
    /// </summary>
    public partial class Consent
    {
        private string _currency;
        private double? _maxPrice;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        ///  Currency for the <code>MaxPrice</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=3)]
        public string Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        ///  Maximum amount the customer agreed to accept. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double MaxPrice
        {
            get { return this._maxPrice.GetValueOrDefault(); }
            set { this._maxPrice = value; }
        }

        // Check to see if MaxPrice property is set
        internal bool IsSetMaxPrice()
        {
            return this._maxPrice.HasValue; 
        }

    }
}