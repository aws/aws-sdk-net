/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteUtterances operation.
    /// Deletes stored utterances.
    /// 
    ///  
    /// <para>
    /// When you create or update a bot using the operation, configure your bot to store user
    /// utterances by setting <code>privacySetting</code> to <code>STORE_UTTERANCES</code>.
    /// Use <code>DeleteUtterances</code> to remove the stored utterances for a specific user
    /// .
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:DeleteUtterances</code> action.
    /// </para>
    /// </summary>
    public partial class DeleteUtterancesRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _botName;
        private string _userId;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot that stored the utterances.
        /// </para>
        /// </summary>
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  The unique identifier for the user that made the utterances. This is the user ID
        /// that was sent in the or operation request that contained the utterance.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}