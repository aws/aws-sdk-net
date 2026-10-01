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
    /// Container for the parameters to the StartMedicalStreamTranscription operation. Starts
    /// a bidirectional HTTP/2 or WebSocket stream where audio is streamed to Amazon Transcribe
    /// Medical and the transcription results are streamed to your application. <para> The
    /// following parameters are required: </para> <ul> <li> <para> <c>language-code</c> </para>
    /// </li> <li> <para> <c>media-encoding</c> </para> </li> <li> <para> <c>sample-rate</c>
    /// </para> </li> </ul> <para> For more information on streaming with Amazon Transcribe
    /// Medical, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html">Transcribing
    /// streaming audio</a>. </para>
    /// </summary>
    public partial class StartMedicalStreamTranscriptionRequest : AmazonTranscribeStreamingRequest
    {
        /// <summary>
        /// Gets and sets the property AudioStreamPublisher.
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
        /// Labels all personal health information (PHI) identified in your transcript.
        /// </para>
        ///  
        /// <para>
        /// Content identification is performed at the segment level; PHI is flagged upon complete
        /// transcription of an audio segment.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/phi-id.html">Identifying
        /// personal health information (PHI) in a transcription</a>.
        /// </para>
        /// </summary>
        public MedicalContentIdentificationType ContentIdentificationType { get; set; }

        /// <summary>
        /// Checks to see if the ContentIdentificationType property is set.
        /// </summary>
        internal bool IsSetContentIdentificationType() => this.ContentIdentificationType != null;

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
        public bool? EnableChannelIdentification { get; set; }

        /// <summary>
        /// Checks to see if the EnableChannelIdentification property is set.
        /// </summary>
        internal bool IsSetEnableChannelIdentification() => this.EnableChannelIdentification.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Specify the language code that represents the language spoken in your audio.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon Transcribe Medical only supports US English (<c>en-US</c>).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// Specify the encoding used for the input audio. Supported formats are:
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
        /// The sample rate of the input audio (in hertz). Amazon Transcribe Medical supports
        /// a range from 16,000 Hz to 48,000 Hz. Note that the sample rate you specify must match
        /// that of your audio.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

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
        [AWSProperty(Min = 2)]
        public int? NumberOfChannels { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfChannels property is set.
        /// </summary>
        internal bool IsSetNumberOfChannels() => this.NumberOfChannels.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// Specify a name for your transcription session. If you don't include this parameter
        /// in your request, Amazon Transcribe Medical generates an ID and returns it in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

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
        public bool? ShowSpeakerLabel { get; set; }

        /// <summary>
        /// Checks to see if the ShowSpeakerLabel property is set.
        /// </summary>
        internal bool IsSetShowSpeakerLabel() => this.ShowSpeakerLabel.HasValue;

        /// <summary>
        /// Gets and sets the property Specialty. 
        /// <para>
        /// Specify the medical specialty contained in your audio.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Specialty Specialty { get; set; }

        /// <summary>
        /// Checks to see if the Specialty property is set.
        /// </summary>
        internal bool IsSetSpecialty() => this.Specialty != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specify the type of input audio. For example, choose <c>DICTATION</c> for a provider
        /// dictating patient notes and <c>CONVERSATION</c> for a dialogue between a patient and
        /// a medical professional.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// Specify the name of the custom vocabulary that you want to use when processing your
        /// transcription. Note that vocabulary names are case sensitive.
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
