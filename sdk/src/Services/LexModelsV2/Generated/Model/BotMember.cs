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
    /// A bot that is a member of a network of bots.
    /// </summary>
    public partial class BotMember
    {
        private string _botMemberAliasId;
        private string _botMemberAliasName;
        private string _botMemberId;
        private string _botMemberName;
        private string _botMemberVersion;

        /// <summary>
        /// Gets and sets the property BotMemberAliasId. 
        /// <para>
        /// The alias ID of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotMemberAliasId
        {
            get { return this._botMemberAliasId; }
            set { this._botMemberAliasId = value; }
        }

        // Check to see if BotMemberAliasId property is set
        internal bool IsSetBotMemberAliasId()
        {
            return this._botMemberAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property BotMemberAliasName. 
        /// <para>
        /// The alias name of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string BotMemberAliasName
        {
            get { return this._botMemberAliasName; }
            set { this._botMemberAliasName = value; }
        }

        // Check to see if BotMemberAliasName property is set
        internal bool IsSetBotMemberAliasName()
        {
            return this._botMemberAliasName != null;
        }

        /// <summary>
        /// Gets and sets the property BotMemberId. 
        /// <para>
        /// The unique ID of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotMemberId
        {
            get { return this._botMemberId; }
            set { this._botMemberId = value; }
        }

        // Check to see if BotMemberId property is set
        internal bool IsSetBotMemberId()
        {
            return this._botMemberId != null;
        }

        /// <summary>
        /// Gets and sets the property BotMemberName. 
        /// <para>
        /// The unique name of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string BotMemberName
        {
            get { return this._botMemberName; }
            set { this._botMemberName = value; }
        }

        // Check to see if BotMemberName property is set
        internal bool IsSetBotMemberName()
        {
            return this._botMemberName != null;
        }

        /// <summary>
        /// Gets and sets the property BotMemberVersion. 
        /// <para>
        /// The version of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string BotMemberVersion
        {
            get { return this._botMemberVersion; }
            set { this._botMemberVersion = value; }
        }

        // Check to see if BotMemberVersion property is set
        internal bool IsSetBotMemberVersion()
        {
            return this._botMemberVersion != null;
        }

    }
}