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
        private ConditionStepMetadata _condition;
        private ModelStepMetadata _model;
        private ProcessingJobStepMetadata _processingJob;
        private RegisterModelStepMetadata _registerModel;
        private TrainingJobStepMetadata _trainingJob;
        private TransformJobStepMetadata _transformJob;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// If this is a Condition step metadata object, details on the condition.
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
        /// Gets and sets the property Model. 
        /// <para>
        /// Metadata for the Model step.
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
        /// Gets and sets the property RegisterModel. 
        /// <para>
        /// Metadata for the RegisterModel step.
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

    }
}