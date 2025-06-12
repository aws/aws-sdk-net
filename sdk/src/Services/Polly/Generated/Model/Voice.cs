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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
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
        private List<string> _additionalLanguageCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Gender _gender;
        private VoiceId _id;
        private LanguageCode _languageCode;
        private string _languageName;
        private string _name;
        private List<string> _supportedEngines = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalLanguageCodes
        {
            get { return this._additionalLanguageCodes; }
            set { this._additionalLanguageCodes = value; }
        }

        // Check to see if AdditionalLanguageCodes property is set
        internal bool IsSetAdditionalLanguageCodes()
        {
            return this._additionalLanguageCodes != null && (this._additionalLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// Gender of the voice.
        /// </para>
        /// </summary>
        public Gender Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }

        // Check to see if Gender property is set
        internal bool IsSetGender()
        {
            return this._gender != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Amazon Polly assigned voice ID. This is the ID that you specify when calling the <c>SynthesizeSpeech</c>
        /// operation.
        /// </para>
        /// </summary>
        public VoiceId Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Language code of the voice.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageName. 
        /// <para>
        /// Human readable name of the language in English.
        /// </para>
        /// </summary>
        public string LanguageName
        {
            get { return this._languageName; }
            set { this._languageName = value; }
        }

        // Check to see if LanguageName property is set
        internal bool IsSetLanguageName()
        {
            return this._languageName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the voice (for example, Salli, Kendra, etc.). This provides a human readable
        /// voice name that you might display in your application.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedEngines. 
        /// <para>
        /// Specifies which engines (<c>standard</c>, <c>neural</c>, <c>long-form</c> or <c>generative</c>)
        /// are supported by a given voice.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngines
        {
            get { return this._supportedEngines; }
            set { this._supportedEngines = value; }
        }

        // Check to see if SupportedEngines property is set
        internal bool IsSetSupportedEngines()
        {
            return this._supportedEngines != null && (this._supportedEngines.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}