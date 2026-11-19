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
    /// This is the response object from the GetDatasetGeneration operation.
    /// </summary>
    public partial class GetDatasetGenerationResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The errors the generation hit, grouped by error code. The list holds the 10 most frequent
        /// error codes, most frequent first.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<GenerationErrorDetail> ErrorDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<GenerationErrorDetail>() : null;

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null && (this.ErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the dataset generation failed. Present only when the status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

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
        /// Gets and sets the property GenerationResults. 
        /// <para>
        /// Counts of the sessions, scenarios and examples the generation has processed.
        /// </para>
        /// </summary>
        public GenerationResults GenerationResults { get; set; }

        /// <summary>
        /// Checks to see if the GenerationResults property is set.
        /// </summary>
        internal bool IsSetGenerationResults() => this.GenerationResults != null;

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
        /// Gets and sets the property RedactionSummary. 
        /// <para>
        /// A summary of what redaction found. Present only when the generation was started with
        /// redaction.
        /// </para>
        /// </summary>
        public RedactionSummary RedactionSummary { get; set; }

        /// <summary>
        /// Checks to see if the RedactionSummary property is set.
        /// </summary>
        internal bool IsSetRedactionSummary() => this.RedactionSummary != null;

        /// <summary>
        /// Gets and sets the property ScenarioType. 
        /// <para>
        /// The type of scenario the generation produces. This is the value from the request,
        /// or <c>DYNAMIC</c> if the request didn't specify one.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScenarioType ScenarioType { get; set; }

        /// <summary>
        /// Checks to see if the ScenarioType property is set.
        /// </summary>
        internal bool IsSetScenarioType() => this.ScenarioType != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source the generation was started with, including the resolved time window. If
        /// you selected sessions and traces by ID, the response gives the number of IDs instead
        /// of the IDs.
        /// </para>
        /// </summary>
        public GenerationSourceRecord Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the dataset generation last changed status.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
