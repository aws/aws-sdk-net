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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more aggregators for viewing counts of nodes using different dimensions.
    /// </summary>
    public partial class NodeAggregator
    {
        /// <summary>
        /// Gets and sets the property AggregatorType. 
        /// <para>
        /// The aggregator type for limiting a node summary. Currently, only <c>Count</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeAggregatorType AggregatorType { get; set; }

        /// <summary>
        /// Checks to see if the AggregatorType property is set.
        /// </summary>
        internal bool IsSetAggregatorType() => this.AggregatorType != null;

        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// Information about aggregators used to refine a node summary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<NodeAggregator> Aggregators { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeAggregator>() : null;

        /// <summary>
        /// Checks to see if the Aggregators property is set.
        /// </summary>
        internal bool IsSetAggregators() => this.Aggregators != null && (this.Aggregators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of a node attribute on which to limit the count of nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeAttributeName AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The data type name to use for viewing counts of nodes. Currently, only <c>Instance</c>
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeTypeName TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
