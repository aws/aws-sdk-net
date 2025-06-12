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
    /// Contains configurations to override prompts in different parts of an agent sequence.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
    /// prompts</a>.
    /// </summary>
    public partial class PromptOverrideConfiguration
    {
        private string _overrideLambda;
        private List<PromptConfiguration> _promptConfigurations = AWSConfigs.InitializeCollections ? new List<PromptConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property OverrideLambda. 
        /// <para>
        /// The ARN of the Lambda function to use when parsing the raw foundation model output
        /// in parts of the agent sequence. If you specify this field, at least one of the <c>promptConfigurations</c>
        /// must contain a <c>parserMode</c> value that is set to <c>OVERRIDDEN</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/lambda-parser.html">Parser
        /// Lambda function in Amazon Bedrock Agents</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string OverrideLambda
        {
            get { return this._overrideLambda; }
            set { this._overrideLambda = value; }
        }

        // Check to see if OverrideLambda property is set
        internal bool IsSetOverrideLambda()
        {
            return this._overrideLambda != null;
        }

        /// <summary>
        /// Gets and sets the property PromptConfigurations. 
        /// <para>
        /// Contains configurations to override a prompt template in one part of an agent sequence.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<PromptConfiguration> PromptConfigurations
        {
            get { return this._promptConfigurations; }
            set { this._promptConfigurations = value; }
        }

        // Check to see if PromptConfigurations property is set
        internal bool IsSetPromptConfigurations()
        {
            return this._promptConfigurations != null && (this._promptConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}