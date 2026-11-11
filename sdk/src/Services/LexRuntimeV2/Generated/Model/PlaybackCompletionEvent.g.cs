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
    /// Event sent from the client application to Amazon Lex V2 to indicate that playback
    /// of audio is complete and that Amazon Lex V2 should start processing the user's input.
    /// </summary>
    public partial class PlaybackCompletionEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property ClientTimestampMillis. 
        /// <para>
        /// A timestamp set by the client of the date and time that the event was sent to Amazon
        /// Lex V2.
        /// </para>
        /// </summary>
        public long? ClientTimestampMillis { get; set; }

        /// <summary>
        /// Checks to see if the ClientTimestampMillis property is set.
        /// </summary>
        internal bool IsSetClientTimestampMillis() => this.ClientTimestampMillis.HasValue;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier that your application assigns to the event. You can use this to
        /// identify events in logs.
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
