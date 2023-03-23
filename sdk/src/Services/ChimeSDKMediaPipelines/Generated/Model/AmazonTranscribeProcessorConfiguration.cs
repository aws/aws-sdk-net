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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A structure that contains the configuration settings for an Amazon Transcribe processor.
    /// </summary>
    public partial class AmazonTranscribeProcessorConfiguration
    {
        private ContentType _contentIdentificationType;
        private ContentType _contentRedactionType;
        private bool? _enablePartialResultsStabilization;
        private bool? _filterPartialResults;
        private CallAnalyticsLanguageCode _languageCode;
        private string _languageModelName;
        private PartialResultsStability _partialResultsStability;
        private string _piiEntityTypes;
        private bool? _showSpeakerLabel;
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Labels all personally identifiable information (PII) identified in your transcript.
        /// </para>
        ///  
        /// <para>
        /// Content identification is performed at the segment level; PII specified in <code>PiiEntityTypes</code>
        /// is flagged upon complete transcription of an audio segment.
        /// </para>
        ///  
        /// <para>
        /// You can’t set <code>ContentIdentificationType</code> and <code>ContentRedactionType</code>
        /// in the same request. If you set both, your request returns a <code>BadRequestException</code>.
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
        /// If you set both, your request returns a <code>BadRequestException</code>.
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
        /// Gets and sets the property FilterPartialResults. 
        /// <para>
        /// If true, <code>TranscriptEvents</code> with <code>IsPartial: true</code> are filtered
        /// out of the insights target.
        /// </para>
        /// </summary>
        public bool FilterPartialResults
        {
            get { return this._filterPartialResults.GetValueOrDefault(); }
            set { this._filterPartialResults = value; }
        }

        // Check to see if FilterPartialResults property is set
        internal bool IsSetFilterPartialResults()
        {
            return this._filterPartialResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language spoken in your audio.
        /// </para>
        ///  
        /// <para>
        /// If you're unsure of the language spoken in your audio, consider using <code>IdentifyLanguage</code>
        /// to enable automatic language identification.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages that real-time Call Analytics supports, see the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages table</a> in the <i>Amazon Transcribe Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PartialResultsStability. 
        /// <para>
        /// The level of stability to use when you enable partial results stabilization (<code>EnablePartialResultsStabilization</code>).
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
        /// You can include as many types as you'd like, or you can select <code>ALL</code>.
        /// </para>
        ///  
        /// <para>
        /// To include <code>PiiEntityTypes</code> in your Call Analytics request, you must also
        /// include <code>ContentIdentificationType</code> or <code>ContentRedactionType</code>,
        /// but you can't include both.
        /// </para>
        ///  
        /// <para>
        /// Values must be comma-separated and can include: <code>ADDRESS</code>, <code>BANK_ACCOUNT_NUMBER</code>,
        /// <code>BANK_ROUTING</code>, <code>CREDIT_DEBIT_CVV</code>, <code>CREDIT_DEBIT_EXPIRY</code>,
        /// <code>CREDIT_DEBIT_NUMBER</code>, <code>EMAIL</code>, <code>NAME</code>, <code>PHONE</code>,
        /// <code>PIN</code>, <code>SSN</code>, or <code>ALL</code>.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 300.
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
        public bool ShowSpeakerLabel
        {
            get { return this._showSpeakerLabel.GetValueOrDefault(); }
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

    }
}