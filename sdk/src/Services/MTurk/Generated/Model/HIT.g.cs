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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// The HIT data structure represents a single HIT, including all the information necessary
    /// for a Worker to accept and complete the HIT.
    /// </summary>
    public partial class HIT
    {
        /// <summary>
        /// Gets and sets the property AssignmentDurationInSeconds. 
        /// <para>
        ///  The length of time, in seconds, that a Worker has to complete the HIT after accepting
        /// it.
        /// </para>
        /// </summary>
        public long? AssignmentDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetAssignmentDurationInSeconds() => this.AssignmentDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property AutoApprovalDelayInSeconds. 
        /// <para>
        /// The amount of time, in seconds, after the Worker submits an assignment for the HIT
        /// that the results are automatically approved by Amazon Mechanical Turk. This is the
        /// amount of time the Requester has to reject an assignment submitted by a Worker before
        /// the assignment is auto-approved and the Worker is paid. 
        /// </para>
        /// </summary>
        public long? AutoApprovalDelayInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AutoApprovalDelayInSeconds property is set.
        /// </summary>
        internal bool IsSetAutoApprovalDelayInSeconds() => this.AutoApprovalDelayInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The date and time the HIT was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A general description of the HIT.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date and time the HIT expires.
        /// </para>
        /// </summary>
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property HITGroupId. 
        /// <para>
        ///  The ID of the HIT Group of this HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HITGroupId { get; set; }

        /// <summary>
        /// Checks to see if the HITGroupId property is set.
        /// </summary>
        internal bool IsSetHITGroupId() => this.HITGroupId != null;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        ///  A unique identifier for the HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HITId { get; set; }

        /// <summary>
        /// Checks to see if the HITId property is set.
        /// </summary>
        internal bool IsSetHITId() => this.HITId != null;

        /// <summary>
        /// Gets and sets the property HITLayoutId. 
        /// <para>
        ///  The ID of the HIT Layout of this HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HITLayoutId { get; set; }

        /// <summary>
        /// Checks to see if the HITLayoutId property is set.
        /// </summary>
        internal bool IsSetHITLayoutId() => this.HITLayoutId != null;

        /// <summary>
        /// Gets and sets the property HITReviewStatus. 
        /// <para>
        ///  Indicates the review status of the HIT. Valid Values are NotReviewed | MarkedForReview
        /// | ReviewedAppropriate | ReviewedInappropriate.
        /// </para>
        /// </summary>
        public HITReviewStatus HITReviewStatus { get; set; }

        /// <summary>
        /// Checks to see if the HITReviewStatus property is set.
        /// </summary>
        internal bool IsSetHITReviewStatus() => this.HITReviewStatus != null;

        /// <summary>
        /// Gets and sets the property HITStatus. 
        /// <para>
        /// The status of the HIT and its assignments. Valid Values are Assignable | Unassignable
        /// | Reviewable | Reviewing | Disposed. 
        /// </para>
        /// </summary>
        public HITStatus HITStatus { get; set; }

        /// <summary>
        /// Checks to see if the HITStatus property is set.
        /// </summary>
        internal bool IsSetHITStatus() => this.HITStatus != null;

        /// <summary>
        /// Gets and sets the property HITTypeId. 
        /// <para>
        /// The ID of the HIT type of this HIT
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HITTypeId { get; set; }

        /// <summary>
        /// Checks to see if the HITTypeId property is set.
        /// </summary>
        internal bool IsSetHITTypeId() => this.HITTypeId != null;

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        ///  One or more words or phrases that describe the HIT, separated by commas. Search terms
        /// similar to the keywords of a HIT are more likely to have the HIT in the search results.
        /// </para>
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Checks to see if the Keywords property is set.
        /// </summary>
        internal bool IsSetKeywords() => this.Keywords != null;

        /// <summary>
        /// Gets and sets the property MaxAssignments. 
        /// <para>
        /// The number of times the HIT can be accepted and completed before the HIT becomes unavailable.
        /// 
        /// </para>
        /// </summary>
        public int? MaxAssignments { get; set; }

        /// <summary>
        /// Checks to see if the MaxAssignments property is set.
        /// </summary>
        internal bool IsSetMaxAssignments() => this.MaxAssignments.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssignmentsAvailable. 
        /// <para>
        ///  The number of assignments for this HIT that are available for Workers to accept.
        /// </para>
        /// </summary>
        public int? NumberOfAssignmentsAvailable { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssignmentsAvailable property is set.
        /// </summary>
        internal bool IsSetNumberOfAssignmentsAvailable() => this.NumberOfAssignmentsAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssignmentsCompleted. 
        /// <para>
        ///  The number of assignments for this HIT that have been approved or rejected.
        /// </para>
        /// </summary>
        public int? NumberOfAssignmentsCompleted { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssignmentsCompleted property is set.
        /// </summary>
        internal bool IsSetNumberOfAssignmentsCompleted() => this.NumberOfAssignmentsCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssignmentsPending. 
        /// <para>
        ///  The number of assignments for this HIT that are being previewed or have been accepted
        /// by Workers, but have not yet been submitted, returned, or abandoned.
        /// </para>
        /// </summary>
        public int? NumberOfAssignmentsPending { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssignmentsPending property is set.
        /// </summary>
        internal bool IsSetNumberOfAssignmentsPending() => this.NumberOfAssignmentsPending.HasValue;

        /// <summary>
        /// Gets and sets the property QualificationRequirements. 
        /// <para>
        ///  Conditions that a Worker's Qualifications must meet in order to accept the HIT. A
        /// HIT can have between zero and ten Qualification requirements. All requirements must
        /// be met in order for a Worker to accept the HIT. Additionally, other actions can be
        /// restricted using the <c>ActionsGuarded</c> field on each <c>QualificationRequirement</c>
        /// structure. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QualificationRequirement> QualificationRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<QualificationRequirement>() : null;

        /// <summary>
        /// Checks to see if the QualificationRequirements property is set.
        /// </summary>
        internal bool IsSetQualificationRequirements() => this.QualificationRequirements != null && (this.QualificationRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        ///  The data the Worker completing the HIT uses produce the results. This is either either
        /// a QuestionForm, HTMLQuestion or an ExternalQuestion data structure.
        /// </para>
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Checks to see if the Question property is set.
        /// </summary>
        internal bool IsSetQuestion() => this.Question != null;

        /// <summary>
        /// Gets and sets the property RequesterAnnotation. 
        /// <para>
        ///  An arbitrary data field the Requester who created the HIT can use. This field is
        /// visible only to the creator of the HIT.
        /// </para>
        /// </summary>
        public string RequesterAnnotation { get; set; }

        /// <summary>
        /// Checks to see if the RequesterAnnotation property is set.
        /// </summary>
        internal bool IsSetRequesterAnnotation() => this.RequesterAnnotation != null;

        /// <summary>
        /// Gets and sets the property Reward.
        /// </summary>
        public string Reward { get; set; }

        /// <summary>
        /// Checks to see if the Reward property is set.
        /// </summary>
        internal bool IsSetReward() => this.Reward != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  The title of the HIT.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
