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
    /// A question that you ask Elemental Inference, which answers by choosing one of its
    /// options. You specify it in the chooseOne array of a question set.
    /// </summary>
    public partial class ChooseOneQuestion
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the question. The name must be unique among all the questions in the version,
        /// across all question types. The name can be up to 64 characters. It must start with
        /// a letter or an underscore, and can contain only the letters A-Z and a-z, the digits
        /// 0-9, and underscores. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options that Elemental Inference chooses from. You can specify from 2 to 26 options.
        /// The question counts as one item toward the limit of 100 scored items in a version,
        /// regardless of how many options it has. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 26)]
        public List<QuestionOption> Options { get; set; } = AWSConfigs.InitializeCollections ? new List<QuestionOption>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        /// The text of the question. The text can be up to 256 bytes, encoded in UTF-8. It can
        /// contain letters in any language, combining marks, digits, spaces, and the following
        /// characters: <c>. , ? ! ' " ( ) - : ; / &amp; %</c>, plus the curly apostrophe and
        /// quotation marks (U+2019, U+201C, and U+201D). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Question { get; set; }

        /// <summary>
        /// Checks to see if the Question property is set.
        /// </summary>
        internal bool IsSetQuestion() => this.Question != null;
    }
}
