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
    /// The information about the suggested answer for the question.
    /// </summary>
    public partial class EvaluationSuggestedAnswer
    {
        private EvaluationQuestionAnswerAnalysisDetails _analysisDetails;
        private EvaluationQuestionAnswerAnalysisType _analysisType;
        private EvaluationQuestionInputDetails _input;
        private EvaluationSuggestedAnswerStatus _status;
        private EvaluationAnswerData _value;

        /// <summary>
        /// Gets and sets the property AnalysisDetails. 
        /// <para>
        /// Detailed analysis results.
        /// </para>
        /// </summary>
        public EvaluationQuestionAnswerAnalysisDetails AnalysisDetails
        {
            get { return this._analysisDetails; }
            set { this._analysisDetails = value; }
        }

        // Check to see if AnalysisDetails property is set
        internal bool IsSetAnalysisDetails()
        {
            return this._analysisDetails != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// Type of analysis used to provide suggested answer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationQuestionAnswerAnalysisType AnalysisType
        {
            get { return this._analysisType; }
            set { this._analysisType = value; }
        }

        // Check to see if AnalysisType property is set
        internal bool IsSetAnalysisType()
        {
            return this._analysisType != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Details about the input used to question automation.
        /// </para>
        /// </summary>
        public EvaluationQuestionInputDetails Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the suggested answer. D
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationSuggestedAnswerStatus Status
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
        /// Gets and sets the property Value.
        /// </summary>
        public EvaluationAnswerData Value
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