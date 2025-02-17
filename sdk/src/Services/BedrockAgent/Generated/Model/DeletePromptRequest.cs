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
    /// Container for the parameters to the DeletePrompt operation.
    /// Deletes a prompt or a version of it, depending on whether you include the <c>promptVersion</c>
    /// field or not. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-manage.html#prompt-management-delete.html">Delete
    /// prompts from the Prompt management tool</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-deploy.html#prompt-management-versions-delete.html">Delete
    /// a version of a prompt from the Prompt management tool</a> in the Amazon Bedrock User
    /// Guide.
    /// </summary>
    public partial class DeletePromptRequest : AmazonBedrockAgentRequest
    {
        private string _promptIdentifier;
        private string _promptVersion;

        /// <summary>
        /// Gets and sets the property PromptIdentifier. 
        /// <para>
        /// The unique identifier of the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PromptIdentifier
        {
            get { return this._promptIdentifier; }
            set { this._promptIdentifier = value; }
        }

        // Check to see if PromptIdentifier property is set
        internal bool IsSetPromptIdentifier()
        {
            return this._promptIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PromptVersion. 
        /// <para>
        /// The version of the prompt to delete. To delete the prompt, omit this field.
        /// </para>
        /// </summary>
        public string PromptVersion
        {
            get { return this._promptVersion; }
            set { this._promptVersion = value; }
        }

        // Check to see if PromptVersion property is set
        internal bool IsSetPromptVersion()
        {
            return this._promptVersion != null;
        }

    }
}