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
    /// Container for the parameters to the CreateDictionary operation. Creates a custom dictionary
    /// for improving transcription accuracy. A dictionary contains custom words and phrases
    /// that the ASR engine might not recognize, such as brand names, technical terms, or
    /// proper nouns. You can reference a dictionary when configuring a smart subtitles output.
    /// </summary>
    public partial class CreateDictionaryRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The dictionary entries payload. Contains the custom words and phrases for the dictionary.
        /// Maximum size is 40,960 characters. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 40960)]
        public string Entries { get; set; }

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language of the dictionary entries. Specify the language using an ISO 639-2/T
        /// three-letter code. Supported values: eng, fra, ita, deu, spa, por. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DictionaryLanguage Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-friendly name for this dictionary.
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
        /// Optional tags to associate with the dictionary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
