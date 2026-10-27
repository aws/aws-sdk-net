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
    /// Both the AssignmentReviewReport and the HITReviewReport elements contains the ReviewActionDetail
    /// data structure. This structure is returned multiple times for each action specified
    /// in the Review Policy.
    /// </summary>
    public partial class ReviewActionDetail
    {
        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The unique identifier for the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ActionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionId property is set.
        /// </summary>
        internal bool IsSetActionId() => this.ActionId != null;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        ///  The nature of the action itself. The Review Policy is responsible for examining the
        /// HIT and Assignments, emitting results, and deciding which other actions will be necessary.
        /// 
        /// </para>
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property CompleteTime. 
        /// <para>
        ///  The date when the action was completed.
        /// </para>
        /// </summary>
        public DateTime? CompleteTime { get; set; }

        /// <summary>
        /// Checks to see if the CompleteTime property is set.
        /// </summary>
        internal bool IsSetCompleteTime() => this.CompleteTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  Present only when the Results have a FAILED Status.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        ///  A description of the outcome of the review.
        /// </para>
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current disposition of the action: INTENDED, SUCCEEDED, FAILED, or CANCELLED.
        /// 
        /// </para>
        /// </summary>
        public ReviewActionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        ///  The specific HITId or AssignmentID targeted by the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        ///  The type of object in TargetId.
        /// </para>
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
