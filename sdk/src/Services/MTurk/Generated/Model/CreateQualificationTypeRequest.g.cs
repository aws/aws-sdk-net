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
    /// Container for the parameters to the CreateQualificationType operation. The <c>CreateQualificationType</c>
    /// operation creates a new Qualification type, which is represented by a <c>QualificationType</c>
    /// data structure.
    /// </summary>
    public partial class CreateQualificationTypeRequest : AmazonMTurkRequest
    {
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
        public string AnswerKey { get; set; }

        /// <summary>
        /// Checks to see if the AnswerKey property is set.
        /// </summary>
        internal bool IsSetAnswerKey() => this.AnswerKey != null;

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
        public bool? AutoGranted { get; set; }

        /// <summary>
        /// Checks to see if the AutoGranted property is set.
        /// </summary>
        internal bool IsSetAutoGranted() => this.AutoGranted.HasValue;

        /// <summary>
        /// Gets and sets the property AutoGrantedValue. 
        /// <para>
        /// The Qualification value to use for automatically granted Qualifications. This parameter
        /// is used only if the AutoGranted parameter is true.
        /// </para>
        /// </summary>
        public int? AutoGrantedValue { get; set; }

        /// <summary>
        /// Checks to see if the AutoGrantedValue property is set.
        /// </summary>
        internal bool IsSetAutoGrantedValue() => this.AutoGrantedValue.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A long description for the Qualification type. On the Amazon Mechanical Turk website,
        /// the long description is displayed when a Worker examines a Qualification type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        /// One or more words or phrases that describe the Qualification type, separated by commas.
        /// The keywords of a type make the type easier to find during a search.
        /// </para>
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Checks to see if the Keywords property is set.
        /// </summary>
        internal bool IsSetKeywords() => this.Keywords != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name you give to the Qualification type. The type name is used to represent the
        /// Qualification to Workers, and to find the type using a Qualification type search.
        /// It must be unique across all of your Qualification types.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Required = true)]
        public QualificationTypeStatus QualificationTypeStatus { get; set; }

        /// <summary>
        /// Checks to see if the QualificationTypeStatus property is set.
        /// </summary>
        internal bool IsSetQualificationTypeStatus() => this.QualificationTypeStatus != null;

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
        public long? RetryDelayInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RetryDelayInSeconds property is set.
        /// </summary>
        internal bool IsSetRetryDelayInSeconds() => this.RetryDelayInSeconds.HasValue;

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
        public string Test { get; set; }

        /// <summary>
        /// Checks to see if the Test property is set.
        /// </summary>
        internal bool IsSetTest() => this.Test != null;

        /// <summary>
        /// Gets and sets the property TestDurationInSeconds. 
        /// <para>
        /// The number of seconds the Worker has to complete the Qualification test, starting
        /// from the time the Worker requests the Qualification.
        /// </para>
        /// </summary>
        public long? TestDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TestDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetTestDurationInSeconds() => this.TestDurationInSeconds.HasValue;
    }
}
