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
    /// Estimated cost of the agreement.
    /// </summary>
    public partial class EstimatedCharges
    {
        private string _agreementValue;
        private string _currencyCode;

        /// <summary>
        /// Gets and sets the property AgreementValue. 
        /// <para>
        /// The total known amount customer has to pay across the lifecycle of the agreement.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is the total contract value if accepted terms contain <c>ConfigurableUpfrontPricingTerm</c>
        /// or <c>FixedUpfrontPricingTerm</c>. In the case of pure contract pricing, this will
        /// be the total value of the contract. In the case of contracts with consumption pricing,
        /// this will only include the committed value and not include any overages that occur.
        /// </para>
        ///  
        /// <para>
        /// If the accepted terms contain <c>PaymentScheduleTerm</c>, it will be the total payment
        /// schedule amount. This occurs when flexible payment schedule is used, and is the sum
        /// of all invoice charges in the payment schedule.
        /// </para>
        ///  
        /// <para>
        /// In case a customer has amended an agreement, by purchasing more units of any dimension,
        /// this will include both the original cost as well as the added cost incurred due to
        /// addition of new units. 
        /// </para>
        ///  
        /// <para>
        /// This is <c>0</c> if the accepted terms contain <c>UsageBasedPricingTerm</c> without
        /// <c>ConfigurableUpfrontPricingTerm</c> or <c>RecurringPaymentTerm</c>. This occurs
        /// for usage-based pricing (such as SaaS metered or AMI/container hourly or monthly),
        /// because the exact usage is not known upfront.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string AgreementValue
        {
            get { return this._agreementValue; }
            set { this._agreementValue = value; }
        }

        // Check to see if AgreementValue property is set
        internal bool IsSetAgreementValue()
        {
            return this._agreementValue != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Defines the currency code for the charge.
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

    }
}