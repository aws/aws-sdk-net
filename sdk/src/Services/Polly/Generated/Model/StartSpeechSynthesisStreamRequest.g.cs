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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// Container for the parameters to the StartSpeechSynthesisStream operation. Synthesizes
    /// UTF-8 input, plain text, or SSML over a bidirectional streaming connection. Specify
    /// synthesis parameters in HTTP/2 headers, send text incrementally as events on the input
    /// stream, and receive synthesized audio as it becomes available. <para> This operation
    /// serves as a bidirectional counterpart to <c>SynthesizeSpeech</c>: </para> <ul> <li>
    /// <para> <a href="https://docs.aws.amazon.com/polly/latest/API/API_SynthesizeSpeech.html">SynthesizeSpeech</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class StartSpeechSynthesisStreamRequest : AmazonPollyRequest
    {
        /// <summary>
        /// Gets and sets the property ActionStreamPublisher. 
        /// <para>
        /// The input event stream that contains text events and stream control events.
        /// </para>
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IStartSpeechSynthesisStreamActionStreamEvent
        /// interface. The known implementations in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="CloseStreamEvent"/></term></item>
        ///   <item><term><see cref="TextEvent"/></term></item>
        /// </list>
        /// </para>
        /// </summary>
        public Func<System.Threading.Tasks.Task<IStartSpeechSynthesisStreamActionStreamEvent>> ActionStreamPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Specifies the engine for Amazon Polly to use when processing input text for speech
        /// synthesis. Currently, only the <c>generative</c> engine is supported. If you specify
        /// a voice that the selected engine doesn't support, Amazon Polly returns an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Engine Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// An optional parameter that sets the language code for the speech synthesis request.
        /// Specify this parameter only when using a bilingual voice. If a bilingual voice is
        /// used and no language code is specified, Amazon Polly uses the default language of
        /// the bilingual voice.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LexiconNames. 
        /// <para>
        /// The names of one or more pronunciation lexicons for the service to apply during synthesis.
        /// Amazon Polly applies lexicons only when the lexicon language matches the voice language.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> LexiconNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LexiconNames property is set.
        /// </summary>
        internal bool IsSetLexiconNames() => this.LexiconNames != null && (this.LexiconNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The audio format for the synthesized speech. Currently, Amazon Polly does not support
        /// JSON speech marks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The audio frequency, specified in Hz.
        /// </para>
        /// </summary>
        public string SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate != null;

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The voice to use in synthesis. To get a list of available voice IDs, use the <a href="https://docs.aws.amazon.com/polly/latest/API/API_DescribeVoices.html">DescribeVoices</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VoiceId VoiceId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceId property is set.
        /// </summary>
        internal bool IsSetVoiceId() => this.VoiceId != null;
    }
}
