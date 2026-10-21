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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Determines which tools the model should request in a call to <c>Converse</c> or <c>ConverseStream</c>.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Call
    /// a tool with the Converse API</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class ToolChoice
    {
        /// <summary>
        /// Gets and sets the property Any. 
        /// <para>
        /// The model must request at least one tool (no text is generated).
        /// </para>
        /// </summary>
        public AnyToolChoice Any { get; set; }

        /// <summary>
        /// Checks to see if the Any property is set.
        /// </summary>
        internal bool IsSetAny() => this.Any != null;

        /// <summary>
        /// Gets and sets the property Auto. 
        /// <para>
        /// (Default). The Model automatically decides if a tool should be called or whether to
        /// generate text instead. 
        /// </para>
        /// </summary>
        public AutoToolChoice Auto { get; set; }

        /// <summary>
        /// Checks to see if the Auto property is set.
        /// </summary>
        internal bool IsSetAuto() => this.Auto != null;

        /// <summary>
        /// Gets and sets the property Tool. 
        /// <para>
        /// The Model must request the specified tool. Only supported by Anthropic Claude 3 and
        /// Amazon Nova models. 
        /// </para>
        /// </summary>
        public SpecificToolChoice Tool { get; set; }

        /// <summary>
        /// Checks to see if the Tool property is set.
        /// </summary>
        internal bool IsSetTool() => this.Tool != null;
    }
}
