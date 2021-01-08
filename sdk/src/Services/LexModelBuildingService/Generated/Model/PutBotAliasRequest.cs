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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the PutBotAlias operation.
    /// Creates an alias for the specified version of the bot or replaces an alias for the
    /// specified bot. To change the version of the bot that the alias points to, replace
    /// the alias. For more information about aliases, see <a>versioning-aliases</a>.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:PutBotAlias</code> action. 
    /// </para>
    /// </summary>
    public partial class PutBotAliasRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _botName;
        private string _botVersion;
        private string _checksum;
        private ConversationLogsRequest _conversationLogs;
        private string _description;
        private string _name;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Identifies a specific revision of the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// When you create a new bot alias, leave the <code>checksum</code> field blank. If you
        /// specify a checksum you get a <code>BadRequestException</code> exception.
        /// </para>
        ///  
        /// <para>
        /// When you want to update a bot alias, set the <code>checksum</code> field to the checksum
        /// of the most recent revision of the <code>$LATEST</code> version. If you don't specify
        /// the <code> checksum</code> field, or if the checksum does not match the <code>$LATEST</code>
        /// version, you get a <code>PreconditionFailedException</code> exception.
        /// </para>
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationLogs. 
        /// <para>
        /// Settings for conversation logs for the alias.
        /// </para>
        /// </summary>
        public ConversationLogsRequest ConversationLogs
        {
            get { return this._conversationLogs; }
            set { this._conversationLogs = value; }
        }

        // Check to see if ConversationLogs property is set
        internal bool IsSetConversationLogs()
        {
            return this._conversationLogs != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alias. The name is <i>not</i> case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to add to the bot alias. You can only add tags when you create an alias,
        /// you can't use the <code>PutBotAlias</code> operation to update the tags on a bot alias.
        /// To update tags, use the <code>TagResource</code> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}