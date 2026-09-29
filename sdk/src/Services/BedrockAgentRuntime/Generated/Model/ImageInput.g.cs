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
    /// Details about an image in the result from a function in the action group invocation.
    /// You can specify images only when the function is a computer use action. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agent-computer-use.html">Configure
    /// an Amazon Bedrock Agent to complete tasks with computer use tools</a>.
    /// </summary>
    public partial class ImageInput
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The type of image in the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageInputFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the image in the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageInputSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
