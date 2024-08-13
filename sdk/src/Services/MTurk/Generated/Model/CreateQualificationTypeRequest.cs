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
    /// Container for the parameters to the CreateQualificationType operation.
    /// The <c>CreateQualificationType</c> operation creates a new Qualification type, which
    /// is represented by a <c>QualificationType</c> data structure.
    /// </summary>
    public partial class CreateQualificationTypeRequest : AmazonMTurkRequest
    {
        private string _answerKey;
        private bool? _autoGranted;
        private int? _autoGrantedValue;
        private string _description;
        private string _keywords;
        private string _name;
        private QualificationTypeStatus _qualificationTypeStatus;
        private long? _retryDelayInSeconds;
        private string _test;
        private long? _testDurationInSeconds;

        /// <summary>
        /// Gets and sets the property AnswerKey. 
        /// <para>
        /// The answers to the Qualification test specified in the Test parameter, in the form
        /// of an AnswerKey data structure.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must not be longer than 65535 bytes.
        /// </para>
        ///  
        /// <para>
        /// Constraints: None. If not specified, you must process Qualification requests manually.
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
        /// Specifies whether requests for the Qualification type are granted immediately, without
        /// prompting the Worker with a Qualification test.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If the Test parameter is specified, this parameter cannot be true.
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
        /// The Qualification value to use for automatically granted Qualifications. This parameter
        /// is used only if the AutoGranted parameter is true.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A long description for the Qualification type. On the Amazon Mechanical Turk website,
        /// the long description is displayed when a Worker examines a Qualification type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Keywords. 
        /// <para>
        /// One or more words or phrases that describe the Qualification type, separated by commas.
        /// The keywords of a type make the type easier to find during a search.
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
        ///  The name you give to the Qualification type. The type name is used to represent the
        /// Qualification to Workers, and to find the type using a Qualification type search.
        /// It must be unique across all of your Qualification types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property QualificationTypeStatus. 
        /// <para>
        /// The initial status of the Qualification type.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Valid values are: Active | Inactive
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The number of seconds that a Worker must wait after requesting a Qualification of
        /// the Qualification type before the worker can retry the Qualification request.
        /// </para>
        ///  
        /// <para>
        /// Constraints: None. If not specified, retries are disabled and Workers can request
        /// a Qualification of this type only once, even if the Worker has not been granted the
        /// Qualification. It is not possible to disable retries for a Qualification type after
        /// it has been created with retries enabled. If you want to disable retries, you must
        /// delete existing retry-enabled Qualification type and then create a new Qualification
        /// type with retries disabled.
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
        ///  The questions for the Qualification test a Worker must answer correctly to obtain
        /// a Qualification of this type. If this parameter is specified, <c>TestDurationInSeconds</c>
        /// must also be specified. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must not be longer than 65535 bytes. Must be a QuestionForm data structure.
        /// This parameter cannot be specified if AutoGranted is true.
        /// </para>
        ///  
        /// <para>
        /// Constraints: None. If not specified, the Worker may request the Qualification without
        /// answering any questions.
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
        /// The number of seconds the Worker has to complete the Qualification test, starting
        /// from the time the Worker requests the Qualification.
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