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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutSession operation.
    /// Creates a new session or modifies an existing session with an Amazon Lex V2 bot. Use
    /// this operation to enable your application to set the state of the bot.
    /// </summary>
    public partial class PutSessionRequest : AmazonLexRuntimeV2Request
    {
        private string _botAliasId;
        private string _botId;
        private string _localeId;
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;
        private Dictionary<string, string> _requestAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _responseContentType;
        private string _sessionId;
        private SessionState _sessionStateValue;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The alias identifier of the bot that receives the session data.
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
        /// The identifier of the bot that receives the session data.
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
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages to send to the user. Messages are sent in the order that they are
        /// defined in the list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// Request-specific information passed between Amazon Lex V2 and the client application.
        /// </para>
        ///  
        /// <para>
        /// The namespace <c>x-amz-lex:</c> is reserved for special attributes. Don't create any
        /// request attributes with the prefix <c>x-amz-lex:</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null && (this._requestAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseContentType. 
        /// <para>
        /// The message that Amazon Lex V2 returns in the response can be either text or speech
        /// depending on the value of this parameter. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <c>text/plain; charset=utf-8</c>, Amazon Lex V2 returns text in the
        /// response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ResponseContentType
        {
            get { return this._responseContentType; }
            set { this._responseContentType = value; }
        }

        // Check to see if ResponseContentType property is set
        internal bool IsSetResponseContentType()
        {
            return this._responseContentType != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session that receives the session data.
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
        /// Sets the state of the session with the user. You can use this to set the current intent,
        /// attributes, context, and dialog action. Use the dialog action to determine the next
        /// step that Amazon Lex V2 should use in the conversation with the user.
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

    }
}