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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains the names of the fields used for an exact response to the user.
    /// </summary>
    public partial class ExactResponseFields
    {
        /// <summary>
        /// Gets and sets the property AnswerField. 
        /// <para>
        /// The name of the field that contains the answer to the query made to the OpenSearch
        /// Service database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AnswerField { get; set; }

        /// <summary>
        /// Checks to see if the AnswerField property is set.
        /// </summary>
        internal bool IsSetAnswerField() => this.AnswerField != null;

        /// <summary>
        /// Gets and sets the property QuestionField. 
        /// <para>
        /// The name of the field that contains the query made to the OpenSearch Service database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuestionField { get; set; }

        /// <summary>
        /// Checks to see if the QuestionField property is set.
        /// </summary>
        internal bool IsSetQuestionField() => this.QuestionField != null;
    }
}
