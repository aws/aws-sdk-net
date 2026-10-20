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
    /// This is the response object from the DescribeBotVersion operation.
    /// </summary>
    public partial class DescribeBotVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the version.
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
        /// The members of bot network in the version that was described.
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
        /// The name of the bot that contains the version.
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
        /// The current status of the bot. When the status is <c>Available</c>, the bot version
        /// is ready for use.
        /// </para>
        /// </summary>
        public BotStatus BotStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotStatus property is set.
        /// </summary>
        internal bool IsSetBotStatus() => this.BotStatus != null;

        /// <summary>
        /// Gets and sets the property BotType. 
        /// <para>
        /// The type of the bot in the version that was described.
        /// </para>
        /// </summary>
        public BotType BotType { get; set; }

        /// <summary>
        /// Checks to see if the BotType property is set.
        /// </summary>
        internal bool IsSetBotType() => this.BotType != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot version was created.
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
        /// Data privacy settings for the bot version.
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
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <c>botStatus</c> is <c>Failed</c>, this contains a list of reasons that the
        /// version couldn't be built.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The number of seconds that a session with the bot remains active before it is discarded
        /// by Amazon Lex.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 86400)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ParentBotNetworks. 
        /// <para>
        /// A list of the networks to which the bot version you described belongs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<ParentBotNetwork> ParentBotNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<ParentBotNetwork>() : null;

        /// <summary>
        /// Checks to see if the ParentBotNetworks property is set.
        /// </summary>
        internal bool IsSetParentBotNetworks() => this.ParentBotNetworks != null && (this.ParentBotNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permission to access the bot
        /// version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
