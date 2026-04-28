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
    /// Arguments for a key press action.
    /// </summary>
    public partial class KeyPressArguments
    {
        private string _key;
        private int? _presses;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key name to press (for example, <c>enter</c>, <c>tab</c>, <c>escape</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Presses. 
        /// <para>
        /// The number of times to press the key. Valid range: 1–100. Defaults to 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Presses
        {
            get { return this._presses; }
            set { this._presses = value; }
        }

        // Check to see if Presses property is set
        internal bool IsSetPresses()
        {
            return this._presses.HasValue; 
        }

    }
}