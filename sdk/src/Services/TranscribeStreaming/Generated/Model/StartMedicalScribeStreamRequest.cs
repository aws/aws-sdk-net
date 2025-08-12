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
    /// Container for the parameters to the StartMedicalScribeStream operation.
    /// Starts a bidirectional HTTP/2 stream, where audio is streamed to Amazon Web Services
    /// HealthScribe and the transcription results are streamed to your application.
    /// 
    ///  
    /// <para>
    /// When you start a stream, you first specify the stream configuration in a <c>MedicalScribeConfigurationEvent</c>.
    /// This event includes channel definitions, encryption settings, medical scribe context,
    /// and post-stream analytics settings, such as the output configuration for aggregated
    /// transcript and clinical note generation. These are additional streaming session configurations
    /// beyond those provided in your initial start request headers. Whether you are starting
    /// a new session or resuming an existing session, your first event must be a <c>MedicalScribeConfigurationEvent</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  After you send a <c>MedicalScribeConfigurationEvent</c>, you start <c>AudioEvents</c>
    /// and Amazon Web Services HealthScribe responds with real-time transcription results.
    /// When you are finished, to start processing the results with the post-stream analytics,
    /// send a <c>MedicalScribeSessionControlEvent</c> with a <c>Type</c> of <c>END_OF_SESSION</c>
    /// and Amazon Web Services HealthScribe starts the analytics. 
    /// </para>
    ///  
    /// <para>
    /// You can pause or resume streaming. To pause streaming, complete the input stream without
    /// sending the <c>MedicalScribeSessionControlEvent</c>. To resume streaming, call the
    /// <c>StartMedicalScribeStream</c> and specify the same SessionId you used to start the
    /// stream. 
    /// </para>
    ///  
    /// <para>
    /// The following parameters are required:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>language-code</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>media-encoding</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>media-sample-rate-hertz</c> 
    /// </para>
    ///  </li> </ul>  
    /// <para>
    /// For more information on streaming with Amazon Web Services HealthScribe, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/health-scribe-streaming.html">Amazon
    /// Web Services HealthScribe</a>. 
    /// </para>
    /// </summary>
    public partial class StartMedicalScribeStreamRequest : AmazonTranscribeStreamingRequest
    {
        private MedicalScribeLanguageCode _languageCode;
        private MedicalScribeMediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property InputStreamPublisher. 
        /// <para>
        /// Specify the input stream where you will send events in real time.
        /// </para>
        ///  
        /// <para>
        /// The first element of the input stream must be a <c>MedicalScribeConfigurationEvent</c>.
        /// 
        /// </para>
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IMedicalScribeInputStreamEvent
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="MedicalScribeAudioEvent"/></term></item>
        ///   <item><term><see cref="MedicalScribeConfigurationEvent"/></term></item>
        ///   <item><term><see cref="MedicalScribeSessionControlEvent"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        [AWSProperty(Required=true)]
        public  Func<System.Threading.Tasks.Task<IMedicalScribeInputStreamEvent>> InputStreamPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Specify the language code for your HealthScribe streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MedicalScribeLanguageCode LanguageCode
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
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// Specify the encoding used for the input audio.
        /// </para>
        ///  
        /// <para>
        /// Supported formats are:
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
        public MedicalScribeMediaEncoding MediaEncoding
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
        /// Specify the sample rate of the input audio (in hertz). Amazon Web Services HealthScribe
        /// supports a range from 16,000 Hz to 48,000 Hz. The sample rate you specify must match
        /// that of your audio. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16000, Max=48000)]
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// Specify an identifier for your streaming session (in UUID format). If you don't include
        /// a SessionId in your request, Amazon Web Services HealthScribe generates an ID and
        /// returns it in the response. 
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

    }
}