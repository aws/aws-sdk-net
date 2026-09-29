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
    /// The long-term memory namespace that the agent might retrieve memory records from,
    /// and the filters applied to that retrieval. You must specify either namespace or namespacePath.
    /// </summary>
    public partial class AgenticRetrieveMemoryRetrievalConfig
    {
        /// <summary>
        /// Gets and sets the property MetadataFilters. 
        /// <para>
        /// The metadata filter expressions that restrict retrieval to matching memory records.
        /// You can specify a maximum of 5 expressions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveMemoryMetadataFilter> MetadataFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveMemoryMetadataFilter>() : null;

        /// <summary>
        /// Checks to see if the MetadataFilters property is set.
        /// </summary>
        internal bool IsSetMetadataFilters() => this.MetadataFilters != null && (this.MetadataFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace prefix to filter memory records by. The agent retrieves memory records
        /// in namespaces that start with the provided prefix. You must specify either namespace
        /// or namespacePath.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NamespacePath. 
        /// <para>
        /// The parent namespace to use for hierarchical retrievals. The agent retrieves all memory
        /// records whose namespace falls under the same parent hierarchy. You must specify either
        /// namespace or namespacePath.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NamespacePath { get; set; }

        /// <summary>
        /// Checks to see if the NamespacePath property is set.
        /// </summary>
        internal bool IsSetNamespacePath() => this.NamespacePath != null;

        /// <summary>
        /// Gets and sets the property StrategyId. 
        /// <para>
        /// The extraction strategy ID that restricts retrieval to memory records produced by
        /// a single strategy. Omit this parameter to retrieve records from every strategy on
        /// the memory resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string StrategyId { get; set; }

        /// <summary>
        /// Checks to see if the StrategyId property is set.
        /// </summary>
        internal bool IsSetStrategyId() => this.StrategyId != null;
    }
}
