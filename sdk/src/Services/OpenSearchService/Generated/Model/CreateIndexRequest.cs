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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIndex operation.
    /// Creates an OpenSearch index with optional automatic semantic enrichment for specified
    /// text fields. Automatic semantic enrichment enables semantic search capabilities without
    /// requiring machine learning expertise, improving search relevance by up to 20% by understanding
    /// search intent and contextual meaning beyond keyword matching. The semantic enrichment
    /// process has zero impact on search latency as sparse encodings are stored directly
    /// within the index during indexing. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/opensearch-semantic-enrichment.html">Automatic
    /// semantic enrichment</a>.
    /// </summary>
    public partial class CreateIndexRequest : AmazonOpenSearchServiceRequest
    {
        private string _domainName;
        private string _indexName;
        private Amazon.Runtime.Documents.Document _indexSchema;

        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to create. Must be between 1 and 255 characters and follow OpenSearch
        /// naming conventions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexSchema. 
        /// <para>
        /// The JSON schema defining index mappings, settings, and semantic enrichment configuration.
        /// The schema specifies which text fields should be automatically enriched for semantic
        /// search capabilities and includes OpenSearch index configuration parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document IndexSchema
        {
            get { return this._indexSchema; }
            set { this._indexSchema = value; }
        }

        // Check to see if IndexSchema property is set
        internal bool IsSetIndexSchema()
        {
            return !this._indexSchema.IsNull();
        }

    }
}