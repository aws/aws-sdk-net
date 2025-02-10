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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A structure that contains the configuration settings for an Amazon Transcribe processor.
    /// 
    ///  <note> 
    /// <para>
    /// Calls to this API must include a <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or
    /// <c>IdentifyMultipleLanguages</c> parameter. If you include more than one of those
    /// parameters, your transcription job fails.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonTranscribeProcessorConfiguration
    {
        private ContentType _contentIdentificationType;
        private ContentType _contentRedactionType;
        private bool? _enablePartialResultsStabilization;
        private bool? _filterPartialResults;
        private bool? _identifyLanguage;
        private bool? _identifyMultipleLanguages;
        private CallAnalyticsLanguageCode _languageCode;
        private string _languageModelName;
        private string _languageOptions;
        private PartialResultsStability _partialResultsStability;
        private string _piiEntityTypes;
        private CallAnalyticsLanguageCode _preferredLanguage;
        private bool? _showSpeakerLabel;
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyFilterNames;
        private string _vocabularyName;
        private string _vocabularyNames;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Labels all personally identifiable information (PII) identified in your transcript.
        /// </para>
        ///  
        /// <para>
        /// Content identification is performed at the segment level; PII specified in <c>PiiEntityTypes</c>
        /// is flagged upon complete transcription of an audio segment.
        /// </para>
        ///  
        /// <para>
        /// You can’t set <c>ContentIdentificationType</c> and <c>ContentRedactionType</c> in
        /// the same request. If you set both, your request returns a <c>BadRequestException</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/pii-redaction.html">Redacting
        /// or identifying personally identifiable information</a> in the <i>Amazon Transcribe
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public ContentType ContentIdentificationType
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
        /// Redacts all personally identifiable information (PII) identified in your transcript.
        /// </para>
        ///  
        /// <para>
        /// Content redaction is performed at the segment level; PII specified in PiiEntityTypes
        /// is redacted upon complete transcription of an audio segment.
        /// </para>
        ///  
        /// <para>
        /// You can’t set ContentRedactionType and ContentIdentificationType in the same request.
        /// If you set both, your request returns a <c>BadRequestException</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/pii-redaction.html">Redacting
        /// or identifying personally identifiable information</a> in the <i>Amazon Transcribe
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public ContentType ContentRedactionType
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
        /// Enables partial result stabilization for your transcription. Partial result stabilization
        /// can reduce latency in your output, but may impact accuracy.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html#streaming-partial-result-stabilization">Partial-result
        /// stabilization</a> in the <i>Amazon Transcribe Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnablePartialResultsStabilization
        {
            get { return this._enablePartialResultsStabilization; }
            set { this._enablePartialResultsStabilization = value; }
        }

        // Check to see if EnablePartialResultsStabilization property is set
        internal bool IsSetEnablePartialResultsStabilization()
        {
            return this._enablePartialResultsStabilization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilterPartialResults. 
        /// <para>
        /// If true, <c>TranscriptEvents</c> with <c>IsPartial: true</c> are filtered out of the
        /// insights target.
        /// </para>
        /// </summary>
        public bool? FilterPartialResults
        {
            get { return this._filterPartialResults; }
            set { this._filterPartialResults = value; }
        }

        // Check to see if FilterPartialResults property is set
        internal bool IsSetFilterPartialResults()
        {
            return this._filterPartialResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Turns language identification on or off.
        /// </para>
        /// </summary>
        public bool? IdentifyLanguage
        {
            get { return this._identifyLanguage; }
            set { this._identifyLanguage = value; }
        }

        // Check to see if IdentifyLanguage property is set
        internal bool IsSetIdentifyLanguage()
        {
            return this._identifyLanguage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyMultipleLanguages. 
        /// <para>
        /// Turns language identification on or off for multiple languages.
        /// </para>
        ///  <note> 
        /// <para>
        /// Calls to this API must include a <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or
        /// <c>IdentifyMultipleLanguages</c> parameter. If you include more than one of those
        /// parameters, your transcription job fails.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? IdentifyMultipleLanguages
        {
            get { return this._identifyMultipleLanguages; }
            set { this._identifyMultipleLanguages = value; }
        }

        // Check to see if IdentifyMultipleLanguages property is set
        internal bool IsSetIdentifyMultipleLanguages()
        {
            return this._identifyMultipleLanguages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language spoken in your audio.
        /// </para>
        ///  
        /// <para>
        /// If you're unsure of the language spoken in your audio, consider using <c>IdentifyLanguage</c>
        /// to enable automatic language identification.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages that real-time Call Analytics supports, see the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages table</a> in the <i>Amazon Transcribe Developer Guide</i>.
        /// </para>
        /// </summary>
        public CallAnalyticsLanguageCode LanguageCode
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
        /// The name of the custom language model that you want to use when processing your transcription.
        /// Note that language model names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified language model must match the language code you specify
        /// in your transcription request. If the languages don't match, the custom language model
        /// isn't applied. There are no errors or warnings associated with a language mismatch.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-language-models.html">Custom
        /// language models</a> in the <i>Amazon Transcribe Developer Guide</i>.
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
        /// The language options for the transcription, such as automatic language detection.
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
        /// The level of stability to use when you enable partial results stabilization (<c>EnablePartialResultsStabilization</c>).
        /// </para>
        ///  
        /// <para>
        /// Low stability provides the highest accuracy. High stability transcribes faster, but
        /// with slightly lower accuracy.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html#streaming-partial-result-stabilization">Partial-result
        /// stabilization</a> in the <i>Amazon Transcribe Developer Guide</i>.
        /// </para>
        /// </summary>
        public PartialResultsStability PartialResultsStability
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
        /// The types of personally identifiable information (PII) to redact from a transcript.
        /// You can include as many types as you'd like, or you can select <c>ALL</c>.
        /// </para>
        ///  
        /// <para>
        /// To include <c>PiiEntityTypes</c> in your Call Analytics request, you must also include
        /// <c>ContentIdentificationType</c> or <c>ContentRedactionType</c>, but you can't include
        /// both.
        /// </para>
        ///  
        /// <para>
        /// Values must be comma-separated and can include: <c>ADDRESS</c>, <c>BANK_ACCOUNT_NUMBER</c>,
        /// <c>BANK_ROUTING</c>, <c>CREDIT_DEBIT_CVV</c>, <c>CREDIT_DEBIT_EXPIRY</c>, <c>CREDIT_DEBIT_NUMBER</c>,
        /// <c>EMAIL</c>, <c>NAME</c>, <c>PHONE</c>, <c>PIN</c>, <c>SSN</c>, or <c>ALL</c>.
        /// </para>
        ///  
        /// <para>
        /// If you leave this parameter empty, the default behavior is equivalent to <c>ALL</c>.
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
        /// The preferred language for the transcription.
        /// </para>
        /// </summary>
        public CallAnalyticsLanguageCode PreferredLanguage
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
        /// Gets and sets the property ShowSpeakerLabel. 
        /// <para>
        /// Enables speaker partitioning (diarization) in your transcription output. Speaker partitioning
        /// labels the speech from individual speakers in your media file.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/diarization.html">Partitioning
        /// speakers (diarization)</a> in the <i>Amazon Transcribe Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? ShowSpeakerLabel
        {
            get { return this._showSpeakerLabel; }
            set { this._showSpeakerLabel = value; }
        }

        // Check to see if ShowSpeakerLabel property is set
        internal bool IsSetShowSpeakerLabel()
        {
            return this._showSpeakerLabel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// The vocabulary filtering method used in your Call Analytics transcription.
        /// </para>
        /// </summary>
        public VocabularyFilterMethod VocabularyFilterMethod
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
        /// The name of the custom vocabulary filter that you specified in your Call Analytics
        /// request.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 200.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property VocabularyFilterNames. 
        /// <para>
        /// The names of the custom vocabulary filter or filters using during transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
        public string VocabularyFilterNames
        {
            get { return this._vocabularyFilterNames; }
            set { this._vocabularyFilterNames = value; }
        }

        // Check to see if VocabularyFilterNames property is set
        internal bool IsSetVocabularyFilterNames()
        {
            return this._vocabularyFilterNames != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the custom vocabulary that you specified in your Call Analytics request.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 200.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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

        /// <summary>
        /// Gets and sets the property VocabularyNames. 
        /// <para>
        /// The names of the custom vocabulary or vocabularies used during transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
        public string VocabularyNames
        {
            get { return this._vocabularyNames; }
            set { this._vocabularyNames = value; }
        }

        // Check to see if VocabularyNames property is set
        internal bool IsSetVocabularyNames()
        {
            return this._vocabularyNames != null;
        }

    }
}