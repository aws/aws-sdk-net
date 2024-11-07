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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Details about mismatched output data types in a node.
    /// </summary>
    public partial class MismatchedNodeOutputTypeFlowValidationDetails
    {
        private FlowNodeIODataType _expectedType;
        private string _node;
        private string _output;

        /// <summary>
        /// Gets and sets the property ExpectedType. 
        /// <para>
        /// The expected data type for the node output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowNodeIODataType ExpectedType
        {
            get { return this._expectedType; }
            set { this._expectedType = value; }
        }

        // Check to see if ExpectedType property is set
        internal bool IsSetExpectedType()
        {
            return this._expectedType != null;
        }

        /// <summary>
        /// Gets and sets the property Node. 
        /// <para>
        /// The name of the node containing the output with the mismatched data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Node
        {
            get { return this._node; }
            set { this._node = value; }
        }

        // Check to see if Node property is set
        internal bool IsSetNode()
        {
            return this._node != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The name of the output with the mismatched data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

    }
}