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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// A result item from an agentic retrieval trace.
    /// </summary>
    public partial class AgenticRetrieveTraceResultItem
    {
        private RetrievalContent _content;
        private Dictionary<string, Amazon.Runtime.Documents.Document> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;
        private AgenticRetrieveSourceRetriever _sourceRetriever;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The retrieved content.
        /// </para>
        /// </summary>
        public RetrievalContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata associated with the retrieved item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceRetriever. 
        /// <para>
        /// The source retriever that produced this result.
        /// </para>
        /// </summary>
        public AgenticRetrieveSourceRetriever SourceRetriever
        {
            get { return this._sourceRetriever; }
            set { this._sourceRetriever = value; }
        }

        // Check to see if SourceRetriever property is set
        internal bool IsSetSourceRetriever()
        {
            return this._sourceRetriever != null;
        }

    }
}