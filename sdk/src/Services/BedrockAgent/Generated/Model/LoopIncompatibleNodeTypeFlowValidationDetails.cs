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
    /// Details about a flow that contains an incompatible node in a DoWhile loop.
    /// </summary>
    public partial class LoopIncompatibleNodeTypeFlowValidationDetails
    {
        private string _incompatibleNodeName;
        private IncompatibleLoopNodeType _incompatibleNodeType;
        private string _node;

        /// <summary>
        /// Gets and sets the property IncompatibleNodeName. 
        /// <para>
        /// The node that's incompatible in the DoWhile loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IncompatibleNodeName
        {
            get { return this._incompatibleNodeName; }
            set { this._incompatibleNodeName = value; }
        }

        // Check to see if IncompatibleNodeName property is set
        internal bool IsSetIncompatibleNodeName()
        {
            return this._incompatibleNodeName != null;
        }

        /// <summary>
        /// Gets and sets the property IncompatibleNodeType. 
        /// <para>
        /// The node type of the incompatible node in the DoWhile loop. Some node types, like
        /// a condition node, aren't allowed in a DoWhile loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncompatibleLoopNodeType IncompatibleNodeType
        {
            get { return this._incompatibleNodeType; }
            set { this._incompatibleNodeType = value; }
        }

        // Check to see if IncompatibleNodeType property is set
        internal bool IsSetIncompatibleNodeType()
        {
            return this._incompatibleNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property Node. 
        /// <para>
        /// The <c>Loop</c> container node that contains an incompatible node.
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

    }
}