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
    /// Both the AssignmentReviewReport and the HITReviewReport elements contains the ReviewActionDetail
    /// data structure. This structure is returned multiple times for each action specified
    /// in the Review Policy.
    /// </summary>
    public partial class ReviewActionDetail
    {
        private string _actionId;
        private string _actionName;
        private DateTime? _completeTime;
        private string _errorCode;
        private string _result;
        private ReviewActionStatus _status;
        private string _targetId;
        private string _targetType;

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The unique identifier for the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        ///  The nature of the action itself. The Review Policy is responsible for examining the
        /// HIT and Assignments, emitting results, and deciding which other actions will be necessary.
        /// 
        /// </para>
        /// </summary>
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property CompleteTime. 
        /// <para>
        ///  The date when the action was completed.
        /// </para>
        /// </summary>
        public DateTime? CompleteTime
        {
            get { return this._completeTime; }
            set { this._completeTime = value; }
        }

        // Check to see if CompleteTime property is set
        internal bool IsSetCompleteTime()
        {
            return this._completeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  Present only when the Results have a FAILED Status.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        ///  A description of the outcome of the review.
        /// </para>
        /// </summary>
        public string Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current disposition of the action: INTENDED, SUCCEEDED, FAILED, or CANCELLED.
        /// 
        /// </para>
        /// </summary>
        public ReviewActionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        ///  The specific HITId or AssignmentID targeted by the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        ///  The type of object in TargetId.
        /// </para>
        /// </summary>
        public string TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}