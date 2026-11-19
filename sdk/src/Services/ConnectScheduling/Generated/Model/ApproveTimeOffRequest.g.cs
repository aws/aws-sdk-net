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
    /// Container for the parameters to the ApproveTimeOff operation. Approves a time off
    /// request. Evaluates agent time off balances and group time off allowances before approving.
    /// <c>RuleFailureAction</c> controls what happens when these evaluations fail. The request
    /// is rejected with <c>CONFLICTING_TIME_OFF_REQUEST</c> if it overlaps another time off
    /// request for the user that is <c>APPROVED</c> or being approved. <para> The time off
    /// request is processed asynchronously, so a successful call doesn't indicate the final
    /// status. Read the resulting status with <c>GetTimeOff</c> or from the time off state-change
    /// events. </para> <para> Approving an <c>APPROVED</c> request succeeds without a change.
    /// Approving a <c>REJECTED</c> request evaluates the rules again, so it can end <c>APPROVED</c>
    /// or <c>REJECTED</c>, and repeating the call can give a different result. Check the
    /// status with <c>GetTimeOff</c> before you retry. </para> <para> Returns <c>ConflictException</c>
    /// if the request is <c>PENDING</c> or <c>CANCELLED</c>. <c>PENDING</c> means Connect
    /// Customer is still processing the request asynchronously. Wait until <c>GetTimeOff</c>
    /// returns a status other than <c>PENDING</c>, and then retry. </para> <important> <para>
    /// When the approval succeeds, Connect Customer cancels any overtime or voluntary time
    /// off activity that overlaps the approved window. </para> </important> <note> <para>
    /// Connect Customer doesn't check whether the principal that calls this operation supervises
    /// the user. The staffing group's approval settings also don't apply. IAM permissions
    /// are the only control. If you allow a principal to call this operation, that principal
    /// can send <c>RuleFailureAction</c> <c>OVERRIDE</c> and approve a request past failed
    /// rules. Grant permission for this operation only to principals that you trust to override
    /// time off rules. </para> </note>
    /// </summary>
    public partial class ApproveTimeOffRequest : AmazonConnectSchedulingRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description recorded with the approval. <c>GetTimeOff</c> doesn't return it.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// an <c>ERROR</c> and leaves the request <c>REJECTED</c>. <c>OVERRIDE</c> records a
        /// <c>WARNING</c> and approves the request, like the <i>Override time off rules</i> option
        /// in the Connect Customer admin website. <c>OVERRIDE</c> never waives <c>CONFLICTING_TIME_OFF_REQUEST</c>.
        /// </para>
        /// </summary>
        public RuleFailureAction RuleFailureAction { get; set; }

        /// <summary>
        /// Checks to see if the RuleFailureAction property is set.
        /// </summary>
        internal bool IsSetRuleFailureAction() => this.RuleFailureAction != null;

        /// <summary>
        /// Gets and sets the property TimeOffId. 
        /// <para>
        /// The unique identifier of the time off request to approve. If the time off request
        /// doesn't belong to <c>UserId</c>, the operation returns <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TimeOffId { get; set; }

        /// <summary>
        /// Checks to see if the TimeOffId property is set.
        /// </summary>
        internal bool IsSetTimeOffId() => this.TimeOffId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user who the time off request belongs to. This can be the ID
        /// or the ARN of the user.
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
