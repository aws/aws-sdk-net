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
    /// A structure that contains the configuration settings for an Amazon Transcribe call
    /// analytics processor.
    /// </summary>
    public partial class AmazonTranscribeCallAnalyticsProcessorConfiguration
    {
        /// <summary>
        /// Gets and sets the property CallAnalyticsStreamCategories. 
        /// <para>
        /// By default, all <c>CategoryEvents</c> are sent to the insights target. If this parameter
        /// is specified, only included categories are sent to the insights target. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> CallAnalyticsStreamCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CallAnalyticsStreamCategories property is set.
        /// </summary>
        internal bool IsSetCallAnalyticsStreamCategories() => this.CallAnalyticsStreamCategories != null && (this.CallAnalyticsStreamCategories.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// the same request. If you do, your request returns a <c>BadRequestException</c>.
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
        /// Content redaction is performed at the segment level; PII specified in <c>PiiEntityTypes</c>
        /// is redacted upon complete transcription of an audio segment.
        /// </para>
        ///  
        /// <para>
        /// You can’t set <c>ContentRedactionType</c> and <c>ContentIdentificationType</c> in
        /// the same request. If you do, your request returns a <c>BadRequestException</c>.
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
        /// can reduce latency in your output, but may impact accuracy. For more information,
        /// see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html#streaming-partial-result-stabilization">Partial-result
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
        /// If true, <c>UtteranceEvents</c> with <c>IsPartial: true</c> are filtered out of the
        /// insights target.
        /// </para>
        /// </summary>
        public bool? FilterPartialResults { get; set; }

        /// <summary>
        /// Checks to see if the FilterPartialResults property is set.
        /// </summary>
        internal bool IsSetFilterPartialResults() => this.FilterPartialResults.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code in the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CallAnalyticsLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

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
        [AWSProperty(Min = 1, Max = 200)]
        public string LanguageModelName { get; set; }

        /// <summary>
        /// Checks to see if the LanguageModelName property is set.
        /// </summary>
        internal bool IsSetLanguageModelName() => this.LanguageModelName != null;

        /// <summary>
        /// Gets and sets the property PartialResultsStability. 
        /// <para>
        /// Specifies the level of stability to use when you enable partial results stabilization
        /// (<c>EnablePartialResultsStabilization</c>).
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
        /// Specifies the types of personally identifiable information (PII) to redact from a
        /// transcript. You can include as many types as you'd like, or you can select <c>ALL</c>.
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
        /// Length Constraints: Minimum length of 1. Maximum length of 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string PiiEntityTypes { get; set; }

        /// <summary>
        /// Checks to see if the PiiEntityTypes property is set.
        /// </summary>
        internal bool IsSetPiiEntityTypes() => this.PiiEntityTypes != null;

        /// <summary>
        /// Gets and sets the property PostCallAnalyticsSettings. 
        /// <para>
        /// The settings for a post-call analysis task in an analytics configuration.
        /// </para>
        /// </summary>
        public PostCallAnalyticsSettings PostCallAnalyticsSettings { get; set; }

        /// <summary>
        /// Checks to see if the PostCallAnalyticsSettings property is set.
        /// </summary>
        internal bool IsSetPostCallAnalyticsSettings() => this.PostCallAnalyticsSettings != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Specifies how to apply a vocabulary filter to a transcript.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <b>***</b>, choose <c>mask</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete words, choose <c>remove</c>.
        /// </para>
        ///  
        /// <para>
        /// To flag words without changing them, choose <c>tag</c>. 
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
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyFilterName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterName property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterName() => this.VocabularyFilterName != null;

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
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;
    }
}
