/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// The HIT data structure represents a single HIT, including all the information necessary
    /// for a Worker to accept and complete the HIT.
    /// </summary>
    public partial class HIT
    {
        private long? _assignmentDurationInSeconds;
        private long? _autoApprovalDelayInSeconds;
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _expiration;
        private string _hitGroupId;
        private string _hitId;
        private string _hitLayoutId;
        private HITReviewStatus _hitReviewStatus;
        private HITStatus _hitStatus;
        private string _hitTypeId;
        private string _keywords;
        private int? _maxAssignments;
        private int? _numberOfAssignmentsAvailable;
        private int? _numberOfAssignmentsCompleted;
        private int? _numberOfAssignmentsPending;
        private List<QualificationRequirement> _qualificationRequirements = new List<QualificationRequirement>();
        private string _question;
        private string _requesterAnnotation;
        private string _reward;
        private string _title;

        /// <summary>
        /// Gets and sets the property AssignmentDurationInSeconds. 
        /// <para>
        ///  The length of time, in seconds, that a Worker has to complete the HIT after accepting
        /// it.
        /// </para>
        /// </summary>
        public long AssignmentDurationInSeconds
        {
            get { return this._assignmentDurationInSeconds.GetValueOrDefault(); }
            set { this._assignmentDurationInSeconds = value; }
        }

        // Check to see if AssignmentDurationInSeconds property is set
        internal bool IsSetAssignmentDurationInSeconds()
        {
            return this._assignmentDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoApprovalDelayInSeconds. 
        /// <para>
        /// The amount of time, in seconds, after the Worker submits an assignment for the HIT
        /// that the results are automatically approved by Amazon Mechanical Turk. This is the
        /// amount of time the Requester has to reject an assignment submitted by a Worker before
        /// the assignment is auto-approved and the Worker is paid. 
        /// </para>
        /// </summary>
        public long AutoApprovalDelayInSeconds
        {
            get { return this._autoApprovalDelayInSeconds.GetValueOrDefault(); }
            set { this._autoApprovalDelayInSeconds = value; }
        }

        // Check to see if AutoApprovalDelayInSeconds property is set
        internal bool IsSetAutoApprovalDelayInSeconds()
        {
            return this._autoApprovalDelayInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The date and time the HIT was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A general description of the HIT.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date and time the HIT expires.
        /// </para>
        /// </summary>
        public DateTime Expiration
        {
            get { return this._expiration.GetValueOrDefault(); }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HITGroupId. 
        /// <para>
        ///  The ID of the HIT Group of this HIT.
        /// </para>
        /// </summary>
        public string HITGroupId
        {
            get { return this._hitGroupId; }
            set { this._hitGroupId = value; }
        }

        // Check to see if HITGroupId property is set
        internal bool IsSetHITGroupId()
        {
            return this._hitGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        ///  A unique identifier for the HIT.
        /// </para>
        /// </summary>
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

        /// <summary>
        /// Gets and sets the property HITLayoutId. 
        /// <para>
        ///  The ID of the HIT Layout of this HIT.
        /// </para>
        /// </summary>
        public string HITLayoutId
        {
            get { return this._hitLayoutId; }
            set { this._hitLayoutId = value; }
        }

        // Check to see if HITLayoutId property is set
        internal bool IsSetHITLayoutId()
        {
            return this._hitLayoutId != null;
        }

        /// <summary>
        /// Gets and sets the property HITReviewStatus. 
        /// <para>
        ///  Indicates the review status of the HIT. Valid Values are NotReviewed | MarkedForReview
        /// | ReviewedAppropriate | ReviewedInappropriate.
        /// </para>
        /// </summary>
        public HITReviewStatus HITReviewStatus
        {
            get { return this._hitReviewStatus; }
            set { this._hitReviewStatus = value; }
        }

        // Check to see if HITReviewStatus property is set
        internal bool IsSetHITReviewStatus()
        {
            return this._hitReviewStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HITStatus. 
        /// <para>
        /// The status of the HIT and its assignments. Valid Values are Assignable | Unassignable
        /// | Reviewable | Reviewing | Disposed. 
        /// </para>
        /// </summary>
        public HITStatus HITStatus
        {
            get { return this._hitStatus; }
            set { this._hitStatus = value; }
        }

        // Check to see if HITStatus property is set
        internal bool IsSetHITStatus()
        {
            return this._hitStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HITTypeId. 
        /// <para>
        /// The ID of the HIT type of this HIT
        /// </para>
        /// </summary>
        public string HITTypeId
        {
            get { return this._hitTypeId; }
            set { this._hitTypeId = value; }
        }

        // Check to see if HITTypeId property is set
        internal bool IsSetHITTypeId()
        {
            return this._hitTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        ///  One or more words or phrases that describe the HIT, separated by commas. Search terms
        /// similar to the keywords of a HIT are more likely to have the HIT in the search results.
        /// </para>
        /// </summary>
        public string Keywords
        {
            get { return this._keywords; }
            set { this._keywords = value; }
        }

        // Check to see if Keywords property is set
        internal bool IsSetKeywords()
        {
            return this._keywords != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAssignments. 
        /// <para>
        /// The number of times the HIT can be accepted and completed before the HIT becomes unavailable.
        /// 
        /// </para>
        /// </summary>
        public int MaxAssignments
        {
            get { return this._maxAssignments.GetValueOrDefault(); }
            set { this._maxAssignments = value; }
        }

        // Check to see if MaxAssignments property is set
        internal bool IsSetMaxAssignments()
        {
            return this._maxAssignments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssignmentsAvailable. 
        /// <para>
        ///  The number of assignments for this HIT that are available for Workers to accept.
        /// </para>
        /// </summary>
        public int NumberOfAssignmentsAvailable
        {
            get { return this._numberOfAssignmentsAvailable.GetValueOrDefault(); }
            set { this._numberOfAssignmentsAvailable = value; }
        }

        // Check to see if NumberOfAssignmentsAvailable property is set
        internal bool IsSetNumberOfAssignmentsAvailable()
        {
            return this._numberOfAssignmentsAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssignmentsCompleted. 
        /// <para>
        ///  The number of assignments for this HIT that have been approved or rejected.
        /// </para>
        /// </summary>
        public int NumberOfAssignmentsCompleted
        {
            get { return this._numberOfAssignmentsCompleted.GetValueOrDefault(); }
            set { this._numberOfAssignmentsCompleted = value; }
        }

        // Check to see if NumberOfAssignmentsCompleted property is set
        internal bool IsSetNumberOfAssignmentsCompleted()
        {
            return this._numberOfAssignmentsCompleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssignmentsPending. 
        /// <para>
        ///  The number of assignments for this HIT that are being previewed or have been accepted
        /// by Workers, but have not yet been submitted, returned, or abandoned.
        /// </para>
        /// </summary>
        public int NumberOfAssignmentsPending
        {
            get { return this._numberOfAssignmentsPending.GetValueOrDefault(); }
            set { this._numberOfAssignmentsPending = value; }
        }

        // Check to see if NumberOfAssignmentsPending property is set
        internal bool IsSetNumberOfAssignmentsPending()
        {
            return this._numberOfAssignmentsPending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualificationRequirements. 
        /// <para>
        ///  Conditions that a Worker's Qualifications must meet in order to accept the HIT. A
        /// HIT can have between zero and ten Qualification requirements. All requirements must
        /// be met in order for a Worker to accept the HIT. Additionally, other actions can be
        /// restricted using the <code>ActionsGuarded</code> field on each <code>QualificationRequirement</code>
        /// structure. 
        /// </para>
        /// </summary>
        public List<QualificationRequirement> QualificationRequirements
        {
            get { return this._qualificationRequirements; }
            set { this._qualificationRequirements = value; }
        }

        // Check to see if QualificationRequirements property is set
        internal bool IsSetQualificationRequirements()
        {
            return this._qualificationRequirements != null && this._qualificationRequirements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        ///  The data the Worker completing the HIT uses produce the results. This is either either
        /// a QuestionForm, HTMLQuestion or an ExternalQuestion data structure.
        /// </para>
        /// </summary>
        public string Question
        {
            get { return this._question; }
            set { this._question = value; }
        }

        // Check to see if Question property is set
        internal bool IsSetQuestion()
        {
            return this._question != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterAnnotation. 
        /// <para>
        ///  An arbitrary data field the Requester who created the HIT can use. This field is
        /// visible only to the creator of the HIT.
        /// </para>
        /// </summary>
        public string RequesterAnnotation
        {
            get { return this._requesterAnnotation; }
            set { this._requesterAnnotation = value; }
        }

        // Check to see if RequesterAnnotation property is set
        internal bool IsSetRequesterAnnotation()
        {
            return this._requesterAnnotation != null;
        }

        /// <summary>
        /// Gets and sets the property Reward.
        /// </summary>
        public string Reward
        {
            get { return this._reward; }
            set { this._reward = value; }
        }

        // Check to see if Reward property is set
        internal bool IsSetReward()
        {
            return this._reward != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  The title of the HIT.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}