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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBot operation.
    /// Deletes all versions of a bot, including the <code>Draft</code> version. To delete
    /// a specific version, use the <code>DeleteBotVersion</code> operation.
    /// 
    ///  
    /// <para>
    /// When you delete a bot, all of the resources contained in the bot are also deleted.
    /// Deleting a bot removes all locales, intents, slot, and slot types defined for the
    /// bot.
    /// </para>
    ///  
    /// <para>
    /// If a bot has an alias, the <code>DeleteBot</code> operation returns a <code>ResourceInUseException</code>
    /// exception. If you want to delete the bot and the alias, set the <code>skipResourceInUseCheck</code>
    /// parameter to <code>true</code>.
    /// </para>
    /// </summary>
    public partial class DeleteBotRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private bool? _skipResourceInUseCheck;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot to delete. 
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
        /// Gets and sets the property SkipResourceInUseCheck. 
        /// <para>
        /// When <code>true</code>, Amazon Lex doesn't check to see if another resource, such
        /// as an alias, is using the bot before it is deleted.
        /// </para>
        /// </summary>
        public bool SkipResourceInUseCheck
        {
            get { return this._skipResourceInUseCheck.GetValueOrDefault(); }
            set { this._skipResourceInUseCheck = value; }
        }

        // Check to see if SkipResourceInUseCheck property is set
        internal bool IsSetSkipResourceInUseCheck()
        {
            return this._skipResourceInUseCheck.HasValue; 
        }

    }
}