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
    /// The configuration of a connection originating from a node that isn't a Condition node.
    /// </summary>
    public partial class FlowDataConnectionConfiguration
    {
        /// <summary>
        /// Gets and sets the property SourceOutput. 
        /// <para>
        /// The name of the output in the source node that the connection begins from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceOutput { get; set; }

        /// <summary>
        /// Checks to see if the SourceOutput property is set.
        /// </summary>
        internal bool IsSetSourceOutput() => this.SourceOutput != null;

        /// <summary>
        /// Gets and sets the property TargetInput. 
        /// <para>
        /// The name of the input in the target node that the connection ends at.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetInput { get; set; }

        /// <summary>
        /// Checks to see if the TargetInput property is set.
        /// </summary>
        internal bool IsSetTargetInput() => this.TargetInput != null;
    }
}
