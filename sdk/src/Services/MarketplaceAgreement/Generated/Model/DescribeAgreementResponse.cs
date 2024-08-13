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
    /// This is the response object from the DescribeAgreement operation.
    /// </summary>
    public partial class DescribeAgreementResponse : AmazonWebServiceResponse
    {
        private DateTime? _acceptanceTime;
        private Acceptor _acceptor;
        private string _agreementId;
        private string _agreementType;
        private DateTime? _endTime;
        private EstimatedCharges _estimatedCharges;
        private ProposalSummary _proposalSummary;
        private Proposer _proposer;
        private DateTime? _startTime;
        private AgreementStatus _status;

        /// <summary>
        /// Gets and sets the property AcceptanceTime. 
        /// <para>
        /// The date and time the offer was accepted or the agreement was created.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>AcceptanceTime</c> and <c>StartTime</c> can differ for future dated agreements
        /// (FDAs).
        /// </para>
        ///  </note>
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
        /// The details of the party accepting the agreement terms. This is commonly the buyer
        /// for <c>PurchaseAgreement</c>.
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
        /// Gets and sets the property EstimatedCharges. 
        /// <para>
        /// The estimated cost of the agreement.
        /// </para>
        /// </summary>
        public EstimatedCharges EstimatedCharges
        {
            get { return this._estimatedCharges; }
            set { this._estimatedCharges = value; }
        }

        // Check to see if EstimatedCharges property is set
        internal bool IsSetEstimatedCharges()
        {
            return this._estimatedCharges != null;
        }

        /// <summary>
        /// Gets and sets the property ProposalSummary. 
        /// <para>
        /// A summary of the proposal received from the proposer.
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
        /// The details of the party proposing the agreement terms. This is commonly the seller
        /// for <c>PurchaseAgreement</c>.
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
        ///  
        /// <para>
        /// Statuses include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> – The terms of the agreement are active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c> – The agreement ended without a specified reason.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> – The acceptor ended the agreement before the defined end date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c> – The agreement ended on the defined end date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RENEWED</c> – The agreement was renewed into a new agreement (for example, an
        /// auto-renewal).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACED</c> – The agreement was replaced using an agreement replacement offer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLED_BACK</c> (Only applicable to inactive agreement revisions) – The agreement
        /// revision has been rolled back because of an error. An earlier revision is now active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUPERCEDED</c> (Only applicable to inactive agreement revisions) – The agreement
        /// revision is no longer active and another agreement revision is now active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATED</c> – The agreement ended before the defined end date because of an
        /// AWS termination (for example, a payment failure).
        /// </para>
        ///  </li> </ul>
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