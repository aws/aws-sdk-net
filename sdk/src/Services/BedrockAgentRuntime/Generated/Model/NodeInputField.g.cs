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
    /// Represents an input field provided to a node during a flow execution.
    /// </summary>
    public partial class NodeInputField
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the input field.
        /// </para>
        /// </summary>
        public FlowNodeInputCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the input field, which can contain text or structured data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public NodeExecutionContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ExecutionChain. 
        /// <para>
        /// The execution path through nested nodes like iterators and loops.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeInputExecutionChainItem> ExecutionChain { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeInputExecutionChainItem>() : null;

        /// <summary>
        /// Checks to see if the ExecutionChain property is set.
        /// </summary>
        internal bool IsSetExecutionChain() => this.ExecutionChain != null && (this.ExecutionChain.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the input field as defined in the node's input schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source node that provides input data to this field.
        /// </para>
        /// </summary>
        public NodeInputSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the input field for compatibility validation.
        /// </para>
        /// </summary>
        public FlowNodeIODataType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
