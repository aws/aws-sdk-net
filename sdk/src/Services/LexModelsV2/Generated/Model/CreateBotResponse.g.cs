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
    /// This is the response object from the CreateBot operation.
    /// </summary>
    public partial class CreateBotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// A unique identifier for a particular bot. You use this to identify the bot when you
        /// call other Amazon Lex API operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotMembers. 
        /// <para>
        /// The list of bots in a network that was created.
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
        /// The name specified for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property BotStatus. 
        /// <para>
        /// Shows the current status of the bot. The bot is first in the <c>Creating</c> status.
        /// Once the bot is read for use, it changes to the <c>Available</c> status. After the
        /// bot is created, you can use the <c>DRAFT</c> version of the bot.
        /// </para>
        /// </summary>
        public BotStatus BotStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotStatus property is set.
        /// </summary>
        internal bool IsSetBotStatus() => this.BotStatus != null;

        /// <summary>
        /// Gets and sets the property BotTags. 
        /// <para>
        /// A list of tags associated with the bot.
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
        /// The type of a bot that was created.
        /// </para>
        /// </summary>
        public BotType BotType { get; set; }

        /// <summary>
        /// Checks to see if the BotType property is set.
        /// </summary>
        internal bool IsSetBotType() => this.BotType != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp indicating the date and time that the bot was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataPrivacy. 
        /// <para>
        /// The data privacy settings specified for the bot.
        /// </para>
        /// </summary>
        public DataPrivacy DataPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the DataPrivacy property is set.
        /// </summary>
        internal bool IsSetDataPrivacy() => this.DataPrivacy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description specified for the bot.
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
        /// Specifies configuration settings for delivering error logs to Cloudwatch Logs in an
        /// Amazon Lex bot response.
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
        /// The session idle time specified for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 86400)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role specified for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TestBotAliasTags. 
        /// <para>
        /// A list of tags associated with the test alias for the bot.
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
