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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the Rerank operation. Reranks the relevance of sources
    /// based on queries. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/rerank.html">Improve
    /// the relevance of query responses with a reranker model</a>.
    /// </summary>
    public partial class RerankRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results was greater than could fit in a response, a token is
        /// returned in the <c>nextToken</c> field. You can enter that token in this field to
        /// return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Queries. 
        /// <para>
        /// An array of objects, each of which contains information about a query to submit to
        /// the reranker model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1)]
        public List<RerankQuery> Queries { get; set; } = AWSConfigs.InitializeCollections ? new List<RerankQuery>() : null;

        /// <summary>
        /// Checks to see if the Queries property is set.
        /// </summary>
        internal bool IsSetQueries() => this.Queries != null && (this.Queries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RerankingConfiguration. 
        /// <para>
        /// Contains configurations for reranking.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RerankingConfiguration RerankingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RerankingConfiguration property is set.
        /// </summary>
        internal bool IsSetRerankingConfiguration() => this.RerankingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// An array of objects, each of which contains information about the sources to rerank.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1000)]
        public List<RerankSource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<RerankSource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
