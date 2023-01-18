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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoom operation.
    /// Updates a room’s configuration.
    /// </summary>
    public partial class UpdateRoomRequest : AmazonIvschatRequest
    {
        private string _identifier;
        private List<string> _loggingConfigurationIdentifiers = new List<string>();
        private int? _maximumMessageLength;
        private int? _maximumMessageRatePerSecond;
        private MessageReviewHandler _messageReviewHandler;
        private string _name;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifier of the room to be updated. Currently this must be an ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfigurationIdentifiers. 
        /// <para>
        /// Array of logging-configuration identifiers attached to the room.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> LoggingConfigurationIdentifiers
        {
            get { return this._loggingConfigurationIdentifiers; }
            set { this._loggingConfigurationIdentifiers = value; }
        }

        // Check to see if LoggingConfigurationIdentifiers property is set
        internal bool IsSetLoggingConfigurationIdentifiers()
        {
            return this._loggingConfigurationIdentifiers != null && this._loggingConfigurationIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumMessageLength. 
        /// <para>
        /// The maximum number of characters in a single message. Messages are expected to be
        /// UTF-8 encoded and this limit applies specifically to rune/code-point count, not number
        /// of bytes. Default: 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaximumMessageLength
        {
            get { return this._maximumMessageLength.GetValueOrDefault(); }
            set { this._maximumMessageLength = value; }
        }

        // Check to see if MaximumMessageLength property is set
        internal bool IsSetMaximumMessageLength()
        {
            return this._maximumMessageLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumMessageRatePerSecond. 
        /// <para>
        /// Maximum number of messages per second that can be sent to the room (by all clients).
        /// Default: 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaximumMessageRatePerSecond
        {
            get { return this._maximumMessageRatePerSecond.GetValueOrDefault(); }
            set { this._maximumMessageRatePerSecond = value; }
        }

        // Check to see if MaximumMessageRatePerSecond property is set
        internal bool IsSetMaximumMessageRatePerSecond()
        {
            return this._maximumMessageRatePerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageReviewHandler. 
        /// <para>
        /// Configuration information for optional review of messages. Specify an empty <code>uri</code>
        /// string to disassociate a message review handler from the specified room.
        /// </para>
        /// </summary>
        public MessageReviewHandler MessageReviewHandler
        {
            get { return this._messageReviewHandler; }
            set { this._messageReviewHandler = value; }
        }

        // Check to see if MessageReviewHandler property is set
        internal bool IsSetMessageReviewHandler()
        {
            return this._messageReviewHandler != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Room name. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}