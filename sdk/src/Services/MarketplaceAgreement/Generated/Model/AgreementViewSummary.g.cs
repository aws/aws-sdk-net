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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// A summary of the agreement, including top-level attributes (for example, the agreement
    /// ID, proposer, and acceptor).
    /// </summary>
    public partial class AgreementViewSummary
    {
        /// <summary>
        /// Gets and sets the property AcceptanceTime. 
        /// <para>
        /// The date and time that the agreement was accepted.
        /// </para>
        /// </summary>
        public DateTime? AcceptanceTime { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceTime property is set.
        /// </summary>
        internal bool IsSetAcceptanceTime() => this.AcceptanceTime.HasValue;

        /// <summary>
        /// Gets and sets the property Acceptor. 
        /// <para>
        /// Details of the party accepting the agreement terms. This is commonly the buyer for
        /// <c>PurchaseAgreement.</c> 
        /// </para>
        /// </summary>
        public Acceptor Acceptor { get; set; }

        /// <summary>
        /// Checks to see if the Acceptor property is set.
        /// </summary>
        internal bool IsSetAcceptor() => this.Acceptor != null;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property AgreementType. 
        /// <para>
        /// The type of agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementType { get; set; }

        /// <summary>
        /// Checks to see if the AgreementType property is set.
        /// </summary>
        internal bool IsSetAgreementType() => this.AgreementType != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the agreement ends. The field is <c>null</c> for pay-as-you-go
        /// agreements, which don’t have end dates.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimeBehaviorReasonCode. 
        /// <para>
        /// The reason why the agreement doesn't renew at its end date. The field is <c>null</c>
        /// when the agreement renews.
        /// </para>
        ///  
        /// <para>
        /// More than one reason can apply to the same agreement. When that happens, the operation
        /// returns only one reason code, and <c>PROPOSER_RENEW_OPTED_OUT</c> takes precedence
        /// over all others.
        /// </para>
        ///  
        /// <para>
        /// The <c>EnableAutoRenew</c> field reflects only the acceptor's preference, and doesn't
        /// reflect the other reasons an agreement might not renew.
        /// </para>
        ///  
        /// <para>
        /// Reason codes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROPOSER_RENEW_OPTED_OUT</c> – The proposer opted out of renewing the agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCEPTOR_RENEW_OPTED_OUT</c> – The acceptor opted out of renewing the agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_RENEWAL_TERM</c> – The accepted terms of the agreement don't include a renewal
        /// term, which is required for an agreement to renew.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RENEWAL_LIMIT_EXHAUSTED</c> – The agreement reached the maximum number of renewals
        /// allowed by its renewal term.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndTimeBehaviorReasonCode EndTimeBehaviorReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeBehaviorReasonCode property is set.
        /// </summary>
        internal bool IsSetEndTimeBehaviorReasonCode() => this.EndTimeBehaviorReasonCode != null;

        /// <summary>
        /// Gets and sets the property EndTimeBehaviorType. 
        /// <para>
        /// The behavior of the agreement when it reaches its end date. The field is <c>null</c>
        /// for agreements that have no end date, because those agreements never reach an end
        /// time.
        /// </para>
        ///  
        /// <para>
        /// Types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RENEW</c> – A new agreement is created from the accepted terms of this agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACE</c> – A new agreement is created from a different offer than the one this
        /// agreement was created from. This happens, for example, when a private offer reaches
        /// its end date and the acceptor transitions to the public offer for the product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRE</c> – The agreement ends and isn't renewed or replaced.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndTimeBehaviorType EndTimeBehaviorType { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeBehaviorType property is set.
        /// </summary>
        internal bool IsSetEndTimeBehaviorType() => this.EndTimeBehaviorType != null;

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// A list of entitlements associated with the agreement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Entitlement> Entitlements { get; set; } = AWSConfigs.InitializeCollections ? new List<Entitlement>() : null;

        /// <summary>
        /// Checks to see if the Entitlements property is set.
        /// </summary>
        internal bool IsSetEntitlements() => this.Entitlements != null && (this.Entitlements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InitialAgreementId. 
        /// <para>
        /// The unique identifier of the very first agreement in a chain of related agreements,
        /// such as renewals or replacements. It stays the same across all agreements in that
        /// chain, which lets you trace an agreement back to the original. You can also use it
        /// as the <c>InitialAgreementId</c> filter value to return every agreement in the same
        /// chain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InitialAgreementId { get; set; }

        /// <summary>
        /// Checks to see if the InitialAgreementId property is set.
        /// </summary>
        internal bool IsSetInitialAgreementId() => this.InitialAgreementId != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time when the agreement was last updated. An agreement is updated when
        /// any of its attributes or accepted terms change. Amendments, renewals, and a party
        /// changing whether the agreement renews are all examples.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>BeforeLastUpdateTime</c> and <c>AfterLastUpdateTime</c> filters to search
        /// on this value, and <c>LastUpdateTime</c> as the <c>SortBy</c> value to sort by it.
        /// Sorting by <c>LastUpdateTime</c> is supported only when <c>PartyType</c> is <c>Proposer</c>.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProposalSummary. 
        /// <para>
        /// A summary of the proposal
        /// </para>
        /// </summary>
        public ProposalSummary ProposalSummary { get; set; }

        /// <summary>
        /// Checks to see if the ProposalSummary property is set.
        /// </summary>
        internal bool IsSetProposalSummary() => this.ProposalSummary != null;

        /// <summary>
        /// Gets and sets the property Proposer. 
        /// <para>
        /// Details of the party proposing the agreement terms, most commonly the seller for <c>PurchaseAgreement</c>.
        /// </para>
        /// </summary>
        public Proposer Proposer { get; set; }

        /// <summary>
        /// Checks to see if the Proposer property is set.
        /// </summary>
        internal bool IsSetProposer() => this.Proposer != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the agreement starts.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the agreement. 
        /// </para>
        /// </summary>
        public AgreementStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
