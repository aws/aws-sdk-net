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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// The destination for the request that a function builds. Specify exactly one member.
    /// </summary>
    public partial class FunctionTarget
    {
        /// <summary>
        /// Gets and sets the property Bedrock. 
        /// <para>
        /// Send the request to an Amazon Bedrock model.
        /// </para>
        /// </summary>
        public BedrockFunctionTarget Bedrock { get; set; }

        /// <summary>
        /// Checks to see if the Bedrock property is set.
        /// </summary>
        internal bool IsSetBedrock() => this.Bedrock != null;

        /// <summary>
        /// Gets and sets the property Passthrough. 
        /// <para>
        /// Send the request nowhere. Use this target to reshape the metadata that Elemental Inference
        /// already produces, with no model invocation and no model charges. 
        /// </para>
        /// </summary>
        public PassthroughFunctionTarget Passthrough { get; set; }

        /// <summary>
        /// Checks to see if the Passthrough property is set.
        /// </summary>
        internal bool IsSetPassthrough() => this.Passthrough != null;
    }
}
