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
    /// Description of the voice.
    /// </summary>
    public partial class Voice
    {
        /// <summary>
        /// Gets and sets the property AdditionalLanguageCodes. 
        /// <para>
        /// Additional codes for languages available for the specified voice in addition to its
        /// default language. 
        /// </para>
        ///  
        /// <para>
        /// For example, the default language for Aditi is Indian English (en-IN) because it was
        /// first used for that language. Since Aditi is bilingual and fluent in both Indian English
        /// and Hindi, this parameter would show the code <c>hi-IN</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalLanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalLanguageCodes property is set.
        /// </summary>
        internal bool IsSetAdditionalLanguageCodes() => this.AdditionalLanguageCodes != null && (this.AdditionalLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// Gender of the voice.
        /// </para>
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Checks to see if the Gender property is set.
        /// </summary>
        internal bool IsSetGender() => this.Gender != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Amazon Polly assigned voice ID. This is the ID that you specify when calling the <c>SynthesizeSpeech</c>
        /// operation.
        /// </para>
        /// </summary>
        public VoiceId Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Language code of the voice.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageName. 
        /// <para>
        /// Human readable name of the language in English.
        /// </para>
        /// </summary>
        public string LanguageName { get; set; }

        /// <summary>
        /// Checks to see if the LanguageName property is set.
        /// </summary>
        internal bool IsSetLanguageName() => this.LanguageName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the voice (for example, Salli, Kendra, etc.). This provides a human readable
        /// voice name that you might display in your application.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SupportedEngines. 
        /// <para>
        /// Specifies which engines (<c>standard</c>, <c>neural</c>, <c>long-form</c> or <c>generative</c>)
        /// are supported by a given voice.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngines { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedEngines property is set.
        /// </summary>
        internal bool IsSetSupportedEngines() => this.SupportedEngines != null && (this.SupportedEngines.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
