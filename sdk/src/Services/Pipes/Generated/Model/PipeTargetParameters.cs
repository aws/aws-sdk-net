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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters required to set up a target for your pipe.
    /// </summary>
    public partial class PipeTargetParameters
    {
        private PipeTargetBatchJobParameters _batchJobParameters;
        private PipeTargetCloudWatchLogsParameters _cloudWatchLogsParameters;
        private PipeTargetEcsTaskParameters _ecsTaskParameters;
        private PipeTargetEventBridgeEventBusParameters _eventBridgeEventBusParameters;
        private PipeTargetHttpParameters _httpParameters;
        private string _inputTemplate;
        private PipeTargetKinesisStreamParameters _kinesisStreamParameters;
        private PipeTargetLambdaFunctionParameters _lambdaFunctionParameters;
        private PipeTargetRedshiftDataParameters _redshiftDataParameters;
        private PipeTargetSageMakerPipelineParameters _sageMakerPipelineParameters;
        private PipeTargetSqsQueueParameters _sqsQueueParameters;
        private PipeTargetStateMachineParameters _stepFunctionStateMachineParameters;

        /// <summary>
        /// Gets and sets the property BatchJobParameters. 
        /// <para>
        /// The parameters for using an Batch job as a target.
        /// </para>
        /// </summary>
        public PipeTargetBatchJobParameters BatchJobParameters
        {
            get { return this._batchJobParameters; }
            set { this._batchJobParameters = value; }
        }

        // Check to see if BatchJobParameters property is set
        internal bool IsSetBatchJobParameters()
        {
            return this._batchJobParameters != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogsParameters. 
        /// <para>
        /// The parameters for using an CloudWatch Logs log stream as a target.
        /// </para>
        /// </summary>
        public PipeTargetCloudWatchLogsParameters CloudWatchLogsParameters
        {
            get { return this._cloudWatchLogsParameters; }
            set { this._cloudWatchLogsParameters = value; }
        }

        // Check to see if CloudWatchLogsParameters property is set
        internal bool IsSetCloudWatchLogsParameters()
        {
            return this._cloudWatchLogsParameters != null;
        }

        /// <summary>
        /// Gets and sets the property EcsTaskParameters. 
        /// <para>
        /// The parameters for using an Amazon ECS task as a target.
        /// </para>
        /// </summary>
        public PipeTargetEcsTaskParameters EcsTaskParameters
        {
            get { return this._ecsTaskParameters; }
            set { this._ecsTaskParameters = value; }
        }

        // Check to see if EcsTaskParameters property is set
        internal bool IsSetEcsTaskParameters()
        {
            return this._ecsTaskParameters != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeEventBusParameters. 
        /// <para>
        /// The parameters for using an EventBridge event bus as a target.
        /// </para>
        /// </summary>
        public PipeTargetEventBridgeEventBusParameters EventBridgeEventBusParameters
        {
            get { return this._eventBridgeEventBusParameters; }
            set { this._eventBridgeEventBusParameters = value; }
        }

        // Check to see if EventBridgeEventBusParameters property is set
        internal bool IsSetEventBridgeEventBusParameters()
        {
            return this._eventBridgeEventBusParameters != null;
        }

        /// <summary>
        /// Gets and sets the property HttpParameters. 
        /// <para>
        /// These are custom parameter to be used when the target is an API Gateway REST APIs
        /// or EventBridge ApiDestinations.
        /// </para>
        /// </summary>
        public PipeTargetHttpParameters HttpParameters
        {
            get { return this._httpParameters; }
            set { this._httpParameters = value; }
        }

        // Check to see if HttpParameters property is set
        internal bool IsSetHttpParameters()
        {
            return this._httpParameters != null;
        }

        /// <summary>
        /// Gets and sets the property InputTemplate. 
        /// <para>
        /// Valid JSON text passed to the target. In this case, nothing from the event itself
        /// is passed to the target. For more information, see <a href="http://www.rfc-editor.org/rfc/rfc7159.txt">The
        /// JavaScript Object Notation (JSON) Data Interchange Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string InputTemplate
        {
            get { return this._inputTemplate; }
            set { this._inputTemplate = value; }
        }

        // Check to see if InputTemplate property is set
        internal bool IsSetInputTemplate()
        {
            return this._inputTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamParameters. 
        /// <para>
        /// The parameters for using a Kinesis stream as a source.
        /// </para>
        /// </summary>
        public PipeTargetKinesisStreamParameters KinesisStreamParameters
        {
            get { return this._kinesisStreamParameters; }
            set { this._kinesisStreamParameters = value; }
        }

        // Check to see if KinesisStreamParameters property is set
        internal bool IsSetKinesisStreamParameters()
        {
            return this._kinesisStreamParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionParameters. 
        /// <para>
        /// The parameters for using a Lambda function as a target.
        /// </para>
        /// </summary>
        public PipeTargetLambdaFunctionParameters LambdaFunctionParameters
        {
            get { return this._lambdaFunctionParameters; }
            set { this._lambdaFunctionParameters = value; }
        }

        // Check to see if LambdaFunctionParameters property is set
        internal bool IsSetLambdaFunctionParameters()
        {
            return this._lambdaFunctionParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDataParameters. 
        /// <para>
        /// These are custom parameters to be used when the target is a Amazon Redshift cluster
        /// to invoke the Amazon Redshift Data API ExecuteStatement.
        /// </para>
        /// </summary>
        public PipeTargetRedshiftDataParameters RedshiftDataParameters
        {
            get { return this._redshiftDataParameters; }
            set { this._redshiftDataParameters = value; }
        }

        // Check to see if RedshiftDataParameters property is set
        internal bool IsSetRedshiftDataParameters()
        {
            return this._redshiftDataParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerPipelineParameters. 
        /// <para>
        /// The parameters for using a SageMaker pipeline as a target.
        /// </para>
        /// </summary>
        public PipeTargetSageMakerPipelineParameters SageMakerPipelineParameters
        {
            get { return this._sageMakerPipelineParameters; }
            set { this._sageMakerPipelineParameters = value; }
        }

        // Check to see if SageMakerPipelineParameters property is set
        internal bool IsSetSageMakerPipelineParameters()
        {
            return this._sageMakerPipelineParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SqsQueueParameters. 
        /// <para>
        /// The parameters for using a Amazon SQS stream as a source.
        /// </para>
        /// </summary>
        public PipeTargetSqsQueueParameters SqsQueueParameters
        {
            get { return this._sqsQueueParameters; }
            set { this._sqsQueueParameters = value; }
        }

        // Check to see if SqsQueueParameters property is set
        internal bool IsSetSqsQueueParameters()
        {
            return this._sqsQueueParameters != null;
        }

        /// <summary>
        /// Gets and sets the property StepFunctionStateMachineParameters. 
        /// <para>
        /// The parameters for using a Step Functions state machine as a target.
        /// </para>
        /// </summary>
        public PipeTargetStateMachineParameters StepFunctionStateMachineParameters
        {
            get { return this._stepFunctionStateMachineParameters; }
            set { this._stepFunctionStateMachineParameters = value; }
        }

        // Check to see if StepFunctionStateMachineParameters property is set
        internal bool IsSetStepFunctionStateMachineParameters()
        {
            return this._stepFunctionStateMachineParameters != null;
        }

    }
}