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
    /// Container for the parameters to the ListIntentPaths operation.
    /// Retrieves summary statistics for a path of intents that users take over sessions with
    /// your bot. The following fields are required:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>startDateTime</c> and <c>endDateTime</c> – Define a time range for which you want
    /// to retrieve results.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>intentPath</c> – Define an order of intents for which you want to retrieve metrics.
    /// Separate intents in the path with a forward slash. For example, populate the <c>intentPath</c>
    /// field with <c>/BookCar/BookHotel</c> to see details about how many times users invoked
    /// the <c>BookCar</c> and <c>BookHotel</c> intents in that order.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use the optional <c>filters</c> field to filter the results.
    /// </para>
    /// </summary>
    public partial class ListIntentPathsRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private DateTime? _endDateTime;
        private List<AnalyticsPathFilter> _filters = AWSConfigs.InitializeCollections ? new List<AnalyticsPathFilter>() : null;
        private string _intentPath;
        private DateTime? _startDateTime;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier for the bot for which you want to retrieve intent path metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
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
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time that marks the end of the range of time for which you want to see
        /// intent path metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of objects, each describes a condition by which you want to filter the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<AnalyticsPathFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntentPath. 
        /// <para>
        /// The intent path for which you want to retrieve metrics. Use a forward slash to separate
        /// intents in the path. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// /BookCar
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// /BookCar/BookHotel
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// /BookHotel/BookCar
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string IntentPath
        {
            get { return this._intentPath; }
            set { this._intentPath = value; }
        }

        // Check to see if IntentPath property is set
        internal bool IsSetIntentPath()
        {
            return this._intentPath != null;
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that marks the beginning of the range of time for which you want
        /// to see intent path metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDateTime
        {
            get { return this._startDateTime; }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

    }
}