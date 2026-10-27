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
    /// Contains incremental updates to tool results information during streaming responses.
    /// This allows clients to build up tool results data progressively as the response is
    /// generated.
    /// </summary>
    public partial class ToolResultBlockDelta
    {
        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// The JSON schema for the tool result content block. see <a href="https://json-schema.org/understanding-json-schema/reference">JSON
        /// Schema Reference</a>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Json { get; set; }

        /// <summary>
        /// Checks to see if the Json property is set.
        /// </summary>
        internal bool IsSetJson() => !this.Json.IsNull();

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The reasoning the model used to return the output.
        /// </para>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
