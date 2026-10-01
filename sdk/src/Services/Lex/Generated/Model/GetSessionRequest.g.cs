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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the GetSession operation. Returns session information
    /// for a specified bot, alias, and user ID.
    /// </summary>
    public partial class GetSessionRequest : AmazonLexRequest
    {
        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// The alias in use for the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotAlias { get; set; }

        /// <summary>
        /// Checks to see if the BotAlias property is set.
        /// </summary>
        internal bool IsSetBotAlias() => this.BotAlias != null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

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
        [AWSProperty(Min = 1, Max = 255)]
        public string CheckpointLabelFilter { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointLabelFilter property is set.
        /// </summary>
        internal bool IsSetCheckpointLabelFilter() => this.CheckpointLabelFilter != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. Amazon Lex uses this to identify a user's conversation
        /// with your bot. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
