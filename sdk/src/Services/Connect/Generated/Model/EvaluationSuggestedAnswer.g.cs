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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The information about the suggested answer for the question.
    /// </summary>
    public partial class EvaluationSuggestedAnswer
    {
        /// <summary>
        /// Gets and sets the property AnalysisDetails. 
        /// <para>
        /// Detailed analysis results.
        /// </para>
        /// </summary>
        public EvaluationQuestionAnswerAnalysisDetails AnalysisDetails { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisDetails property is set.
        /// </summary>
        internal bool IsSetAnalysisDetails() => this.AnalysisDetails != null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// Type of analysis used to provide suggested answer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationQuestionAnswerAnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Details about the input used to question automation.
        /// </para>
        /// </summary>
        public EvaluationQuestionInputDetails Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the suggested answer. D
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationSuggestedAnswerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        public EvaluationAnswerData Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
