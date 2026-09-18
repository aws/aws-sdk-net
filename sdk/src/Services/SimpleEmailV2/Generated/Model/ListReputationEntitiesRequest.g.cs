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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListReputationEntities operation. List reputation
    /// entities in your Amazon SES account in the current Amazon Web Services Region. You
    /// can filter the results by entity type, reputation impact, sending status, or entity
    /// reference prefix. <para> <i>Reputation entities</i> represent resources in your account
    /// that have reputation tracking and management capabilities. Use this operation to get
    /// an overview of all entities and their current reputation status. </para>
    /// </summary>
    public partial class ListReputationEntitiesRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// An object that contains filters to apply when listing reputation entities. You can
        /// filter by entity type, reputation impact, sending status, or entity reference prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Filter { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null && (this.Filter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from a previous call to <c>ListReputationEntities</c> to indicate
        /// the position in the list of reputation entities.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of results to show in a single call to <c>ListReputationEntities</c>. If
        /// the number of results is larger than the number you specified in this parameter, then
        /// the response includes a <c>NextToken</c> element, which you can use to obtain additional
        /// results.
        /// </para>
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;
    }
}
