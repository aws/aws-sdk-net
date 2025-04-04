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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// A wrapper for your audio chunks
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/event-stream.html">Event
    /// stream encoding</a>. 
    /// </para>
    /// </summary>
    public partial class MedicalScribeAudioEvent
        : IEventStreamEvent
    {
        private MemoryStream _audioChunk;

        /// <summary>
        /// Gets and sets the property AudioChunk. 
        /// <para>
        ///  An audio blob containing the next segment of audio from your application, with a
        /// maximum duration of 1 second. The maximum size in bytes varies based on audio properties.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Find recommended size in <a href="https://docs.aws.amazon.com/transcribe/latest/dg/streaming.html#best-practices">Transcribing
        /// streaming best practices</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Size calculation: <c>Duration (s) * Sample Rate (Hz) * Number of Channels * 2 (Bytes
        /// per Sample)</c> 
        /// </para>
        ///  
        /// <para>
        ///  For example, a 1-second chunk of 16 kHz, 2-channel, 16-bit audio would be <c>1 *
        /// 16000 * 2 * 2 = 64000 bytes</c>. 
        /// </para>
        ///  
        /// <para>
        ///  For 8 kHz, 1-channel, 16-bit audio, a 1-second chunk would be <c>1 * 8000 * 1 * 2
        /// = 16000 bytes</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream AudioChunk
        {
            get { return this._audioChunk; }
            set { this._audioChunk = value; }
        }

        // Check to see if AudioChunk property is set
        internal bool IsSetAudioChunk()
        {
            return this._audioChunk != null;
        }

    }
}