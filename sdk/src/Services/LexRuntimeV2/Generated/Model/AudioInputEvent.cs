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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
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
using Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Represents a chunk of audio sent from the client application to Amazon Lex V2. The
    /// audio is all or part of an utterance from the user.
    /// 
    ///  
    /// <para>
    /// Amazon Lex V2 accumulates audio chunks until it recognizes a natural pause in speech
    /// before processing the input.
    /// </para>
    /// </summary>
    public partial class AudioInputEvent
        : IEventStreamEvent
    {
        private MemoryStream _audioChunk;
        private long? _clientTimestampMillis;
        private string _contentType;
        private string _eventId;

        /// <summary>
        /// Gets and sets the property AudioChunk. 
        /// <para>
        /// An encoded stream of audio.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ClientTimestampMillis. 
        /// <para>
        /// A timestamp set by the client of the date and time that the event was sent to Amazon
        /// Lex V2.
        /// </para>
        /// </summary>
        public long? ClientTimestampMillis
        {
            get { return this._clientTimestampMillis; }
            set { this._clientTimestampMillis = value; }
        }

        // Check to see if ClientTimestampMillis property is set
        internal bool IsSetClientTimestampMillis()
        {
            return this._clientTimestampMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The encoding used for the audio chunk. You must use 8 KHz PCM 16-bit mono-channel
        /// little-endian format. The value of the field should be:
        /// </para>
        ///  
        /// <para>
        ///  <c>audio/lpcm; sample-rate=8000; sample-size-bits=16; channel-count=1; is-big-endian=false</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier that your application assigns to the event. You can use this to
        /// identify events in logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

    }
}