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
    /// Information about a question from an evaluation form.
    /// </summary>
    public partial class EvaluationFormQuestion
    {
        /// <summary>
        /// Gets and sets the property Enablement. 
        /// <para>
        /// A question conditional enablement.
        /// </para>
        /// </summary>
        public EvaluationFormItemEnablementConfiguration Enablement { get; set; }

        /// <summary>
        /// Checks to see if the Enablement property is set.
        /// </summary>
        internal bool IsSetEnablement() => this.Enablement != null;

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// The instructions of the section.
        /// </para>
        /// </summary>
        public string Instructions { get; set; }

        /// <summary>
        /// Checks to see if the Instructions property is set.
        /// </summary>
        internal bool IsSetInstructions() => this.Instructions != null;

        /// <summary>
        /// Gets and sets the property MetricConfiguration. 
        /// <para>
        /// The metric configuration for the question. Use this to associate a business outcome
        /// metric with the question.
        /// </para>
        /// </summary>
        public EvaluationFormMetricConfiguration MetricConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MetricConfiguration property is set.
        /// </summary>
        internal bool IsSetMetricConfiguration() => this.MetricConfiguration != null;

        /// <summary>
        /// Gets and sets the property NotApplicableEnabled. 
        /// <para>
        /// The flag to enable not applicable answers to the question.
        /// </para>
        /// </summary>
        public bool? NotApplicableEnabled { get; set; }

        /// <summary>
        /// Checks to see if the NotApplicableEnabled property is set.
        /// </summary>
        internal bool IsSetNotApplicableEnabled() => this.NotApplicableEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property QuestionType. 
        /// <para>
        /// The type of the question.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationFormQuestionType QuestionType { get; set; }

        /// <summary>
        /// Checks to see if the QuestionType property is set.
        /// </summary>
        internal bool IsSetQuestionType() => this.QuestionType != null;

        /// <summary>
        /// Gets and sets the property QuestionTypeProperties. 
        /// <para>
        /// The properties of the type of question. Text questions do not have to define question
        /// type properties.
        /// </para>
        /// </summary>
        public EvaluationFormQuestionTypeProperties QuestionTypeProperties { get; set; }

        /// <summary>
        /// Checks to see if the QuestionTypeProperties property is set.
        /// </summary>
        internal bool IsSetQuestionTypeProperties() => this.QuestionTypeProperties != null;

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// The identifier of the question. An identifier must be unique within the evaluation
        /// form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RefId { get; set; }

        /// <summary>
        /// Checks to see if the RefId property is set.
        /// </summary>
        internal bool IsSetRefId() => this.RefId != null;

        /// <summary>
        /// Gets and sets the property ScoringConfiguration. 
        /// <para>
        /// The scoring configuration of the question.
        /// </para>
        /// </summary>
        public EvaluationFormQuestionScoringConfiguration ScoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScoringConfiguration property is set.
        /// </summary>
        internal bool IsSetScoringConfiguration() => this.ScoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the question.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The scoring weight of the section.
        /// </para>
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
