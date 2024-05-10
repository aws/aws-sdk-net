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
    /// The QualificationType data structure represents a Qualification type, a description
    /// of a property of a Worker that must match the requirements of a HIT for the Worker
    /// to be able to accept the HIT. The type also describes how a Worker can obtain a Qualification
    /// of that type, such as through a Qualification test.
    /// </summary>
    public partial class QualificationType
    {
        private string _answerKey;
        private bool? _autoGranted;
        private int? _autoGrantedValue;
        private DateTime? _creationTime;
        private string _description;
        private bool? _isRequestable;
        private string _keywords;
        private string _name;
        private string _qualificationTypeId;
        private QualificationTypeStatus _qualificationTypeStatus;
        private long? _retryDelayInSeconds;
        private string _test;
        private long? _testDurationInSeconds;

        /// <summary>
        /// Gets and sets the property AnswerKey. 
        /// <para>
        /// The answers to the Qualification test specified in the Test parameter.
        /// </para>
        /// </summary>
        public string AnswerKey
        {
            get { return this._answerKey; }
            set { this._answerKey = value; }
        }

        // Check to see if AnswerKey property is set
        internal bool IsSetAnswerKey()
        {
            return this._answerKey != null;
        }

        /// <summary>
        /// Gets and sets the property AutoGranted. 
        /// <para>
        /// Specifies that requests for the Qualification type are granted immediately, without
        /// prompting the Worker with a Qualification test. Valid values are True | False.
        /// </para>
        /// </summary>
        public bool? AutoGranted
        {
            get { return this._autoGranted; }
            set { this._autoGranted = value; }
        }

        // Check to see if AutoGranted property is set
        internal bool IsSetAutoGranted()
        {
            return this._autoGranted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoGrantedValue. 
        /// <para>
        ///  The Qualification integer value to use for automatically granted Qualifications,
        /// if AutoGranted is true. This is 1 by default. 
        /// </para>
        /// </summary>
        public int? AutoGrantedValue
        {
            get { return this._autoGrantedValue; }
            set { this._autoGrantedValue = value; }
        }

        // Check to see if AutoGrantedValue property is set
        internal bool IsSetAutoGrantedValue()
        {
            return this._autoGrantedValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The date and time the Qualification type was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
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
        ///  A long description for the Qualification type. 
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
        /// Gets and sets the property IsRequestable. 
        /// <para>
        ///  Specifies whether the Qualification type is one that a user can request through the
        /// Amazon Mechanical Turk web site, such as by taking a Qualification test. This value
        /// is False for Qualifications assigned automatically by the system. Valid values are
        /// True | False. 
        /// </para>
        /// </summary>
        public bool? IsRequestable
        {
            get { return this._isRequestable; }
            set { this._isRequestable = value; }
        }

        // Check to see if IsRequestable property is set
        internal bool IsSetIsRequestable()
        {
            return this._isRequestable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        ///  One or more words or phrases that describe theQualification type, separated by commas.
        /// The Keywords make the type easier to find using a search. 
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the Qualification type. The type name is used to identify the type, and
        /// to find the type using a Qualification type search. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        ///  A unique identifier for the Qualification type. A Qualification type is given a Qualification
        /// type ID when you call the CreateQualificationType operation. 
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
        /// Gets and sets the property QualificationTypeStatus. 
        /// <para>
        ///  The status of the Qualification type. A Qualification type's status determines if
        /// users can apply to receive a Qualification of this type, and if HITs can be created
        /// with requirements based on this type. Valid values are Active | Inactive. 
        /// </para>
        /// </summary>
        public QualificationTypeStatus QualificationTypeStatus
        {
            get { return this._qualificationTypeStatus; }
            set { this._qualificationTypeStatus = value; }
        }

        // Check to see if QualificationTypeStatus property is set
        internal bool IsSetQualificationTypeStatus()
        {
            return this._qualificationTypeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RetryDelayInSeconds. 
        /// <para>
        ///  The amount of time, in seconds, Workers must wait after taking the Qualification
        /// test before they can take it again. Workers can take a Qualification test multiple
        /// times if they were not granted the Qualification from a previous attempt, or if the
        /// test offers a gradient score and they want a better score. If not specified, retries
        /// are disabled and Workers can request a Qualification only once. 
        /// </para>
        /// </summary>
        public long? RetryDelayInSeconds
        {
            get { return this._retryDelayInSeconds; }
            set { this._retryDelayInSeconds = value; }
        }

        // Check to see if RetryDelayInSeconds property is set
        internal bool IsSetRetryDelayInSeconds()
        {
            return this._retryDelayInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        ///  The questions for a Qualification test associated with this Qualification type that
        /// a user can take to obtain a Qualification of this type. This parameter must be specified
        /// if AnswerKey is present. A Qualification type cannot have both a specified Test parameter
        /// and an AutoGranted value of true. 
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
        /// Gets and sets the property TestDurationInSeconds. 
        /// <para>
        ///  The amount of time, in seconds, given to a Worker to complete the Qualification test,
        /// beginning from the time the Worker requests the Qualification. 
        /// </para>
        /// </summary>
        public long? TestDurationInSeconds
        {
            get { return this._testDurationInSeconds; }
            set { this._testDurationInSeconds = value; }
        }

        // Check to see if TestDurationInSeconds property is set
        internal bool IsSetTestDurationInSeconds()
        {
            return this._testDurationInSeconds.HasValue; 
        }

    }
}