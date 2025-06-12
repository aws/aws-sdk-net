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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private ApplicationType _applicationType;
        private DateTime? _creationTime;
        private List<string> _customMetricsEvaluatorModelIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _evaluationTaskTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _evaluatorModelIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EvaluationInferenceConfigSummary _inferenceConfigSummary;
        private string _jobArn;
        private string _jobName;
        private EvaluationJobType _jobType;
        private List<string> _modelIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ragIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EvaluationJobStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// Specifies whether the evaluation job is for evaluating a model or evaluating a knowledge
        /// base (retrieval and response generation).
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType
        {
            get { return this._applicationType; }
            set { this._applicationType = value; }
        }

        // Check to see if ApplicationType property is set
        internal bool IsSetApplicationType()
        {
            return this._applicationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the evaluation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomMetricsEvaluatorModelIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the models used to compute custom metrics in an
        /// Amazon Bedrock evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> CustomMetricsEvaluatorModelIdentifiers
        {
            get { return this._customMetricsEvaluatorModelIdentifiers; }
            set { this._customMetricsEvaluatorModelIdentifiers = value; }
        }

        // Check to see if CustomMetricsEvaluatorModelIdentifiers property is set
        internal bool IsSetCustomMetricsEvaluatorModelIdentifiers()
        {
            return this._customMetricsEvaluatorModelIdentifiers != null && (this._customMetricsEvaluatorModelIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationTaskTypes. 
        /// <para>
        /// The type of task for model evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> EvaluationTaskTypes
        {
            get { return this._evaluationTaskTypes; }
            set { this._evaluationTaskTypes = value; }
        }

        // Check to see if EvaluationTaskTypes property is set
        internal bool IsSetEvaluationTaskTypes()
        {
            return this._evaluationTaskTypes != null && (this._evaluationTaskTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluatorModelIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the models used to compute the metrics for a knowledge
        /// base evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> EvaluatorModelIdentifiers
        {
            get { return this._evaluatorModelIdentifiers; }
            set { this._evaluatorModelIdentifiers = value; }
        }

        // Check to see if EvaluatorModelIdentifiers property is set
        internal bool IsSetEvaluatorModelIdentifiers()
        {
            return this._evaluatorModelIdentifiers != null && (this._evaluatorModelIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferenceConfigSummary. 
        /// <para>
        /// Identifies the models, Knowledge Bases, or other RAG sources evaluated in a model
        /// or Knowledge Base evaluation job.
        /// </para>
        /// </summary>
        public EvaluationInferenceConfigSummary InferenceConfigSummary
        {
            get { return this._inferenceConfigSummary; }
            set { this._inferenceConfigSummary = value; }
        }

        // Check to see if InferenceConfigSummary property is set
        internal bool IsSetInferenceConfigSummary()
        {
            return this._inferenceConfigSummary != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Specifies whether the evaluation job is automated or human-based.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationJobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property ModelIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the model(s) used for the evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Inference identifiers should be retrieved from the inferenceConfigSummary")]
        [AWSProperty(Min=0, Max=2)]
        public List<string> ModelIdentifiers
        {
            get { return this._modelIdentifiers; }
            set { this._modelIdentifiers = value; }
        }

        // Check to see if ModelIdentifiers property is set
        internal bool IsSetModelIdentifiers()
        {
            return this._modelIdentifiers != null && (this._modelIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RagIdentifiers. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the knowledge base resources used for a knowledge
        /// base evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Inference identifiers should be retrieved from the inferenceConfigSummary")]
        [AWSProperty(Min=0, Max=1)]
        public List<string> RagIdentifiers
        {
            get { return this._ragIdentifiers; }
            set { this._ragIdentifiers = value; }
        }

        // Check to see if RagIdentifiers property is set
        internal bool IsSetRagIdentifiers()
        {
            return this._ragIdentifiers != null && (this._ragIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}