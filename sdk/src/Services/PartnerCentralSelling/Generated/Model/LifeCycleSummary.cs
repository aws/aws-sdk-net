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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// An object that contains a <c>LifeCycle</c> object's subset of fields.
    /// </summary>
    public partial class LifeCycleSummary
    {
        private ClosedLostReason _closedLostReason;
        private string _nextSteps;
        private string _reviewComments;
        private ReviewStatus _reviewStatus;
        private string _reviewStatusReason;
        private Stage _stage;
        private string _targetCloseDate;

        /// <summary>
        /// Gets and sets the property ClosedLostReason. 
        /// <para>
        /// Specifies the reason code when an opportunity is marked as <i>Closed Lost</i>. When
        /// you select an appropriate reason code, you communicate the context for closing the
        /// <c>Opportunity</c>, and aid in accurate reports and analysis of opportunity outcomes.
        /// </para>
        /// </summary>
        public ClosedLostReason ClosedLostReason
        {
            get { return this._closedLostReason; }
            set { this._closedLostReason = value; }
        }

        // Check to see if ClosedLostReason property is set
        internal bool IsSetClosedLostReason()
        {
            return this._closedLostReason != null;
        }

        /// <summary>
        /// Gets and sets the property NextSteps. 
        /// <para>
        /// Specifies the upcoming actions or tasks for the <c>Opportunity</c>. This field is
        /// utilized to communicate to Amazon Web Services the next actions required for the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=255)]
        public string NextSteps
        {
            get { return this._nextSteps; }
            set { this._nextSteps = value; }
        }

        // Check to see if NextSteps property is set
        internal bool IsSetNextSteps()
        {
            return this._nextSteps != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewComments. 
        /// <para>
        /// Indicates why an opportunity was sent back for further details. Partners must take
        /// corrective action based on the <c>ReviewComments</c>.
        /// </para>
        /// </summary>
        public string ReviewComments
        {
            get { return this._reviewComments; }
            set { this._reviewComments = value; }
        }

        // Check to see if ReviewComments property is set
        internal bool IsSetReviewComments()
        {
            return this._reviewComments != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// Indicates the review status of a partner referred opportunity. This field is read-only
        /// and only applicable for partner referrals. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending Submission: Not submitted for validation (editable).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submitted: Submitted for validation and not yet Amazon Web Services reviewed (read-only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Review: Undergoing Amazon Web Services validation (read-only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Action Required: Address any issues Amazon Web Services highlights. Use the <c>UpdateOpportunity</c>
        /// API action to update the opportunity, and ensure you make all required changes. Only
        /// these fields are editable when the <c>Lifecycle.ReviewStatus</c> is <c>Action Required</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Customer.Account.Address.City
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer.Account.Address.CountryCode
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer.Account.Address.PostalCode
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer.Account.Address.StateOrRegion
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer.Account.Address.StreetAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer.Account.WebsiteUrl
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LifeCycle.TargetCloseDate
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Project.ExpectedCustomerSpend.Amount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Project.ExpectedCustomerSpend.CurrencyCode
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Project.CustomerBusinessProblem
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PartnerOpportunityIdentifier
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After updates, the opportunity re-enters the validation phase. This process repeats
        /// until all issues are resolved, and the opportunity's <c>Lifecycle.ReviewStatus</c>
        /// is set to <c>Approved</c> or <c>Rejected</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Approved: Validated and converted into the Amazon Web Services seller's pipeline (editable).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rejected: Disqualified (read-only).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReviewStatus ReviewStatus
        {
            get { return this._reviewStatus; }
            set { this._reviewStatus = value; }
        }

        // Check to see if ReviewStatus property is set
        internal bool IsSetReviewStatus()
        {
            return this._reviewStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewStatusReason. 
        /// <para>
        /// Indicates the reason a specific decision was taken during the opportunity review process.
        /// This field combines the reasons for both disqualified and action required statuses,
        /// and provides clarity for why an opportunity was disqualified or required further action.
        /// </para>
        /// </summary>
        public string ReviewStatusReason
        {
            get { return this._reviewStatusReason; }
            set { this._reviewStatusReason = value; }
        }

        // Check to see if ReviewStatusReason property is set
        internal bool IsSetReviewStatusReason()
        {
            return this._reviewStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// Specifies the current stage of the <c>Opportunity</c>'s lifecycle as it maps to Amazon
        /// Web Services stages from the current stage in the partner CRM. This field provides
        /// a translated value of the stage, and offers insight into the <c>Opportunity</c>'s
        /// progression in the sales cycle, according to Amazon Web Services definitions.
        /// </para>
        ///  <note> 
        /// <para>
        /// A lead and a prospect must be further matured to a <c>Qualified</c> opportunity before
        /// submission. Opportunities that were closed/lost before submission aren't suitable
        /// for submission.
        /// </para>
        ///  </note> 
        /// <para>
        /// The descriptions of each sales stage are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Prospect: Amazon Web Services identifies the opportunity. It can be active (Comes
        /// directly from the end customer through a lead) or latent (Your account team believes
        /// it exists based on research, account plans, sales plays).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Qualified: Your account team engaged with the customer to discuss viability and understand
        /// requirements. The customer agreed that the opportunity is real, of interest, and may
        /// solve business/technical needs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Technical Validation: All parties understand the implementation plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Business Validation: Pricing was proposed, and all parties agree to the steps to close.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Committed: The customer signed the contract, but Amazon Web Services hasn't started
        /// billing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launched: The workload is complete, and Amazon Web Services has started billing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Closed Lost: The opportunity is lost, and there are no steps to move forward.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Stage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCloseDate. 
        /// <para>
        /// Specifies the date when Amazon Web Services expects to start significant billing,
        /// when the project finishes, and when it moves into production. This field informs the
        /// Amazon Web Services seller about when the opportunity launches and starts to incur
        /// Amazon Web Services usage.
        /// </para>
        ///  
        /// <para>
        /// Ensure the <c>Target Close Date</c> isn't in the past.
        /// </para>
        /// </summary>
        public string TargetCloseDate
        {
            get { return this._targetCloseDate; }
            set { this._targetCloseDate = value; }
        }

        // Check to see if TargetCloseDate property is set
        internal bool IsSetTargetCloseDate()
        {
            return this._targetCloseDate != null;
        }

    }
}