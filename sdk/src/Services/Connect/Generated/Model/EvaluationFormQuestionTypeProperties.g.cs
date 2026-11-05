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
    /// Information about properties for a question in an evaluation form. The question type
    /// properties must be either for a numeric question or a single select question.
    /// </summary>
    public partial class EvaluationFormQuestionTypeProperties
    {
        /// <summary>
        /// Gets and sets the property MultiSelect. 
        /// <para>
        /// Properties for multi-select question types.
        /// </para>
        /// </summary>
        public EvaluationFormMultiSelectQuestionProperties MultiSelect { get; set; }

        /// <summary>
        /// Checks to see if the MultiSelect property is set.
        /// </summary>
        internal bool IsSetMultiSelect() => this.MultiSelect != null;

        /// <summary>
        /// Gets and sets the property Numeric. 
        /// <para>
        /// The properties of the numeric question.
        /// </para>
        /// </summary>
        public EvaluationFormNumericQuestionProperties Numeric { get; set; }

        /// <summary>
        /// Checks to see if the Numeric property is set.
        /// </summary>
        internal bool IsSetNumeric() => this.Numeric != null;

        /// <summary>
        /// Gets and sets the property SingleSelect. 
        /// <para>
        /// The properties of the numeric question.
        /// </para>
        /// </summary>
        public EvaluationFormSingleSelectQuestionProperties SingleSelect { get; set; }

        /// <summary>
        /// Checks to see if the SingleSelect property is set.
        /// </summary>
        internal bool IsSetSingleSelect() => this.SingleSelect != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The properties of the text question.
        /// </para>
        /// </summary>
        public EvaluationFormTextQuestionProperties Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
