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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata for a step execution.
    /// </summary>
    public partial class PipelineExecutionStepMetadata
    {
        private AutoMLJobStepMetadata _autoMLJob;
        private CallbackStepMetadata _callback;
        private ClarifyCheckStepMetadata _clarifyCheck;
        private ConditionStepMetadata _condition;
        private EMRStepMetadata _emr;
        private FailStepMetadata _fail;
        private LambdaStepMetadata _lambda;
        private ModelStepMetadata _model;
        private ProcessingJobStepMetadata _processingJob;
        private QualityCheckStepMetadata _qualityCheck;
        private RegisterModelStepMetadata _registerModel;
        private TrainingJobStepMetadata _trainingJob;
        private TransformJobStepMetadata _transformJob;
        private TuningJobStepMetaData _tuningJob;

        /// <summary>
        /// Gets and sets the property AutoMLJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AutoML job that was run by this step.
        /// </para>
        /// </summary>
        public AutoMLJobStepMetadata AutoMLJob
        {
            get { return this._autoMLJob; }
            set { this._autoMLJob = value; }
        }

        // Check to see if AutoMLJob property is set
        internal bool IsSetAutoMLJob()
        {
            return this._autoMLJob != null;
        }

        /// <summary>
        /// Gets and sets the property Callback. 
        /// <para>
        /// The URL of the Amazon SQS queue used by this step execution, the pipeline generated
        /// token, and a list of output parameters.
        /// </para>
        /// </summary>
        public CallbackStepMetadata Callback
        {
            get { return this._callback; }
            set { this._callback = value; }
        }

        // Check to see if Callback property is set
        internal bool IsSetCallback()
        {
            return this._callback != null;
        }

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
        /// If step property <code>BaselineUsedForDriftCheck</code> is set the same as <code>CalculatedBaseline</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClarifyCheckStepMetadata ClarifyCheck
        {
            get { return this._clarifyCheck; }
            set { this._clarifyCheck = value; }
        }

        // Check to see if ClarifyCheck property is set
        internal bool IsSetClarifyCheck()
        {
            return this._clarifyCheck != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The outcome of the condition evaluation that was run by this step execution.
        /// </para>
        /// </summary>
        public ConditionStepMetadata Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property EMR. 
        /// <para>
        /// The configurations and outcomes of an Amazon EMR step execution.
        /// </para>
        /// </summary>
        public EMRStepMetadata EMR
        {
            get { return this._emr; }
            set { this._emr = value; }
        }

        // Check to see if EMR property is set
        internal bool IsSetEMR()
        {
            return this._emr != null;
        }

        /// <summary>
        /// Gets and sets the property Fail. 
        /// <para>
        /// The configurations and outcomes of a Fail step execution.
        /// </para>
        /// </summary>
        public FailStepMetadata Fail
        {
            get { return this._fail; }
            set { this._fail = value; }
        }

        // Check to see if Fail property is set
        internal bool IsSetFail()
        {
            return this._fail != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function that was run by this step execution
        /// and a list of output parameters.
        /// </para>
        /// </summary>
        public LambdaStepMetadata Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model that was created by this step execution.
        /// </para>
        /// </summary>
        public ModelStepMetadata Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the processing job that was run by this step execution.
        /// </para>
        /// </summary>
        public ProcessingJobStepMetadata ProcessingJob
        {
            get { return this._processingJob; }
            set { this._processingJob = value; }
        }

        // Check to see if ProcessingJob property is set
        internal bool IsSetProcessingJob()
        {
            return this._processingJob != null;
        }

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
        /// If step property <code>BaselineUsedForDriftCheck</code> is set the same as <code>CalculatedBaseline</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public QualityCheckStepMetadata QualityCheck
        {
            get { return this._qualityCheck; }
            set { this._qualityCheck = value; }
        }

        // Check to see if QualityCheck property is set
        internal bool IsSetQualityCheck()
        {
            return this._qualityCheck != null;
        }

        /// <summary>
        /// Gets and sets the property RegisterModel. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package that the model was registered
        /// to by this step execution.
        /// </para>
        /// </summary>
        public RegisterModelStepMetadata RegisterModel
        {
            get { return this._registerModel; }
            set { this._registerModel = value; }
        }

        // Check to see if RegisterModel property is set
        internal bool IsSetRegisterModel()
        {
            return this._registerModel != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job that was run by this step execution.
        /// </para>
        /// </summary>
        public TrainingJobStepMetadata TrainingJob
        {
            get { return this._trainingJob; }
            set { this._trainingJob = value; }
        }

        // Check to see if TrainingJob property is set
        internal bool IsSetTrainingJob()
        {
            return this._trainingJob != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transform job that was run by this step execution.
        /// </para>
        /// </summary>
        public TransformJobStepMetadata TransformJob
        {
            get { return this._transformJob; }
            set { this._transformJob = value; }
        }

        // Check to see if TransformJob property is set
        internal bool IsSetTransformJob()
        {
            return this._transformJob != null;
        }

        /// <summary>
        /// Gets and sets the property TuningJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tuning job that was run by this step execution.
        /// </para>
        /// </summary>
        public TuningJobStepMetaData TuningJob
        {
            get { return this._tuningJob; }
            set { this._tuningJob = value; }
        }

        // Check to see if TuningJob property is set
        internal bool IsSetTuningJob()
        {
            return this._tuningJob != null;
        }

    }
}