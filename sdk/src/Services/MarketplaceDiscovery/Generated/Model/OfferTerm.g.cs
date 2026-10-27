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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A term attached to an offer. Each element contains exactly one term type, such as
    /// a pricing term, legal term, or payment schedule term.
    /// </summary>
    public partial class OfferTerm
    {
        /// <summary>
        /// Gets and sets the property ByolPricingTerm.
        /// </summary>
        public ByolPricingTerm ByolPricingTerm { get; set; }

        /// <summary>
        /// Checks to see if the ByolPricingTerm property is set.
        /// </summary>
        internal bool IsSetByolPricingTerm() => this.ByolPricingTerm != null;

        /// <summary>
        /// Gets and sets the property ConfigurableUpfrontPricingTerm.
        /// </summary>
        public ConfigurableUpfrontPricingTerm ConfigurableUpfrontPricingTerm { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurableUpfrontPricingTerm property is set.
        /// </summary>
        internal bool IsSetConfigurableUpfrontPricingTerm() => this.ConfigurableUpfrontPricingTerm != null;

        /// <summary>
        /// Gets and sets the property FixedUpfrontPricingTerm.
        /// </summary>
        public FixedUpfrontPricingTerm FixedUpfrontPricingTerm { get; set; }

        /// <summary>
        /// Checks to see if the FixedUpfrontPricingTerm property is set.
        /// </summary>
        internal bool IsSetFixedUpfrontPricingTerm() => this.FixedUpfrontPricingTerm != null;

        /// <summary>
        /// Gets and sets the property FreeTrialPricingTerm.
        /// </summary>
        public FreeTrialPricingTerm FreeTrialPricingTerm { get; set; }

        /// <summary>
        /// Checks to see if the FreeTrialPricingTerm property is set.
        /// </summary>
        internal bool IsSetFreeTrialPricingTerm() => this.FreeTrialPricingTerm != null;

        /// <summary>
        /// Gets and sets the property LegalTerm.
        /// </summary>
        public LegalTerm LegalTerm { get; set; }

        /// <summary>
        /// Checks to see if the LegalTerm property is set.
        /// </summary>
        internal bool IsSetLegalTerm() => this.LegalTerm != null;

        /// <summary>
        /// Gets and sets the property NetPaymentTerm. 
        /// <para>
        /// A net payment term.
        /// </para>
        /// </summary>
        public NetPaymentTerm NetPaymentTerm { get; set; }

        /// <summary>
        /// Checks to see if the NetPaymentTerm property is set.
        /// </summary>
        internal bool IsSetNetPaymentTerm() => this.NetPaymentTerm != null;

        /// <summary>
        /// Gets and sets the property PaymentScheduleTerm.
        /// </summary>
        public PaymentScheduleTerm PaymentScheduleTerm { get; set; }

        /// <summary>
        /// Checks to see if the PaymentScheduleTerm property is set.
        /// </summary>
        internal bool IsSetPaymentScheduleTerm() => this.PaymentScheduleTerm != null;

        /// <summary>
        /// Gets and sets the property RecurringPaymentTerm.
        /// </summary>
        public RecurringPaymentTerm RecurringPaymentTerm { get; set; }

        /// <summary>
        /// Checks to see if the RecurringPaymentTerm property is set.
        /// </summary>
        internal bool IsSetRecurringPaymentTerm() => this.RecurringPaymentTerm != null;

        /// <summary>
        /// Gets and sets the property RenewalTerm.
        /// </summary>
        public RenewalTerm RenewalTerm { get; set; }

        /// <summary>
        /// Checks to see if the RenewalTerm property is set.
        /// </summary>
        internal bool IsSetRenewalTerm() => this.RenewalTerm != null;

        /// <summary>
        /// Gets and sets the property SupportTerm.
        /// </summary>
        public SupportTerm SupportTerm { get; set; }

        /// <summary>
        /// Checks to see if the SupportTerm property is set.
        /// </summary>
        internal bool IsSetSupportTerm() => this.SupportTerm != null;

        /// <summary>
        /// Gets and sets the property UsageBasedPricingTerm.
        /// </summary>
        public UsageBasedPricingTerm UsageBasedPricingTerm { get; set; }

        /// <summary>
        /// Checks to see if the UsageBasedPricingTerm property is set.
        /// </summary>
        internal bool IsSetUsageBasedPricingTerm() => this.UsageBasedPricingTerm != null;

        /// <summary>
        /// Gets and sets the property ValidityTerm.
        /// </summary>
        public ValidityTerm ValidityTerm { get; set; }

        /// <summary>
        /// Checks to see if the ValidityTerm property is set.
        /// </summary>
        internal bool IsSetValidityTerm() => this.ValidityTerm != null;

        /// <summary>
        /// Gets and sets the property VariablePaymentTerm.
        /// </summary>
        public VariablePaymentTerm VariablePaymentTerm { get; set; }

        /// <summary>
        /// Checks to see if the VariablePaymentTerm property is set.
        /// </summary>
        internal bool IsSetVariablePaymentTerm() => this.VariablePaymentTerm != null;
    }
}
