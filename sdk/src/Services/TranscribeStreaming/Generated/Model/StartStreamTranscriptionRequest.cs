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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
    /// Container for the parameters to the StartStreamTranscription operation.
    /// Starts a bidirectional HTTP/2 or WebSocket stream where audio is streamed to Amazon
    /// Transcribe and the transcription results are streamed to your application.
    /// 
    ///  
    /// <para>
    /// The following parameters are required:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>language-code</c> or <c>identify-language</c> or <c>identify-multiple-language</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>media-encoding</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>sample-rate</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information on streaming with Amazon Transcribe, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html">Transcribing
    /// streaming audio</a>.
    /// </para>
    /// </summary>
    public partial class StartStreamTranscriptionRequest : AmazonTranscribeStreamingRequest
    {
        private ContentIdentificationType _contentIdentificationType;
        private ContentRedactionType _contentRedactionType;
        private bool? _enableChannelIdentification;
        private bool? _enablePartialResultsStabilization;
        private bool? _identifyLanguage;
        private bool? _identifyMultipleLanguages;
        private LanguageCode _languageCode;
        private string _languageModelName;
        private string _languageOptions;
        private MediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private int? _numberOfChannels;
        private PartialResultsStability _partialResultsStability;
        private string _piiEntityTypes;
        private LanguageCode _preferredLanguage;
        private string _sessionId;
        private bool? _showSpeakerLabel;
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyFilterNames;
        private string _vocabularyName;
        private string _vocabularyNames;

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
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="AudioEvent"/></term></item>
        ///   <item><term><see cref="ConfigurationEvent"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        [AWSProperty(Required=true)]
        public  Func<System.Threading.Tasks.Task<IAudioStreamEvent>> AudioStreamPublisher { get; set; }

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
        public ContentIdentificationType ContentIdentificationType
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
        public ContentRedactionType ContentRedactionType
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
        /// Gets and sets the property EnableChannelIdentification. 
        /// <para>
        /// Enables channel identification in multi-channel audio.
        /// </para>
        ///  
        /// <para>
        /// Channel identification transcribes the audio on each channel independently, then appends
        /// the output for each channel into one transcript.
        /// </para>
        ///  
        /// <para>
        /// If you have multi-channel audio and do not enable channel identification, your audio
        /// is transcribed in a continuous manner and your transcript is not separated by channel.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>EnableChannelIdentification</c> in your request, you must also include
        /// <c>NumberOfChannels</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/channel-id.html">Transcribing
        /// multi-channel audio</a>.
        /// </para>
        /// </summary>
        public bool? EnableChannelIdentification
        {
            get { return this._enableChannelIdentification; }
            set { this._enableChannelIdentification = value; }
        }

        // Check to see if EnableChannelIdentification property is set
        internal bool IsSetEnableChannelIdentification()
        {
            return this._enableChannelIdentification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePartialResultsStabilization. 
        /// <para>
        /// Enables partial result stabilization for your transcription. Partial result stabilization
        /// can reduce latency in your output, but may impact accuracy. For more information,
        /// see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html#streaming-partial-result-stabilization">Partial-result
        /// stabilization</a>.
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
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Enables automatic language identification for your transcription.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>IdentifyLanguage</c>, you must include a list of language codes,
        /// using <c>LanguageOptions</c>, that you think may be present in your audio stream.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can also include a preferred language using <c>PreferredLanguage</c>. Adding a
        /// preferred language can help Amazon Transcribe identify the language faster than if
        /// you omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have multi-channel audio that contains different languages on each channel,
        /// and you've enabled channel identification, automatic language identification identifies
        /// the dominant language on each audio channel.
        /// </para>
        ///  
        /// <para>
        /// Note that you must include either <c>LanguageCode</c> or <c>IdentifyLanguage</c> or
        /// <c>IdentifyMultipleLanguages</c> in your request. If you include more than one of
        /// these parameters, your transcription job fails.
        /// </para>
        ///  
        /// <para>
        /// Streaming language identification can't be combined with custom language models or
        /// redaction.
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
        /// Enables automatic multi-language identification in your transcription job request.
        /// Use this parameter if your stream contains more than one language. If your stream
        /// contains only one language, use IdentifyLanguage instead.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>IdentifyMultipleLanguages</c>, you must include a list of language
        /// codes, using <c>LanguageOptions</c>, that you think may be present in your stream.
        /// </para>
        ///  
        /// <para>
        /// If you want to apply a custom vocabulary or a custom vocabulary filter to your automatic
        /// multiple language identification request, include <c>VocabularyNames</c> or <c>VocabularyFilterNames</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that you must include one of <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or
        /// <c>IdentifyMultipleLanguages</c> in your request. If you include more than one of
        /// these parameters, your transcription job fails.
        /// </para>
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
        /// Specify the language code that represents the language spoken in your audio.
        /// </para>
        ///  
        /// <para>
        /// If you're unsure of the language spoken in your audio, consider using <c>IdentifyLanguage</c>
        /// to enable automatic language identification.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages supported with Amazon Transcribe streaming, refer to the <a
        /// href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
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
        /// in your media; including more than five is not recommended.
        /// </para>
        ///  
        /// <para>
        /// Including language options can improve the accuracy of language identification.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>LanguageOptions</c> in your request, you must also include <c>IdentifyLanguage</c>
        /// or <c>IdentifyMultipleLanguages</c>.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages supported with Amazon Transcribe streaming, refer to the <a
        /// href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only include one language dialect per language per stream. For example, you
        /// cannot include <c>en-US</c> and <c>en-AU</c> in the same request.
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
        [AWSProperty(Required=true)]
        public MediaEncoding MediaEncoding
        {
            get { return this._mediaEncoding; }
            set { this._mediaEncoding = value; }
        }

        // Check to see if MediaEncoding property is set
        internal bool IsSetMediaEncoding()
        {
            return this._mediaEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate of the input audio (in hertz). Low-quality audio, such as telephone
        /// audio, is typically around 8,000 Hz. High-quality audio typically ranges from 16,000
        /// Hz to 48,000 Hz. Note that the sample rate you specify must match that of your audio.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8000, Max=48000)]
        public int? MediaSampleRateHertz
        {
            get { return this._mediaSampleRateHertz; }
            set { this._mediaSampleRateHertz = value; }
        }

        // Check to see if MediaSampleRateHertz property is set
        internal bool IsSetMediaSampleRateHertz()
        {
            return this._mediaSampleRateHertz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfChannels. 
        /// <para>
        /// Specify the number of channels in your audio stream. This value must be <c>2</c>,
        /// as only two channels are supported. If your audio doesn't contain multiple channels,
        /// do not include this parameter in your request.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>NumberOfChannels</c> in your request, you must also include <c>EnableChannelIdentification</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int? NumberOfChannels
        {
            get { return this._numberOfChannels; }
            set { this._numberOfChannels = value; }
        }

        // Check to see if NumberOfChannels property is set
        internal bool IsSetNumberOfChannels()
        {
            return this._numberOfChannels.HasValue; 
        }

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
        /// Specify a preferred language from the subset of languages codes you specified in <c>LanguageOptions</c>.
        /// </para>
        ///  
        /// <para>
        /// You can only use this parameter if you've included <c>IdentifyLanguage</c> and <c>LanguageOptions</c>
        /// in your request.
        /// </para>
        /// </summary>
        public LanguageCode PreferredLanguage
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// Specify a name for your transcription session. If you don't include this parameter
        /// in your request, Amazon Transcribe generates an ID and returns it in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
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
        /// speakers (diarization)</a>.
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
        /// Specify the name of the custom vocabulary filter that you want to use when processing
        /// your transcription. Note that vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If the language of the specified custom vocabulary filter doesn't match the language
        /// identified in your media, the vocabulary filter is not applied to your transcription.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter is <b>not</b> intended for use with the <c>IdentifyLanguage</c> parameter.
        /// If you're including <c>IdentifyLanguage</c> in your request and want to use one or
        /// more vocabulary filters with your transcription, use the <c>VocabularyFilterNames</c>
        /// parameter instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/vocabulary-filtering.html">Using
        /// vocabulary filtering with unwanted words</a>.
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
        /// Specify the names of the custom vocabulary filters that you want to use when processing
        /// your transcription. Note that vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If none of the languages of the specified custom vocabulary filters match the language
        /// identified in your media, your job fails.
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
        /// If the language of the specified custom vocabulary doesn't match the language identified
        /// in your media, the custom vocabulary is not applied to your transcription.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter is <b>not</b> intended for use with the <c>IdentifyLanguage</c> parameter.
        /// If you're including <c>IdentifyLanguage</c> in your request and want to use one or
        /// more custom vocabularies with your transcription, use the <c>VocabularyNames</c> parameter
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary.html">Custom
        /// vocabularies</a>.
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
        /// Specify the names of the custom vocabularies that you want to use when processing
        /// your transcription. Note that vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If none of the languages of the specified custom vocabularies match the language identified
        /// in your media, your job fails.
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