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
    /// Container for the parameters to the RedeemCredits operation.
    /// Redeems an Amazon Web Services promotional credit code on behalf of the calling account.
    /// On success, a new credit is added to the account's credit ledger with the amount,
    /// validity period, and applicable products defined by the promotion. The credit is then
    /// automatically applied to subsequent bills according to the standard credit application
    /// order.
    /// </summary>
    public partial class RedeemCreditsRequest : AmazonBillingRequest
    {
        private string _promoCode;

        /// <summary>
        /// Gets and sets the property PromoCode. 
        /// <para>
        /// The promotional credit code to redeem.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PromoCode
        {
            get { return this._promoCode; }
            set { this._promoCode = value; }
        }

        // Check to see if PromoCode property is set
        internal bool IsSetPromoCode()
        {
            return this._promoCode != null;
        }

    }
}