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
    /// Defines the messages that Amazon Lex sends to a user to remind them that the bot is
    /// waiting for a response.
    /// </summary>
    public partial class StillWaitingResponseSpecification
    {
        /// <summary>
        /// Gets and sets the property AllowInterrupt. 
        /// <para>
        /// Indicates that the user can interrupt the response by speaking while the message is
        /// being played.
        /// </para>
        /// </summary>
        public bool? AllowInterrupt { get; set; }

        /// <summary>
        /// Checks to see if the AllowInterrupt property is set.
        /// </summary>
        internal bool IsSetAllowInterrupt() => this.AllowInterrupt.HasValue;

        /// <summary>
        /// Gets and sets the property FrequencyInSeconds. 
        /// <para>
        /// How often a message should be sent to the user. Minimum of 1 second, maximum of 5
        /// minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public int? FrequencyInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the FrequencyInSeconds property is set.
        /// </summary>
        internal bool IsSetFrequencyInSeconds() => this.FrequencyInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MessageGroups. 
        /// <para>
        /// One or more message groups, each containing one or more messages, that define the
        /// prompts that Amazon Lex sends to the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<MessageGroup> MessageGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageGroup>() : null;

        /// <summary>
        /// Checks to see if the MessageGroups property is set.
        /// </summary>
        internal bool IsSetMessageGroups() => this.MessageGroups != null && (this.MessageGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// If Amazon Lex waits longer than this length of time for a response, it will stop sending
        /// messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 900)]
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutInSeconds() => this.TimeoutInSeconds.HasValue;
    }
}
