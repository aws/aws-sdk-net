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
    /// Contains a specification for a tool. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Use
    /// a tool to complete an Amazon Bedrock model response</a>.
    /// </summary>
    public partial class ToolSpecification
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// The input schema for the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ToolInputSchema InputSchema { get; set; }

        /// <summary>
        /// Checks to see if the InputSchema property is set.
        /// </summary>
        internal bool IsSetInputSchema() => this.InputSchema != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Strict. 
        /// <para>
        /// Whether the tool schema is strictly enforced.
        /// </para>
        /// </summary>
        public bool? Strict { get; set; }

        /// <summary>
        /// Checks to see if the Strict property is set.
        /// </summary>
        internal bool IsSetStrict() => this.Strict.HasValue;
    }
}
