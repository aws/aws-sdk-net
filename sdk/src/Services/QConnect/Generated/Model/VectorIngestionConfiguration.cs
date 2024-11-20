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
    /// Contains details about how to ingest the documents in a data source.
    /// </summary>
    public partial class VectorIngestionConfiguration
    {
        private ChunkingConfiguration _chunkingConfiguration;
        private ParsingConfiguration _parsingConfiguration;

        /// <summary>
        /// Gets and sets the property ChunkingConfiguration. 
        /// <para>
        /// Details about how to chunk the documents in the data source. A chunk refers to an
        /// excerpt from a data source that is returned when the knowledge base that it belongs
        /// to is queried.
        /// </para>
        /// </summary>
        public ChunkingConfiguration ChunkingConfiguration
        {
            get { return this._chunkingConfiguration; }
            set { this._chunkingConfiguration = value; }
        }

        // Check to see if ChunkingConfiguration property is set
        internal bool IsSetChunkingConfiguration()
        {
            return this._chunkingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ParsingConfiguration. 
        /// <para>
        /// A custom parser for data source documents.
        /// </para>
        /// </summary>
        public ParsingConfiguration ParsingConfiguration
        {
            get { return this._parsingConfiguration; }
            set { this._parsingConfiguration = value; }
        }

        // Check to see if ParsingConfiguration property is set
        internal bool IsSetParsingConfiguration()
        {
            return this._parsingConfiguration != null;
        }

    }
}