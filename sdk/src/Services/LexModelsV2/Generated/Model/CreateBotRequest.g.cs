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
    /// Container for the parameters to the CreateBot operation. Creates an Amazon Lex conversational
    /// bot.
    /// </summary>
    public partial class CreateBotRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotMembers. 
        /// <para>
        /// The list of bot members in a network to be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<BotMember> BotMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<BotMember>() : null;

        /// <summary>
        /// Checks to see if the BotMembers property is set.
        /// </summary>
        internal bool IsSetBotMembers() => this.BotMembers != null && (this.BotMembers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot. The bot name must be unique in the account that creates the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property BotTags. 
        /// <para>
        /// A list of tags to add to the bot. You can only add tags when you create a bot. You
        /// can't use the <c>UpdateBot</c> operation to update tags. To update tags, use the <c>TagResource</c>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> BotTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the BotTags property is set.
        /// </summary>
        internal bool IsSetBotTags() => this.BotTags != null && (this.BotTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotType. 
        /// <para>
        /// The type of a bot to create.
        /// </para>
        /// </summary>
        public BotType BotType { get; set; }

        /// <summary>
        /// Checks to see if the BotType property is set.
        /// </summary>
        internal bool IsSetBotType() => this.BotType != null;

        /// <summary>
        /// Gets and sets the property DataPrivacy. 
        /// <para>
        /// Provides information on additional privacy protections Amazon Lex should use with
        /// the bot's data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataPrivacy DataPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the DataPrivacy property is set.
        /// </summary>
        internal bool IsSetDataPrivacy() => this.DataPrivacy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the bot. It appears in lists to help you identify a particular bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorLogSettings. 
        /// <para>
        /// Specifies the configuration for error logging during bot creation.
        /// </para>
        /// </summary>
        public ErrorLogSettings ErrorLogSettings { get; set; }

        /// <summary>
        /// Checks to see if the ErrorLogSettings property is set.
        /// </summary>
        internal bool IsSetErrorLogSettings() => this.ErrorLogSettings != null;

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The time, in seconds, that Amazon Lex should keep information about a user's conversation
        /// with the bot. 
        /// </para>
        ///  
        /// <para>
        /// A user interaction remains active for the amount of time specified. If no conversation
        /// occurs during this time, the session expires and Amazon Lex deletes any data provided
        /// before the timeout.
        /// </para>
        ///  
        /// <para>
        /// You can specify between 60 (1 minute) and 86,400 (24 hours) seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 86400)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permission to access the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TestBotAliasTags. 
        /// <para>
        /// A list of tags to add to the test alias for a bot. You can only add tags when you
        /// create a bot. You can't use the <c>UpdateAlias</c> operation to update tags. To update
        /// tags on the test alias, use the <c>TagResource</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> TestBotAliasTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TestBotAliasTags property is set.
        /// </summary>
        internal bool IsSetTestBotAliasTags() => this.TestBotAliasTags != null && (this.TestBotAliasTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
