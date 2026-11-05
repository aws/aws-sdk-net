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
    /// Detailed information about an investment summary within a contract or a private pricing
    /// addendum.
    /// </summary>
    public partial class InvestmentSummary
    {
        /// <summary>
        /// Gets and sets the property InvestmentName. 
        /// <para>
        /// The name of the investment summary, used to reference the investment against a term
        /// in the physical contract. This value is 1–400 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 400)]
        public string InvestmentName { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentName property is set.
        /// </summary>
        internal bool IsSetInvestmentName() => this.InvestmentName != null;

        /// <summary>
        /// Gets and sets the property InvestmentSummaryId. 
        /// <para>
        /// The identifier of the investment summary. Pass this value to <c>ListContractualInvestments</c>
        /// to list the investments within the summary, and to <c>CreateContractualInvestmentAttestation</c>
        /// to attest an investment. This value is 1–36 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string InvestmentSummaryId { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentSummaryId property is set.
        /// </summary>
        internal bool IsSetInvestmentSummaryId() => this.InvestmentSummaryId != null;

        /// <summary>
        /// Gets and sets the property InvestmentType. 
        /// <para>
        /// The type of the investment summary. Valid values are <c>MILESTONE_BASED</c> and <c>OUTCOME_BASED</c>.
        /// <c>OUTCOME_BASED</c> investments can be attested to, upon completion of outcomes.
        /// <c>MILESTONE_BASED</c> are automatically triggered by Amazon Web Services, based on
        /// the time schedule in the contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvestmentType InvestmentType { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentType property is set.
        /// </summary>
        internal bool IsSetInvestmentType() => this.InvestmentType != null;

        /// <summary>
        /// Gets and sets the property MaxAllowedInvestmentDisbursementValue. 
        /// <para>
        /// The maximum monetary value that can be disbursed against the investment summary, inclusive
        /// of all outcomes combined under the summary.
        /// </para>
        /// </summary>
        public Amount MaxAllowedInvestmentDisbursementValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllowedInvestmentDisbursementValue property is set.
        /// </summary>
        internal bool IsSetMaxAllowedInvestmentDisbursementValue() => this.MaxAllowedInvestmentDisbursementValue != null;
    }
}
