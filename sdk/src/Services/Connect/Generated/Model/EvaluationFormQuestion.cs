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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a question from an evaluation form.
    /// </summary>
    public partial class EvaluationFormQuestion
    {
        private string _instructions;
        private bool? _notApplicableEnabled;
        private EvaluationFormQuestionType _questionType;
        private EvaluationFormQuestionTypeProperties _questionTypeProperties;
        private string _refId;
        private string _title;
        private double? _weight;

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// The instructions of the section.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Instructions
        {
            get { return this._instructions; }
            set { this._instructions = value; }
        }

        // Check to see if Instructions property is set
        internal bool IsSetInstructions()
        {
            return this._instructions != null;
        }

        /// <summary>
        /// Gets and sets the property NotApplicableEnabled. 
        /// <para>
        /// The flag to enable not applicable answers to the question.
        /// </para>
        /// </summary>
        public bool? NotApplicableEnabled
        {
            get { return this._notApplicableEnabled; }
            set { this._notApplicableEnabled = value; }
        }

        // Check to see if NotApplicableEnabled property is set
        internal bool IsSetNotApplicableEnabled()
        {
            return this._notApplicableEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuestionType. 
        /// <para>
        /// The type of the question.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormQuestionType QuestionType
        {
            get { return this._questionType; }
            set { this._questionType = value; }
        }

        // Check to see if QuestionType property is set
        internal bool IsSetQuestionType()
        {
            return this._questionType != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionTypeProperties. 
        /// <para>
        /// The properties of the type of question. Text questions do not have to define question
        /// type properties.
        /// </para>
        /// </summary>
        public EvaluationFormQuestionTypeProperties QuestionTypeProperties
        {
            get { return this._questionTypeProperties; }
            set { this._questionTypeProperties = value; }
        }

        // Check to see if QuestionTypeProperties property is set
        internal bool IsSetQuestionTypeProperties()
        {
            return this._questionTypeProperties != null;
        }

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// The identifier of the question. An identifier must be unique within the evaluation
        /// form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string RefId
        {
            get { return this._refId; }
            set { this._refId = value; }
        }

        // Check to see if RefId property is set
        internal bool IsSetRefId()
        {
            return this._refId != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the question.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=350)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The scoring weight of the section.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}