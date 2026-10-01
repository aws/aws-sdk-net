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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A tool available to the agent loop.
    /// </summary>
    public partial class HarnessTool
    {
        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// Tool-specific configuration.
        /// </para>
        /// </summary>
        public HarnessToolConfiguration Config { get; set; }

        /// <summary>
        /// Checks to see if the Config property is set.
        /// </summary>
        internal bool IsSetConfig() => this.Config != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Unique name for the tool. If not provided, a name will be inferred or generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarnessToolType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
