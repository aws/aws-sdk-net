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
    /// Specifies a list of message groups that Amazon Lex sends to a user to elicit a response.
    /// </summary>
    public partial class PromptSpecification
    {
        /// <summary>
        /// Gets and sets the property AllowInterrupt. 
        /// <para>
        /// Indicates whether the user can interrupt a speech prompt from the bot.
        /// </para>
        /// </summary>
        public bool? AllowInterrupt { get; set; }

        /// <summary>
        /// Checks to see if the AllowInterrupt property is set.
        /// </summary>
        internal bool IsSetAllowInterrupt() => this.AllowInterrupt.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times the bot tries to elicit a response from the user using
        /// this prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 5)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetries property is set.
        /// </summary>
        internal bool IsSetMaxRetries() => this.MaxRetries.HasValue;

        /// <summary>
        /// Gets and sets the property MessageGroups. 
        /// <para>
        /// A collection of messages that Amazon Lex can send to the user. Amazon Lex chooses
        /// the actual message to send at runtime.
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
        /// Gets and sets the property MessageSelectionStrategy. 
        /// <para>
        /// Indicates how a message is selected from a message group among retries.
        /// </para>
        /// </summary>
        public MessageSelectionStrategy MessageSelectionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MessageSelectionStrategy property is set.
        /// </summary>
        internal bool IsSetMessageSelectionStrategy() => this.MessageSelectionStrategy != null;

        /// <summary>
        /// Gets and sets the property PromptAttemptsSpecification. 
        /// <para>
        /// Specifies the advanced settings on each attempt of the prompt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PromptAttemptSpecification> PromptAttemptsSpecification { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PromptAttemptSpecification>() : null;

        /// <summary>
        /// Checks to see if the PromptAttemptsSpecification property is set.
        /// </summary>
        internal bool IsSetPromptAttemptsSpecification() => this.PromptAttemptsSpecification != null && (this.PromptAttemptsSpecification.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
