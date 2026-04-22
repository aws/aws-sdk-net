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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// A delta update to a reasoning content block.
    /// </summary>
    public partial class HarnessReasoningContentBlockDelta
    {
        private MemoryStream _redactedContent;
        private string _signature;
        private string _text;

        /// <summary>
        /// Gets and sets the property RedactedContent. 
        /// <para>
        /// Redacted reasoning content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100000000)]
        public MemoryStream RedactedContent
        {
            get { return this._redactedContent; }
            set { this._redactedContent = value; }
        }

        // Check to see if RedactedContent property is set
        internal bool IsSetRedactedContent()
        {
            return this._redactedContent != null;
        }

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// Signature for the reasoning content.
        /// </para>
        /// </summary>
        public string Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Reasoning text delta.
        /// </para>
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}