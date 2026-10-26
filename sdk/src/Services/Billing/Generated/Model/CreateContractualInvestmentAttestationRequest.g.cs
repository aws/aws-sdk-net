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
    /// Container for the parameters to the CreateContractualInvestmentAttestation operation.
    /// Creates an attestation that claims an investment award for a completed milestone or
    /// outcome within a private pricing contract. Supply a <c>clientToken</c> to make the
    /// request idempotent so a safe retry does not create a duplicate attestation. This operation
    /// starts an asynchronous review and returns an <c>attestationId</c> while the attestation
    /// is pending.
    /// </summary>
    public partial class CreateContractualInvestmentAttestationRequest : AmazonBillingRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalRecipients. 
        /// <para>
        /// The email addresses to copy as viewers on the executive approval request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<AdditionalRecipient> AdditionalRecipients { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalRecipient>() : null;

        /// <summary>
        /// Checks to see if the AdditionalRecipients property is set.
        /// </summary>
        internal bool IsSetAdditionalRecipients() => this.AdditionalRecipients != null && (this.AdditionalRecipients.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApproverDetails. 
        /// <para>
        /// The details of the executive who authorized the attestation, under the terms of the
        /// private pricing contract. The executive receives a click-to-accept email to confirm
        /// the attestation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApproverDetails ApproverDetails { get; set; }

        /// <summary>
        /// Checks to see if the ApproverDetails property is set.
        /// </summary>
        internal bool IsSetApproverDetails() => this.ApproverDetails != null;

        /// <summary>
        /// Gets and sets the property AttestationDetails. 
        /// <para>
        /// The details of the attestation, including the value being claimed and how the resulting
        /// investment is distributed across investment accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttestationDetails AttestationDetails { get; set; }

        /// <summary>
        /// Checks to see if the AttestationDetails property is set.
        /// </summary>
        internal bool IsSetAttestationDetails() => this.AttestationDetails != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry completes without performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContractArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contract that contains the investment being
        /// attested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ContractArn { get; set; }

        /// <summary>
        /// Checks to see if the ContractArn property is set.
        /// </summary>
        internal bool IsSetContractArn() => this.ContractArn != null;

        /// <summary>
        /// Gets and sets the property ContractDocumentId. 
        /// <para>
        /// The contract ID from the contract document, located in the top-right corner of the
        /// private pricing contract pages. This value confirms that you have access to the contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 36)]
        public string ContractDocumentId { get; set; }

        /// <summary>
        /// Checks to see if the ContractDocumentId property is set.
        /// </summary>
        internal bool IsSetContractDocumentId() => this.ContractDocumentId != null;

        /// <summary>
        /// Gets and sets the property InvestmentDisbursedAt. 
        /// <para>
        /// The date on which the investment is disbursed to the investment accounts. The disbursement
        /// date is subject to review timelines.
        /// </para>
        /// </summary>
        public DateTime? InvestmentDisbursedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentDisbursedAt property is set.
        /// </summary>
        internal bool IsSetInvestmentDisbursedAt() => this.InvestmentDisbursedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InvestmentId. 
        /// <para>
        /// The identifier of the investment (outcome) being attested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string InvestmentId { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentId property is set.
        /// </summary>
        internal bool IsSetInvestmentId() => this.InvestmentId != null;

        /// <summary>
        /// Gets and sets the property InvestmentSummaryId. 
        /// <para>
        /// The identifier of the investment summary being attested. This is the parent to the
        /// investmentId.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string InvestmentSummaryId { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentSummaryId property is set.
        /// </summary>
        internal bool IsSetInvestmentSummaryId() => this.InvestmentSummaryId != null;
    }
}
