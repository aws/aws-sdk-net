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
        public ContentType ContentIdentificationType { get; set; }

        /// <summary>
        /// Checks to see if the ContentIdentificationType property is set.
        /// </summary>
        internal bool IsSetContentIdentificationType() => this.ContentIdentificationType != null;

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
        public ContentType ContentRedactionType { get; set; }

        /// <summary>
        /// Checks to see if the ContentRedactionType property is set.
        /// </summary>
        internal bool IsSetContentRedactionType() => this.ContentRedactionType != null;

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
        public bool? EnablePartialResultsStabilization { get; set; }

        /// <summary>
        /// Checks to see if the EnablePartialResultsStabilization property is set.
        /// </summary>
        internal bool IsSetEnablePartialResultsStabilization() => this.EnablePartialResultsStabilization.HasValue;

        /// <summary>
        /// Gets and sets the property FilterPartialResults. 
        /// <para>
        /// If true, <c>TranscriptEvents</c> with <c>IsPartial: true</c> are filtered out of the
        /// insights target.
        /// </para>
        /// </summary>
        public bool? FilterPartialResults { get; set; }

        /// <summary>
        /// Checks to see if the FilterPartialResults property is set.
        /// </summary>
        internal bool IsSetFilterPartialResults() => this.FilterPartialResults.HasValue;

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Turns language identification on or off.
        /// </para>
        /// </summary>
        public bool? IdentifyLanguage { get; set; }

        /// <summary>
        /// Checks to see if the IdentifyLanguage property is set.
        /// </summary>
        internal bool IsSetIdentifyLanguage() => this.IdentifyLanguage.HasValue;

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
        public bool? IdentifyMultipleLanguages { get; set; }

        /// <summary>
        /// Checks to see if the IdentifyMultipleLanguages property is set.
        /// </summary>
        internal bool IsSetIdentifyMultipleLanguages() => this.IdentifyMultipleLanguages.HasValue;

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
        public CallAnalyticsLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

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
        [AWSProperty(Min = 1, Max = 200)]
        public string LanguageModelName { get; set; }

        /// <summary>
        /// Checks to see if the LanguageModelName property is set.
        /// </summary>
        internal bool IsSetLanguageModelName() => this.LanguageModelName != null;

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// The language options for the transcription, such as automatic language detection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string LanguageOptions { get; set; }

        /// <summary>
        /// Checks to see if the LanguageOptions property is set.
        /// </summary>
        internal bool IsSetLanguageOptions() => this.LanguageOptions != null;

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
        public PartialResultsStability PartialResultsStability { get; set; }

        /// <summary>
        /// Checks to see if the PartialResultsStability property is set.
        /// </summary>
        internal bool IsSetPartialResultsStability() => this.PartialResultsStability != null;

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
        [AWSProperty(Min = 1, Max = 300)]
        public string PiiEntityTypes { get; set; }

        /// <summary>
        /// Checks to see if the PiiEntityTypes property is set.
        /// </summary>
        internal bool IsSetPiiEntityTypes() => this.PiiEntityTypes != null;

        /// <summary>
        /// Gets and sets the property PreferredLanguage. 
        /// <para>
        /// The preferred language for the transcription.
        /// </para>
        /// </summary>
        public CallAnalyticsLanguageCode PreferredLanguage { get; set; }

        /// <summary>
        /// Checks to see if the PreferredLanguage property is set.
        /// </summary>
        internal bool IsSetPreferredLanguage() => this.PreferredLanguage != null;

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
        public bool? ShowSpeakerLabel { get; set; }

        /// <summary>
        /// Checks to see if the ShowSpeakerLabel property is set.
        /// </summary>
        internal bool IsSetShowSpeakerLabel() => this.ShowSpeakerLabel.HasValue;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// The vocabulary filtering method used in your Call Analytics transcription.
        /// </para>
        /// </summary>
        public VocabularyFilterMethod VocabularyFilterMethod { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterMethod property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterMethod() => this.VocabularyFilterMethod != null;

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
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyFilterName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterName property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterName() => this.VocabularyFilterName != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterNames. 
        /// <para>
        /// The names of the custom vocabulary filter or filters using during transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3000)]
        public string VocabularyFilterNames { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterNames property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterNames() => this.VocabularyFilterNames != null;

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
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;

        /// <summary>
        /// Gets and sets the property VocabularyNames. 
        /// <para>
        /// The names of the custom vocabulary or vocabularies used during transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3000)]
        public string VocabularyNames { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyNames property is set.
        /// </summary>
        internal bool IsSetVocabularyNames() => this.VocabularyNames != null;
    }
}
