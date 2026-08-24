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
 * Do not modify this file. This file is generated from the agent-registry-2025-12-01.normal.json service model.
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
    /// Container for the parameters to the SearchDiscoverableRegistryRecords operation.
    /// Searches the discoverable registry records in a registry using a natural language
    /// query. Returns metadata for the matching records ordered by relevance.
    /// </summary>
    public partial class SearchDiscoverableRegistryRecordsRequest : AmazonAgentRegistryRequest
    {
        private Amazon.Runtime.Documents.Document _filters;
        private int? _maxResults;
        private List<string> _registryIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _searchQuery;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  An optional structured JSON metadata filter that narrows the search results. Supports
        /// the field-level operators <c>$eq</c>, <c>$ne</c>, and <c>$in</c>, and the logical
        /// operators <c>$and</c> and <c>$or</c> on filterable fields.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Amazon.Runtime.Documents.Document Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return !this._filters.IsNull();
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return. Valid values are 1 through 20. The default
        /// value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryIds. 
        /// <para>
        ///  The registry identifiers to search within. Currently, you must specify exactly one
        /// registry identifier. You can provide either the full Amazon Web Services Resource
        /// Name (ARN) or the registry ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> RegistryIds
        {
            get { return this._registryIds; }
            set { this._registryIds = value; }
        }

        // Check to see if RegistryIds property is set
        internal bool IsSetRegistryIds()
        {
            return this._registryIds != null && (this._registryIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SearchQuery. 
        /// <para>
        ///  The natural language query to search for matching registry records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=256)]
        public string SearchQuery
        {
            get { return this._searchQuery; }
            set { this._searchQuery = value; }
        }

        // Check to see if SearchQuery property is set
        internal bool IsSetSearchQuery()
        {
            return this._searchQuery != null;
        }

    }
}