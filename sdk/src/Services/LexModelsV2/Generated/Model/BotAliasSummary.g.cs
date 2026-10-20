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
    /// Summary information about bot aliases returned from the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListBotAliases.html">ListBotAliases</a>
    /// operation.
    /// </summary>
    public partial class BotAliasSummary
    {
        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The unique identifier assigned to the bot alias. You can use this ID to get detailed
        /// information about the alias using the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeBotAlias.html">DescribeBotAlias</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotAliasName. 
        /// <para>
        /// The name of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string BotAliasName { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasName property is set.
        /// </summary>
        internal bool IsSetBotAliasName() => this.BotAliasName != null;

        /// <summary>
        /// Gets and sets the property BotAliasStatus. 
        /// <para>
        /// The current state of the bot alias. If the status is <c>Available</c>, the alias is
        /// ready for use.
        /// </para>
        /// </summary>
        public BotAliasStatus BotAliasStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasStatus property is set.
        /// </summary>
        internal bool IsSetBotAliasStatus() => this.BotAliasStatus != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that the bot alias references.
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
        /// A timestamp of the date and time that the bot alias was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot alias was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;
    }
}
