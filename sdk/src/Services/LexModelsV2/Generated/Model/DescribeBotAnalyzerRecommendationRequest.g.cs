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
    /// Container for the parameters to the DescribeBotAnalyzerRecommendation operation. Retrieves
    /// the analysis results and recommendations for bot optimization. The analysis must be
    /// in <c>Available</c> status before recommendations can be retrieved. <para> Recommendations
    /// are returned with pagination support. Each recommendation includes the issue location,
    /// priority level, detailed description, and proposed fix. </para>
    /// </summary>
    public partial class DescribeBotAnalyzerRecommendationRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotAnalyzerRequestId. 
        /// <para>
        /// The unique identifier of the analysis request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string BotAnalyzerRequestId { get; set; }

        /// <summary>
        /// Checks to see if the BotAnalyzerRequestId property is set.
        /// </summary>
        internal bool IsSetBotAnalyzerRequestId() => this.BotAnalyzerRequestId != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendations to return in the response. The default is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response from a previous request was truncated, the <c>nextToken</c> value
        /// is used to retrieve the next page of recommendations.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
