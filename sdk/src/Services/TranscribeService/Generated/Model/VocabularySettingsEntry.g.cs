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
    /// A custom vocabulary for one language. Specify exactly one of <c>VocabularyName</c>
    /// or <c>Phrases</c>.
    /// </summary>
    public partial class VocabularySettingsEntry
    {
        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language this custom vocabulary applies to, as a base language code (for example,
        /// <c>en</c>). Each language can appear in only one entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Phrases. 
        /// <para>
        /// Up to 100 phrases to use as a custom vocabulary, provided inline. You don't need to
        /// create the vocabulary first.
        /// </para>
        ///  
        /// <para>
        /// Include either <c>Phrases</c> or <c>VocabularyName</c> in each entry, but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<VocabularyPhrase> Phrases { get; set; } = AWSConfigs.InitializeCollections ? new List<VocabularyPhrase>() : null;

        /// <summary>
        /// Checks to see if the Phrases property is set.
        /// </summary>
        internal bool IsSetPhrases() => this.Phrases != null && (this.Phrases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of a custom vocabulary you created. The vocabulary must be in the <c>READY</c>
        /// state, and its language must match this entry's <c>Language</c>.
        /// </para>
        ///  
        /// <para>
        /// Vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Include either <c>VocabularyName</c> or <c>Phrases</c> in each entry, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;
    }
}
