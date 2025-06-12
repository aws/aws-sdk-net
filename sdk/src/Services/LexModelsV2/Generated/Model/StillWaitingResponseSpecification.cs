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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// Defines the messages that Amazon Lex sends to a user to remind them that the bot is
    /// waiting for a response.
    /// </summary>
    public partial class StillWaitingResponseSpecification
    {
        private bool? _allowInterrupt;
        private int? _frequencyInSeconds;
        private List<MessageGroup> _messageGroups = AWSConfigs.InitializeCollections ? new List<MessageGroup>() : null;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property AllowInterrupt. 
        /// <para>
        /// Indicates that the user can interrupt the response by speaking while the message is
        /// being played.
        /// </para>
        /// </summary>
        public bool? AllowInterrupt
        {
            get { return this._allowInterrupt; }
            set { this._allowInterrupt = value; }
        }

        // Check to see if AllowInterrupt property is set
        internal bool IsSetAllowInterrupt()
        {
            return this._allowInterrupt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrequencyInSeconds. 
        /// <para>
        /// How often a message should be sent to the user. Minimum of 1 second, maximum of 5
        /// minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public int? FrequencyInSeconds
        {
            get { return this._frequencyInSeconds; }
            set { this._frequencyInSeconds = value; }
        }

        // Check to see if FrequencyInSeconds property is set
        internal bool IsSetFrequencyInSeconds()
        {
            return this._frequencyInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageGroups. 
        /// <para>
        /// One or more message groups, each containing one or more messages, that define the
        /// prompts that Amazon Lex sends to the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<MessageGroup> MessageGroups
        {
            get { return this._messageGroups; }
            set { this._messageGroups = value; }
        }

        // Check to see if MessageGroups property is set
        internal bool IsSetMessageGroups()
        {
            return this._messageGroups != null && (this._messageGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// If Amazon Lex waits longer than this length of time for a response, it will stop sending
        /// messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=900)]
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}