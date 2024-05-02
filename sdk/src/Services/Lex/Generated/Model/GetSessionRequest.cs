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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
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
namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the GetSession operation.
    /// Returns session information for a specified bot, alias, and user ID.
    /// </summary>
    public partial class GetSessionRequest : AmazonLexRequest
    {
        private string _botAlias;
        private string _botName;
        private string _checkpointLabelFilter;
        private string _userId;

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// The alias in use for the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotAlias
        {
            get { return this._botAlias; }
            set { this._botAlias = value; }
        }

        // Check to see if BotAlias property is set
        internal bool IsSetBotAlias()
        {
            return this._botAlias != null;
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CheckpointLabelFilter. 
        /// <para>
        /// A string used to filter the intents returned in the <c>recentIntentSummaryView</c>
        /// structure. 
        /// </para>
        ///  
        /// <para>
        /// When you specify a filter, only intents with their <c>checkpointLabel</c> field set
        /// to that string are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CheckpointLabelFilter
        {
            get { return this._checkpointLabelFilter; }
            set { this._checkpointLabelFilter = value; }
        }

        // Check to see if CheckpointLabelFilter property is set
        internal bool IsSetCheckpointLabelFilter()
        {
            return this._checkpointLabelFilter != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. Amazon Lex uses this to identify a user's conversation
        /// with your bot. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
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