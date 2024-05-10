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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Details about how to chunk the documents in the data source. A <i>chunk</i> refers
    /// to an excerpt from a data source that is returned when the knowledge base that it
    /// belongs to is queried.
    /// </summary>
    public partial class ChunkingConfiguration
    {
        private ChunkingStrategy _chunkingStrategy;
        private FixedSizeChunkingConfiguration _fixedSizeChunkingConfiguration;

        /// <summary>
        /// Gets and sets the property ChunkingStrategy. 
        /// <para>
        /// Knowledge base can split your source data into chunks. A <i>chunk</i> refers to an
        /// excerpt from a data source that is returned when the knowledge base that it belongs
        /// to is queried. You have the following options for chunking your data. If you opt for
        /// <c>NONE</c>, then you may want to pre-process your files by splitting them up such
        /// that each file corresponds to a chunk.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FIXED_SIZE</c> – Amazon Bedrock splits your source data into chunks of the approximate
        /// size that you set in the <c>fixedSizeChunkingConfiguration</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Amazon Bedrock treats each file as one chunk. If you choose this option,
        /// you may want to pre-process your documents by splitting them into separate files.
        /// </para>
        ///  </li> </ul>
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

    }
}