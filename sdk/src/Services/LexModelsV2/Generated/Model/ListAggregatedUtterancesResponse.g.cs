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
    /// This is the response object from the ListAggregatedUtterances operation.
    /// </summary>
    public partial class ListAggregatedUtterancesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AggregatedUtterancesSummaries. 
        /// <para>
        /// Summaries of the aggregated utterance data. Each response contains information about
        /// the number of times that the utterance was seen during the time period, whether it
        /// was detected or missed, and when it was seen during the time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AggregatedUtterancesSummary> AggregatedUtterancesSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregatedUtterancesSummary>() : null;

        /// <summary>
        /// Checks to see if the AggregatedUtterancesSummaries property is set.
        /// </summary>
        internal bool IsSetAggregatedUtterancesSummaries() => this.AggregatedUtterancesSummaries != null && (this.AggregatedUtterancesSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AggregationDuration. 
        /// <para>
        /// The time period used to aggregate the utterance data.
        /// </para>
        /// </summary>
        public UtteranceAggregationDuration AggregationDuration { get; set; }

        /// <summary>
        /// Checks to see if the AggregationDuration property is set.
        /// </summary>
        internal bool IsSetAggregationDuration() => this.AggregationDuration != null;

        /// <summary>
        /// Gets and sets the property AggregationLastRefreshedDateTime. 
        /// <para>
        /// The last date and time that the aggregated data was collected. The time period depends
        /// on the length of the aggregation window.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Hours</b> - for 1 hour time window, every half hour; otherwise every hour.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Days</b> - every 6 hours
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Weeks</b> - for a one week time window, every 12 hours; otherwise, every day
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? AggregationLastRefreshedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the AggregationLastRefreshedDateTime property is set.
        /// </summary>
        internal bool IsSetAggregationLastRefreshedDateTime() => this.AggregationLastRefreshedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property AggregationWindowEndTime. 
        /// <para>
        /// The date and time that the aggregation window ends. Only data collected between the
        /// start time and the end time are returned in the results. 
        /// </para>
        /// </summary>
        public DateTime? AggregationWindowEndTime { get; set; }

        /// <summary>
        /// Checks to see if the AggregationWindowEndTime property is set.
        /// </summary>
        internal bool IsSetAggregationWindowEndTime() => this.AggregationWindowEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property AggregationWindowStartTime. 
        /// <para>
        /// The date and time that the aggregation window begins. Only data collected after this
        /// time is returned in the results.
        /// </para>
        /// </summary>
        public DateTime? AggregationWindowStartTime { get; set; }

        /// <summary>
        /// Checks to see if the AggregationWindowStartTime property is set.
        /// </summary>
        internal bool IsSetAggregationWindowStartTime() => this.AggregationWindowStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the bot alias that contains the utterances. If you specified the
        /// bot version, the bot alias ID isn't returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the utterances.
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
        /// The identifier of the bot version that contains the utterances. If you specified the
        /// bot alias, the bot version isn't returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that the utterances are in.
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
        /// A token that indicates whether there are more results to return in a response to the
        /// <c>ListAggregatedUtterances</c> operation. If the <c>nextToken</c> field is present,
        /// you send the contents as the <c>nextToken</c> parameter of a <c>ListAggregatedUtterances</c>
        /// operation request to get the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
