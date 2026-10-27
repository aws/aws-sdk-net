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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the SearchOrganizationInsights operation. Returns
    /// a list of insights in your organization. You can specify which insights are returned
    /// by their start time, one or more statuses (<c>ONGOING</c>, <c>CLOSED</c>, and <c>CLOSED</c>),
    /// one or more severities (<c>LOW</c>, <c>MEDIUM</c>, and <c>HIGH</c>), and type (<c>REACTIVE</c>
    /// or <c>PROACTIVE</c>). <para> Use the <c>Filters</c> parameter to specify status and
    /// severity search parameters. Use the <c>Type</c> parameter to specify <c>REACTIVE</c>
    /// or <c>PROACTIVE</c> in your search. </para>
    /// </summary>
    public partial class SearchOrganizationInsightsRequest : AmazonDevOpsGuruRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The ID of the Amazon Web Services account. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  A <c>SearchOrganizationInsightsFilters</c> object that is used to set the severity
        /// and status filters on your insight search. 
        /// </para>
        /// </summary>
        public SearchOrganizationInsightsFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <c>nextToken</c> value.
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
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If this value is null, it retrieves the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTimeRange.
        /// </summary>
        [AWSProperty(Required = true)]
        public StartTimeRange StartTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeRange property is set.
        /// </summary>
        internal bool IsSetStartTimeRange() => this.StartTimeRange != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of insights you are searching for (<c>REACTIVE</c> or <c>PROACTIVE</c>).
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
