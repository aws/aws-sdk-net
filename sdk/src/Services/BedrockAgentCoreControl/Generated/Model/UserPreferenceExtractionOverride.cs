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
    /// Contains user preference extraction override configuration.
    /// </summary>
    public partial class UserPreferenceExtractionOverride
    {
        private string _appendToPrompt;
        private string _modelId;

        /// <summary>
        /// Gets and sets the property AppendToPrompt. 
        /// <para>
        /// The text to append to the prompt for user preference extraction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=30000)]
        public string AppendToPrompt
        {
            get { return this._appendToPrompt; }
            set { this._appendToPrompt = value; }
        }

        // Check to see if AppendToPrompt property is set
        internal bool IsSetAppendToPrompt()
        {
            return this._appendToPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID to use for user preference extraction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

    }
}