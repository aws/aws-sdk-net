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
    /// The Assignment data structure represents a single assignment of a HIT to a Worker.
    /// The assignment tracks the Worker's efforts to complete the HIT, and contains the results
    /// for later retrieval.
    /// </summary>
    public partial class Assignment
    {
        /// <summary>
        /// Gets and sets the property AcceptTime. 
        /// <para>
        ///  The date and time the Worker accepted the assignment.
        /// </para>
        /// </summary>
        public DateTime? AcceptTime { get; set; }

        /// <summary>
        /// Checks to see if the AcceptTime property is set.
        /// </summary>
        internal bool IsSetAcceptTime() => this.AcceptTime.HasValue;

        /// <summary>
        /// Gets and sets the property Answer. 
        /// <para>
        ///  The Worker's answers submitted for the HIT contained in a QuestionFormAnswers document,
        /// if the Worker provides an answer. If the Worker does not provide any answers, Answer
        /// may contain a QuestionFormAnswers document, or Answer may be empty.
        /// </para>
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// Checks to see if the Answer property is set.
        /// </summary>
        internal bool IsSetAnswer() => this.Answer != null;

        /// <summary>
        /// Gets and sets the property ApprovalTime. 
        /// <para>
        ///  If the Worker has submitted results and the Requester has approved the results, ApprovalTime
        /// is the date and time the Requester approved the results. This value is omitted from
        /// the assignment if the Requester has not yet approved the results.
        /// </para>
        /// </summary>
        public DateTime? ApprovalTime { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalTime property is set.
        /// </summary>
        internal bool IsSetApprovalTime() => this.ApprovalTime.HasValue;

        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        ///  A unique identifier for the assignment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AssignmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentId property is set.
        /// </summary>
        internal bool IsSetAssignmentId() => this.AssignmentId != null;

        /// <summary>
        /// Gets and sets the property AssignmentStatus. 
        /// <para>
        ///  The status of the assignment.
        /// </para>
        /// </summary>
        public AssignmentStatus AssignmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentStatus property is set.
        /// </summary>
        internal bool IsSetAssignmentStatus() => this.AssignmentStatus != null;

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
        public DateTime? AutoApprovalTime { get; set; }

        /// <summary>
        /// Checks to see if the AutoApprovalTime property is set.
        /// </summary>
        internal bool IsSetAutoApprovalTime() => this.AutoApprovalTime.HasValue;

        /// <summary>
        /// Gets and sets the property Deadline. 
        /// <para>
        ///  The date and time of the deadline for the assignment. This value is derived from
        /// the deadline specification for the HIT and the date and time the Worker accepted the
        /// HIT.
        /// </para>
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Checks to see if the Deadline property is set.
        /// </summary>
        internal bool IsSetDeadline() => this.Deadline.HasValue;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        ///  The ID of the HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HITId { get; set; }

        /// <summary>
        /// Checks to see if the HITId property is set.
        /// </summary>
        internal bool IsSetHITId() => this.HITId != null;

        /// <summary>
        /// Gets and sets the property RejectionTime. 
        /// <para>
        ///  If the Worker has submitted results and the Requester has rejected the results, RejectionTime
        /// is the date and time the Requester rejected the results.
        /// </para>
        /// </summary>
        public DateTime? RejectionTime { get; set; }

        /// <summary>
        /// Checks to see if the RejectionTime property is set.
        /// </summary>
        internal bool IsSetRejectionTime() => this.RejectionTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequesterFeedback. 
        /// <para>
        ///  The feedback string included with the call to the ApproveAssignment operation or
        /// the RejectAssignment operation, if the Requester approved or rejected the assignment
        /// and specified feedback.
        /// </para>
        /// </summary>
        public string RequesterFeedback { get; set; }

        /// <summary>
        /// Checks to see if the RequesterFeedback property is set.
        /// </summary>
        internal bool IsSetRequesterFeedback() => this.RequesterFeedback != null;

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        ///  If the Worker has submitted results, SubmitTime is the date and time the assignment
        /// was submitted. This value is omitted from the assignment if the Worker has not yet
        /// submitted results.
        /// </para>
        /// </summary>
        public DateTime? SubmitTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTime property is set.
        /// </summary>
        internal bool IsSetSubmitTime() => this.SubmitTime.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        ///  The ID of the Worker who accepted the HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkerId property is set.
        /// </summary>
        internal bool IsSetWorkerId() => this.WorkerId != null;
    }
}
