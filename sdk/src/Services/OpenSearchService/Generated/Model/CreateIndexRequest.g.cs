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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIndex operation. Creates an OpenSearch index
    /// with optional automatic semantic enrichment for specified text fields. Automatic semantic
    /// enrichment enables semantic search capabilities without requiring machine learning
    /// expertise, improving search relevance by up to 20% by understanding search intent
    /// and contextual meaning beyond keyword matching. The semantic enrichment process has
    /// zero impact on search latency as sparse encodings are stored directly within the index
    /// during indexing. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/opensearch-semantic-enrichment.html">Automatic
    /// semantic enrichment</a>.
    /// </summary>
    public partial class CreateIndexRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to create. Must be between 1 and 255 characters and follow OpenSearch
        /// naming conventions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexSchema. 
        /// <para>
        /// The JSON schema defining index mappings, settings, and semantic enrichment configuration.
        /// The schema specifies which text fields should be automatically enriched for semantic
        /// search capabilities and includes OpenSearch index configuration parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document IndexSchema { get; set; }

        /// <summary>
        /// Checks to see if the IndexSchema property is set.
        /// </summary>
        internal bool IsSetIndexSchema() => !this.IndexSchema.IsNull();
    }
}
