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

namespace Amazon.AgentDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the SearchPublicRecords operation. Search public agent
    /// records across the authoritative + crawler indexes. Hybrid keyword + neural ranking,
    /// merged and fused (weighted RRF), with filters, org governance policy, and descriptor-visibility
    /// enforcement applied server-side. Public, authenticated (D-1).
    /// </summary>
    public partial class SearchPublicRecordsRequest : AmazonAgentDiscoveryRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. Structured filter narrowing the results, in the
        /// grammar of Agent Registry's SearchDiscoverableRegistryRecords `filters`: `$eq`, `$ne`
        /// and `$in` on a field, with `$and` or `$or` over single-condition objects, never nested.
        /// Fields are `identifier`, `domain`, `recordType`, `descriptorType`, `provenance` and
        /// `recordVersion`, and `identifier` also takes `$prefix`. For example `{"recordType":
        /// {"$eq": "AGENT"}}` or `{"$or": [{"recordType": {"$eq": "MCP"}}, {"domain": {"$eq":
        /// "acme.com"}}]}`. 
        /// &lt;para&gt;
        /// Limits, the same ones Agent Registry applies: at most 10 conditions, `$in` takes 1-25
        /// values, values are strings of 1-512 characters, and `{}` is invalid. A `document`
        /// can't carry `@length`, so the service enforces these and answers a filter past them
        /// with a ValidationException, as Agent Registry does.
        /// </summary>
        public Amazon.Runtime.Documents.Document Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => !this.Filters.IsNull();

        /// <summary>
        /// Gets and sets the property MaxResults. Max records per page. Default 20, max 100.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. Opaque composite-cursor pagination token (O-DM12).
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchQuery. Free-text natural-language query (ARD `text`).
        /// Drives semantic + lexical ranking.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Checks to see if the SearchQuery property is set.
        /// </summary>
        internal bool IsSetSearchQuery() => this.SearchQuery != null;
    }
}
