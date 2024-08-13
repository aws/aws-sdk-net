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
    /// The QualificationRequest data structure represents a request a Worker has made for
    /// a Qualification.
    /// </summary>
    public partial class QualificationRequest
    {
        private string _answer;
        private string _qualificationRequestId;
        private string _qualificationTypeId;
        private DateTime? _submitTime;
        private string _test;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property Answer. 
        /// <para>
        ///  The Worker's answers for the Qualification type's test contained in a QuestionFormAnswers
        /// document, if the type has a test and the Worker has submitted answers. If the Worker
        /// does not provide any answers, Answer may be empty. 
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
        /// Gets and sets the property QualificationRequestId. 
        /// <para>
        /// The ID of the Qualification request, a unique identifier generated when the request
        /// was submitted. 
        /// </para>
        /// </summary>
        public string QualificationRequestId
        {
            get { return this._qualificationRequestId; }
            set { this._qualificationRequestId = value; }
        }

        // Check to see if QualificationRequestId property is set
        internal bool IsSetQualificationRequestId()
        {
            return this._qualificationRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        ///  The ID of the Qualification type the Worker is requesting, as returned by the CreateQualificationType
        /// operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string QualificationTypeId
        {
            get { return this._qualificationTypeId; }
            set { this._qualificationTypeId = value; }
        }

        // Check to see if QualificationTypeId property is set
        internal bool IsSetQualificationTypeId()
        {
            return this._qualificationTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The date and time the Qualification request had a status of Submitted. This is either
        /// the time the Worker submitted answers for a Qualification test, or the time the Worker
        /// requested the Qualification if the Qualification type does not have a test. 
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
        /// Gets and sets the property Test. 
        /// <para>
        ///  The contents of the Qualification test that was presented to the Worker, if the type
        /// has a test and the Worker has submitted answers. This value is identical to the QuestionForm
        /// associated with the Qualification type at the time the Worker requests the Qualification.
        /// </para>
        /// </summary>
        public string Test
        {
            get { return this._test; }
            set { this._test = value; }
        }

        // Check to see if Test property is set
        internal bool IsSetTest()
        {
            return this._test != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        ///  The ID of the Worker requesting the Qualification.
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