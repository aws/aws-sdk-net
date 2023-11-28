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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configures chunking strategy
    /// </summary>
    public partial class ChunkingConfiguration
    {
        private ChunkingStrategy _chunkingStrategy;
        private FixedSizeChunkingConfiguration _fixedSizeChunkingConfiguration;

        /// <summary>
        /// Gets and sets the property ChunkingStrategy.
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