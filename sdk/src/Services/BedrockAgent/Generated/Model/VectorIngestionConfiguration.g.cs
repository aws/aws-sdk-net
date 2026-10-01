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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about how to ingest the documents in a data source.
    /// </summary>
    public partial class VectorIngestionConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChunkingConfiguration. 
        /// <para>
        /// Details about how to chunk the documents in the data source. A <i>chunk</i> refers
        /// to an excerpt from a data source that is returned when the knowledge base that it
        /// belongs to is queried.
        /// </para>
        /// </summary>
        public ChunkingConfiguration ChunkingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChunkingConfiguration property is set.
        /// </summary>
        internal bool IsSetChunkingConfiguration() => this.ChunkingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ContextEnrichmentConfiguration. 
        /// <para>
        /// The context enrichment configuration used for ingestion of the data into the vector
        /// store.
        /// </para>
        /// </summary>
        public ContextEnrichmentConfiguration ContextEnrichmentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ContextEnrichmentConfiguration property is set.
        /// </summary>
        internal bool IsSetContextEnrichmentConfiguration() => this.ContextEnrichmentConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomTransformationConfiguration. 
        /// <para>
        /// A custom document transformer for parsed data source documents.
        /// </para>
        /// </summary>
        public CustomTransformationConfiguration CustomTransformationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomTransformationConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomTransformationConfiguration() => this.CustomTransformationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ParsingConfiguration. 
        /// <para>
        /// Configurations for a parser to use for parsing documents in your data source. If you
        /// exclude this field, the default parser will be used.
        /// </para>
        /// </summary>
        public ParsingConfiguration ParsingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ParsingConfiguration property is set.
        /// </summary>
        internal bool IsSetParsingConfiguration() => this.ParsingConfiguration != null;
    }
}
