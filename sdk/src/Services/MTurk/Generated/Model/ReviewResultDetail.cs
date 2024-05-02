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
    /// This data structure is returned multiple times for each result specified in the Review
    /// Policy.
    /// </summary>
    public partial class ReviewResultDetail
    {
        private string _actionId;
        private string _key;
        private string _questionId;
        private string _subjectId;
        private string _subjectType;
        private string _value;

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        ///  A unique identifier of the Review action result. 
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
        /// Gets and sets the property Key. 
        /// <para>
        ///  Key identifies the particular piece of reviewed information. 
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionId. 
        /// <para>
        ///  Specifies the QuestionId the result is describing. Depending on whether the TargetType
        /// is a HIT or Assignment this results could specify multiple values. If TargetType is
        /// HIT and QuestionId is absent, then the result describes results of the HIT, including
        /// the HIT agreement score. If ObjectType is Assignment and QuestionId is absent, then
        /// the result describes the Worker's performance on the HIT. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string QuestionId
        {
            get { return this._questionId; }
            set { this._questionId = value; }
        }

        // Check to see if QuestionId property is set
        internal bool IsSetQuestionId()
        {
            return this._questionId != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The HITID or AssignmentId about which this result was taken. Note that HIT-level Review
        /// Policies will often emit results about both the HIT itself and its Assignments, while
        /// Assignment-level review policies generally only emit results about the Assignment
        /// itself. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SubjectId
        {
            get { return this._subjectId; }
            set { this._subjectId = value; }
        }

        // Check to see if SubjectId property is set
        internal bool IsSetSubjectId()
        {
            return this._subjectId != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectType. 
        /// <para>
        ///  The type of the object from the SubjectId field.
        /// </para>
        /// </summary>
        public string SubjectType
        {
            get { return this._subjectType; }
            set { this._subjectType = value; }
        }

        // Check to see if SubjectType property is set
        internal bool IsSetSubjectType()
        {
            return this._subjectType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The values of Key provided by the review policies you have selected. 
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}