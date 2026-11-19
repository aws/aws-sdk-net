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

namespace Amazon.ConnectScheduling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTimeOff operation. Creates a time off request
    /// for a user. You don't provide a status, because Connect Customer owns the request
    /// lifecycle. To get the decided status, call <c>GetTimeOff</c> or use the time off state-change
    /// events. <para> <c>ApprovalType</c> controls who approves the request. You can specify
    /// one of the following values: </para> <ul> <li> <para> <c>AWAIT_APPROVAL</c>: the request
    /// waits in <c>AWAITING_APPROVAL</c> until you call <c>ApproveTimeOff</c> or <c>RejectTimeOff</c>.
    /// Rule evaluation and the overlap check run at approval, not at creation. A waiting
    /// request doesn't reserve its window, so another request for the same window can be
    /// approved first. </para> </li> <li> <para> <c>AUTOMATIC</c>: Connect Customer evaluates
    /// the rules (time off balances and group allowances) and decides the request. The request
    /// can be <c>PENDING</c> while Connect Customer decides, and then ends <c>APPROVED</c>
    /// or <c>REJECTED</c>. If it overlaps another time off request for the user, the requested
    /// time off ends <c>REJECTED</c> with <c>CONFLICTING_TIME_OFF_REQUEST</c>. It also ends
    /// <c>REJECTED</c> if it overlaps overtime or voluntary time off. If the whole window
    /// is in the past, Connect Customer records failed rules as <c>WARNING</c> and doesn't
    /// reject the request, whatever the <c>RuleFailureAction</c>. </para> </li> </ul> <para>
    /// The staffing group's <i>Supervisor approval needed</i> setting doesn't apply to this
    /// operation. <c>ApprovalType</c> alone decides whether the request waits for approval.
    /// The operation fails with <c>ValidationException</c> on <c>UserId</c> in the following
    /// cases: </para> <ul> <li> <para> The user isn't in a staffing group, or the staffing
    /// group isn't associated with a forecast group. </para> </li> <li> <para> Time off isn't
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-to.html">enabled</a>
    /// for the user's staffing group, or the user's staff rules don't allow time off. </para>
    /// </li> </ul> <para> To change the dates of a request, cancel it with <c>CancelTimeOff</c>
    /// and create a new request. The new request has a new <c>TimeOffId</c>. </para> <note>
    /// <para> Connect Customer doesn't check whether the principal that calls this operation
    /// supervises the user. The staffing group's approval settings also don't apply. IAM
    /// permissions are the only control. If you allow a principal to call this operation,
    /// that principal can send <c>ApprovalType</c> <c>AUTOMATIC</c> with <c>RuleFailureAction</c>
    /// <c>OVERRIDE</c> and approve a request past failed rules. Grant permission for this
    /// operation only to principals that you trust to override time off rules. </para> </note>
    /// <para> For information about time off in the Connect Customer admin website, see <a
    /// href="https://docs.aws.amazon.com/connect/latest/adminguide/scheduling-time-off.html">Time
    /// off management</a> in the <i>Connect Customer Administrator Guide</i>. </para>
    /// </summary>
    public partial class CreateTimeOffRequest : AmazonConnectSchedulingRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalType. 
        /// <para>
        /// Controls who approves the request. <c>AWAIT_APPROVAL</c> waits for an <c>ApproveTimeOff</c>
        /// or <c>RejectTimeOff</c> call. <c>AUTOMATIC</c> has Connect Customer decide the request.
        /// For details, see <c>CreateTimeOff</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApprovalType ApprovalType { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalType property is set.
        /// </summary>
        internal bool IsSetApprovalType() => this.ApprovalType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If this token matches a previous request, Connect
        /// Customer returns the result of that request and doesn't create another time off request.
        /// If you don't provide a token, the AWS SDK populates this field. If you reuse a client
        /// token with a different request body, the request fails with <c>ValidationException</c>.
        /// For more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description recorded on the time off request. If you omit it, the request has no
        /// description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndAt. 
        /// <para>
        /// The end of the time off window, exclusive. It must be after <c>StartAt</c> and no
        /// later than 24 months after the current date. Connect Customer stores the value as
        /// sent, to the millisecond.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndAt { get; set; }

        /// <summary>
        /// Checks to see if the EndAt property is set.
        /// </summary>
        internal bool IsSetEndAt() => this.EndAt.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. This can be the ID or the ARN of
        /// the instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 250)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property RuleFailureAction. 
        /// <para>
        /// Controls what happens when a configured rule fails. <c>REJECT</c>, the default, records
        /// an <c>ERROR</c> and ends the request <c>REJECTED</c>, unless the whole window is in
        /// the past. <c>OVERRIDE</c> records a <c>WARNING</c> and ends the request <c>APPROVED</c>,
        /// like the <i>Override time off rules</i> option in the Connect Customer admin website.
        /// <c>OVERRIDE</c> requires <c>AUTOMATIC</c>. With <c>AWAIT_APPROVAL</c>, <c>OVERRIDE</c>
        /// fails with <c>ValidationException</c>. Set it on <c>ApproveTimeOff</c> instead. <c>OVERRIDE</c>
        /// never waives <c>CONFLICTING_TIME_OFF_REQUEST</c>.
        /// </para>
        /// </summary>
        public RuleFailureAction RuleFailureAction { get; set; }

        /// <summary>
        /// Checks to see if the RuleFailureAction property is set.
        /// </summary>
        internal bool IsSetRuleFailureAction() => this.RuleFailureAction != null;

        /// <summary>
        /// Gets and sets the property ShiftActivityId. 
        /// <para>
        /// The identifier of the shift activity that defines the type of time off being requested.
        /// This can be the ID or the ARN of the shift activity. It must be a time off activity.
        /// Activities that aren't set as <i>Requestable</i> are accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ShiftActivityId { get; set; }

        /// <summary>
        /// Checks to see if the ShiftActivityId property is set.
        /// </summary>
        internal bool IsSetShiftActivityId() => this.ShiftActivityId != null;

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The start of the time off window, inclusive. It must be no earlier than one year before
        /// the current date. Connect Customer stores the value as sent, to the millisecond.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Checks to see if the StartAt property is set.
        /// </summary>
        internal bool IsSetStartAt() => this.StartAt.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user who the time off request is for. This can be the ID or
        /// the ARN of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
