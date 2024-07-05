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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Card data parameters that are required to verify Card Verification Value (CVV2) for
    /// the payment card.
    /// </summary>
    public partial class CardVerificationValue2
    {
        private string _cardExpiryDate;

        /// <summary>
        /// Gets and sets the property CardExpiryDate. 
        /// <para>
        /// The expiry date of a payment card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=4, Max=4)]
        public string CardExpiryDate
        {
            get { return this._cardExpiryDate; }
            set { this._cardExpiryDate = value; }
        }

        // Check to see if CardExpiryDate property is set
        internal bool IsSetCardExpiryDate()
        {
            return this._cardExpiryDate != null;
        }

    }
}