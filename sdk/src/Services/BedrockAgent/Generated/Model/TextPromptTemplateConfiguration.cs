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
        private CachePointBlock _cachePoint;
        private List<PromptInputVariable> _inputVariables = AWSConfigs.InitializeCollections ? new List<PromptInputVariable>() : null;
        private string _text;

        /// <summary>
        /// Gets and sets the property CachePoint. 
        /// <para>
        /// A cache checkpoint within a template configuration.
        /// </para>
        /// </summary>
        public CachePointBlock CachePoint
        {
            get { return this._cachePoint; }
            set { this._cachePoint = value; }
        }

        // Check to see if CachePoint property is set
        internal bool IsSetCachePoint()
        {
            return this._cachePoint != null;
        }

        /// <summary>
        /// Gets and sets the property InputVariables. 
        /// <para>
        /// An array of the variables in the prompt template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
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
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
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