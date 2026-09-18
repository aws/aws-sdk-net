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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Details about a flow that contains an incompatible node in a DoWhile loop.
    /// </summary>
    public partial class LoopIncompatibleNodeTypeFlowValidationDetails
    {
        /// <summary>
        /// Gets and sets the property IncompatibleNodeName. 
        /// <para>
        /// The node that's incompatible in the DoWhile loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IncompatibleNodeName { get; set; }

        /// <summary>
        /// Checks to see if the IncompatibleNodeName property is set.
        /// </summary>
        internal bool IsSetIncompatibleNodeName() => this.IncompatibleNodeName != null;

        /// <summary>
        /// Gets and sets the property IncompatibleNodeType. 
        /// <para>
        /// The node type of the incompatible node in the DoWhile loop. Some node types, like
        /// a condition node, aren't allowed in a DoWhile loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IncompatibleLoopNodeType IncompatibleNodeType { get; set; }

        /// <summary>
        /// Checks to see if the IncompatibleNodeType property is set.
        /// </summary>
        internal bool IsSetIncompatibleNodeType() => this.IncompatibleNodeType != null;

        /// <summary>
        /// Gets and sets the property Node. 
        /// <para>
        /// The <c>Loop</c> container node that contains an incompatible node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Node { get; set; }

        /// <summary>
        /// Checks to see if the Node property is set.
        /// </summary>
        internal bool IsSetNode() => this.Node != null;
    }
}
