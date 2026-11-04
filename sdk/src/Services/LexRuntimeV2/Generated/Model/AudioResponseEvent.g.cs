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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// An event sent from Amazon Lex V2 to your client application containing audio to play
    /// to the user.
    /// </summary>
    public partial class AudioResponseEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property AudioChunk. 
        /// <para>
        /// A chunk of the audio to play. 
        /// </para>
        /// </summary>
        public MemoryStream AudioChunk { get; set; }

        /// <summary>
        /// Checks to see if the AudioChunk property is set.
        /// </summary>
        internal bool IsSetAudioChunk() => this.AudioChunk != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The encoding of the audio chunk. This is the same as the encoding configure in the
        /// <c>contentType</c> field of the <c>ConfigurationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier of the event sent by Amazon Lex V2. The identifier is in the form
        /// <c>RESPONSE-N</c>, where N is a number starting with one and incremented for each
        /// event sent by Amazon Lex V2 in the current session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;
    }
}
