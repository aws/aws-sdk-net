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
    /// Output configuration for a model response in a call to <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
    /// or <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>.
    /// </summary>
    public partial class OutputConfig
    {
        private OutputFormat _textFormat;

        /// <summary>
        /// Gets and sets the property TextFormat. 
        /// <para>
        /// Structured output parameters to control the model's text response. 
        /// </para>
        /// </summary>
        public OutputFormat TextFormat
        {
            get { return this._textFormat; }
            set { this._textFormat = value; }
        }

        // Check to see if TextFormat property is set
        internal bool IsSetTextFormat()
        {
            return this._textFormat != null;
        }

    }
}