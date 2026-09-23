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

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// The configuration for an Amazon Lex V2 bot.
    /// </summary>
    public partial class LexConfiguration
    {
        /// <summary>
        /// Gets and sets the property InvokedBy. 
        /// <para>
        /// Specifies the type of message that triggers a bot.
        /// </para>
        /// </summary>
        public InvokedBy InvokedBy { get; set; }

        /// <summary>
        /// Checks to see if the InvokedBy property is set.
        /// </summary>
        internal bool IsSetInvokedBy() => this.InvokedBy != null;

        /// <summary>
        /// Gets and sets the property LexBotAliasArn. 
        /// <para>
        /// The ARN of the Amazon Lex V2 bot's alias. The ARN uses this format: <c>arn:aws:lex:REGION:ACCOUNT:bot-alias/MYBOTID/MYBOTALIAS</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 15, Max = 2048)]
        public string LexBotAliasArn { get; set; }

        /// <summary>
        /// Checks to see if the LexBotAliasArn property is set.
        /// </summary>
        internal bool IsSetLexBotAliasArn() => this.LexBotAliasArn != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// Identifies the Amazon Lex V2 bot's language and locale. The string must match one
        /// of the supported locales in Amazon Lex V2. All of the intents, slot types, and slots
        /// used in the bot must have the same locale. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a> in the <i>Amazon Lex V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property RespondsTo. <important> 
        /// <para>
        ///  <b>Deprecated</b>. Use <c>InvokedBy</c> instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// Determines whether the Amazon Lex V2 bot responds to all standard messages. Control
        /// messages are not supported.
        /// </para>
        /// </summary>
        public RespondsTo RespondsTo { get; set; }

        /// <summary>
        /// Checks to see if the RespondsTo property is set.
        /// </summary>
        internal bool IsSetRespondsTo() => this.RespondsTo != null;

        /// <summary>
        /// Gets and sets the property WelcomeIntent. 
        /// <para>
        /// The name of the welcome intent configured in the Amazon Lex V2 bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string WelcomeIntent { get; set; }

        /// <summary>
        /// Checks to see if the WelcomeIntent property is set.
        /// </summary>
        internal bool IsSetWelcomeIntent() => this.WelcomeIntent != null;
    }
}
