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
    /// Container for the parameters to the CreateRoom operation.
    /// Creates a room that allows clients to connect and pass messages.
    /// </summary>
    public partial class CreateRoomRequest : AmazonIvschatRequest
    {
        private List<string> _loggingConfigurationIdentifiers = new List<string>();
        private int? _maximumMessageLength;
        private int? _maximumMessageRatePerSecond;
        private MessageReviewHandler _messageReviewHandler;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Maximum number of characters in a single message. Messages are expected to be UTF-8
        /// encoded and this limit applies specifically to rune/code-point count, not number of
        /// bytes. Default: 500.
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
        /// Configuration information for optional review of messages.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to attach to the resource. Array of maps, each of the form <code>string:string
        /// (key:value)</code>. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> for details, including restrictions that apply to tags and "Tag
        /// naming limits and requirements"; Amazon IVS Chat has no constraints beyond what is
        /// documented there.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}