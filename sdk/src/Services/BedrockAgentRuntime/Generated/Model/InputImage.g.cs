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
    /// Contains the image data for multimodal knowledge base queries, including format and
    /// content.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html#API_agent-runtime_Retrieve_RequestSyntax">Retrieve
    /// request</a> – in the <c>image</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InputImage
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the input image. Supported formats include png, gif, jpeg, and webp.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputImageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property InlineContent. 
        /// <para>
        /// The base64-encoded image data for inline image content. Maximum size is 5MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 5242880)]
        public MemoryStream InlineContent { get; set; }

        /// <summary>
        /// Checks to see if the InlineContent property is set.
        /// </summary>
        internal bool IsSetInlineContent() => this.InlineContent != null;
    }
}
