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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private ImageInputFormat _format;
        private ImageInputSource _source;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The type of image in the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageInputFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the image in the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageInputSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}