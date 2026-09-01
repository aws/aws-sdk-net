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
    /// A summary of the agreement, including top-level attributes (for example, the agreement
    /// ID, proposer, and acceptor).
    /// </summary>
    public partial class AgreementViewSummary
    {
        private DateTime? _acceptanceTime;
        private Acceptor _acceptor;
        private string _agreementId;
        private string _agreementType;
        private DateTime? _endTime;
        private EndTimeBehaviorReasonCode _endTimeBehaviorReasonCode;
        private EndTimeBehaviorType _endTimeBehaviorType;
        private List<Entitlement> _entitlements = AWSConfigs.InitializeCollections ? new List<Entitlement>() : null;
        private string _initialAgreementId;
        private DateTime? _lastUpdateTime;
        private ProposalSummary _proposalSummary;
        private Proposer _proposer;
        private DateTime? _startTime;
        private AgreementStatus _status;

        /// <summary>
        /// Gets and sets the property AcceptanceTime. 
        /// <para>
        /// The date and time that the agreement was accepted.
        /// </para>
        /// </summary>
        public DateTime? AcceptanceTime
        {
            get { return this._acceptanceTime; }
            set { this._acceptanceTime = value; }
        }

        // Check to see if AcceptanceTime property is set
        internal bool IsSetAcceptanceTime()
        {
            return this._acceptanceTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Acceptor. 
        /// <para>
        /// Details of the party accepting the agreement terms. This is commonly the buyer for
        /// <c>PurchaseAgreement.</c> 
        /// </para>
        /// </summary>
        public Acceptor Acceptor
        {
            get { return this._acceptor; }
            set { this._acceptor = value; }
        }

        // Check to see if Acceptor property is set
        internal bool IsSetAcceptor()
        {
            return this._acceptor != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementType. 
        /// <para>
        /// The type of agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementType
        {
            get { return this._agreementType; }
            set { this._agreementType = value; }
        }

        // Check to see if AgreementType property is set
        internal bool IsSetAgreementType()
        {
            return this._agreementType != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the agreement ends. The field is <c>null</c> for pay-as-you-go
        /// agreements, which don’t have end dates.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

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
        public EndTimeBehaviorReasonCode EndTimeBehaviorReasonCode
        {
            get { return this._endTimeBehaviorReasonCode; }
            set { this._endTimeBehaviorReasonCode = value; }
        }

        // Check to see if EndTimeBehaviorReasonCode property is set
        internal bool IsSetEndTimeBehaviorReasonCode()
        {
            return this._endTimeBehaviorReasonCode != null;
        }

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
        public EndTimeBehaviorType EndTimeBehaviorType
        {
            get { return this._endTimeBehaviorType; }
            set { this._endTimeBehaviorType = value; }
        }

        // Check to see if EndTimeBehaviorType property is set
        internal bool IsSetEndTimeBehaviorType()
        {
            return this._endTimeBehaviorType != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// A list of entitlements associated with the agreement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Entitlement> Entitlements
        {
            get { return this._entitlements; }
            set { this._entitlements = value; }
        }

        // Check to see if Entitlements property is set
        internal bool IsSetEntitlements()
        {
            return this._entitlements != null && (this._entitlements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=64)]
        public string InitialAgreementId
        {
            get { return this._initialAgreementId; }
            set { this._initialAgreementId = value; }
        }

        // Check to see if InitialAgreementId property is set
        internal bool IsSetInitialAgreementId()
        {
            return this._initialAgreementId != null;
        }

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
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProposalSummary. 
        /// <para>
        /// A summary of the proposal
        /// </para>
        /// </summary>
        public ProposalSummary ProposalSummary
        {
            get { return this._proposalSummary; }
            set { this._proposalSummary = value; }
        }

        // Check to see if ProposalSummary property is set
        internal bool IsSetProposalSummary()
        {
            return this._proposalSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Proposer. 
        /// <para>
        /// Details of the party proposing the agreement terms, most commonly the seller for <c>PurchaseAgreement</c>.
        /// </para>
        /// </summary>
        public Proposer Proposer
        {
            get { return this._proposer; }
            set { this._proposer = value; }
        }

        // Check to see if Proposer property is set
        internal bool IsSetProposer()
        {
            return this._proposer != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the agreement starts.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the agreement. 
        /// </para>
        /// </summary>
        public AgreementStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}