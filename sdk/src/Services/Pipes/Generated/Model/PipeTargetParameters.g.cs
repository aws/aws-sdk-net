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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters required to set up a target for your pipe.
    /// 
    ///  
    /// <para>
    /// For more information about pipe target parameters, including how to use dynamic path
    /// parameters, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-event-target.html">Target
    /// parameters</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PipeTargetParameters
    {
        /// <summary>
        /// Gets and sets the property BatchJobParameters. 
        /// <para>
        /// The parameters for using an Batch job as a target.
        /// </para>
        /// </summary>
        public PipeTargetBatchJobParameters BatchJobParameters { get; set; }

        /// <summary>
        /// Checks to see if the BatchJobParameters property is set.
        /// </summary>
        internal bool IsSetBatchJobParameters() => this.BatchJobParameters != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsParameters. 
        /// <para>
        /// The parameters for using an CloudWatch Logs log stream as a target.
        /// </para>
        /// </summary>
        public PipeTargetCloudWatchLogsParameters CloudWatchLogsParameters { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsParameters property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsParameters() => this.CloudWatchLogsParameters != null;

        /// <summary>
        /// Gets and sets the property EcsTaskParameters. 
        /// <para>
        /// The parameters for using an Amazon ECS task as a target.
        /// </para>
        /// </summary>
        public PipeTargetEcsTaskParameters EcsTaskParameters { get; set; }

        /// <summary>
        /// Checks to see if the EcsTaskParameters property is set.
        /// </summary>
        internal bool IsSetEcsTaskParameters() => this.EcsTaskParameters != null;

        /// <summary>
        /// Gets and sets the property EventBridgeEventBusParameters. 
        /// <para>
        /// The parameters for using an EventBridge event bus as a target.
        /// </para>
        /// </summary>
        public PipeTargetEventBridgeEventBusParameters EventBridgeEventBusParameters { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeEventBusParameters property is set.
        /// </summary>
        internal bool IsSetEventBridgeEventBusParameters() => this.EventBridgeEventBusParameters != null;

        /// <summary>
        /// Gets and sets the property HttpParameters. 
        /// <para>
        /// These are custom parameter to be used when the target is an API Gateway REST APIs
        /// or EventBridge ApiDestinations.
        /// </para>
        /// </summary>
        public PipeTargetHttpParameters HttpParameters { get; set; }

        /// <summary>
        /// Checks to see if the HttpParameters property is set.
        /// </summary>
        internal bool IsSetHttpParameters() => this.HttpParameters != null;

        /// <summary>
        /// Gets and sets the property InputTemplate. 
        /// <para>
        /// Valid JSON text passed to the target. In this case, nothing from the event itself
        /// is passed to the target. For more information, see <a href="http://www.rfc-editor.org/rfc/rfc7159.txt">The
        /// JavaScript Object Notation (JSON) Data Interchange Format</a>.
        /// </para>
        ///  
        /// <para>
        /// To remove an input template, specify an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 8192)]
        public string InputTemplate { get; set; }

        /// <summary>
        /// Checks to see if the InputTemplate property is set.
        /// </summary>
        internal bool IsSetInputTemplate() => this.InputTemplate != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamParameters. 
        /// <para>
        /// The parameters for using a Kinesis stream as a target.
        /// </para>
        /// </summary>
        public PipeTargetKinesisStreamParameters KinesisStreamParameters { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamParameters property is set.
        /// </summary>
        internal bool IsSetKinesisStreamParameters() => this.KinesisStreamParameters != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionParameters. 
        /// <para>
        /// The parameters for using a Lambda function as a target.
        /// </para>
        /// </summary>
        public PipeTargetLambdaFunctionParameters LambdaFunctionParameters { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionParameters property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionParameters() => this.LambdaFunctionParameters != null;

        /// <summary>
        /// Gets and sets the property RedshiftDataParameters. 
        /// <para>
        /// These are custom parameters to be used when the target is a Amazon Redshift cluster
        /// to invoke the Amazon Redshift Data API BatchExecuteStatement.
        /// </para>
        /// </summary>
        public PipeTargetRedshiftDataParameters RedshiftDataParameters { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftDataParameters property is set.
        /// </summary>
        internal bool IsSetRedshiftDataParameters() => this.RedshiftDataParameters != null;

        /// <summary>
        /// Gets and sets the property SageMakerPipelineParameters. 
        /// <para>
        /// The parameters for using a SageMaker pipeline as a target.
        /// </para>
        /// </summary>
        public PipeTargetSageMakerPipelineParameters SageMakerPipelineParameters { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerPipelineParameters property is set.
        /// </summary>
        internal bool IsSetSageMakerPipelineParameters() => this.SageMakerPipelineParameters != null;

        /// <summary>
        /// Gets and sets the property SqsQueueParameters. 
        /// <para>
        /// The parameters for using a Amazon SQS stream as a target.
        /// </para>
        /// </summary>
        public PipeTargetSqsQueueParameters SqsQueueParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqsQueueParameters property is set.
        /// </summary>
        internal bool IsSetSqsQueueParameters() => this.SqsQueueParameters != null;

        /// <summary>
        /// Gets and sets the property StepFunctionStateMachineParameters. 
        /// <para>
        /// The parameters for using a Step Functions state machine as a target.
        /// </para>
        /// </summary>
        public PipeTargetStateMachineParameters StepFunctionStateMachineParameters { get; set; }

        /// <summary>
        /// Checks to see if the StepFunctionStateMachineParameters property is set.
        /// </summary>
        internal bool IsSetStepFunctionStateMachineParameters() => this.StepFunctionStateMachineParameters != null;

        /// <summary>
        /// Gets and sets the property TimestreamParameters. 
        /// <para>
        /// The parameters for using a Timestream for LiveAnalytics table as a target.
        /// </para>
        /// </summary>
        public PipeTargetTimestreamParameters TimestreamParameters { get; set; }

        /// <summary>
        /// Checks to see if the TimestreamParameters property is set.
        /// </summary>
        internal bool IsSetTimestreamParameters() => this.TimestreamParameters != null;
    }
}
