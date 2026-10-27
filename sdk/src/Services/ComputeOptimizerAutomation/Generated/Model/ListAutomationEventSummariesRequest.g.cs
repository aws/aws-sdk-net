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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the ListAutomationEventSummaries operation. Provides
    /// a summary of automation events based on specified filters. Only events created within
    /// the past year will be included in the summary.
    /// </summary>
    public partial class ListAutomationEventSummariesRequest : AmazonComputeOptimizerAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property EndDateExclusive. 
        /// <para>
        /// The end date for filtering automation event summaries, exclusive. Events created before
        /// this date will be included.
        /// </para>
        /// </summary>
        public string EndDateExclusive { get; set; }

        /// <summary>
        /// Checks to see if the EndDateExclusive property is set.
        /// </summary>
        internal bool IsSetEndDateExclusive() => this.EndDateExclusive != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  The filters to apply to the list of automation event summaries. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomationEventFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomationEventFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of automation event summaries to return in a single response. Valid
        /// range is 1-1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination to retrieve the next set of results when the response
        /// is truncated.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartDateInclusive. 
        /// <para>
        /// The start date for filtering automation event summaries, inclusive. Events created
        /// on or after this date will be included.
        /// </para>
        /// </summary>
        public string StartDateInclusive { get; set; }

        /// <summary>
        /// Checks to see if the StartDateInclusive property is set.
        /// </summary>
        internal bool IsSetStartDateInclusive() => this.StartDateInclusive != null;
    }
}
