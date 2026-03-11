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
    /// Input structure to create a new memory record.
    /// </summary>
    public partial class MemoryRecordCreateInput
    {
        private MemoryContent _content;
        private string _memoryStrategyId;
        private List<string> _namespaces = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _requestIdentifier;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content to be stored within the memory record.
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
        /// Gets and sets the property MemoryStrategyId. 
        /// <para>
        /// The ID of the memory strategy that defines how this memory record is grouped.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A list of namespace identifiers that categorize or group the memory record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// A client-provided identifier for tracking this specific record creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string RequestIdentifier
        {
            get { return this._requestIdentifier; }
            set { this._requestIdentifier = value; }
        }

        // Check to see if RequestIdentifier property is set
        internal bool IsSetRequestIdentifier()
        {
            return this._requestIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time at which the memory record was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}