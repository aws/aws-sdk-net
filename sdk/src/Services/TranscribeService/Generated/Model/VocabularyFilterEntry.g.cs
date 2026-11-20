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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// A custom vocabulary filter for one language. Specify exactly one of <c>VocabularyFilterName</c>
    /// or <c>Words</c>.
    /// </summary>
    public partial class VocabularyFilterEntry
    {
        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language this custom vocabulary filter applies to, as a base language code (for
        /// example, <c>en</c>). Each language can appear in only one entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of a custom vocabulary filter you created. The filter's language must match
        /// this entry's <c>Language</c>.
        /// </para>
        ///  
        /// <para>
        /// Vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Include either <c>VocabularyFilterName</c> or <c>Words</c> in each entry, but not
        /// both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyFilterName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterName property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterName() => this.VocabularyFilterName != null;

        /// <summary>
        /// Gets and sets the property Words. 
        /// <para>
        /// The words to filter, provided inline. You don't need to create the vocabulary filter
        /// first.
        /// </para>
        ///  
        /// <para>
        /// Include either <c>Words</c> or <c>VocabularyFilterName</c> in each entry, but not
        /// both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> Words { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Words property is set.
        /// </summary>
        internal bool IsSetWords() => this.Words != null && (this.Words.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
