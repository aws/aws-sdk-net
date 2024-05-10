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
    /// A subset of terms proposed by the proposer, which have been accepted by the acceptor
    /// as part of agreement creation.
    /// </summary>
    public partial class AcceptedTerm
    {
        private ByolPricingTerm _byolPricingTerm;
        private ConfigurableUpfrontPricingTerm _configurableUpfrontPricingTerm;
        private FixedUpfrontPricingTerm _fixedUpfrontPricingTerm;
        private FreeTrialPricingTerm _freeTrialPricingTerm;
        private LegalTerm _legalTerm;
        private PaymentScheduleTerm _paymentScheduleTerm;
        private RecurringPaymentTerm _recurringPaymentTerm;
        private RenewalTerm _renewalTerm;
        private SupportTerm _supportTerm;
        private UsageBasedPricingTerm _usageBasedPricingTerm;
        private ValidityTerm _validityTerm;

        /// <summary>
        /// Gets and sets the property ByolPricingTerm. 
        /// <para>
        /// Enables you and your customers to move your existing agreements to AWS Marketplace.
        /// The customer won't be charged for product usage in AWS Marketplace because they already
        /// paid for the product outside of AWS Marketplace.
        /// </para>
        /// </summary>
        public ByolPricingTerm ByolPricingTerm
        {
            get { return this._byolPricingTerm; }
            set { this._byolPricingTerm = value; }
        }

        // Check to see if ByolPricingTerm property is set
        internal bool IsSetByolPricingTerm()
        {
            return this._byolPricingTerm != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurableUpfrontPricingTerm. 
        /// <para>
        /// Defines a prepaid payment model that allows buyers to configure the entitlements they
        /// want to purchase and the duration.
        /// </para>
        /// </summary>
        public ConfigurableUpfrontPricingTerm ConfigurableUpfrontPricingTerm
        {
            get { return this._configurableUpfrontPricingTerm; }
            set { this._configurableUpfrontPricingTerm = value; }
        }

        // Check to see if ConfigurableUpfrontPricingTerm property is set
        internal bool IsSetConfigurableUpfrontPricingTerm()
        {
            return this._configurableUpfrontPricingTerm != null;
        }

        /// <summary>
        /// Gets and sets the property FixedUpfrontPricingTerm. 
        /// <para>
        /// Defines a pre-paid pricing model where the customers are charged a fixed upfront amount.
        /// </para>
        /// </summary>
        public FixedUpfrontPricingTerm FixedUpfrontPricingTerm
        {
            get { return this._fixedUpfrontPricingTerm; }
            set { this._fixedUpfrontPricingTerm = value; }
        }

        // Check to see if FixedUpfrontPricingTerm property is set
        internal bool IsSetFixedUpfrontPricingTerm()
        {
            return this._fixedUpfrontPricingTerm != null;
        }

        /// <summary>
        /// Gets and sets the property FreeTrialPricingTerm. 
        /// <para>
        /// Defines a short-term free pricing model where the buyers aren’t charged anything within
        /// a specified limit.
        /// </para>
        /// </summary>
        public FreeTrialPricingTerm FreeTrialPricingTerm
        {
            get { return this._freeTrialPricingTerm; }
            set { this._freeTrialPricingTerm = value; }
        }

        // Check to see if FreeTrialPricingTerm property is set
        internal bool IsSetFreeTrialPricingTerm()
        {
            return this._freeTrialPricingTerm != null;
        }

        /// <summary>
        /// Gets and sets the property LegalTerm. 
        /// <para>
        /// Defines the list of text agreements proposed to the acceptors. An example is the end
        /// user license agreement (EULA).
        /// </para>
        /// </summary>
        public LegalTerm LegalTerm
        {
            get { return this._legalTerm; }
            set { this._legalTerm = value; }
        }

        // Check to see if LegalTerm property is set
        internal bool IsSetLegalTerm()
        {
            return this._legalTerm != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentScheduleTerm. 
        /// <para>
        /// Defines an installment-based pricing model where customers are charged a fixed price
        /// on different dates during the agreement validity period. This is used most commonly
        /// for flexible payment schedule pricing.
        /// </para>
        /// </summary>
        public PaymentScheduleTerm PaymentScheduleTerm
        {
            get { return this._paymentScheduleTerm; }
            set { this._paymentScheduleTerm = value; }
        }

        // Check to see if PaymentScheduleTerm property is set
        internal bool IsSetPaymentScheduleTerm()
        {
            return this._paymentScheduleTerm != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringPaymentTerm. 
        /// <para>
        /// Defines a pricing model where customers are charged a fixed recurring price at the
        /// end of each billing period.
        /// </para>
        /// </summary>
        public RecurringPaymentTerm RecurringPaymentTerm
        {
            get { return this._recurringPaymentTerm; }
            set { this._recurringPaymentTerm = value; }
        }

        // Check to see if RecurringPaymentTerm property is set
        internal bool IsSetRecurringPaymentTerm()
        {
            return this._recurringPaymentTerm != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalTerm. 
        /// <para>
        /// Defines that on graceful expiration of the agreement (when the agreement ends on its
        /// pre-defined end date), a new agreement will be created using the accepted terms on
        /// the existing agreement. In other words, the agreement will be renewed. Presence of
        /// <c>RenewalTerm</c> in the offer document means that auto-renewal is allowed. Buyers
        /// will have the option to accept or decline auto-renewal at the offer acceptance/agreement
        /// creation. Buyers can also change this flag from <c>True</c> to <c>False</c> or <c>False</c>
        /// to <c>True</c> at anytime during the agreement's lifecycle.
        /// </para>
        /// </summary>
        public RenewalTerm RenewalTerm
        {
            get { return this._renewalTerm; }
            set { this._renewalTerm = value; }
        }

        // Check to see if RenewalTerm property is set
        internal bool IsSetRenewalTerm()
        {
            return this._renewalTerm != null;
        }

        /// <summary>
        /// Gets and sets the property SupportTerm. 
        /// <para>
        /// Defines the customer support available for the acceptors when they purchase the software.
        /// </para>
        /// </summary>
        public SupportTerm SupportTerm
        {
            get { return this._supportTerm; }
            set { this._supportTerm = value; }
        }

        // Check to see if SupportTerm property is set
        internal bool IsSetSupportTerm()
        {
            return this._supportTerm != null;
        }

        /// <summary>
        /// Gets and sets the property UsageBasedPricingTerm. 
        /// <para>
        /// Defines a usage-based pricing model (typically, pay-as-you-go pricing), where the
        /// customers are charged based on product usage.
        /// </para>
        /// </summary>
        public UsageBasedPricingTerm UsageBasedPricingTerm
        {
            get { return this._usageBasedPricingTerm; }
            set { this._usageBasedPricingTerm = value; }
        }

        // Check to see if UsageBasedPricingTerm property is set
        internal bool IsSetUsageBasedPricingTerm()
        {
            return this._usageBasedPricingTerm != null;
        }

        /// <summary>
        /// Gets and sets the property ValidityTerm. 
        /// <para>
        /// Defines the conditions that will keep an agreement created from this offer valid.
        /// </para>
        /// </summary>
        public ValidityTerm ValidityTerm
        {
            get { return this._validityTerm; }
            set { this._validityTerm = value; }
        }

        // Check to see if ValidityTerm property is set
        internal bool IsSetValidityTerm()
        {
            return this._validityTerm != null;
        }

    }
}