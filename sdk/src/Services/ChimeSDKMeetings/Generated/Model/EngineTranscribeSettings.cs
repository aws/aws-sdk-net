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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Settings specific to the Amazon Transcribe engine.
    /// </summary>
    public partial class EngineTranscribeSettings
    {
        private TranscribeContentIdentificationType _contentIdentificationType;
        private TranscribeContentRedactionType _contentRedactionType;
        private bool? _enablePartialResultsStabilization;
        private bool? _identifyLanguage;
        private TranscribeLanguageCode _languageCode;
        private string _languageModelName;
        private string _languageOptions;
        private TranscribePartialResultsStability _partialResultsStability;
        private string _piiEntityTypes;
        private TranscribeLanguageCode _preferredLanguage;
        private TranscribeRegion _region;
        private TranscribeVocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Set this field to <code>PII</code> to identify personally identifiable information
        /// in the transcription output.
        /// </para>
        /// </summary>
        public TranscribeContentIdentificationType ContentIdentificationType
        {
            get { return this._contentIdentificationType; }
            set { this._contentIdentificationType = value; }
        }

        // Check to see if ContentIdentificationType property is set
        internal bool IsSetContentIdentificationType()
        {
            return this._contentIdentificationType != null;
        }

        /// <summary>
        /// Gets and sets the property ContentRedactionType. 
        /// <para>
        /// Set this field to <code>PII</code> to redact personally identifiable information in
        /// the transcription output. Content redaction is performed only upon complete transcription
        /// of the audio segments.
        /// </para>
        ///  
        /// <para>
        /// You can’t set <code>ContentRedactionType</code> and <code>ContentIdentificationType</code>
        /// in the same request. If you set both, your request returns a <code>BadRequestException</code>.
        /// </para>
        /// </summary>
        public TranscribeContentRedactionType ContentRedactionType
        {
            get { return this._contentRedactionType; }
            set { this._contentRedactionType = value; }
        }

        // Check to see if ContentRedactionType property is set
        internal bool IsSetContentRedactionType()
        {
            return this._contentRedactionType != null;
        }

        /// <summary>
        /// Gets and sets the property EnablePartialResultsStabilization. 
        /// <para>
        /// Generates partial transcription results that are less likely to change as meeting
        /// attendees speak. It does so by only allowing the last few words from the partial results
        /// to change.
        /// </para>
        /// </summary>
        public bool EnablePartialResultsStabilization
        {
            get { return this._enablePartialResultsStabilization.GetValueOrDefault(); }
            set { this._enablePartialResultsStabilization = value; }
        }

        // Check to see if EnablePartialResultsStabilization property is set
        internal bool IsSetEnablePartialResultsStabilization()
        {
            return this._enablePartialResultsStabilization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Automatically identifies the language spoken in media files.
        /// </para>
        /// </summary>
        public bool IdentifyLanguage
        {
            get { return this._identifyLanguage.GetValueOrDefault(); }
            set { this._identifyLanguage = value; }
        }

        // Check to see if IdentifyLanguage property is set
        internal bool IsSetIdentifyLanguage()
        {
            return this._identifyLanguage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code specified for the Amazon Transcribe engine.
        /// </para>
        /// </summary>
        public TranscribeLanguageCode LanguageCode
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
        /// Gets and sets the property LanguageModelName. 
        /// <para>
        /// The name of the language model used during transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LanguageModelName
        {
            get { return this._languageModelName; }
            set { this._languageModelName = value; }
        }

        // Check to see if LanguageModelName property is set
        internal bool IsSetLanguageModelName()
        {
            return this._languageModelName != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// Language codes for the languages that you want to identify. You must provide at least
        /// 2 codes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LanguageOptions
        {
            get { return this._languageOptions; }
            set { this._languageOptions = value; }
        }

        // Check to see if LanguageOptions property is set
        internal bool IsSetLanguageOptions()
        {
            return this._languageOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PartialResultsStability. 
        /// <para>
        /// The stabity level of a partial results transcription. Determines how stable you want
        /// the transcription results to be. A higher level means the transcription results are
        /// less likely to change.
        /// </para>
        /// </summary>
        public TranscribePartialResultsStability PartialResultsStability
        {
            get { return this._partialResultsStability; }
            set { this._partialResultsStability = value; }
        }

        // Check to see if PartialResultsStability property is set
        internal bool IsSetPartialResultsStability()
        {
            return this._partialResultsStability != null;
        }

        /// <summary>
        /// Gets and sets the property PiiEntityTypes. 
        /// <para>
        /// Lists the PII entity types you want to identify or redact. To specify entity types,
        /// you must enable <code>ContentIdentificationType</code> or <code>ContentRedactionType</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PIIEntityTypes</code> must be comma-separated. The available values are: <code>BANK_ACCOUNT_NUMBER</code>,
        /// <code>BANK_ROUTING, CREDIT_DEBIT_NUMBER</code>, <code>CREDIT_DEBIT_CVV</code>, <code>CREDIT_DEBIT_EXPIRY</code>,
        /// <code>PIN</code>, <code>EMAIL</code>, <code>ADDRESS</code>, <code>NAME</code>, <code>PHONE</code>,
        /// <code>SSN</code>, and <code>ALL</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PiiEntityTypes</code> is an optional parameter with a default value of <code>ALL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string PiiEntityTypes
        {
            get { return this._piiEntityTypes; }
            set { this._piiEntityTypes = value; }
        }

        // Check to see if PiiEntityTypes property is set
        internal bool IsSetPiiEntityTypes()
        {
            return this._piiEntityTypes != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredLanguage. 
        /// <para>
        /// Language code for the preferred language.
        /// </para>
        /// </summary>
        public TranscribeLanguageCode PreferredLanguage
        {
            get { return this._preferredLanguage; }
            set { this._preferredLanguage = value; }
        }

        // Check to see if PreferredLanguage property is set
        internal bool IsSetPreferredLanguage()
        {
            return this._preferredLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region passed to Amazon Transcribe. If you don't specify a Region, Amazon
        /// Chime uses the meeting's Region.
        /// </para>
        /// </summary>
        public TranscribeRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// The filtering method passed to Amazon Transcribe.
        /// </para>
        /// </summary>
        public TranscribeVocabularyFilterMethod VocabularyFilterMethod
        {
            get { return this._vocabularyFilterMethod; }
            set { this._vocabularyFilterMethod = value; }
        }

        // Check to see if VocabularyFilterMethod property is set
        internal bool IsSetVocabularyFilterMethod()
        {
            return this._vocabularyFilterMethod != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the vocabulary filter passed to Amazon Transcribe.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string VocabularyFilterName
        {
            get { return this._vocabularyFilterName; }
            set { this._vocabularyFilterName = value; }
        }

        // Check to see if VocabularyFilterName property is set
        internal bool IsSetVocabularyFilterName()
        {
            return this._vocabularyFilterName != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the vocabulary passed to Amazon Transcribe.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string VocabularyName
        {
            get { return this._vocabularyName; }
            set { this._vocabularyName = value; }
        }

        // Check to see if VocabularyName property is set
        internal bool IsSetVocabularyName()
        {
            return this._vocabularyName != null;
        }

    }
}