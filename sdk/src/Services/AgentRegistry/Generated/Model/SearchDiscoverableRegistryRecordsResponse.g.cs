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

namespace Amazon.AgentRegistry.Model
{
    /// <summary>
    /// This is the response object from the SearchDiscoverableRegistryRecords operation.
    /// </summary>
    public partial class SearchDiscoverableRegistryRecordsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token to pass to a subsequent request to retrieve the next page of
        /// results. This field is absent when there are no more results, or when the search has
        /// returned the maximum number of results for its search type.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegistryRecords. 
        /// <para>
        ///  The registry records that match the search query, ordered by relevance. A page can
        /// contain fewer than <c>maxResults</c> records, or none, even when the response includes
        /// a <c>nextToken</c>. To retrieve every result, continue until the response has no <c>nextToken</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RegistryRecordSummary> RegistryRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<RegistryRecordSummary>() : null;

        /// <summary>
        /// Checks to see if the RegistryRecords property is set.
        /// </summary>
        internal bool IsSetRegistryRecords() => this.RegistryRecords != null && (this.RegistryRecords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchType. 
        /// <para>
        ///  Specifies the search type that the service used to rank the returned records. If
        /// you omitted <c>searchType</c> in the request, this is the default for the Amazon Web
        /// Services Region: <c>HYBRID</c> where semantic search is supported, and <c>KEYWORD</c>
        /// elsewhere.
        /// </para>
        /// </summary>
        public SearchType SearchType { get; set; }

        /// <summary>
        /// Checks to see if the SearchType property is set.
        /// </summary>
        internal bool IsSetSearchType() => this.SearchType != null;
    }
}
