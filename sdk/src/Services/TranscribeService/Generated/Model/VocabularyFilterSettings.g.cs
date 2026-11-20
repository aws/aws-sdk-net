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
    /// Custom vocabulary filters to apply to your transcript, and how to apply them.
    /// </summary>
    public partial class VocabularyFilterSettings
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Custom vocabulary filters, with one entry per language. In each entry, you can reference
        /// a custom vocabulary filter you created or provide words inline. All entries must use
        /// the same type, either all by name or all inline.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Language</c>, include exactly one entry, and its <c>Language</c>
        /// must match. If you use <c>LanguageDetectionMode</c>, you can include one entry for
        /// each language in <c>LanguageOptions</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<VocabularyFilterEntry> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<VocabularyFilterEntry>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Specify how you want your custom vocabulary filter applied to your transcript.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <c>***</c>, choose <c>mask</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete words, choose <c>remove</c>.
        /// </para>
        ///  
        /// <para>
        /// To flag words without changing them, choose <c>tag</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VocabularyFilterMethod VocabularyFilterMethod { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterMethod property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterMethod() => this.VocabularyFilterMethod != null;
    }
}
