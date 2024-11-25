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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Details about how to chunk the documents in the data source. A chunk refers to an
    /// excerpt from a data source that is returned when the knowledge base that it belongs
    /// to is queried.
    /// </summary>
    public partial class ChunkingConfiguration
    {
        private ChunkingStrategy _chunkingStrategy;
        private FixedSizeChunkingConfiguration _fixedSizeChunkingConfiguration;
        private HierarchicalChunkingConfiguration _hierarchicalChunkingConfiguration;
        private SemanticChunkingConfiguration _semanticChunkingConfiguration;

        /// <summary>
        /// Gets and sets the property ChunkingStrategy. 
        /// <para>
        /// Knowledge base can split your source data into chunks. A chunk refers to an excerpt
        /// from a data source that is returned when the knowledge base that it belongs to is
        /// queried. You have the following options for chunking your data. If you opt for <c>NONE</c>,
        /// then you may want to pre-process your files by splitting them up such that each file
        /// corresponds to a chunk.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChunkingStrategy ChunkingStrategy
        {
            get { return this._chunkingStrategy; }
            set { this._chunkingStrategy = value; }
        }

        // Check to see if ChunkingStrategy property is set
        internal bool IsSetChunkingStrategy()
        {
            return this._chunkingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property FixedSizeChunkingConfiguration. 
        /// <para>
        /// Configurations for when you choose fixed-size chunking. If you set the <c>chunkingStrategy</c>
        /// as <c>NONE</c>, exclude this field.
        /// </para>
        /// </summary>
        public FixedSizeChunkingConfiguration FixedSizeChunkingConfiguration
        {
            get { return this._fixedSizeChunkingConfiguration; }
            set { this._fixedSizeChunkingConfiguration = value; }
        }

        // Check to see if FixedSizeChunkingConfiguration property is set
        internal bool IsSetFixedSizeChunkingConfiguration()
        {
            return this._fixedSizeChunkingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchicalChunkingConfiguration. 
        /// <para>
        /// Settings for hierarchical document chunking for a data source. Hierarchical chunking
        /// splits documents into layers of chunks where the first layer contains large chunks,
        /// and the second layer contains smaller chunks derived from the first layer.
        /// </para>
        /// </summary>
        public HierarchicalChunkingConfiguration HierarchicalChunkingConfiguration
        {
            get { return this._hierarchicalChunkingConfiguration; }
            set { this._hierarchicalChunkingConfiguration = value; }
        }

        // Check to see if HierarchicalChunkingConfiguration property is set
        internal bool IsSetHierarchicalChunkingConfiguration()
        {
            return this._hierarchicalChunkingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticChunkingConfiguration. 
        /// <para>
        /// Settings for semantic document chunking for a data source. Semantic chunking splits
        /// a document into smaller documents based on groups of similar content derived from
        /// the text with natural language processing.
        /// </para>
        /// </summary>
        public SemanticChunkingConfiguration SemanticChunkingConfiguration
        {
            get { return this._semanticChunkingConfiguration; }
            set { this._semanticChunkingConfiguration = value; }
        }

        // Check to see if SemanticChunkingConfiguration property is set
        internal bool IsSetSemanticChunkingConfiguration()
        {
            return this._semanticChunkingConfiguration != null;
        }

    }
}