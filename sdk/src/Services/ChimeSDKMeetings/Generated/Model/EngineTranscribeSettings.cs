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
    /// Settings specific for Amazon Transcribe as the live transcription engine. 
    /// 
    ///  
    /// <para>
    /// If you specify an invalid combination of parameters, a <code>TranscriptFailed</code>
    /// event will be sent with the contents of the <code>BadRequestException</code> generated
    /// by Amazon Transcribe. For more information on each parameter and which combinations
    /// are valid, refer to the <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/API_streaming_StartStreamTranscription.html">StartStreamTranscription</a>
    /// API in the <i>Amazon Transcribe Developer Guide</i>.
    /// </para>
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
        private string _vocabularyFilterNames;
        private string _vocabularyName;
        private string _vocabularyNames;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Labels all personally identifiable information (PII) identified in your transcript.
        /// If you don't include <code>PiiEntityTypes</code>, all PII is identified.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can’t set <code>ContentIdentificationType</code> and <code>ContentRedactionType</code>.
        /// </para>
        ///  </note>
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
        /// Content redaction is performed at the segment level. If you don't include <code>PiiEntityTypes</code>,
        /// all PII is redacted.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can’t set <code>ContentRedactionType</code> and <code>ContentIdentificationType</code>.
        /// </para>
        ///  </note>
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
        /// Enables partial result stabilization for your transcription. Partial result stabilization
        /// can reduce latency in your output, but may impact accuracy.
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
        /// Enables automatic language identification for your transcription.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>IdentifyLanguage</code>, you can optionally use <code>LanguageOptions</code>
        /// to include a list of language codes that you think may be present in your audio stream.
        /// Including language options can improve transcription accuracy.
        /// </para>
        ///  
        /// <para>
        /// You can also use <code>PreferredLanguage</code> to include a preferred language. Doing
        /// so can help Amazon Transcribe identify the language faster.
        /// </para>
        ///  
        /// <para>
        /// You must include either <code>LanguageCode</code> or <code>IdentifyLanguage</code>.
        /// </para>
        ///  
        /// <para>
        /// Language identification can't be combined with custom language models or redaction.
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
        /// Specify the language code that represents the language spoken.
        /// </para>
        ///  
        /// <para>
        /// If you're unsure of the language spoken in your audio, consider using <code>IdentifyLanguage</code>
        /// to enable automatic language identification.
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
        /// Specify the name of the custom language model that you want to use when processing
        /// your transcription. Note that language model names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified language model must match the language code. If the
        /// languages don't match, the custom language model isn't applied. There are no errors
        /// or warnings associated with a language mismatch.
        /// </para>
        ///  
        /// <para>
        /// If you use Amazon Transcribe in multiple Regions, the custom language model must be
        /// available in Amazon Transcribe in each Region.
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
        /// Specify two or more language codes that represent the languages you think may be present
        /// in your media; including more than five is not recommended. If you're unsure what
        /// languages are present, do not include this parameter.
        /// </para>
        ///  
        /// <para>
        /// Including language options can improve the accuracy of language identification.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>LanguageOptions</code>, you must also include <code>IdentifyLanguage</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only include one language dialect per language. For example, you cannot include
        /// <code>en-US</code> and <code>en-AU</code>.
        /// </para>
        ///  </important>
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
        /// Specify the level of stability to use when you enable partial results stabilization
        /// (<code>EnablePartialResultsStabilization</code>).
        /// </para>
        ///  
        /// <para>
        /// Low stability provides the highest accuracy. High stability transcribes faster, but
        /// with slightly lower accuracy.
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
        /// Specify which types of personally identifiable information (PII) you want to redact
        /// in your transcript. You can include as many types as you'd like, or you can select
        /// <code>ALL</code>.
        /// </para>
        ///  
        /// <para>
        /// Values must be comma-separated and can include: <code>ADDRESS</code>, <code>BANK_ACCOUNT_NUMBER</code>,
        /// <code>BANK_ROUTING</code>, <code>CREDIT_DEBIT_CVV</code>, <code>CREDIT_DEBIT_EXPIRY</code>
        /// <code>CREDIT_DEBIT_NUMBER</code>, <code>EMAIL</code>,<code>NAME</code>, <code>PHONE</code>,
        /// <code>PIN</code>, <code>SSN</code>, or <code>ALL</code>.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <code>PiiEntityTypes</code>, you must also include <code>ContentIdentificationType</code>
        /// or <code>ContentRedactionType</code>.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>ContentRedactionType</code> or <code>ContentIdentificationType</code>,
        /// but do not include PiiEntityTypes, all PII is redacted or identified.
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
        /// Specify a preferred language from the subset of languages codes you specified in <code>LanguageOptions</code>.
        /// </para>
        ///  
        /// <para>
        /// You can only use this parameter if you include <code>IdentifyLanguage</code> and <code>LanguageOptions</code>.
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
        /// The AWS Region in which to use Amazon Transcribe.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a Region, then the <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeeting.html">MediaRegion</a>
        /// of the meeting is used. However, if Amazon Transcribe is not available in the <code>MediaRegion</code>,
        /// then a <code>TranscriptFailed</code> event is sent.
        /// </para>
        ///  
        /// <para>
        /// Use <code>auto</code> to use Amazon Transcribe in a Region near the meeting’s <code>MediaRegion</code>.
        /// For more information, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/transcription-options.html#choose-region">Choosing
        /// a transcription Region</a> in the <i>Amazon Chime SDK Developer Guide</i>.
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
        /// Specify how you want your vocabulary filter applied to your transcript.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <code>***</code>, choose <code>mask</code>.
        /// </para>
        ///  
        /// <para>
        /// To delete words, choose <code>remove</code>.
        /// </para>
        ///  
        /// <para>
        /// To flag words without changing them, choose <code>tag</code>.
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
        /// Specify the name of the custom vocabulary filter that you want to use when processing
        /// your transcription. Note that vocabulary filter names are case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// If you use Amazon Transcribe in multiple Regions, the vocabulary filter must be available
        /// in Amazon Transcribe in each Region.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>IdentifyLanguage</code> and want to use one or more vocabulary
        /// filters with your transcription, use the <code>VocabularyFilterNames</code> parameter
        /// instead.
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
        /// Gets and sets the property VocabularyFilterNames. 
        /// <para>
        /// Specify the names of the custom vocabulary filters that you want to use when processing
        /// your transcription. Note that vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If you use Amazon Transcribe in multiple Regions, the vocabulary filter must be available
        /// in Amazon Transcribe in each Region.
        /// </para>
        ///  
        /// <para>
        ///  If you're <i>not</i> including <code>IdentifyLanguage</code> and want to use a custom
        /// vocabulary filter with your transcription, use the <code>VocabularyFilterName</code>
        /// parameter instead.
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
        /// Specify the name of the custom vocabulary that you want to use when processing your
        /// transcription. Note that vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If you use Amazon Transcribe multiple Regions, the vocabulary must be available in
        /// Amazon Transcribe in each Region.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>IdentifyLanguage</code> and want to use one or more custom vocabularies
        /// with your transcription, use the <code>VocabularyNames</code> parameter instead.
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

        /// <summary>
        /// Gets and sets the property VocabularyNames. 
        /// <para>
        /// Specify the names of the custom vocabularies that you want to use when processing
        /// your transcription. Note that vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If you use Amazon Transcribe in multiple Regions, the vocabulary must be available
        /// in Amazon Transcribe in each Region.
        /// </para>
        ///  
        /// <para>
        /// If you don't include <code>IdentifyLanguage</code> and want to use a custom vocabulary
        /// with your transcription, use the <code>VocabularyName</code> parameter instead.
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