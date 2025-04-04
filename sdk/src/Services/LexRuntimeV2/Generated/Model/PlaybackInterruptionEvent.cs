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
    /// Event sent from Amazon Lex V2 to indicate to the client application should stop playback
    /// of audio. For example, if the client is playing a prompt that asks for the user's
    /// telephone number, the user might start to say the phone number before the prompt is
    /// complete. Amazon Lex V2 sends this event to the client application to indicate that
    /// the user is responding and that Amazon Lex V2 is processing their input.
    /// </summary>
    public partial class PlaybackInterruptionEvent
        : IEventStreamEvent
    {
        private string _causedByEventId;
        private string _eventId;
        private PlaybackInterruptionReason _eventReason;

        /// <summary>
        /// Gets and sets the property CausedByEventId. 
        /// <para>
        /// The identifier of the event that contained the audio, DTMF, or text that caused the
        /// interruption.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string CausedByEventId
        {
            get { return this._causedByEventId; }
            set { this._causedByEventId = value; }
        }

        // Check to see if CausedByEventId property is set
        internal bool IsSetCausedByEventId()
        {
            return this._causedByEventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier of the event sent by Amazon Lex V2. The identifier is in the form
        /// <c>RESPONSE-N</c>, where N is a number starting with one and incremented for each
        /// event sent by Amazon Lex V2 in the current session.
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

        /// <summary>
        /// Gets and sets the property EventReason. 
        /// <para>
        /// Indicates the type of user input that Amazon Lex V2 detected.
        /// </para>
        /// </summary>
        public PlaybackInterruptionReason EventReason
        {
            get { return this._eventReason; }
            set { this._eventReason = value; }
        }

        // Check to see if EventReason property is set
        internal bool IsSetEventReason()
        {
            return this._eventReason != null;
        }

    }
}