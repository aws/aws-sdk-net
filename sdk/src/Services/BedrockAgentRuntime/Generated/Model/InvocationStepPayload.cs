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
    /// Payload content, such as text and images, for the invocation step.
    /// </summary>
    public partial class InvocationStepPayload
    {
        private List<BedrockSessionContentBlock> _contentBlocks = AWSConfigs.InitializeCollections ? new List<BedrockSessionContentBlock>() : null;

        /// <summary>
        /// Gets and sets the property ContentBlocks. 
        /// <para>
        /// The content for the invocation step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<BedrockSessionContentBlock> ContentBlocks
        {
            get { return this._contentBlocks; }
            set { this._contentBlocks = value; }
        }

        // Check to see if ContentBlocks property is set
        internal bool IsSetContentBlocks()
        {
            return this._contentBlocks != null && (this._contentBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}