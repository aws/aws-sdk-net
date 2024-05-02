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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
    /// The Assignment data structure represents a single assignment of a HIT to a Worker.
    /// The assignment tracks the Worker's efforts to complete the HIT, and contains the results
    /// for later retrieval.
    /// </summary>
    public partial class Assignment
    {
        private DateTime? _acceptTime;
        private string _answer;
        private DateTime? _approvalTime;
        private string _assignmentId;
        private AssignmentStatus _assignmentStatus;
        private DateTime? _autoApprovalTime;
        private DateTime? _deadline;
        private string _hitId;
        private DateTime? _rejectionTime;
        private string _requesterFeedback;
        private DateTime? _submitTime;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property AcceptTime. 
        /// <para>
        ///  The date and time the Worker accepted the assignment.
        /// </para>
        /// </summary>
        public DateTime? AcceptTime
        {
            get { return this._acceptTime; }
            set { this._acceptTime = value; }
        }

        // Check to see if AcceptTime property is set
        internal bool IsSetAcceptTime()
        {
            return this._acceptTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Answer. 
        /// <para>
        ///  The Worker's answers submitted for the HIT contained in a QuestionFormAnswers document,
        /// if the Worker provides an answer. If the Worker does not provide any answers, Answer
        /// may contain a QuestionFormAnswers document, or Answer may be empty.
        /// </para>
        /// </summary>
        public string Answer
        {
            get { return this._answer; }
            set { this._answer = value; }
        }

        // Check to see if Answer property is set
        internal bool IsSetAnswer()
        {
            return this._answer != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalTime. 
        /// <para>
        ///  If the Worker has submitted results and the Requester has approved the results, ApprovalTime
        /// is the date and time the Requester approved the results. This value is omitted from
        /// the assignment if the Requester has not yet approved the results.
        /// </para>
        /// </summary>
        public DateTime? ApprovalTime
        {
            get { return this._approvalTime; }
            set { this._approvalTime = value; }
        }

        // Check to see if ApprovalTime property is set
        internal bool IsSetApprovalTime()
        {
            return this._approvalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        ///  A unique identifier for the assignment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AssignmentId
        {
            get { return this._assignmentId; }
            set { this._assignmentId = value; }
        }

        // Check to see if AssignmentId property is set
        internal bool IsSetAssignmentId()
        {
            return this._assignmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssignmentStatus. 
        /// <para>
        ///  The status of the assignment.
        /// </para>
        /// </summary>
        public AssignmentStatus AssignmentStatus
        {
            get { return this._assignmentStatus; }
            set { this._assignmentStatus = value; }
        }

        // Check to see if AssignmentStatus property is set
        internal bool IsSetAssignmentStatus()
        {
            return this._assignmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AutoApprovalTime. 
        /// <para>
        ///  If results have been submitted, AutoApprovalTime is the date and time the results
        /// of the assignment results are considered Approved automatically if they have not already
        /// been explicitly approved or rejected by the Requester. This value is derived from
        /// the auto-approval delay specified by the Requester in the HIT. This value is omitted
        /// from the assignment if the Worker has not yet submitted results.
        /// </para>
        /// </summary>
        public DateTime? AutoApprovalTime
        {
            get { return this._autoApprovalTime; }
            set { this._autoApprovalTime = value; }
        }

        // Check to see if AutoApprovalTime property is set
        internal bool IsSetAutoApprovalTime()
        {
            return this._autoApprovalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deadline. 
        /// <para>
        ///  The date and time of the deadline for the assignment. This value is derived from
        /// the deadline specification for the HIT and the date and time the Worker accepted the
        /// HIT.
        /// </para>
        /// </summary>
        public DateTime? Deadline
        {
            get { return this._deadline; }
            set { this._deadline = value; }
        }

        // Check to see if Deadline property is set
        internal bool IsSetDeadline()
        {
            return this._deadline.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        ///  The ID of the HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property RejectionTime. 
        /// <para>
        ///  If the Worker has submitted results and the Requester has rejected the results, RejectionTime
        /// is the date and time the Requester rejected the results.
        /// </para>
        /// </summary>
        public DateTime? RejectionTime
        {
            get { return this._rejectionTime; }
            set { this._rejectionTime = value; }
        }

        // Check to see if RejectionTime property is set
        internal bool IsSetRejectionTime()
        {
            return this._rejectionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterFeedback. 
        /// <para>
        ///  The feedback string included with the call to the ApproveAssignment operation or
        /// the RejectAssignment operation, if the Requester approved or rejected the assignment
        /// and specified feedback.
        /// </para>
        /// </summary>
        public string RequesterFeedback
        {
            get { return this._requesterFeedback; }
            set { this._requesterFeedback = value; }
        }

        // Check to see if RequesterFeedback property is set
        internal bool IsSetRequesterFeedback()
        {
            return this._requesterFeedback != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        ///  If the Worker has submitted results, SubmitTime is the date and time the assignment
        /// was submitted. This value is omitted from the assignment if the Worker has not yet
        /// submitted results.
        /// </para>
        /// </summary>
        public DateTime? SubmitTime
        {
            get { return this._submitTime; }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        ///  The ID of the Worker who accepted the HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string WorkerId
        {
            get { return this._workerId; }
            set { this._workerId = value; }
        }

        // Check to see if WorkerId property is set
        internal bool IsSetWorkerId()
        {
            return this._workerId != null;
        }

    }
}