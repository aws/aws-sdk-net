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

namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Container for the parameters to the StartCallAnalyticsStreamTranscription operation.
    /// Starts a bidirectional HTTP/2 or WebSocket stream where audio is streamed to Amazon
    /// Transcribe and the transcription results are streamed to your application. Use this
    /// operation for <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics.html">Call
    /// Analytics</a> transcriptions. <para> The following parameters are required: </para>
    /// <ul> <li> <para> <c>language-code</c> or <c>identify-language</c> </para> </li> <li>
    /// <para> <c>media-encoding</c> </para> </li> <li> <para> <c>sample-rate</c> </para>
    /// </li> </ul> <para> For more information on streaming with Amazon Transcribe, see <a
    /// href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html">Transcribing
    /// streaming audio</a>. </para>
    /// </summary>
    public partial class StartCallAnalyticsStreamTranscriptionRequest : AmazonTranscribeStreamingRequest
    {
        /// <summary>
        /// Gets and sets the property AudioStreamPublisher. 
        /// <para>
        /// An encoded stream of audio blobs. Audio streams are encoded as either HTTP/2 or WebSocket
        /// data frames.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html">Transcribing
        /// streaming audio</a>.
        /// </para>
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IAudioStreamEvent
        /// interface. The known implementations in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="AudioEvent"/></term></item>
        ///   <item><term><see cref="ConfigurationEvent"/></term></item>
        /// </list>
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Func<System.Threading.Tasks.Task<IAudioStreamEvent>> AudioStreamPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Labels all personally identifiable information (PII) identified in your transcript.
        /// </para>
        ///  
        /// <para>
        /// Content identification is performed at the segment level; PII specified in <c>PiiEntityTypes</c>
        /// is flagged upon complete transcription of an audio segment. If you don't include <c>PiiEntityTypes</c>
        /// in your request, all PII is identified.
        /// </para>
        ///  
        /// <para>
        /// You can’t set <c>ContentIdentificationType</c> and <c>ContentRedactionType</c> in
        /// the same request. If you set both, your request returns a <c>BadRequestException</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/pii-redaction.html">Redacting
        /// or identifying personally identifiable information</a>.
        /// </para>
        /// </summary>
        public ContentIdentificationType ContentIdentificationType { get; set; }

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
        /// is redacted upon complete transcription of an audio segment. If you don't include
        /// <c>PiiEntityTypes</c> in your request, all PII is redacted.
        /// </para>
        ///  
        /// <para>
        /// You can’t set <c>ContentRedactionType</c> and <c>ContentIdentificationType</c> in
        /// the same request. If you set both, your request returns a <c>BadRequestException</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/pii-redaction.html">Redacting
        /// or identifying personally identifiable information</a>.
        /// </para>
        /// </summary>
        public ContentRedactionType ContentRedactionType { get; set; }

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
        /// stabilization</a>.
        /// </para>
        /// </summary>
        public bool? EnablePartialResultsStabilization { get; set; }

        /// <summary>
        /// Checks to see if the EnablePartialResultsStabilization property is set.
        /// </summary>
        internal bool IsSetEnablePartialResultsStabilization() => this.EnablePartialResultsStabilization.HasValue;

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Enables automatic language identification for your Call Analytics transcription.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>IdentifyLanguage</c>, you must include a list of language codes,
        /// using <c>LanguageOptions</c>, that you think may be present in your audio stream.
        /// You must provide a minimum of two language selections.
        /// </para>
        ///  
        /// <para>
        /// You can also include a preferred language using <c>PreferredLanguage</c>. Adding a
        /// preferred language can help Amazon Transcribe identify the language faster than if
        /// you omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that you must include either <c>LanguageCode</c> or <c>IdentifyLanguage</c> in
        /// your request. If you include both parameters, your transcription job fails.
        /// </para>
        /// </summary>
        public bool? IdentifyLanguage { get; set; }

        /// <summary>
        /// Checks to see if the IdentifyLanguage property is set.
        /// </summary>
        internal bool IsSetIdentifyLanguage() => this.IdentifyLanguage.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Specify the language code that represents the language spoken in your audio.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages supported with real-time Call Analytics, refer to the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
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
        /// Specify the name of the custom language model that you want to use when processing
        /// your transcription. Note that language model names are case sensitive.
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
        /// language models</a>.
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
        /// Specify two or more language codes that represent the languages you think may be present
        /// in your media.
        /// </para>
        ///  
        /// <para>
        /// Including language options can improve the accuracy of language identification.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>LanguageOptions</c> in your request, you must also include <c>IdentifyLanguage</c>.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages supported with Call Analytics streaming, refer to the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only include one language dialect per language per stream. For example, you
        /// cannot include <c>en-US</c> and <c>en-AU</c> in the same request.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string LanguageOptions { get; set; }

        /// <summary>
        /// Checks to see if the LanguageOptions property is set.
        /// </summary>
        internal bool IsSetLanguageOptions() => this.LanguageOptions != null;

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// Specify the encoding of your input audio. Supported formats are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FLAC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPUS-encoded audio in an Ogg container
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PCM (only signed 16-bit little-endian audio formats, which does not include WAV)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-input.html#how-input-audio">Media
        /// formats</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaEncoding MediaEncoding { get; set; }

        /// <summary>
        /// Checks to see if the MediaEncoding property is set.
        /// </summary>
        internal bool IsSetMediaEncoding() => this.MediaEncoding != null;

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate of the input audio (in hertz). Low-quality audio, such as telephone
        /// audio, is typically around 8,000 Hz. High-quality audio typically ranges from 16,000
        /// Hz to 48,000 Hz. Note that the sample rate you specify must match that of your audio.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

        /// <summary>
        /// Gets and sets the property PartialResultsStability. 
        /// <para>
        /// Specify the level of stability to use when you enable partial results stabilization
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
        /// stabilization</a>.
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
        /// Specify which types of personally identifiable information (PII) you want to redact
        /// in your transcript. You can include as many types as you'd like, or you can select
        /// <c>ALL</c>.
        /// </para>
        ///  
        /// <para>
        /// Values must be comma-separated and can include: <c>ADDRESS</c>, <c>BANK_ACCOUNT_NUMBER</c>,
        /// <c>BANK_ROUTING</c>, <c>CREDIT_DEBIT_CVV</c>, <c>CREDIT_DEBIT_EXPIRY</c>, <c>CREDIT_DEBIT_NUMBER</c>,
        /// <c>EMAIL</c>, <c>NAME</c>, <c>PHONE</c>, <c>PIN</c>, <c>SSN</c>, or <c>ALL</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <c>PiiEntityTypes</c> in your request, you must also include
        /// <c>ContentIdentificationType</c> or <c>ContentRedactionType</c>.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>ContentRedactionType</c> or <c>ContentIdentificationType</c> in
        /// your request, but do not include <c>PiiEntityTypes</c>, all PII is redacted or identified.
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
        /// Specify a preferred language from the subset of languages codes you specified in <c>LanguageOptions</c>.
        /// </para>
        ///  
        /// <para>
        /// You can only use this parameter if you've included <c>IdentifyLanguage</c> and <c>LanguageOptions</c>
        /// in your request.
        /// </para>
        /// </summary>
        public CallAnalyticsLanguageCode PreferredLanguage { get; set; }

        /// <summary>
        /// Checks to see if the PreferredLanguage property is set.
        /// </summary>
        internal bool IsSetPreferredLanguage() => this.PreferredLanguage != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// Specify a name for your Call Analytics transcription session. If you don't include
        /// this parameter in your request, Amazon Transcribe generates an ID and returns it in
        /// the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Specify how you want your vocabulary filter applied to your transcript.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <c>***</c>, choose <c>mask</c>.
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
        /// Specify the name of the custom vocabulary filter that you want to use when processing
        /// your transcription. Note that vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If the language of the specified custom vocabulary filter doesn't match the language
        /// identified in your media, the vocabulary filter is not applied to your transcription.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/vocabulary-filtering.html">Using
        /// vocabulary filtering with unwanted words</a>.
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
        /// Specify the names of the custom vocabulary filters that you want to use when processing
        /// your Call Analytics transcription. Note that vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// These filters serve to customize the transcript output.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter is only intended for use <b>with</b> the <c>IdentifyLanguage</c> parameter.
        /// If you're <b>not</b> including <c>IdentifyLanguage</c> in your request and want to
        /// use a custom vocabulary filter with your transcription, use the <c>VocabularyFilterName</c>
        /// parameter instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/vocabulary-filtering.html">Using
        /// vocabulary filtering with unwanted words</a>.
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
        /// Specify the name of the custom vocabulary that you want to use when processing your
        /// transcription. Note that vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If the language of the specified custom vocabulary doesn't match the language identified
        /// in your media, the custom vocabulary is not applied to your transcription.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary.html">Custom
        /// vocabularies</a>.
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
        /// Specify the names of the custom vocabularies that you want to use when processing
        /// your Call Analytics transcription. Note that vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If the custom vocabulary's language doesn't match the identified media language, it
        /// won't be applied to the transcription.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter is only intended for use <b>with</b> the <c>IdentifyLanguage</c> parameter.
        /// If you're <b>not</b> including <c>IdentifyLanguage</c> in your request and want to
        /// use a custom vocabulary with your transcription, use the <c>VocabularyName</c> parameter
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary.html">Custom
        /// vocabularies</a>.
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
