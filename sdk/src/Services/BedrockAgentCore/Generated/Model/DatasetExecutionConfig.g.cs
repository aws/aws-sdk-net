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
    /// The configuration for running the scenarios in a dataset against an agent as part
    /// of a batch evaluation.
    /// </summary>
    public partial class DatasetExecutionConfig
    {
        /// <summary>
        /// Gets and sets the property AgentInvocation. 
        /// <para>
        /// Specifies the agent runtime endpoint and the request template that the batch evaluation
        /// uses to invoke the agent for each scenario in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInvocationConfig AgentInvocation { get; set; }

        /// <summary>
        /// Checks to see if the AgentInvocation property is set.
        /// </summary>
        internal bool IsSetAgentInvocation() => this.AgentInvocation != null;

        /// <summary>
        /// Gets and sets the property Dataset. 
        /// <para>
        /// The dataset whose scenarios are sent to the agent. The dataset must use the predefined
        /// evaluation schema, and the version that runs must contain between 1 and 1,000 scenarios.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetSource Dataset { get; set; }

        /// <summary>
        /// Checks to see if the Dataset property is set.
        /// </summary>
        internal bool IsSetDataset() => this.Dataset != null;
    }
}
