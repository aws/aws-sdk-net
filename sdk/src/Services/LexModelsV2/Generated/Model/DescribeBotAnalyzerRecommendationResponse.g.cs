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
    /// This is the response object from the DescribeBotAnalyzerRecommendation operation.
    /// </summary>
    public partial class DescribeBotAnalyzerRecommendationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotAnalyzerRecommendationList. 
        /// <para>
        /// A list of recommendations for optimizing your bot configuration. Each recommendation
        /// includes the issue location, priority, description, and proposed fix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotAnalyzerRecommendation> BotAnalyzerRecommendationList { get; set; } = AWSConfigs.InitializeCollections ? new List<BotAnalyzerRecommendation>() : null;

        /// <summary>
        /// Checks to see if the BotAnalyzerRecommendationList property is set.
        /// </summary>
        internal bool IsSetBotAnalyzerRecommendationList() => this.BotAnalyzerRecommendationList != null && (this.BotAnalyzerRecommendationList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotAnalyzerStatus. 
        /// <para>
        /// The current status of the analysis.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>Processing | Available | Failed | Stopping | Stopped</c> 
        /// </para>
        /// </summary>
        public BotAnalyzerStatus BotAnalyzerStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotAnalyzerStatus property is set.
        /// </summary>
        internal bool IsSetBotAnalyzerStatus() => this.BotAnalyzerStatus != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the analysis was initiated.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale identifier of the bot locale that was analyzed.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, this token can be used in a subsequent request to retrieve
        /// the next page of recommendations.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
