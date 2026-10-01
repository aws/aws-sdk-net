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
    /// Represents an item in the execution chain for flow trace node input tracking.
    /// </summary>
    public partial class FlowTraceNodeInputExecutionChainItem
    {
        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The index position of this item in the execution chain.
        /// </para>
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Checks to see if the Index property is set.
        /// </summary>
        internal bool IsSetIndex() => this.Index.HasValue;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node in the execution chain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeName { get; set; }

        /// <summary>
        /// Checks to see if the NodeName property is set.
        /// </summary>
        internal bool IsSetNodeName() => this.NodeName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of execution chain item. Supported values are Iterator and Loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowControlNodeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
