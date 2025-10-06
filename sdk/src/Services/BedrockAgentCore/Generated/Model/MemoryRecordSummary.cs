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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains summary information about a memory record.
    /// </summary>
    public partial class MemoryRecordSummary
    {
        private MemoryContent _content;
        private DateTime? _createdAt;
        private string _memoryRecordId;
        private string _memoryStrategyId;
        private List<string> _namespaces = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _score;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the memory record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryContent Content
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the memory record was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryRecordId. 
        /// <para>
        /// The unique identifier of the memory record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=40, Max=50)]
        public string MemoryRecordId
        {
            get { return this._memoryRecordId; }
            set { this._memoryRecordId = value; }
        }

        // Check to see if MemoryRecordId property is set
        internal bool IsSetMemoryRecordId()
        {
            return this._memoryRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryStrategyId. 
        /// <para>
        /// The identifier of the memory strategy associated with this record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MemoryStrategyId
        {
            get { return this._memoryStrategyId; }
            set { this._memoryStrategyId = value; }
        }

        // Check to see if MemoryStrategyId property is set
        internal bool IsSetMemoryStrategyId()
        {
            return this._memoryStrategyId != null;
        }

        /// <summary>
        /// Gets and sets the property Namespaces. 
        /// <para>
        /// The namespaces associated with this memory record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<string> Namespaces
        {
            get { return this._namespaces; }
            set { this._namespaces = value; }
        }

        // Check to see if Namespaces property is set
        internal bool IsSetNamespaces()
        {
            return this._namespaces != null && (this._namespaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The relevance score of the memory record when returned as part of a search result.
        /// Higher values indicate greater relevance to the search query.
        /// </para>
        /// </summary>
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}