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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Obtains information from the user. To define a prompt, provide one or more messages
    /// and specify the number of attempts to get information from the user. If you provide
    /// more than one message, Amazon Lex chooses one of the messages to use to prompt the
    /// user. For more information, see <a>how-it-works</a>.
    /// </summary>
    public partial class Prompt
    {
        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// The number of times to prompt the user for information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaxAttempts property is set.
        /// </summary>
        internal bool IsSetMaxAttempts() => this.MaxAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// An array of objects, each of which provides a message string and its type. You can
        /// specify the message string in plain text or in Speech Synthesis Markup Language (SSML).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public List<Message> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseCard. 
        /// <para>
        /// A response card. Amazon Lex uses this prompt at runtime, in the <c>PostText</c> API
        /// response. It substitutes session attributes and slot values for placeholders in the
        /// response card. For more information, see <a>ex-resp-card</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50000)]
        public string ResponseCard { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCard property is set.
        /// </summary>
        internal bool IsSetResponseCard() => this.ResponseCard != null;
    }
}
