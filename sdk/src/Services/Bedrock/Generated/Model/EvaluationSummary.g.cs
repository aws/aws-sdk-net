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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Summary information of an evaluation job.
    /// </summary>
    public partial class EvaluationSummary
    {
        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// Specifies whether the evaluation job is for evaluating a model or evaluating a knowledge
        /// base (retrieval and response generation).
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the evaluation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomMetricsEvaluatorModelIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the models used to compute custom metrics in an
        /// Amazon Bedrock evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> CustomMetricsEvaluatorModelIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomMetricsEvaluatorModelIdentifiers property is set.
        /// </summary>
        internal bool IsSetCustomMetricsEvaluatorModelIdentifiers() => this.CustomMetricsEvaluatorModelIdentifiers != null && (this.CustomMetricsEvaluatorModelIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluationTaskTypes. 
        /// <para>
        /// The type of task for model evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> EvaluationTaskTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EvaluationTaskTypes property is set.
        /// </summary>
        internal bool IsSetEvaluationTaskTypes() => this.EvaluationTaskTypes != null && (this.EvaluationTaskTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluatorModelIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the models used to compute the metrics for a knowledge
        /// base evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> EvaluatorModelIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EvaluatorModelIdentifiers property is set.
        /// </summary>
        internal bool IsSetEvaluatorModelIdentifiers() => this.EvaluatorModelIdentifiers != null && (this.EvaluatorModelIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InferenceConfigSummary. 
        /// <para>
        /// Identifies the models, Knowledge Bases, or other RAG sources evaluated in a model
        /// or Knowledge Base evaluation job.
        /// </para>
        /// </summary>
        public EvaluationInferenceConfigSummary InferenceConfigSummary { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfigSummary property is set.
        /// </summary>
        internal bool IsSetInferenceConfigSummary() => this.InferenceConfigSummary != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Specifies whether the evaluation job is automated or human-based.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationJobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property ModelIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the model(s) used for the evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Inference identifiers should be retrieved from the inferenceConfigSummary")]
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> ModelIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ModelIdentifiers property is set.
        /// </summary>
        internal bool IsSetModelIdentifiers() => this.ModelIdentifiers != null && (this.ModelIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RagIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the knowledge base resources used for a knowledge
        /// base evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Inference identifiers should be retrieved from the inferenceConfigSummary")]
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> RagIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RagIdentifiers property is set.
        /// </summary>
        internal bool IsSetRagIdentifiers() => this.RagIdentifiers != null && (this.RagIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
