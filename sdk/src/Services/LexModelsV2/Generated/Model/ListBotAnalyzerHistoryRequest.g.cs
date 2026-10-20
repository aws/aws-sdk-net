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
    /// Container for the parameters to the ListBotAnalyzerHistory operation. Retrieves a
    /// list of historical bot analysis executions for a specific bot. You can filter the
    /// results by locale and bot version. <para> The history includes all analysis executions
    /// regardless of their status, allowing you to track past analyses and their outcomes.
    /// </para>
    /// </summary>
    public partial class ListBotAnalyzerHistoryRequest : AmazonLexModelsV2Request
    {
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The bot version to filter the history. If not specified, defaults to <c>DRAFT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale identifier to filter the history. If not specified, returns history for
        /// all locales.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of history entries to return in the response. The default is 10.
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
        /// is used to retrieve the next page of history entries.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
