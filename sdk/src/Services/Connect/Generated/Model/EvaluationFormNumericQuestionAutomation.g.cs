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
    /// Information about the automation configuration in numeric questions.
    /// </summary>
    public partial class EvaluationFormNumericQuestionAutomation
    {
        /// <summary>
        /// Gets and sets the property AnswerSource. 
        /// <para>
        /// A source of automation answer for numeric question.
        /// </para>
        /// </summary>
        public EvaluationFormQuestionAutomationAnswerSource AnswerSource { get; set; }

        /// <summary>
        /// Checks to see if the AnswerSource property is set.
        /// </summary>
        internal bool IsSetAnswerSource() => this.AnswerSource != null;

        /// <summary>
        /// Gets and sets the property PropertyValue. 
        /// <para>
        /// The property value of the automation.
        /// </para>
        /// </summary>
        public NumericQuestionPropertyValueAutomation PropertyValue { get; set; }

        /// <summary>
        /// Checks to see if the PropertyValue property is set.
        /// </summary>
        internal bool IsSetPropertyValue() => this.PropertyValue != null;
    }
}
