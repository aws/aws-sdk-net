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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// An object that contains the <c>Opportunity</c> lifecycle's details.
    /// </summary>
    public partial class LifeCycle
    {
        /// <summary>
        /// Gets and sets the property ClosedLostReason. 
        /// <para>
        /// Specifies the reason code when an opportunity is marked as <i>Closed Lost</i>. When
        /// you select an appropriate reason code, you communicate the context for closing the
        /// <c>Opportunity</c>, and aid in accurate reports and analysis of opportunity outcomes.
        /// The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Customer Deficiency: The customer lacked necessary resources or capabilities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delay/Cancellation of Project: The project was delayed or canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Legal/Tax/Regulatory: Legal, tax, or regulatory issues prevented progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lost to Competitor—Google: The opportunity was lost to Google.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lost to Competitor—Microsoft: The opportunity was lost to Microsoft.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lost to Competitor—SoftLayer: The opportunity was lost to SoftLayer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lost to Competitor—VMWare: The opportunity was lost to VMWare.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lost to Competitor—Other: The opportunity was lost to a competitor not listed above.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No Opportunity: There was no opportunity to pursue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// On Premises Deployment: The customer chose an on-premises solution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Partner Gap: The partner lacked necessary resources or capabilities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Price: The price was not competitive or acceptable to the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Security/Compliance: Security or compliance issues prevented progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Technical Limitations: Technical limitations prevented progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer Experience: Issues related to the customer's experience impacted the decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Other: Any reason not covered by the other values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// People/Relationship/Governance: Issues related to people, relationships, or governance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Product/Technology: Issues related to the product or technology.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Financial/Commercial: Financial or commercial issues impacted the decision.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClosedLostReason ClosedLostReason { get; set; }

        /// <summary>
        /// Checks to see if the ClosedLostReason property is set.
        /// </summary>
        internal bool IsSetClosedLostReason() => this.ClosedLostReason != null;

        /// <summary>
        /// Gets and sets the property NextSteps. 
        /// <para>
        /// Specifies the upcoming actions or tasks for the <c>Opportunity</c>. Use this field
        /// to communicate with Amazon Web Services about the next actions required for the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string NextSteps { get; set; }

        /// <summary>
        /// Checks to see if the NextSteps property is set.
        /// </summary>
        internal bool IsSetNextSteps() => this.NextSteps != null;

        /// <summary>
        /// Gets and sets the property NextStepsHistory. 
        /// <para>
        /// Captures a chronological record of the next steps or actions planned or taken for
        /// the current opportunity, along with the timestamp.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<NextStepsHistory> NextStepsHistory { get; set; } = AWSConfigs.InitializeCollections ? new List<NextStepsHistory>() : null;

        /// <summary>
        /// Checks to see if the NextStepsHistory property is set.
        /// </summary>
        internal bool IsSetNextStepsHistory() => this.NextStepsHistory != null && (this.NextStepsHistory.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReviewComments. 
        /// <para>
        /// Contains detailed feedback from Amazon Web Services when requesting additional information
        /// from partners. Provides specific guidance on what partners need to provide or clarify
        /// for opportunity validation, complementing the <c>ReviewStatusReason</c> field.
        /// </para>
        /// </summary>
        public string ReviewComments { get; set; }

        /// <summary>
        /// Checks to see if the ReviewComments property is set.
        /// </summary>
        internal bool IsSetReviewComments() => this.ReviewComments != null;

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// Indicates the review status of an opportunity referred by a partner. This field is
        /// read-only and only applicable for partner referrals. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending Submission: Not submitted for validation (editable).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submitted: Submitted for validation, and Amazon Web Services hasn't reviewed it (read-only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Review: Amazon Web Services is validating (read-only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Action Required: Issues that Amazon Web Services highlights need to be addressed.
        /// Partners should use the <c>UpdateOpportunity</c> API action to update the opportunity
        /// and helps to ensure that all required changes are made. Only the following fields
        /// are editable when the <c>Lifecycle.ReviewStatus</c> is <c>Action Required</c>:
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
        /// Project.ExpectedMonthlyAWSRevenue.Amount
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Project.ExpectedMonthlyAWSRevenue.CurrencyCode
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
        public ReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReviewStatus property is set.
        /// </summary>
        internal bool IsSetReviewStatus() => this.ReviewStatus != null;

        /// <summary>
        /// Gets and sets the property ReviewStatusReason. 
        /// <para>
        /// Code indicating the validation decision during the Amazon Web Services opportunity
        /// review. Applies when status is <c>Rejected</c> or <c>Action Required</c>. Used to
        /// document validation results for AWS Partner Referrals and indicate when additional
        /// information is needed from partners as part of the APN Customer Engagement (ACE) program.
        /// </para>
        /// </summary>
        public string ReviewStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ReviewStatusReason property is set.
        /// </summary>
        internal bool IsSetReviewStatusReason() => this.ReviewStatusReason != null;

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
        /// Qualified: Your account team engaged with the customer to discuss viability and requirements.
        /// The customer agreed that the opportunity is real, of interest, and may solve business/technical
        /// needs.
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
        public Stage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;

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
        public string TargetCloseDate { get; set; }

        /// <summary>
        /// Checks to see if the TargetCloseDate property is set.
        /// </summary>
        internal bool IsSetTargetCloseDate() => this.TargetCloseDate != null;
    }
}
