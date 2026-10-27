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
    /// A summary of the bot recommendation.
    /// </summary>
    public partial class BotRecommendationSummary
    {
        /// <summary>
        /// Gets and sets the property BotRecommendationId. 
        /// <para>
        /// The unique identifier of the bot recommendation to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotRecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the BotRecommendationId property is set.
        /// </summary>
        internal bool IsSetBotRecommendationId() => this.BotRecommendationId != null;

        /// <summary>
        /// Gets and sets the property BotRecommendationStatus. 
        /// <para>
        /// The status of the bot recommendation.
        /// </para>
        ///  
        /// <para>
        /// If the status is Failed, then the reasons for the failure are listed in the failureReasons
        /// field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BotRecommendationStatus BotRecommendationStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotRecommendationStatus property is set.
        /// </summary>
        internal bool IsSetBotRecommendationStatus() => this.BotRecommendationStatus != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot recommendation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot recommendation was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;
    }
}
