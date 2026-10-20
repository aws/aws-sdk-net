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
    /// Container for the parameters to the ListSlots operation. Gets a list of slots that
    /// match the specified criteria.
    /// </summary>
    public partial class ListSlotsRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the slot.
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
        /// The version of the bot that contains the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Provides the specification of a filter used to limit the slots in the response to
        /// only those that match the filter specification. You can only specify one filter and
        /// only one string to filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<SlotFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<SlotFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The unique identifier of the intent that contains the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string IntentId { get; set; }

        /// <summary>
        /// Checks to see if the IntentId property is set.
        /// </summary>
        internal bool IsSetIntentId() => this.IntentId != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale of the slots to list. The string must match
        /// one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of slots to return in each page of results. If there are fewer
        /// results than the max page size, only the actual number of results are returned.
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
        /// If the response from the <c>ListSlots</c> operation contains more results than specified
        /// in the <c>maxResults</c> parameter, a token is returned in the response. Use that
        /// token in the <c>nextToken</c> parameter to return the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Determines the sort order for the response from the <c>ListSlots</c> operation. You
        /// can choose to sort by the slot name or last updated date in either ascending or descending
        /// order.
        /// </para>
        /// </summary>
        public SlotSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;
    }
}
