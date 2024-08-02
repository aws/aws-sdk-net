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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains configurations for a text prompt template. To include a variable, enclose
    /// a word in double curly braces as in <c>{{variable}}</c>.
    /// </summary>
    public partial class TextPromptTemplateConfiguration
    {
        private List<PromptInputVariable> _inputVariables = AWSConfigs.InitializeCollections ? new List<PromptInputVariable>() : null;
        private string _text;

        /// <summary>
        /// Gets and sets the property InputVariables. 
        /// <para>
        /// An array of the variables in the prompt template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=5)]
        public List<PromptInputVariable> InputVariables
        {
            get { return this._inputVariables; }
            set { this._inputVariables = value; }
        }

        // Check to see if InputVariables property is set
        internal bool IsSetInputVariables()
        {
            return this._inputVariables != null && (this._inputVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The message for the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200000)]
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