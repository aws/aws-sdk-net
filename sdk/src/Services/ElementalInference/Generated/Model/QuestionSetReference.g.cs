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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Identifies one version of a question set. You specify it in CustomQuestionsConfig.
    /// </summary>
    public partial class QuestionSetReference
    {
        /// <summary>
        /// Gets and sets the property QuestionSetId. 
        /// <para>
        /// The ID of the question set. The question set must be in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuestionSetId { get; set; }

        /// <summary>
        /// Checks to see if the QuestionSetId property is set.
        /// </summary>
        internal bool IsSetQuestionSetId() => this.QuestionSetId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the question set: DRAFT or the number of a published version. The version
        /// must exist. 
        /// </para>
        ///  
        /// <para>
        /// If you specify DRAFT, the output uses the current DRAFT questions and picks up changes
        /// that you make later by using UpdateQuestionSet. To keep the questions for the output
        /// fixed, specify a published version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
