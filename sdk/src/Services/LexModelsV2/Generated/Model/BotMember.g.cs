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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// A bot that is a member of a network of bots.
    /// </summary>
    public partial class BotMember
    {
        /// <summary>
        /// Gets and sets the property BotMemberAliasId. 
        /// <para>
        /// The alias ID of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotMemberAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotMemberAliasId property is set.
        /// </summary>
        internal bool IsSetBotMemberAliasId() => this.BotMemberAliasId != null;

        /// <summary>
        /// Gets and sets the property BotMemberAliasName. 
        /// <para>
        /// The alias name of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string BotMemberAliasName { get; set; }

        /// <summary>
        /// Checks to see if the BotMemberAliasName property is set.
        /// </summary>
        internal bool IsSetBotMemberAliasName() => this.BotMemberAliasName != null;

        /// <summary>
        /// Gets and sets the property BotMemberId. 
        /// <para>
        /// The unique ID of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotMemberId { get; set; }

        /// <summary>
        /// Checks to see if the BotMemberId property is set.
        /// </summary>
        internal bool IsSetBotMemberId() => this.BotMemberId != null;

        /// <summary>
        /// Gets and sets the property BotMemberName. 
        /// <para>
        /// The unique name of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string BotMemberName { get; set; }

        /// <summary>
        /// Checks to see if the BotMemberName property is set.
        /// </summary>
        internal bool IsSetBotMemberName() => this.BotMemberName != null;

        /// <summary>
        /// Gets and sets the property BotMemberVersion. 
        /// <para>
        /// The version of a bot that is a member of this network of bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string BotMemberVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotMemberVersion property is set.
        /// </summary>
        internal bool IsSetBotMemberVersion() => this.BotMemberVersion != null;
    }
}
