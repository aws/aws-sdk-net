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
    /// This is the response object from the GetTimeOff operation.
    /// </summary>
    public partial class GetTimeOffResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the time off request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identity that created the request. Immutable for the life of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActorInfo CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the time off request. <c>CreateTimeOff</c> sets it, and <c>CancelTimeOff</c>
        /// replaces or removes it. An edit in the Connect Customer admin website can also change
        /// it. <c>GetTimeOff</c> doesn't return descriptions sent with <c>ApproveTimeOff</c>
        /// or <c>RejectTimeOff</c>.
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
        /// The end of the time off window, exclusive, as sent to <c>CreateTimeOff</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndAt { get; set; }

        /// <summary>
        /// Checks to see if the EndAt property is set.
        /// </summary>
        internal bool IsSetEndAt() => this.EndAt.HasValue;

        /// <summary>
        /// Gets and sets the property ShiftActivityId. 
        /// <para>
        /// The identifier of the shift activity for the time off request.
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
        /// The start of the time off window, inclusive, as sent to <c>CreateTimeOff</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Checks to see if the StartAt property is set.
        /// </summary>
        internal bool IsSetStartAt() => this.StartAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the time off request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: Connect Customer is processing a change to the request, which then
        /// changes to another status. An edit in the Connect Customer admin website can also
        /// make a request <c>PENDING</c>, so an <c>APPROVED</c> request can become <c>PENDING</c>
        /// and then end <c>APPROVED</c> or <c>REJECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWAITING_APPROVAL</c>: the request is waiting for an <c>ApproveTimeOff</c> or
        /// <c>RejectTimeOff</c> call.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeOffStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeOffId. 
        /// <para>
        /// The identifier of the time off request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TimeOffId { get; set; }

        /// <summary>
        /// Checks to see if the TimeOffId property is set.
        /// </summary>
        internal bool IsSetTimeOffId() => this.TimeOffId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the time off request was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The identity that made the most recent <c>ApproveTimeOff</c>, <c>RejectTimeOff</c>,
        /// or <c>CancelTimeOff</c> call on the request, or took the same action in the Connect
        /// Customer admin website. Absent until one of those actions is taken, including after
        /// Connect Customer decides an <c>AUTOMATIC</c> request. <c>UpdatedAt</c> also changes
        /// when a <c>PENDING</c> request changes to another status and for other edits, which
        /// don't set <c>UpdatedBy</c>.
        /// </para>
        /// </summary>
        public ActorInfo UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user the time off is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property ValidationResults. 
        /// <para>
        /// Warnings or failures produced while processing the time off request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TimeOffValidationResult> ValidationResults { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeOffValidationResult>() : null;

        /// <summary>
        /// Checks to see if the ValidationResults property is set.
        /// </summary>
        internal bool IsSetValidationResults() => this.ValidationResults != null && (this.ValidationResults.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
