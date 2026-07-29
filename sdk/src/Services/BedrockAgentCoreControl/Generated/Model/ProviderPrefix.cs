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
    /// The configuration that controls how a provider prefix is applied to model IDs during
    /// translation.
    /// </summary>
    public partial class ProviderPrefix
    {
        private string _separator;
        private bool? _strip;

        /// <summary>
        /// Gets and sets the property Separator. 
        /// <para>
        /// The single character that separates the provider prefix from the model name (for example,
        /// <c>.</c>). The default is <c>.</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string Separator
        {
            get { return this._separator; }
            set { this._separator = value; }
        }

        // Check to see if Separator property is set
        internal bool IsSetSeparator()
        {
            return this._separator != null;
        }

        /// <summary>
        /// Gets and sets the property Strip. 
        /// <para>
        /// Whether clients can omit the provider prefix from model IDs. If <c>true</c>, the gateway
        /// accepts model IDs without the prefix and restores the full prefixed form before forwarding
        /// to the provider. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Strip
        {
            get { return this._strip; }
            set { this._strip = value; }
        }

        // Check to see if Strip property is set
        internal bool IsSetStrip()
        {
            return this._strip.HasValue; 
        }

    }
}