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
    /// A DTMF character sent from the client application. DTMF characters are typically sent
    /// from a phone keypad to represent numbers. For example, you can have Amazon Lex V2
    /// process a credit card number input from a phone.
    /// </summary>
    public partial class DTMFInputEvent
        : IEventStreamEvent
    {
        private long? _clientTimestampMillis;
        private string _eventId;
        private string _inputCharacter;

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

        /// <summary>
        /// Gets and sets the property InputCharacter. 
        /// <para>
        /// The DTMF character that the user pressed. The allowed characters are A - D, 0 - 9,
        /// # and *.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1)]
        public string InputCharacter
        {
            get { return this._inputCharacter; }
            set { this._inputCharacter = value; }
        }

        // Check to see if InputCharacter property is set
        internal bool IsSetInputCharacter()
        {
            return this._inputCharacter != null;
        }

    }
}