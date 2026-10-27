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
    /// A summary of a submitted investment attestation, as returned by <c>ListContractualInvestmentAttestations</c>.
    /// </summary>
    public partial class InvestmentAttestation
    {
        /// <summary>
        /// Gets and sets the property AttestationId. 
        /// <para>
        /// The identifier of the attestation. This value is returned by <c>CreateContractualInvestmentAttestation</c>
        /// and is used to cancel the attestation with <c>CancelContractualInvestmentAttestation</c>.
        /// This value is 1–36 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string AttestationId { get; set; }

        /// <summary>
        /// Checks to see if the AttestationId property is set.
        /// </summary>
        internal bool IsSetAttestationId() => this.AttestationId != null;

        /// <summary>
        /// Gets and sets the property AttestationStatus. 
        /// <para>
        /// The current status of the attestation. Valid values are <c>PENDING_REVIEW</c>, <c>PENDING_C_LEVEL_APPROVAL</c>,
        /// <c>PENDING_CANCELLATION</c>, <c>REJECTED</c>, <c>CANCELLED</c>, and <c>DISBURSED</c>.
        /// The values <c>DISBURSED</c>, <c>REJECTED</c>, and <c>CANCELLED</c> are terminal. The
        /// other values indicate the attestation is still in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvestmentAttestationStatus AttestationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AttestationStatus property is set.
        /// </summary>
        internal bool IsSetAttestationStatus() => this.AttestationStatus != null;

        /// <summary>
        /// Gets and sets the property AttestedAt. 
        /// <para>
        /// The date on which the attestation was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AttestedAt { get; set; }

        /// <summary>
        /// Checks to see if the AttestedAt property is set.
        /// </summary>
        internal bool IsSetAttestedAt() => this.AttestedAt.HasValue;

        /// <summary>
        /// Gets and sets the property AttestedValue. 
        /// <para>
        /// The monetary value attested.
        /// </para>
        /// </summary>
        public Amount AttestedValue { get; set; }

        /// <summary>
        /// Checks to see if the AttestedValue property is set.
        /// </summary>
        internal bool IsSetAttestedValue() => this.AttestedValue != null;

        /// <summary>
        /// Gets and sets the property InvestmentDisbursedAt. 
        /// <para>
        /// The start date on which the investment is disbursed to the investment accounts. This
        /// is not the same as the time of disbursement, but reflects the date you submitted with
        /// the attestation.
        /// </para>
        /// </summary>
        public DateTime? InvestmentDisbursedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentDisbursedAt property is set.
        /// </summary>
        internal bool IsSetInvestmentDisbursedAt() => this.InvestmentDisbursedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InvestmentDistributions. 
        /// <para>
        /// The distribution of the attested investment across the eligible investment accounts.
        /// The list contains at most 200 distributions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<InvestmentDistribution> InvestmentDistributions { get; set; } = AWSConfigs.InitializeCollections ? new List<InvestmentDistribution>() : null;

        /// <summary>
        /// Checks to see if the InvestmentDistributions property is set.
        /// </summary>
        internal bool IsSetInvestmentDistributions() => this.InvestmentDistributions != null && (this.InvestmentDistributions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InvestmentId. 
        /// <para>
        /// The identifier of the investment that was attested, as returned by <c>ListContractualInvestments</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string InvestmentId { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentId property is set.
        /// </summary>
        internal bool IsSetInvestmentId() => this.InvestmentId != null;

        /// <summary>
        /// Gets and sets the property InvestmentName. 
        /// <para>
        /// The name of the investment summary that contains the attested outcome. This value
        /// is 1–400 characters.
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
        /// The identifier of the investment summary that was attested, as returned by <c>ListContractualInvestmentSummaries</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string InvestmentSummaryId { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentSummaryId property is set.
        /// </summary>
        internal bool IsSetInvestmentSummaryId() => this.InvestmentSummaryId != null;

        /// <summary>
        /// Gets and sets the property IsCancellable. 
        /// <para>
        /// Indicates whether the attestation can be canceled with <c>CancelContractualInvestmentAttestation</c>.
        /// </para>
        /// </summary>
        public bool? IsCancellable { get; set; }

        /// <summary>
        /// Checks to see if the IsCancellable property is set.
        /// </summary>
        internal bool IsSetIsCancellable() => this.IsCancellable.HasValue;

        /// <summary>
        /// Gets and sets the property OutcomeDescription. 
        /// <para>
        /// The description of the attested outcome. This value is 1–2048 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string OutcomeDescription { get; set; }

        /// <summary>
        /// Checks to see if the OutcomeDescription property is set.
        /// </summary>
        internal bool IsSetOutcomeDescription() => this.OutcomeDescription != null;

        /// <summary>
        /// Gets and sets the property RejectionReasons. 
        /// <para>
        /// The reasons the attestation was rejected. This value is present only when <c>attestationStatus</c>
        /// is <c>REJECTED</c>. The list contains at most 30 reasons.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 30)]
        public List<string> RejectionReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RejectionReasons property is set.
        /// </summary>
        internal bool IsSetRejectionReasons() => this.RejectionReasons != null && (this.RejectionReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date on which the attestation was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
