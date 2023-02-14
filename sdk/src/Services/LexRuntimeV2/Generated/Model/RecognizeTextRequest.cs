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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Container for the parameters to the RecognizeText operation.
    /// Sends user input to Amazon Lex V2. Client applications use this API to send requests
    /// to Amazon Lex V2 at runtime. Amazon Lex V2 then interprets the user input using the
    /// machine learning model that it build for the bot.
    /// 
    ///  
    /// <para>
    /// In response, Amazon Lex V2 returns the next message to convey to the user and an optional
    /// response card to display.
    /// </para>
    ///  
    /// <para>
    /// If the optional post-fulfillment response is specified, the messages are returned
    /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
    /// the intent state is fulfilled or ready fulfillment if the message is present.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
    /// an exception or if the Lambda function returns a failed intent state without a message.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
    /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
    /// If you configure a timeout, the timeout message is returned when the period times
    /// out. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
    /// message</a>.
    /// </para>
    /// </summary>
    public partial class RecognizeTextRequest : AmazonLexRuntimeV2Request
    {
        private string _botAliasId;
        private string _botId;
        private string _localeId;
        private Dictionary<string, string> _requestAttributes = new Dictionary<string, string>();
        private string _sessionId;
        private SessionState _sessionStateValue;
        private string _text;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The alias identifier in use for the bot that processes the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotAliasId
        {
            get { return this._botAliasId; }
            set { this._botAliasId = value; }
        }

        // Check to see if BotAliasId property is set
        internal bool IsSetBotAliasId()
        {
            return this._botAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that processes the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale where the session is in use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// Request-specific information passed between the client application and Amazon Lex
        /// V2 
        /// </para>
        ///  
        /// <para>
        /// The namespace <code>x-amz-lex:</code> is reserved for special attributes. Don't create
        /// any request attributes with the prefix <code>x-amz-lex:</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null && this._requestAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the user session that is having the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionStateValue. 
        /// <para>
        /// The current state of the dialog between the user and the bot.
        /// </para>
        /// </summary>
        public SessionState SessionStateValue
        {
            get { return this._sessionStateValue; }
            set { this._sessionStateValue = value; }
        }

        // Check to see if SessionStateValue property is set
        internal bool IsSetSessionStateValue()
        {
            return this._sessionStateValue != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text that the user entered. Amazon Lex V2 interprets this text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}