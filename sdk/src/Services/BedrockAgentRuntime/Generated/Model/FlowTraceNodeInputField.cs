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
    /// Contains information about a field in the input into a node. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-trace.html">Track
    /// each step in your prompt flow by viewing its trace in Amazon Bedrock</a>.
    /// </summary>
    public partial class FlowTraceNodeInputField
    {
        private FlowNodeInputCategory _category;
        private FlowTraceNodeInputContent _content;
        private List<FlowTraceNodeInputExecutionChainItem> _executionChain = AWSConfigs.InitializeCollections ? new List<FlowTraceNodeInputExecutionChainItem>() : null;
        private string _nodeInputName;
        private FlowTraceNodeInputSource _source;
        private FlowNodeIODataType _type;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the input field.
        /// </para>
        /// </summary>
        public FlowNodeInputCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the node input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public FlowTraceNodeInputContent Content
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
        /// Gets and sets the property ExecutionChain. 
        /// <para>
        /// The execution path through nested nodes like iterators and loops.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<FlowTraceNodeInputExecutionChainItem> ExecutionChain
        {
            get { return this._executionChain; }
            set { this._executionChain = value; }
        }

        // Check to see if ExecutionChain property is set
        internal bool IsSetExecutionChain()
        {
            return this._executionChain != null && (this._executionChain.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeInputName. 
        /// <para>
        /// The name of the node input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeInputName
        {
            get { return this._nodeInputName; }
            set { this._nodeInputName = value; }
        }

        // Check to see if NodeInputName property is set
        internal bool IsSetNodeInputName()
        {
            return this._nodeInputName != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source node that provides input data to this field.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FlowTraceNodeInputSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the input field for compatibility validation.
        /// </para>
        /// </summary>
        public FlowNodeIODataType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}