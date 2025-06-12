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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
        private List<AggregatedUtterancesSummary> _aggregatedUtterancesSummaries = AWSConfigs.InitializeCollections ? new List<AggregatedUtterancesSummary>() : null;
        private UtteranceAggregationDuration _aggregationDuration;
        private DateTime? _aggregationLastRefreshedDateTime;
        private DateTime? _aggregationWindowEndTime;
        private DateTime? _aggregationWindowStartTime;
        private string _botAliasId;
        private string _botId;
        private string _botVersion;
        private string _localeId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AggregatedUtterancesSummaries. 
        /// <para>
        /// Summaries of the aggregated utterance data. Each response contains information about
        /// the number of times that the utterance was seen during the time period, whether it
        /// was detected or missed, and when it was seen during the time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AggregatedUtterancesSummary> AggregatedUtterancesSummaries
        {
            get { return this._aggregatedUtterancesSummaries; }
            set { this._aggregatedUtterancesSummaries = value; }
        }

        // Check to see if AggregatedUtterancesSummaries property is set
        internal bool IsSetAggregatedUtterancesSummaries()
        {
            return this._aggregatedUtterancesSummaries != null && (this._aggregatedUtterancesSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AggregationDuration. 
        /// <para>
        /// The time period used to aggregate the utterance data.
        /// </para>
        /// </summary>
        public UtteranceAggregationDuration AggregationDuration
        {
            get { return this._aggregationDuration; }
            set { this._aggregationDuration = value; }
        }

        // Check to see if AggregationDuration property is set
        internal bool IsSetAggregationDuration()
        {
            return this._aggregationDuration != null;
        }

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
        public DateTime? AggregationLastRefreshedDateTime
        {
            get { return this._aggregationLastRefreshedDateTime; }
            set { this._aggregationLastRefreshedDateTime = value; }
        }

        // Check to see if AggregationLastRefreshedDateTime property is set
        internal bool IsSetAggregationLastRefreshedDateTime()
        {
            return this._aggregationLastRefreshedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AggregationWindowEndTime. 
        /// <para>
        /// The date and time that the aggregation window ends. Only data collected between the
        /// start time and the end time are returned in the results. 
        /// </para>
        /// </summary>
        public DateTime? AggregationWindowEndTime
        {
            get { return this._aggregationWindowEndTime; }
            set { this._aggregationWindowEndTime = value; }
        }

        // Check to see if AggregationWindowEndTime property is set
        internal bool IsSetAggregationWindowEndTime()
        {
            return this._aggregationWindowEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AggregationWindowStartTime. 
        /// <para>
        /// The date and time that the aggregation window begins. Only data collected after this
        /// time is returned in the results.
        /// </para>
        /// </summary>
        public DateTime? AggregationWindowStartTime
        {
            get { return this._aggregationWindowStartTime; }
            set { this._aggregationWindowStartTime = value; }
        }

        // Check to see if AggregationWindowStartTime property is set
        internal bool IsSetAggregationWindowStartTime()
        {
            return this._aggregationWindowStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the bot alias that contains the utterances. If you specified the
        /// bot version, the bot alias ID isn't returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotAliasId
        {
            get { return this._botAliasId; }
            set { this._botAliasId = value; }
        }

        // Check to see if BotAliasId property is set
        internal bool IsSetBotAliasId()
        {
            return this._botAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the utterances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The identifier of the bot version that contains the utterances. If you specified the
        /// bot alias, the bot version isn't returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that the utterances are in.
        /// </para>
        /// </summary>
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates whether there are more results to return in a response to the
        /// <c>ListAggregatedUtterances</c> operation. If the <c>nextToken</c> field is present,
        /// you send the contents as the <c>nextToken</c> parameter of a <c>ListAggregatedUtterances</c>
        /// operation request to get the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}