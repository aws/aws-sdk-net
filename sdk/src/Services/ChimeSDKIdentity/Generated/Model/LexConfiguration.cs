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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// The configuration for an Amazon Lex V2 bot.
    /// </summary>
    public partial class LexConfiguration
    {
        private string _lexBotAliasArn;
        private string _localeId;
        private RespondsTo _respondsTo;
        private string _welcomeIntent;

        /// <summary>
        /// Gets and sets the property LexBotAliasArn. 
        /// <para>
        /// The ARN of the Amazon Lex V2 bot's alias. The ARN uses this format: <code>arn:aws:lex:REGION:ACCOUNT:bot-alias/MYBOTID/MYBOTALIAS</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=2048)]
        public string LexBotAliasArn
        {
            get { return this._lexBotAliasArn; }
            set { this._lexBotAliasArn = value; }
        }

        // Check to see if LexBotAliasArn property is set
        internal bool IsSetLexBotAliasArn()
        {
            return this._lexBotAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// Identifies the Amazon Lex V2 bot's language and locale. The string must match one
        /// of the supported locales in Amazon Lex V2. All of the intents, slot types, and slots
        /// used in the bot must have the same locale. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a> in the <i>Amazon Lex V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RespondsTo. 
        /// <para>
        /// Determines whether the Amazon Lex V2 bot responds to all standard messages. Control
        /// messages are not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RespondsTo RespondsTo
        {
            get { return this._respondsTo; }
            set { this._respondsTo = value; }
        }

        // Check to see if RespondsTo property is set
        internal bool IsSetRespondsTo()
        {
            return this._respondsTo != null;
        }

        /// <summary>
        /// Gets and sets the property WelcomeIntent. 
        /// <para>
        /// The name of the welcome intent configured in the Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string WelcomeIntent
        {
            get { return this._welcomeIntent; }
            set { this._welcomeIntent = value; }
        }

        // Check to see if WelcomeIntent property is set
        internal bool IsSetWelcomeIntent()
        {
            return this._welcomeIntent != null;
        }

    }
}