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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata for a step execution.
    /// </summary>
    public partial class PipelineExecutionStepMetadata
    {
        /// <summary>
        /// Gets and sets the property Athena. 
        /// <para>
        /// The metadata for the Athena step execution.
        /// </para>
        /// </summary>
        public AthenaStepMetadata Athena { get; set; }

        /// <summary>
        /// Checks to see if the Athena property is set.
        /// </summary>
        internal bool IsSetAthena() => this.Athena != null;

        /// <summary>
        /// Gets and sets the property AutoMLJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AutoML job that was run by this step.
        /// </para>
        /// </summary>
        public AutoMLJobStepMetadata AutoMLJob { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJob property is set.
        /// </summary>
        internal bool IsSetAutoMLJob() => this.AutoMLJob != null;

        /// <summary>
        /// Gets and sets the property BedrockCustomModel. 
        /// <para>
        ///  The metadata of the Amazon Bedrock custom model used in the pipeline execution step.
        /// 
        /// </para>
        /// </summary>
        public BedrockCustomModelMetadata BedrockCustomModel { get; set; }

        /// <summary>
        /// Checks to see if the BedrockCustomModel property is set.
        /// </summary>
        internal bool IsSetBedrockCustomModel() => this.BedrockCustomModel != null;

        /// <summary>
        /// Gets and sets the property BedrockCustomModelDeployment. 
        /// <para>
        ///  The metadata of the Amazon Bedrock custom model deployment used in pipeline execution
        /// step. 
        /// </para>
        /// </summary>
        public BedrockCustomModelDeploymentMetadata BedrockCustomModelDeployment { get; set; }

        /// <summary>
        /// Checks to see if the BedrockCustomModelDeployment property is set.
        /// </summary>
        internal bool IsSetBedrockCustomModelDeployment() => this.BedrockCustomModelDeployment != null;

        /// <summary>
        /// Gets and sets the property BedrockModelImport. 
        /// <para>
        ///  The metadata of Amazon Bedrock model import used in pipeline execution step. 
        /// </para>
        /// </summary>
        public BedrockModelImportMetadata BedrockModelImport { get; set; }

        /// <summary>
        /// Checks to see if the BedrockModelImport property is set.
        /// </summary>
        internal bool IsSetBedrockModelImport() => this.BedrockModelImport != null;

        /// <summary>
        /// Gets and sets the property BedrockProvisionedModelThroughput. 
        /// <para>
        ///  The metadata of the Amazon Bedrock provisioned model throughput used in the pipeline
        /// execution step. 
        /// </para>
        /// </summary>
        public BedrockProvisionedModelThroughputMetadata BedrockProvisionedModelThroughput { get; set; }

        /// <summary>
        /// Checks to see if the BedrockProvisionedModelThroughput property is set.
        /// </summary>
        internal bool IsSetBedrockProvisionedModelThroughput() => this.BedrockProvisionedModelThroughput != null;

        /// <summary>
        /// Gets and sets the property Callback. 
        /// <para>
        /// The URL of the Amazon SQS queue used by this step execution, the pipeline generated
        /// token, and a list of output parameters.
        /// </para>
        /// </summary>
        public CallbackStepMetadata Callback { get; set; }

        /// <summary>
        /// Checks to see if the Callback property is set.
        /// </summary>
        internal bool IsSetCallback() => this.Callback != null;

        /// <summary>
        /// Gets and sets the property ClarifyCheck. 
        /// <para>
        /// Container for the metadata for a Clarify check step. The configurations and outcomes
        /// of the check step execution. This includes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The type of the check conducted,
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon S3 URIs of baseline constraints and statistics files to be used for the
        /// drift check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon S3 URIs of newly calculated baseline constraints and statistics.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The model package group name provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon S3 URI of the violation report if violations detected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of check processing job initiated by the step execution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The boolean flags indicating if the drift check is skipped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If step property <c>BaselineUsedForDriftCheck</c> is set the same as <c>CalculatedBaseline</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClarifyCheckStepMetadata ClarifyCheck { get; set; }

        /// <summary>
        /// Checks to see if the ClarifyCheck property is set.
        /// </summary>
        internal bool IsSetClarifyCheck() => this.ClarifyCheck != null;

        /// <summary>
        /// Gets and sets the property Cleanup. 
        /// <para>
        /// The metadata for the cleanup step execution.
        /// </para>
        /// </summary>
        public CleanupStepMetadata Cleanup { get; set; }

        /// <summary>
        /// Checks to see if the Cleanup property is set.
        /// </summary>
        internal bool IsSetCleanup() => this.Cleanup != null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The outcome of the condition evaluation that was run by this step execution.
        /// </para>
        /// </summary>
        public ConditionStepMetadata Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property EMR. 
        /// <para>
        /// The configurations and outcomes of an Amazon EMR step execution.
        /// </para>
        /// </summary>
        public EMRStepMetadata EMR { get; set; }

        /// <summary>
        /// Checks to see if the EMR property is set.
        /// </summary>
        internal bool IsSetEMR() => this.EMR != null;

        /// <summary>
        /// Gets and sets the property EMRServerless. 
        /// <para>
        /// The configurations and outcomes of an Amazon EMR Serverless step execution.
        /// </para>
        /// </summary>
        public EMRServerlessStepMetadata EMRServerless { get; set; }

        /// <summary>
        /// Checks to see if the EMRServerless property is set.
        /// </summary>
        internal bool IsSetEMRServerless() => this.EMRServerless != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint that was invoked during this step execution.
        /// </para>
        /// </summary>
        public EndpointStepMetadata Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property EndpointConfig. 
        /// <para>
        /// The endpoint configuration used to create an endpoint during this step execution.
        /// </para>
        /// </summary>
        public EndpointConfigStepMetadata EndpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfig property is set.
        /// </summary>
        internal bool IsSetEndpointConfig() => this.EndpointConfig != null;

        /// <summary>
        /// Gets and sets the property Fail. 
        /// <para>
        /// The configurations and outcomes of a Fail step execution.
        /// </para>
        /// </summary>
        public FailStepMetadata Fail { get; set; }

        /// <summary>
        /// Checks to see if the Fail property is set.
        /// </summary>
        internal bool IsSetFail() => this.Fail != null;

        /// <summary>
        /// Gets and sets the property ForEach. 
        /// <para>
        /// The metadata for the ForEach step execution.
        /// </para>
        /// </summary>
        public ForEachStepMetadata ForEach { get; set; }

        /// <summary>
        /// Checks to see if the ForEach property is set.
        /// </summary>
        internal bool IsSetForEach() => this.ForEach != null;

        /// <summary>
        /// Gets and sets the property InferenceComponent. 
        /// <para>
        ///  The metadata of the inference component used in pipeline execution step. 
        /// </para>
        /// </summary>
        public InferenceComponentMetadata InferenceComponent { get; set; }

        /// <summary>
        /// Checks to see if the InferenceComponent property is set.
        /// </summary>
        internal bool IsSetInferenceComponent() => this.InferenceComponent != null;

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// The metadata for a SageMaker job used in a pipeline execution step.
        /// </para>
        /// </summary>
        public JobStepMetadata Job { get; set; }

        /// <summary>
        /// Checks to see if the Job property is set.
        /// </summary>
        internal bool IsSetJob() => this.Job != null;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function that was run by this step execution
        /// and a list of output parameters.
        /// </para>
        /// </summary>
        public LambdaStepMetadata Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;

        /// <summary>
        /// Gets and sets the property Lineage. 
        /// <para>
        ///  The metadata of the lineage used in pipeline execution step. 
        /// </para>
        /// </summary>
        public LineageMetadata Lineage { get; set; }

        /// <summary>
        /// Checks to see if the Lineage property is set.
        /// </summary>
        internal bool IsSetLineage() => this.Lineage != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model that was created by this step execution.
        /// </para>
        /// </summary>
        public ModelStepMetadata Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property ProcessingJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the processing job that was run by this step execution.
        /// </para>
        /// </summary>
        public ProcessingJobStepMetadata ProcessingJob { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJob property is set.
        /// </summary>
        internal bool IsSetProcessingJob() => this.ProcessingJob != null;

        /// <summary>
        /// Gets and sets the property QualityCheck. 
        /// <para>
        /// The configurations and outcomes of the check step execution. This includes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The type of the check conducted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon S3 URIs of baseline constraints and statistics files to be used for the
        /// drift check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon S3 URIs of newly calculated baseline constraints and statistics.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The model package group name provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon S3 URI of the violation report if violations detected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of check processing job initiated by the step execution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Boolean flags indicating if the drift check is skipped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If step property <c>BaselineUsedForDriftCheck</c> is set the same as <c>CalculatedBaseline</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public QualityCheckStepMetadata QualityCheck { get; set; }

        /// <summary>
        /// Checks to see if the QualityCheck property is set.
        /// </summary>
        internal bool IsSetQualityCheck() => this.QualityCheck != null;

        /// <summary>
        /// Gets and sets the property RegisterModel. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package that the model was registered
        /// to by this step execution.
        /// </para>
        /// </summary>
        public RegisterModelStepMetadata RegisterModel { get; set; }

        /// <summary>
        /// Checks to see if the RegisterModel property is set.
        /// </summary>
        internal bool IsSetRegisterModel() => this.RegisterModel != null;

        /// <summary>
        /// Gets and sets the property TrainingJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job that was run by this step execution.
        /// </para>
        /// </summary>
        public TrainingJobStepMetadata TrainingJob { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJob property is set.
        /// </summary>
        internal bool IsSetTrainingJob() => this.TrainingJob != null;

        /// <summary>
        /// Gets and sets the property TransformJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transform job that was run by this step execution.
        /// </para>
        /// </summary>
        public TransformJobStepMetadata TransformJob { get; set; }

        /// <summary>
        /// Checks to see if the TransformJob property is set.
        /// </summary>
        internal bool IsSetTransformJob() => this.TransformJob != null;

        /// <summary>
        /// Gets and sets the property TuningJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tuning job that was run by this step execution.
        /// </para>
        /// </summary>
        public TuningJobStepMetaData TuningJob { get; set; }

        /// <summary>
        /// Checks to see if the TuningJob property is set.
        /// </summary>
        internal bool IsSetTuningJob() => this.TuningJob != null;
    }
}
