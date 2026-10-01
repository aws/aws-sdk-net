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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Configuration for generating tool description optimization recommendations.
    /// </summary>
    public partial class ToolDescriptionRecommendationConfig
    {
        /// <summary>
        /// Gets and sets the property AgentTraces. 
        /// <para>
        /// The agent traces to analyze for generating tool description recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentTracesConfig AgentTraces { get; set; }

        /// <summary>
        /// Checks to see if the AgentTraces property is set.
        /// </summary>
        internal bool IsSetAgentTraces() => this.AgentTraces != null;

        /// <summary>
        /// Gets and sets the property ToolDescription. 
        /// <para>
        /// The current tool descriptions to optimize.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ToolDescriptionSource ToolDescription { get; set; }

        /// <summary>
        /// Checks to see if the ToolDescription property is set.
        /// </summary>
        internal bool IsSetToolDescription() => this.ToolDescription != null;
    }
}
