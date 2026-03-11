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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Represents content input for policy generation operations. This structure encapsulates
    /// the natural language descriptions or other content formats that are used as input
    /// for AI-powered policy generation.
    /// </summary>
    public partial class Content
    {
        private string _rawText;

        /// <summary>
        /// Gets and sets the property RawText. 
        /// <para>
        /// The raw text content containing natural language descriptions of desired policy behavior.
        /// This text is processed by AI to generate corresponding Cedar policy statements that
        /// match the described intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string RawText
        {
            get { return this._rawText; }
            set { this._rawText = value; }
        }

        // Check to see if RawText property is set
        internal bool IsSetRawText()
        {
            return this._rawText != null;
        }

    }
}