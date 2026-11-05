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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// Container for the parameters to the PutLexicon operation. Stores a pronunciation lexicon
    /// in an Amazon Web Services Region. If a lexicon with the same name already exists in
    /// the region, it is overwritten by the new lexicon. Lexicon operations have eventual
    /// consistency, therefore, it might take some time before the lexicon is available to
    /// the SynthesizeSpeech operation. <para> Overwriting a lexicon keeps its existing tags.
    /// You can specify tags only when you create a lexicon. If you specify tags for a lexicon
    /// that already exists, the request fails with a <c>ValidationException</c>. To change
    /// the tags of an existing lexicon, use <c>TagResource</c> and <c>UntagResource</c>.
    /// </para> <para> For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
    /// Lexicons</a>. </para>
    /// </summary>
    public partial class PutLexiconRequest : AmazonPollyRequest
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Content of the PLS lexicon as string data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the lexicon. The name must follow the regular expression format [0-9A-Za-z]{1,20}.
        /// That is, the name is a case-sensitive alphanumeric string up to 20 characters long.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the lexicon to help you categorize and organize it.
        /// Each tag consists of a key and an optional value, both of which you define. Tag keys
        /// can have a maximum character length of 128 characters, and tag values can have a maximum
        /// length of 256 characters. You can't replace the tags of an existing lexicon by overwriting
        /// it with PutLexicon.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
