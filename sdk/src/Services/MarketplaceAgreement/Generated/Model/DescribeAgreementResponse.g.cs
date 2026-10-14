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
    /// This is the response object from the DescribeAgreement operation.
    /// </summary>
    public partial class DescribeAgreementResponse : AmazonWebServiceResponse
    {
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
        public DateTime? AcceptanceTime { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceTime property is set.
        /// </summary>
        internal bool IsSetAcceptanceTime() => this.AcceptanceTime.HasValue;

        /// <summary>
        /// Gets and sets the property Acceptor. 
        /// <para>
        /// The details of the party accepting the agreement terms. This is commonly the buyer
        /// for <c>PurchaseAgreement</c>.
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
        /// The type of agreement. Values are <c>PurchaseAgreement</c> or <c>VendorInsightsAgreement</c>.
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
        /// Gets and sets the property EndTimeBehavior. 
        /// <para>
        /// The behavior of the agreement when it reaches its end date. For example, whether the
        /// agreement renews, and if it doesn't, the reason why.
        /// </para>
        ///  
        /// <para>
        /// This field is present for every active agreement that has an end date. It is not present
        /// for an agreement that has no end date, because such an agreement never reaches an
        /// end time. Pay-as-you-go agreements are the most common example. It is also not present
        /// for an agreement that is no longer active.
        /// </para>
        /// </summary>
        public EndTimeBehavior EndTimeBehavior { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeBehavior property is set.
        /// </summary>
        internal bool IsSetEndTimeBehavior() => this.EndTimeBehavior != null;

        /// <summary>
        /// Gets and sets the property EstimatedCharges. 
        /// <para>
        /// The estimated cost of the agreement.
        /// </para>
        /// </summary>
        public EstimatedCharges EstimatedCharges { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCharges property is set.
        /// </summary>
        internal bool IsSetEstimatedCharges() => this.EstimatedCharges != null;

        /// <summary>
        /// Gets and sets the property InitialAgreementId. 
        /// <para>
        /// The unique identifier of the very first agreement in a chain of related agreements,
        /// such as renewals or replacements. It stays the same across all agreements in that
        /// chain, which lets you trace an agreement back to the original. When an agreement isn't
        /// derived from another agreement, its <c>InitialAgreementId</c> is its own <c>AgreementId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InitialAgreementId { get; set; }

        /// <summary>
        /// Checks to see if the InitialAgreementId property is set.
        /// </summary>
        internal bool IsSetInitialAgreementId() => this.InitialAgreementId != null;

        /// <summary>
        /// Gets and sets the property ProposalSummary. 
        /// <para>
        /// A summary of the proposal received from the proposer.
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
        /// The details of the party proposing the agreement terms. This is commonly the seller
        /// for <c>PurchaseAgreement</c>.
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
        ///  <c>TERMINATED</c> – The agreement ended before the defined end date because of an
        /// AWS termination (for example, a payment failure).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AgreementStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
