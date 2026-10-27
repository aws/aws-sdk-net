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
    /// Provides information about a custom vocabulary, including the language of the custom
    /// vocabulary, when it was last modified, its name, and the processing state.
    /// </summary>
    public partial class VocabularyInfo
    {
        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your custom vocabulary. Each custom vocabulary must
        /// contain terms in only one language.
        /// </para>
        ///  
        /// <para>
        /// A custom vocabulary can only be used to transcribe files in the same language as the
        /// custom vocabulary. For example, if you create a custom vocabulary using US English
        /// (<c>en-US</c>), you can only apply this custom vocabulary to files that contain English
        /// audio.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the specified custom vocabulary was last modified.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// A unique name, chosen by you, for your custom vocabulary. This name is case sensitive,
        /// cannot contain spaces, and must be unique within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;

        /// <summary>
        /// Gets and sets the property VocabularyState. 
        /// <para>
        /// The processing state of your custom vocabulary. If the state is <c>READY</c>, you
        /// can use the custom vocabulary in a <c>StartTranscriptionJob</c> request.
        /// </para>
        /// </summary>
        public VocabularyState VocabularyState { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyState property is set.
        /// </summary>
        internal bool IsSetVocabularyState() => this.VocabularyState != null;
    }
}
