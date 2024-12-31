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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
    /// An image block that contains images that you want to assess with a guardrail.
    /// </summary>
    public partial class GuardrailConverseImageBlock
    {
        private GuardrailConverseImageFormat _format;
        private GuardrailConverseImageSource _source;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format details for the image type of the guardrail converse image block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailConverseImageFormat Format
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
        /// The image source (image bytes) of the guardrail converse image block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public GuardrailConverseImageSource Source
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