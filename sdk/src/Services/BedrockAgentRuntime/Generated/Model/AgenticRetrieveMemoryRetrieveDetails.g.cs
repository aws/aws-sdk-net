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
    /// A long-term memory retrieval that the agent chose to perform. The record reports the
    /// query and the namespace. The corresponding Retrieval step reports the results.
    /// </summary>
    public partial class AgenticRetrieveMemoryRetrieveDetails
    {
        /// <summary>
        /// Gets and sets the property InputQuery. 
        /// <para>
        /// The query that the agent composed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public AgenticRetrieveMessageContent InputQuery { get; set; }

        /// <summary>
        /// Checks to see if the InputQuery property is set.
        /// </summary>
        internal bool IsSetInputQuery() => this.InputQuery != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource retrieved from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace prefix retrieved from, as supplied in the request. This field is present
        /// when the request specified namespace.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NamespacePath. 
        /// <para>
        /// The parent namespace retrieved from hierarchically, as supplied in the request. This
        /// field is present when the request specified namespacePath.
        /// </para>
        /// </summary>
        public string NamespacePath { get; set; }

        /// <summary>
        /// Checks to see if the NamespacePath property is set.
        /// </summary>
        internal bool IsSetNamespacePath() => this.NamespacePath != null;

        /// <summary>
        /// Gets and sets the property StrategyId. 
        /// <para>
        /// The extraction strategy that restricted retrieval, if the request specified one.
        /// </para>
        /// </summary>
        public string StrategyId { get; set; }

        /// <summary>
        /// Checks to see if the StrategyId property is set.
        /// </summary>
        internal bool IsSetStrategyId() => this.StrategyId != null;
    }
}
