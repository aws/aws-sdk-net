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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A term attached to an offer. Each element contains exactly one term type, such as
    /// a pricing term, legal term, or payment schedule term.
    /// </summary>
    public partial class OfferTerm
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
        private VariablePaymentTerm _variablePaymentTerm;

        /// <summary>
        /// Gets and sets the property ByolPricingTerm.
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

        /// <summary>
        /// Gets and sets the property VariablePaymentTerm.
        /// </summary>
        public VariablePaymentTerm VariablePaymentTerm
        {
            get { return this._variablePaymentTerm; }
            set { this._variablePaymentTerm = value; }
        }

        // Check to see if VariablePaymentTerm property is set
        internal bool IsSetVariablePaymentTerm()
        {
            return this._variablePaymentTerm != null;
        }

    }
}