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
    /// Summary information about a bot returned by the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListBots.html">ListBots</a>
    /// operation.
    /// </summary>
    public partial class BotSummary
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier assigned to the bot. Use this ID to get detailed information
        /// about the bot with the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeBot.html">DescribeBot</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot.
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
        /// The current status of the bot. When the status is <c>Available</c> the bot is ready
        /// for use.
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
        /// The type of the bot.
        /// </para>
        /// </summary>
        public BotType BotType { get; set; }

        /// <summary>
        /// Checks to see if the BotType property is set.
        /// </summary>
        internal bool IsSetBotType() => this.BotType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the bot.
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
        /// The date and time that the bot was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestBotVersion. 
        /// <para>
        /// The latest numerical version in use for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string LatestBotVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestBotVersion property is set.
        /// </summary>
        internal bool IsSetLatestBotVersion() => this.LatestBotVersion != null;
    }
}
