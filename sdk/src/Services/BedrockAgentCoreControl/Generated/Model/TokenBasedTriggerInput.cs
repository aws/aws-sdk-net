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
    /// Trigger configuration based on tokens.
    /// </summary>
    public partial class TokenBasedTriggerInput
    {
        private int? _tokenCount;

        /// <summary>
        /// Gets and sets the property TokenCount. 
        /// <para>
        /// Number of tokens that trigger memory processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=500000)]
        public int? TokenCount
        {
            get { return this._tokenCount; }
            set { this._tokenCount = value; }
        }

        // Check to see if TokenCount property is set
        internal bool IsSetTokenCount()
        {
            return this._tokenCount.HasValue; 
        }

    }
}