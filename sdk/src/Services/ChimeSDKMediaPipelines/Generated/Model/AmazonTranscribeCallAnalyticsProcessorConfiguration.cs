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
    /// A structure that contains the configuration settings for an Amazon Transcribe call
    /// analytics processor.
    /// </summary>
    public partial class AmazonTranscribeCallAnalyticsProcessorConfiguration
    {
        private List<string> _callAnalyticsStreamCategories = new List<string>();
        private ContentType _contentIdentificationType;
        private ContentType _contentRedactionType;
        private bool? _enablePartialResultsStabilization;
        private bool? _filterPartialResults;
        private CallAnalyticsLanguageCode _languageCode;
        private string _languageModelName;
        private PartialResultsStability _partialResultsStability;
        private string _piiEntityTypes;
        private PostCallAnalyticsSettings _postCallAnalyticsSettings;
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property CallAnalyticsStreamCategories. 
        /// <para>
        /// By default, all <code>CategoryEvents</code> will be sent to the insights target. If
        /// this parameter is specified, only included categories will be sent to the insights
        /// target. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> CallAnalyticsStreamCategories
        {
            get { return this._callAnalyticsStreamCategories; }
            set { this._callAnalyticsStreamCategories = value; }
        }

        // Check to see if CallAnalyticsStreamCategories property is set
        internal bool IsSetCallAnalyticsStreamCategories()
        {
            return this._callAnalyticsStreamCategories != null && this._callAnalyticsStreamCategories.Count > 0; 
        }

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
        /// in the same request. If you do, your request returns a <code>BadRequestException</code>.
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
        /// Content redaction is performed at the segment level; PII specified in <code>PiiEntityTypes</code>
        /// is redacted upon complete transcription of an audio segment.
        /// </para>
        ///  
        /// <para>
        /// You can’t set <code>ContentRedactionType</code> and <code>ContentIdentificationType</code>
        /// in the same request. If you do, your request returns a <code>BadRequestException</code>.
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
        /// can reduce latency in your output, but may impact accuracy. For more information,
        /// see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html#streaming-partial-result-stabilization">Partial-result
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
        /// If true, <code>UtteranceEvents</code> with <code>IsPartial: true</code> are filtered
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
        /// The language code in the configuration.
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
        /// Specifies the name of the custom language model to use when processing a transcription.
        /// Note that language model names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified language model must match the language code specified
        /// in the transcription request. If the languages don't match, the custom language model
        /// isn't applied. Language mismatches don't generate errors or warnings.
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
        /// Specifies the level of stability to use when you enable partial results stabilization
        /// (<code>EnablePartialResultsStabilization</code>).
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
        /// Specifies the types of personally identifiable information (PII) to redact from a
        /// transcript. You can include as many types as you'd like, or you can select <code>ALL</code>.
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
        /// Gets and sets the property PostCallAnalyticsSettings. 
        /// <para>
        /// The settings for a post-call analysis task in an analytics configuration.
        /// </para>
        /// </summary>
        public PostCallAnalyticsSettings PostCallAnalyticsSettings
        {
            get { return this._postCallAnalyticsSettings; }
            set { this._postCallAnalyticsSettings = value; }
        }

        // Check to see if PostCallAnalyticsSettings property is set
        internal bool IsSetPostCallAnalyticsSettings()
        {
            return this._postCallAnalyticsSettings != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Specifies how to apply a vocabulary filter to a transcript.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <b>***</b>, choose <code>mask</code>.
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
        /// Specifies the name of the custom vocabulary filter to use when processing a transcription.
        /// Note that vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If the language of the specified custom vocabulary filter doesn't match the language
        /// identified in your media, the vocabulary filter is not applied to your transcription.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/vocabulary-filtering.html">Using
        /// vocabulary filtering with unwanted words</a> in the <i>Amazon Transcribe Developer
        /// Guide</i>.
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
        /// Specifies the name of the custom vocabulary to use when processing a transcription.
        /// Note that vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If the language of the specified custom vocabulary doesn't match the language identified
        /// in your media, the custom vocabulary is not applied to your transcription.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary.html">Custom
        /// vocabularies</a> in the <i>Amazon Transcribe Developer Guide</i>.
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