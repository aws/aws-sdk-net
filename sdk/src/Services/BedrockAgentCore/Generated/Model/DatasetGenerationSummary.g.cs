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
    /// A summary of a dataset generation. To get its counts and the request it was started
    /// with, call <c>GetDatasetGeneration</c>.
    /// </summary>
    public partial class DatasetGenerationSummary
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The time at which the dataset generation finished. Present only when the generation
        /// has finished.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the dataset generation started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier of the dataset.
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
        /// The description of the dataset generation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The unique identifier of the dataset generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GenerationId { get; set; }

        /// <summary>
        /// Checks to see if the GenerationId property is set.
        /// </summary>
        internal bool IsSetGenerationId() => this.GenerationId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dataset generation.
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
        /// The type of scenario the generation produces.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScenarioType ScenarioType { get; set; }

        /// <summary>
        /// Checks to see if the ScenarioType property is set.
        /// </summary>
        internal bool IsSetScenarioType() => this.ScenarioType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dataset generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetGenerationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
