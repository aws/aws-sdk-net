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
    /// ID, version, proposer, and acceptor).
    /// </summary>
    public partial class AgreementViewSummary
    {
        private DateTime? _acceptanceTime;
        private Acceptor _acceptor;
        private string _agreementId;
        private string _agreementType;
        private DateTime? _endTime;
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
        /// The type of agreement. Values are <c>PurchaseAgreement</c> or <c>VendorInsightsAgreement</c>.
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