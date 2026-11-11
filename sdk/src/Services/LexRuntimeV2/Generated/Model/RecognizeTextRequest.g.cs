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
    /// Container for the parameters to the RecognizeText operation. Sends user input to Amazon
    /// Lex V2. Client applications use this API to send requests to Amazon Lex V2 at runtime.
    /// Amazon Lex V2 then interprets the user input using the machine learning model that
    /// it build for the bot. <para> In response, Amazon Lex V2 returns the next message to
    /// convey to the user and an optional response card to display. </para> <para> If the
    /// optional post-fulfillment response is specified, the messages are returned as follows.
    /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
    /// </para> <ul> <li> <para> <b>Success message</b> - Returned if the Lambda function
    /// completes successfully and the intent state is fulfilled or ready fulfillment if the
    /// message is present. </para> </li> <li> <para> <b>Failed message</b> - The failed message
    /// is returned if the Lambda function throws an exception or if the Lambda function returns
    /// a failed intent state without a message. </para> </li> <li> <para> <b>Timeout message</b>
    /// - If you don't configure a timeout message and a timeout, and the Lambda function
    /// doesn't return within 30 seconds, the timeout message is returned. If you configure
    /// a timeout, the timeout message is returned when the period times out. </para> </li>
    /// </ul> <para> For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
    /// message</a>. </para>
    /// </summary>
    public partial class RecognizeTextRequest : AmazonLexRuntimeV2Request
    {
        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The alias identifier in use for the bot that processes the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that processes the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale where the session is in use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// Request-specific information passed between the client application and Amazon Lex
        /// V2 
        /// </para>
        ///  
        /// <para>
        /// The namespace <c>x-amz-lex:</c> is reserved for special attributes. Don't create any
        /// request attributes with the prefix <c>x-amz-lex:</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequestAttributes property is set.
        /// </summary>
        internal bool IsSetRequestAttributes() => this.RequestAttributes != null && (this.RequestAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the user session that is having the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionStateValue. 
        /// <para>
        /// The current state of the dialog between the user and the bot.
        /// </para>
        /// </summary>
        public SessionState SessionStateValue { get; set; }

        /// <summary>
        /// Checks to see if the SessionStateValue property is set.
        /// </summary>
        internal bool IsSetSessionStateValue() => this.SessionStateValue != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text that the user entered. Amazon Lex V2 interprets this text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
