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
    /// A long-term memory retrieval that the agent chose to perform. The record reports the
    /// query and the namespace. The corresponding Retrieval step reports the results.
    /// </summary>
    public partial class AgenticRetrieveMemoryRetrieveDetails
    {
        private AgenticRetrieveMessageContent _inputQuery;
        private string _memoryId;
        private string _awsNamespace;
        private string _namespacePath;
        private string _strategyId;

        /// <summary>
        /// Gets and sets the property InputQuery. 
        /// <para>
        /// The query that the agent composed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public AgenticRetrieveMessageContent InputQuery
        {
            get { return this._inputQuery; }
            set { this._inputQuery = value; }
        }

        // Check to see if InputQuery property is set
        internal bool IsSetInputQuery()
        {
            return this._inputQuery != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource retrieved from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MemoryId
        {
            get { return this._memoryId; }
            set { this._memoryId = value; }
        }

        // Check to see if MemoryId property is set
        internal bool IsSetMemoryId()
        {
            return this._memoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace prefix retrieved from, as supplied in the request. This field is present
        /// when the request specified namespace.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NamespacePath. 
        /// <para>
        /// The parent namespace retrieved from hierarchically, as supplied in the request. This
        /// field is present when the request specified namespacePath.
        /// </para>
        /// </summary>
        public string NamespacePath
        {
            get { return this._namespacePath; }
            set { this._namespacePath = value; }
        }

        // Check to see if NamespacePath property is set
        internal bool IsSetNamespacePath()
        {
            return this._namespacePath != null;
        }

        /// <summary>
        /// Gets and sets the property StrategyId. 
        /// <para>
        /// The extraction strategy that restricted retrieval, if the request specified one.
        /// </para>
        /// </summary>
        public string StrategyId
        {
            get { return this._strategyId; }
            set { this._strategyId = value; }
        }

        // Check to see if StrategyId property is set
        internal bool IsSetStrategyId()
        {
            return this._strategyId != null;
        }

    }
}