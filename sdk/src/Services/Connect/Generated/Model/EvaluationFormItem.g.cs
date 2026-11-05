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
    /// Information about an item from an evaluation form. The item must be either a section
    /// or a question.
    /// </summary>
    public partial class EvaluationFormItem
    {
        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        /// The information of the question.
        /// </para>
        /// </summary>
        public EvaluationFormQuestion Question { get; set; }

        /// <summary>
        /// Checks to see if the Question property is set.
        /// </summary>
        internal bool IsSetQuestion() => this.Question != null;

        /// <summary>
        /// Gets and sets the property Section. 
        /// <para>
        /// The information of the section.
        /// </para>
        /// </summary>
        public EvaluationFormSection Section { get; set; }

        /// <summary>
        /// Checks to see if the Section property is set.
        /// </summary>
        internal bool IsSetSection() => this.Section != null;
    }
}
