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
    /// Container for the parameters to the StartDatasetGeneration operation. Starts a dataset
    /// generation, which creates examples for an existing dataset from your agent's traces.
    /// The dataset must be <c>ACTIVE</c>. Each generation produces one scenario type, set
    /// by <c>scenarioType</c>. When the generation finishes, AgentCore adds the examples
    /// to the dataset's draft. Examples that duplicate each other, or that duplicate examples
    /// already in the draft, are left out. <para> A dataset can have only one generation
    /// in progress at a time. While it runs, requests that change the dataset's draft or
    /// publish a version are rejected with a <c>ConflictException</c>. </para> <para> AgentCore
    /// reads the traces with your credentials, so you need read access to the trace log groups,
    /// and to the dataset's KMS key if the dataset uses a customer managed key. The draft
    /// can hold at most 1,000 examples, including the examples this generation can add (<c>maxScenarios</c>).
    /// </para> <para> The operation returns immediately. To track progress, call <c>GetDatasetGeneration</c>.
    /// </para>
    /// </summary>
    public partial class StartDatasetGenerationRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier of the dataset to add the generated examples to. The dataset
        /// must be <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the dataset generation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dataset generation. The generation ID starts with this name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScenarioType. 
        /// <para>
        /// The type of scenario to generate. If you don't specify a value, the generation produces
        /// <c>DYNAMIC</c> scenarios.
        /// </para>
        /// </summary>
        public ScenarioType ScenarioType { get; set; }

        /// <summary>
        /// Checks to see if the ScenarioType property is set.
        /// </summary>
        internal bool IsSetScenarioType() => this.ScenarioType != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Where the generation reads sessions from, and how it selects, samples, labels and
        /// redacts them.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GenerationSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
