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
    /// Defines a custom prompt template for orchestrating the retrieval and generation process.
    /// </summary>
    public partial class KnowledgeBasePromptTemplate
    {
        private string _textPromptTemplate;

        /// <summary>
        /// Gets and sets the property TextPromptTemplate. 
        /// <para>
        /// The text of the prompt template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100000)]
        public string TextPromptTemplate
        {
            get { return this._textPromptTemplate; }
            set { this._textPromptTemplate = value; }
        }

        // Check to see if TextPromptTemplate property is set
        internal bool IsSetTextPromptTemplate()
        {
            return this._textPromptTemplate != null;
        }

    }
}