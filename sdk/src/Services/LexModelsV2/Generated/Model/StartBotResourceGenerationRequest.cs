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
    /// Container for the parameters to the StartBotResourceGeneration operation.
    /// Starts a request for the descriptive bot builder to generate a bot locale configuration
    /// based on the prompt you provide it. After you make this call, use the <c>DescribeBotResourceGeneration</c>
    /// operation to check on the status of the generation and for the <c>generatedBotLocaleUrl</c>
    /// when the generation is complete. Use that value to retrieve the Amazon S3 object containing
    /// the bot locale configuration. You can then modify and import this configuration.
    /// </summary>
    public partial class StartBotResourceGenerationRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private string _generationInputPrompt;
        private string _localeId;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot for which to generate intents and slot types.
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot for which to generate intents and slot types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationInputPrompt. 
        /// <para>
        /// The prompt to generate intents and slot types for the bot locale. Your description
        /// should be both <i>detailed</i> and <i>precise</i> to help generate appropriate and
        /// sufficient intents for your bot. Include a list of actions to improve the intent creation
        /// process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=100, Max=2000)]
        public string GenerationInputPrompt
        {
            get { return this._generationInputPrompt; }
            set { this._generationInputPrompt = value; }
        }

        // Check to see if GenerationInputPrompt property is set
        internal bool IsSetGenerationInputPrompt()
        {
            return this._generationInputPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale of the bot for which to generate intents and slot types.
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

    }
}