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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// An investment that is awarded upon completion of a defined outcome. This corresponds
    /// to the <c>OUTCOME_BASED</c> investment type and is claimed through <c>CreateContractualInvestmentAttestation</c>.
    /// </summary>
    public partial class OutcomeBasedInvestment
    {
        /// <summary>
        /// Gets and sets the property AttestationWindow. 
        /// <para>
        /// The time window, expressed as an interval with inclusive start and end dates, during
        /// which outcomes can be attested to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Interval AttestationWindow { get; set; }

        /// <summary>
        /// Checks to see if the AttestationWindow property is set.
        /// </summary>
        internal bool IsSetAttestationWindow() => this.AttestationWindow != null;

        /// <summary>
        /// Gets and sets the property DisbursedValue. 
        /// <para>
        /// The total value already disbursed against the investment. This value can be distributed
        /// among the investment accounts distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amount DisbursedValue { get; set; }

        /// <summary>
        /// Checks to see if the DisbursedValue property is set.
        /// </summary>
        internal bool IsSetDisbursedValue() => this.DisbursedValue != null;

        /// <summary>
        /// Gets and sets the property InvestmentId. 
        /// <para>
        /// The identifier of the investment, as returned by <c>ListContractualInvestments</c>.
        /// This value is 1–36 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string InvestmentId { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentId property is set.
        /// </summary>
        internal bool IsSetInvestmentId() => this.InvestmentId != null;

        /// <summary>
        /// Gets and sets the property InvestmentMultipliers. 
        /// <para>
        /// The multipliers used to compute the investment value from the attestation input. The
        /// list contains at most 200 multipliers. Multipliers are derived from the terms of the
        /// private pricing contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<InvestmentMultiplier> InvestmentMultipliers { get; set; } = AWSConfigs.InitializeCollections ? new List<InvestmentMultiplier>() : null;

        /// <summary>
        /// Checks to see if the InvestmentMultipliers property is set.
        /// </summary>
        internal bool IsSetInvestmentMultipliers() => this.InvestmentMultipliers != null && (this.InvestmentMultipliers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InvestmentRestrictions. 
        /// <para>
        /// The restrictions that cap the value that can be disbursed for the investment. The
        /// list contains at most 10 restrictions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<InvestmentRestriction> InvestmentRestrictions { get; set; } = AWSConfigs.InitializeCollections ? new List<InvestmentRestriction>() : null;

        /// <summary>
        /// Checks to see if the InvestmentRestrictions property is set.
        /// </summary>
        internal bool IsSetInvestmentRestrictions() => this.InvestmentRestrictions != null && (this.InvestmentRestrictions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutcomeDescription. 
        /// <para>
        /// The description of what must be completed to attest the outcome. This value is 1–2048
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string OutcomeDescription { get; set; }

        /// <summary>
        /// Checks to see if the OutcomeDescription property is set.
        /// </summary>
        internal bool IsSetOutcomeDescription() => this.OutcomeDescription != null;
    }
}
