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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the SearchRegistryRecords operation. Searches for
    /// registry records using semantic, lexical, or hybrid queries. Returns metadata for
    /// matching records ordered by relevance within the specified registry.
    /// </summary>
    public partial class SearchRegistryRecordsRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  A metadata filter expression to narrow search results. Uses structured JSON operators
        /// including field-level operators (<c>$eq</c>, <c>$ne</c>, <c>$in</c>) and logical operators
        /// (<c>$and</c>, <c>$or</c>) on filterable fields (<c>name</c>, <c>descriptorType</c>,
        /// <c>version</c>). For example, to filter by descriptor type: <c>{"descriptorType":
        /// {"$eq": "MCP"}}</c>. To combine filters: <c>{"$and": [{"descriptorType": {"$eq": "MCP"}},
        /// {"name": {"$eq": "my-tool"}}]}</c>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => !this.Filters.IsNull();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of records to return in a single call. Valid values are 1 through
        /// 20. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryIds. 
        /// <para>
        ///  The list of registry identifiers to search within. Currently, you can specify exactly
        /// one registry identifier. You can provide either the full Amazon Web Services Resource
        /// Name (ARN) or the 12-character alphanumeric registry ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> RegistryIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegistryIds property is set.
        /// </summary>
        internal bool IsSetRegistryIds() => this.RegistryIds != null && (this.RegistryIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchQuery. 
        /// <para>
        ///  The search query to find matching registry records.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Checks to see if the SearchQuery property is set.
        /// </summary>
        internal bool IsSetSearchQuery() => this.SearchQuery != null;
    }
}
