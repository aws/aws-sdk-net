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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Configuration that plays background filler audio during speech-to-speech interactions
    /// to mask processing delays and improve the perceived responsiveness of the bot.
    /// 
    ///  
    /// <para>
    /// Audio filler requires <c>unifiedSpeechSettings</c> (speech-to-speech) to be enabled
    /// on the bot locale when <c>enabled</c> is <c>true</c>.
    /// </para>
    /// </summary>
    public partial class AudioFillerSettings
    {
        /// <summary>
        /// Gets and sets the property AudioType. 
        /// <para>
        /// The identifier of the audio filler to play while Amazon Lex processes the user's input.
        /// This field is required when <c>enabled</c> is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public AudioFillerType AudioType { get; set; }

        /// <summary>
        /// Checks to see if the AudioType property is set.
        /// </summary>
        internal bool IsSetAudioType() => this.AudioType != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether audio filler playback is enabled for the bot locale. Set to <c>true</c>
        /// to play filler audio while Amazon Lex processes a user utterance. Set to <c>false</c>
        /// to disable filler audio.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumPlayDurationInMilliseconds. 
        /// <para>
        /// The minimum time, in milliseconds, that audio filler plays once it has started, even
        /// if the bot response becomes ready sooner. Valid range is <c>1000</c> to <c>5000</c>
        /// milliseconds. If not specified, Amazon Lex uses a default of <c>3000</c> milliseconds.
        /// </para>
        /// </summary>
        public int? MinimumPlayDurationInMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the MinimumPlayDurationInMilliseconds property is set.
        /// </summary>
        internal bool IsSetMinimumPlayDurationInMilliseconds() => this.MinimumPlayDurationInMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseDeliveryDelayInMilliseconds. 
        /// <para>
        /// The silent delay, in milliseconds, inserted between the end of audio filler playback
        /// and the start of the bot's response. Valid range is <c>200</c> to <c>1000</c> milliseconds.
        /// If not specified, Amazon Lex uses a default of <c>500</c> milliseconds.
        /// </para>
        /// </summary>
        public int? ResponseDeliveryDelayInMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the ResponseDeliveryDelayInMilliseconds property is set.
        /// </summary>
        internal bool IsSetResponseDeliveryDelayInMilliseconds() => this.ResponseDeliveryDelayInMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property StartDelayInMilliseconds. 
        /// <para>
        /// The time, in milliseconds, to wait after the end of the user's utterance before starting
        /// audio filler playback. Valid range is <c>500</c> to <c>5000</c> milliseconds. If not
        /// specified, Amazon Lex uses a default of <c>2500</c> milliseconds.
        /// </para>
        /// </summary>
        public int? StartDelayInMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the StartDelayInMilliseconds property is set.
        /// </summary>
        internal bool IsSetStartDelayInMilliseconds() => this.StartDelayInMilliseconds.HasValue;
    }
}
