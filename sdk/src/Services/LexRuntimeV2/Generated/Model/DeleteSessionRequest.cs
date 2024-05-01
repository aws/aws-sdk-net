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
    /// Container for the parameters to the DeleteSession operation.
    /// Removes session information for a specified bot, alias, and user ID. 
    /// 
    ///  
    /// <para>
    /// You can use this operation to restart a conversation with a bot. When you remove a
    /// session, the entire history of the session is removed so that you can start again.
    /// </para>
    ///  
    /// <para>
    /// You don't need to delete a session. Sessions have a time limit and will expire. Set
    /// the session time limit when you create the bot. The default is 5 minutes, but you
    /// can specify anything between 1 minute and 24 hours.
    /// </para>
    ///  
    /// <para>
    /// If you specify a bot or alias ID that doesn't exist, you receive a <c>BadRequestException.</c>
    /// 
    /// </para>
    ///  
    /// <para>
    /// If the locale doesn't exist in the bot, or if the locale hasn't been enables for the
    /// alias, you receive a <c>BadRequestException</c>.
    /// </para>
    /// </summary>
    public partial class DeleteSessionRequest : AmazonLexRuntimeV2Request
    {
        private string _botAliasId;
        private string _botId;
        private string _localeId;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The alias identifier in use for the bot that contains the session data.
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
        /// The identifier of the bot that contains the session data.
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session to delete.
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

    }
}